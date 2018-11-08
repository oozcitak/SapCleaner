using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace SapCleaner
{
    public class FileSearcher
    {
        private readonly string[] extensionsToKeep = new string[] { ".txt", ".dwg", ".doc", ".docx", ".xls", ".xlsx", ".pdf" };

        private readonly SearchParameters parameters;
        private readonly BackgroundWorker Worker = new BackgroundWorker();

        public event ProgressChangedEventHandler ProgressChanged;
        public event RunWorkerCompletedEventHandler SearchCompleted;

        public class SearchParameters
        {
            public IEnumerable<DirectoryInfo> SearchFolders { get; private set; }
            public IEnumerable<Cleaner> Cleaners { get; private set; }
            public HashSet<string> ExtensionsToKeep { get; private set; }

            public SearchParameters(IEnumerable<DirectoryInfo> searchFolders, IEnumerable<Cleaner> cleaners, string[] extensionsToKeep)
            {
                SearchFolders = searchFolders;
                Cleaners = cleaners;
                ExtensionsToKeep = new HashSet<string>(extensionsToKeep, StringComparer.OrdinalIgnoreCase);
            }
        }

        public class SearchResult
        {
            public FileInfo SourceFile { get; private set; }
            public IEnumerable<FileInfo> AssociatedFiles { get; private set; }
            public long TotalFileSize { get; private set; }

            public SearchResult(FileInfo sourceFile, IEnumerable<FileInfo> associatedFiles, long totalFileSize)
            {
                SourceFile = sourceFile;
                AssociatedFiles = associatedFiles;
                TotalFileSize = totalFileSize;
            }
        }

        public FileSearcher(IEnumerable<DirectoryInfo> searchFolders, List<Cleaner> cleaners)
        {
            parameters = new SearchParameters(searchFolders, cleaners, extensionsToKeep);

            Worker.WorkerReportsProgress = true;
            Worker.DoWork += Worker_DoWork;
            Worker.ProgressChanged += Worker_ProgressChanged;
            Worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        public FileSearcher(DirectoryInfo searchFolder, List<Cleaner> cleaners) : this(new DirectoryInfo[] { searchFolder }, cleaners)
        {
        }

        public void StartSearch()
        {
            Worker.RunWorkerAsync(parameters);
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            SearchParameters parameters = e.Argument as SearchParameters;

            var folders = new Queue<DirectoryInfo>();
            foreach (var folder in parameters.SearchFolders)
            {
                folders.Enqueue(folder);
            }

            var results = new List<SearchResult>();

            long currentFolder = 0;
            long totalFolderCount = folders.Count;
            while (folders.Count > 0)
            {
                var path = folders.Dequeue();

                var currentFolderResults = new List<SearchResult>();
                foreach (var file in path.GetFilesSafe())
                {
                    string ext = file.Extension;
                    if (parameters.ExtensionsToKeep.Contains(ext))
                        continue;

                    foreach (Cleaner cleaner in parameters.Cleaners)
                    {
                        if (!string.IsNullOrEmpty(cleaner.Extension) && string.Compare(ext, ".*", true) != 0 && string.Compare(cleaner.Extension, ext, true) != 0)
                            continue;
                        if (!cleaner.CanProcess(file))
                            continue;

                        var result = new SearchResult(file, cleaner.GetAssociatedFiles(file), cleaner.AssociatedFileSizeTotal);
                        if (result.AssociatedFiles.Any())
                            currentFolderResults.Add(result);
                    }
                }
                results.AddRange(currentFolderResults);

                foreach (var folder in path.GetDirectoriesSafe())
                {
                    folders.Enqueue(folder);
                    totalFolderCount++;
                }

                currentFolder++;

                int progress = Math.Max(0, Math.Min(100, (int)(currentFolder / (float)totalFolderCount * 100f)));
                Worker.ReportProgress(progress, currentFolderResults);
            }

            e.Result = results;
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            OnProgressChanged(e);
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            OnSearchCompleted(e);
        }

        protected void OnProgressChanged(ProgressChangedEventArgs e)
        {
            ProgressChanged?.Invoke(this, e);
        }

        protected void OnSearchCompleted(RunWorkerCompletedEventArgs e)
        {
            SearchCompleted?.Invoke(this, e);
        }
    }
}

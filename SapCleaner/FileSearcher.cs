﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace SapCleaner
{
    public class FileSearcher
    {
        private readonly SearchParameters parameters;
        private BackgroundWorker Worker = new BackgroundWorker();

        public event ProgressChangedEventHandler ProgressChanged;
        public event RunWorkerCompletedEventHandler SearchCompleted;


        public FileSearcher(IEnumerable<DirectoryInfo> searchFolders, string searchPattern, string[] extensionsToKeep)
        {
            parameters = new SearchParameters(searchFolders, searchPattern, extensionsToKeep);

            Worker.WorkerReportsProgress = true;
            Worker.DoWork += Worker_DoWork;
            Worker.ProgressChanged += Worker_ProgressChanged;
            Worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        public FileSearcher(IEnumerable<string> searchPaths, string searchPattern, string[] extensionsToKeep)
            : this(searchPaths.Select(p => new DirectoryInfo(p)), searchPattern, extensionsToKeep)
        {
            ;
        }

        public FileSearcher(DirectoryInfo searchFolder, string searchPattern, string[] extensionsToKeep)
            : this(new DirectoryInfo[] { searchFolder }, searchPattern, extensionsToKeep)
        {
            ;
        }

        public FileSearcher(string searchPath, string searchPattern, string[] extensionsToKeep)
            : this(new DirectoryInfo(searchPath), searchPattern, extensionsToKeep)
        {
            ;
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
                foreach (var file in path.GetFilesSafe(parameters.SearchPattern))
                {
                    if (IsSapFile(file.FullName))
                    {
                        var result = new SearchResult(file, parameters.ExtensionsToKeep);
                        if (result.AssociatedFiles.Count > 0)
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

        private bool IsSapFile(string filename)
        {
            try
            {
                using (var file = new FileStream(filename, FileMode.Open))
                using (var reader = new BinaryReader(file))
                {
                    var bytes = reader.ReadBytes(7);
                    return (Encoding.ASCII.GetString(bytes) == "SAP2000");
                }
            }
            catch
            {
                return false;
            }
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

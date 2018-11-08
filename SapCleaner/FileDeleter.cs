using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace SapCleaner
{
    public class FileDeleter
    {
        private readonly DeleteParameters parameters;
        private readonly BackgroundWorker Worker = new BackgroundWorker();

        public event ProgressChangedEventHandler ProgressChanged;
        public event RunWorkerCompletedEventHandler DeleteCompleted;

        public class DeleteParameters
        {
            public IEnumerable<FileSearcher.SearchResult> SourceFiles { get; private set; }
            public bool DeleteToRecycleBin { get; private set; }

            public DeleteParameters(IEnumerable<FileSearcher.SearchResult> sourceFiles, bool deleteToRecycleBin)
            {
                SourceFiles = sourceFiles;
                DeleteToRecycleBin = deleteToRecycleBin;
            }
        }

        public class DeleteResult
        {
            public long Count { get; private set; }
            public long TotalFileSize { get; private set; }

            public DeleteResult(long count,long size)
            {
                Count = count;
                TotalFileSize = size;
            }
        }

        public FileDeleter(IEnumerable<FileSearcher.SearchResult> files, bool sendToRecycleBin)
        {
            parameters = new DeleteParameters(files, sendToRecycleBin);

            Worker.WorkerReportsProgress = true;
            Worker.DoWork += Worker_DoWork;
            Worker.ProgressChanged += Worker_ProgressChanged;
            Worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        public void StartDelete()
        {
            Worker.RunWorkerAsync(parameters);
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            DeleteParameters parameters = e.Argument as DeleteParameters;

            var fileQueue = new Queue<FileSearcher.SearchResult>(parameters.SourceFiles);

            long currentSourceFile = 0;
            long sourceFileCount = fileQueue.Count;
            long totalFileSize = 0;
            long totalFileCount = 0;
            while (fileQueue.Count > 0)
            {
                var result = fileQueue.Dequeue();

                foreach (var file in result.AssociatedFiles)
                {
                    totalFileSize += file.Length;
                    totalFileCount++;
                    // Delete file
                    DeleteFile(file.FullName, parameters.DeleteToRecycleBin);
                }
                currentSourceFile++;

                int progress = Math.Max(0, Math.Min(100, (int)(currentSourceFile / (float)sourceFileCount * 100f)));
                Worker.ReportProgress(progress, result.SourceFile);
            }

            e.Result = new DeleteResult(totalFileCount, totalFileSize);
        }

        private void DeleteFile(string path, bool sendToRecycleBin)
        {
            try
            {
                if (sendToRecycleBin)
                {
                    var fs = new Shell32.SHFILEOPSTRUCT();
                    fs.wFunc = Shell32.FileOperationType.FO_DELETE;
                    fs.pFrom = path + '\0' + '\0';
                    fs.fFlags = Shell32.FileOperationFlags.FOF_SILENT | Shell32.FileOperationFlags.FOF_NOCONFIRMATION |
                        Shell32.FileOperationFlags.FOF_NOERRORUI | Shell32.FileOperationFlags.FOF_SILENT;
                    Shell32.SHFileOperation(ref fs);
                }
                else
                {
                    System.IO.File.Delete(path);
                }
            }
            catch
            {
                ;
            }
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
            DeleteCompleted?.Invoke(this, e);
        }
    }
}

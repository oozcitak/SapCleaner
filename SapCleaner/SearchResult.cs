using System.Collections.Generic;
using System.IO;

namespace SapCleaner
{
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
}

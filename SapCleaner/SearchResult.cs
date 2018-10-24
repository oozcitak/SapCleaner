using System.Collections.Generic;
using System.IO;

namespace SapCleaner
{
    public class SearchResult
    {
        public FileInfo SourceFile { get; private set; }
        public List<FileInfo> AssociatedFiles { get; private set; }
        public long TotalFileSize { get; private set; }

        public SearchResult(FileInfo sourceFile, HashSet<string> extensionsToKeep)
        {
            SourceFile = sourceFile;
            AssociatedFiles = new List<FileInfo>();
            TotalFileSize = 0;

            DirectoryInfo path = sourceFile.Directory;
            foreach (var file in path.GetFiles(Path.ChangeExtension(sourceFile.Name, ".*")))
            {
                if (extensionsToKeep.Contains(file.Extension))
                    continue;
                AssociatedFiles.Add(file);
                TotalFileSize += file.Length;
            }
        }
    }
}

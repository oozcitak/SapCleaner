using System.Collections.Generic;
using System.IO;

namespace SapCleaner
{
    public abstract class Cleaner
    {
        private long totalFileSize = 0;

        public abstract HashSet<string> ExtensionsToKeep { get; }
        public abstract string Extension { get; }
        public virtual long AssociatedFileSizeTotal { get => totalFileSize; }

        public abstract bool CanProcess(FileInfo sourceFile);

        public virtual List<FileInfo> GetAssociatedFiles(FileInfo sourceFile)
        {
            var files = new List<FileInfo>();
            totalFileSize = 0;

            DirectoryInfo path = sourceFile.Directory;
            foreach (var file in path.GetFiles(Path.ChangeExtension(sourceFile.Name, ".*")))
            {
                if (ExtensionsToKeep.Contains(file.Extension))
                    continue;

                totalFileSize += file.Length;
                files.Add(file);
            }
            return files;
        }
    }
}

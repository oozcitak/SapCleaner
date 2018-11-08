using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SapCleaner
{
    public class Larsa4DCleaner : Cleaner
    {
        private long totalFileSize = 0;

        public override string Extension => ".lar";
        public override HashSet<string> ExtensionsToKeep => new HashSet<string>(StringComparer.OrdinalIgnoreCase) { ".lar", ".la_", ".dml", ".drs", ".lpsx" };
        public override long AssociatedFileSizeTotal => totalFileSize;

        public override bool CanProcess(FileInfo sourceFile)
        {
            try
            {
                using (var file = new FileStream(sourceFile.FullName, FileMode.Open))
                using (var reader = new BinaryReader(file))
                {
                    var bytes = reader.ReadBytes(5);
                    return (Encoding.ASCII.GetString(bytes) == "LAR6A");
                }
            }
            catch
            {
                return false;
            }
        }

        public override List<FileInfo> GetAssociatedFiles(FileInfo sourceFile)
        {
            var files = new List<FileInfo>();
            totalFileSize = 0;

            DirectoryInfo path = new DirectoryInfo(
                Path.Combine(
                    Path.Combine(sourceFile.Directory.FullName, "LarsaResults"),
                    Path.GetFileNameWithoutExtension(sourceFile.Name)));
            if (path.Exists)
            {
                foreach (var file in path.GetFiles())
                {
                    totalFileSize += file.Length;
                    files.Add(file);
                }
            }

            DirectoryInfo cachePath = new DirectoryInfo(
                Path.Combine(path.FullName, "Cache"));
            if (cachePath.Exists)
            {
                foreach (var file in cachePath.GetFiles())
                {
                    totalFileSize += file.Length;
                    files.Add(file);
                }
            }

            return files;
        }
    }
}

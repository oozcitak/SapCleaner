using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SapCleaner
{
    public class SafeCleaner : Cleaner
    {
        public override string Extension => ".fdb";
        public override HashSet<string> ExtensionsToKeep => new HashSet<string>(StringComparer.OrdinalIgnoreCase) { ".fdb", "f2k", ".log", ".out" };

        public override bool CanProcess(FileInfo sourceFile)
        {
            try
            {
                using (var file = new FileStream(sourceFile.FullName, FileMode.Open))
                using (var reader = new BinaryReader(file))
                {
                    var bytes = reader.ReadBytes(4);
                    return (Encoding.ASCII.GetString(bytes) == "SAFE");
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

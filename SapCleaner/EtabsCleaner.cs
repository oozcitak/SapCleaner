using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SapCleaner
{
    public class EtabsCleaner : Cleaner
    {
        public override string Extension => ".edb";
        public override HashSet<string> ExtensionsToKeep => new HashSet<string>(StringComparer.OrdinalIgnoreCase) { ".edb", ".$et", ".log", ".out" };

        public override bool CanProcess(FileInfo sourceFile)
        {
            try
            {
                using (var file = new FileStream(sourceFile.FullName, FileMode.Open))
                using (var reader = new BinaryReader(file))
                {
                    var bytes = reader.ReadBytes(5);
                    return (Encoding.ASCII.GetString(bytes) == "ETABS");
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SapCleaner
{
    public class Sap2000Cleaner : Cleaner
    {
        public override string Extension => ".sdb";
        public override HashSet<string> ExtensionsToKeep => new HashSet<string>(StringComparer.OrdinalIgnoreCase) { ".sdb", ".$2k", ".s2k", ".sbk", ".log", ".out" };

        public override bool CanProcess(FileInfo sourceFile)
        {
            try
            {
                using (var file = new FileStream(sourceFile.FullName, FileMode.Open))
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
    }
}

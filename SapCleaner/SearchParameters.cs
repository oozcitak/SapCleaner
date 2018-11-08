using System;
using System.Collections.Generic;
using System.IO;

namespace SapCleaner
{
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
}

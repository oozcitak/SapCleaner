using System;
using System.Collections.Generic;
using System.IO;

namespace SapCleaner
{
    public class SearchParameters
    {
        public IEnumerable<DirectoryInfo> SearchFolders { get; private set; }
        public string SearchPattern { get; private set; }
        public HashSet<string> ExtensionsToKeep { get; private set; }

        public SearchParameters(IEnumerable<DirectoryInfo> searchFolders, string searchPattern, string[] extensionsToKeep)
        {
            SearchFolders = searchFolders;
            SearchPattern = searchPattern;
            ExtensionsToKeep = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (string extension in extensionsToKeep)
            {
                if (extension.StartsWith("."))
                    ExtensionsToKeep.Add(extension);
                else
                    ExtensionsToKeep.Add("." + extension);
            }
        }
    }
}

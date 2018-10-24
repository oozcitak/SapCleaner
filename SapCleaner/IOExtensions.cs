using System.Collections.Generic;
using System.IO;

namespace SapCleaner
{
    public static class IOExtensions
    {
        public static List<DirectoryInfo> GetDirectoriesSafe(this DirectoryInfo dir, string searchPattern, SearchOption searchOption)
        {
            List<DirectoryInfo> directories = new List<DirectoryInfo>();

            try
            {
                var enumerator = dir.EnumerateDirectories(searchPattern, searchOption).GetEnumerator();
                while (true)
                {
                    try
                    {
                        if (!enumerator.MoveNext())
                            break;
                        directories.Add(enumerator.Current);
                    }
                    catch
                    {
                        ;
                    }
                }
            }
            catch
            {
                ;
            }

            return directories;
        }

        public static List<DirectoryInfo> GetDirectoriesSafe(this DirectoryInfo dir, string searchPattern)
        {
            return dir.GetDirectoriesSafe(searchPattern, SearchOption.TopDirectoryOnly);
        }

        public static List<DirectoryInfo> GetDirectoriesSafe(this DirectoryInfo dir, SearchOption searchOption)
        {
            return dir.GetDirectoriesSafe("*.*", searchOption);
        }

        public static List<DirectoryInfo> GetDirectoriesSafe(this DirectoryInfo dir)
        {
            return dir.GetDirectoriesSafe("*.*", SearchOption.TopDirectoryOnly);
        }

        public static List<FileInfo> GetFilesSafe(this DirectoryInfo dir, string searchPattern, SearchOption searchOption)
        {
            List<FileInfo> files = new List<FileInfo>();

            try
            {
                var enumerator = dir.EnumerateFiles(searchPattern, searchOption).GetEnumerator();
                while (true)
                {
                    try
                    {
                        if (!enumerator.MoveNext())
                            break;
                        files.Add(enumerator.Current);
                    }
                    catch
                    {
                        ;
                    }
                }
            }
            catch
            {
                ;
            }

            return files;
        }

        public static List<FileInfo> GetFilesSafe(this DirectoryInfo dir, string searchPattern)
        {
            return dir.GetFilesSafe(searchPattern, SearchOption.TopDirectoryOnly);
        }

        public static List<FileInfo> GetFilesSafe(this DirectoryInfo dir, SearchOption searchOption)
        {
            return dir.GetFilesSafe("*.*", searchOption);
        }

        public static List<FileInfo> GetFilesSafe(this DirectoryInfo dir)
        {
            return dir.GetFilesSafe("*.*", SearchOption.TopDirectoryOnly);
        }
    }
}

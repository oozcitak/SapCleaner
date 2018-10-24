using System;

namespace SapCleaner
{
    public static class Utility
    {
        public static string ByteSizeToString(long bytes)
        {
            double num = bytes;
            foreach (var unit in new string[] { " bytes", "KB", "MB", "GB", "TB" })
            {
                if (Math.Abs(num) < 1024)
                    return string.Format("{0:0.#} {1}", num, unit);
                else
                    num /= 1024.0;
            }
            return string.Format("{0:0.#} {1}", num, "PB");
        }
    }
}

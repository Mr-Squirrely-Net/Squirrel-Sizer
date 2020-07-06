using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Squirrel_Sizer {
    public static class Sizer {
        private static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        /// <summary>
        /// Gets the size suffix from the given parameters
        /// </summary>
        /// <param name="value">The size in bytes you wish to convert.</param>
        /// <param name="decimalPlaces">The decimal places.</param>
        /// <returns>string</returns>
        /// <example>Sizer.SizeSuffix(1024)</example>
        public static string SizeSuffix(long value, int decimalPlaces = 0) {
            if (value < 0) {
                return $"-{SizeSuffix(-value)}";
            }
            int i = 0;
            decimal dValue = value;
            while (System.Math.Round(dValue, decimalPlaces) >= 1000) {
                dValue /= 1024;
                i++;
            }
            return $"{dValue:n}{SizeSuffixes[i]}";
        }
        /// <summary>
        /// Returns the size of a given file
        /// </summary>
        /// <param name="file">String location of file</param>
        /// <returns>string</returns>
        public static string GetSize(string file) => SizeSuffix(new FileInfo(file).Length);
        /// <summary>
        /// Returns the complete size of the given files
        /// </summary>
        /// <param name="files">A list of the files</param>
        /// <returns>string</returns>
        public static string GetCompleteSize(List<string> files) => SizeSuffix(files.Aggregate(0, (current, file) => (int)(current + new FileInfo(file).Length)));
        /// <summary>
        /// Returns a size of zero
        /// </summary>
        public static string Zero => SizeSuffix(0);
        /// <summary>
        /// Returns the maximum file size
        /// </summary>
        public static string Max => SizeSuffix(long.MaxValue);
    }
}
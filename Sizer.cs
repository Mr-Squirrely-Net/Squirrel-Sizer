using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Squirrel_Sizer {
    public static class Sizer {
        private static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        private static readonly string[] SizeNames = { "bytes", "Kilobytes", "Megabytes", "Gigabytes", "Terabytes", "Petabytes", "Exabytes", "Zettabytes", "Yottabytes" };

        private static int _index;

        /// <summary>
        /// Gets the size suffix from the given parameters
        /// </summary>
        /// <param name="value">The size in bytes you wish to convert.</param>
        /// <param name="decimalPlaces">The number od decimal places you want. Default is 0</param>
        /// <returns>string</returns>
        /// <example>Sizer.Suffix(1024)</example>
        public static string GetSizeSuffix(ulong value, int decimalPlaces = 0) 
            => $"{decimal.Round(Suffix(value), decimalPlaces)}{SizeSuffixes[_index]}";
        /// <summary>
        /// Returns the size of a given file
        /// </summary>
        /// <param name="file">String location of file</param>
        /// /// <param name="decimalPlaces">The number od decimal places you want. Default is 0</param>
        /// <returns>string</returns>
        public static string GetSizeSuffix(string file, int decimalPlaces = 0) 
            => $"{decimal.Round(Suffix((ulong)new FileInfo(file).Length), decimalPlaces)}{SizeSuffixes[_index]}";
        /// <summary>
        /// Returns the complete size of the given files
        /// </summary>
        /// <param name="files">A list of the files</param>
        /// /// <param name="decimalPlaces">The number od decimal places you want. Default is 0</param>
        /// <returns>string</returns>
        public static string GetFullSizeSuffix(List<string> files, int decimalPlaces = 0) 
            => $"{decimal.Round(Suffix((ulong)files.Aggregate(0, (current, file) => (int)(current + new FileInfo(file).Length))), decimalPlaces)}{SizeSuffixes[_index]}";
        /// <summary>
        /// Gets the size from the given parameters
        /// </summary>
        /// <param name="value">The size in bytes you wish to convert.</param>
        /// /// <param name="decimalPlaces">The number od decimal places you want. Default is 0</param>
        /// <returns>string</returns>
        /// <example>Sizer.Suffix(1024)</example>
        public static string GetSizeName(ulong value, int decimalPlaces = 0) 
            => $"{decimal.Round(Suffix(value), decimalPlaces)} {SizeNames[_index]}";
        /// <summary>
        /// Returns the size of a given file
        /// </summary>
        /// <param name="file">String location of file</param>
        /// /// <param name="decimalPlaces">The number od decimal places you want. Default is 0</param>
        /// <returns>string</returns>
        public static string GetSizeName(string file, int decimalPlaces = 0) 
            => $"{decimal.Round(Suffix((ulong)new FileInfo(file).Length), decimalPlaces)} {SizeNames[_index]}";
        /// <summary>
        /// Returns the complete size of the given files
        /// </summary>
        /// <param name="files">A list of the files</param>
        /// /// <param name="decimalPlaces">The number od decimal places you want. Default is 0</param>
        /// <returns>string</returns>
        public static string GetFullSizeName(List<string> files, int decimalPlaces = 0) 
            => $"{decimal.Round(Suffix((ulong)files.Aggregate(0, (current, file) => (int)(current + new FileInfo(file).Length))), decimalPlaces)} {SizeNames[_index]}";
                
        private static decimal Suffix(ulong value) {
            _index = 0;
            decimal dValue = value;
            while (System.Math.Round(dValue, 1) >= 1000) {
                dValue /= 1024;
                _index++;
            }
            return dValue;
        }



        #region Obsolete Stuff To Remove
        //Everything in this region will be removed in updated 1.3
        [Obsolete("This method has been deprecated.", true)]
        public static string SizeSuffix(long value, int decimalPlaces = 0) => throw new NotImplementedException("This method has been deprecated.");

        [Obsolete("This method has been deprecated. Use GetSizeSuffix or GetSizeName Instead.", true)]
        public static string GetSize(string file) => throw new NotImplementedException("This method has been deprecated. Use GetSizeSuffix or GetSizeName Instead.");

        [Obsolete("This method has been deprecated. Use GetFullSizeSuffix or GetFullSizeName Instead.", true)]
        public static string GetCompleteSize(List<string> files) => throw new NotImplementedException("This method has been deprecated. Use GetFullSizeSuffix or GetFullSizeName Instead.");

        [Obsolete("This method has been deprecated.", true)]
        public static string Zero => throw new NotImplementedException("This method has been deprecated.");


        [Obsolete("This method has been deprecated.", true)]
        public static string Max => throw new NotImplementedException("This method has been deprecated.");
        #endregion
    }
}
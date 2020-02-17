namespace Squirrel_Sizer {
    public class Sizer {
        /// <summary>
        /// The size suffixes
        /// </summary>
        private static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        /// <summary>
        /// Gets the size suffix from the given parameters
        /// </summary>
        /// <param name="value">The size in bytes you wish to convert.</param>
        /// <param name="decimalPlaces">The decimal places.</param>
        /// <returns>A string</returns>
        /// <example>Sizer.SizeSuffix(1024)</example>
        public static string SizeSuffix(long value, int decimalPlaces = 1) {
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
        /// Gets the zero.
        /// </summary>
        /// <value>
        /// The zero.
        /// </value>
        public static string Zero => SizeSuffix(0);
        /// <summary>
        /// Determines the maximum file size
        /// </summary>
        /// <value>
        /// The maximum.
        /// </value>
        public static string Max => SizeSuffix(long.MaxValue);
    }
}
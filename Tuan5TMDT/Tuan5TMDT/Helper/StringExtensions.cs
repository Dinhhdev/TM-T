using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Text.RegularExpressions;
using Tuan5TMDT.Helper;
using System.IO;

namespace Tuan5TMDT.Helper
{
    public static class StringExtensions
    {

        /// <summary>
        ///  A nicer way of calling  
        ///  <see cref="System.String.IsNullOrEmpty(string)"/> 
        /// </summary>
        /// <param name="value">The string to test.</param> 
        /// <returns>true if the value parameter is null or an empty string ("");otherwise, false. 
        /// </returns>
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
        /// <summary> 
        /// A nicer way of calling the inverse of <see cref="System.String.IsNullOrEmpty(string)"/> 
        /// </summary> 
        /// <param name="value">The string to test.</param> 
        /// <returns> /// <param name="value">The string to test.</param>
        /// <returns>true if the value parameter is not null or an empty string (""); otherwise, false.
        /// </returns>
        public static bool IsNotNullOrEmpty(this string value)
        {
            return !value.IsNullOrEmpty();
        }
        /// <summary> 
        /// Slugifies a string 
        /// </summary> 
        /// <param name="value">The string value to slugify</param> 
        /// <param name="maxLength">An optional maximum length of the generated slug</param>
        /// <returns>A URL safe slug representation of the input <paramref name = "value" />.
        /// </ returns >
        public static string ToSlug(this string value, int? maxLength = null)
        {
            // Ensure.Argument.NotNull(value, "value"); 

            // if it's already a valid slug, return it 
            if (RegexUtils.SlugRegex.IsMatch(value))
                return value;

            return GenerateSlug(value, maxLength);
        }
        /// <summary> 
        /// Credit for this method goes to  http://stackoverflow.com/questions/2920744/url-slugify-alrogithm-in-cs 
        /// </summary> 
        private static string GenerateSlug(string value, int? maxLength = null)
        {
            // prepare string, remove accents, lower case and convert hyphens to  whitespace
            var result = RemoveAccent(value).Replace("-", " ").ToLowerInvariant();


            result = Regex.Replace(result, @"[^a-z0-9\s-]", string.Empty); // remove invalid characters
            result = Regex.Replace(result, @"\s+", " ").Trim(); // convert multiple spaces into one space


            if (maxLength.HasValue) // cut and trim 
                result = result.Substring(0, result.Length <= maxLength ?
result.Length : maxLength.Value).Trim();

            return Regex.Replace(result, @"\s", "-"); // replace all spaces with hyphens
        }
        private static string RemoveAccent(string value)
        {
            var bytes = Encoding.GetEncoding("Cyrillic").GetBytes(value);
            return Encoding.ASCII.GetString(bytes);
        }
    }
    public static class PathUtils
    {
        /// <summary> 
        /// Makes a filename safe for use within a URL 
        /// </summary> 
        public static string MakeFileNameSafeForUrls(string fileName)
        {

            var extension = Path.GetExtension(fileName);
            var safeFileName = Path.GetFileNameWithoutExtension(fileName).ToSlug();
            return Path.Combine(Path.GetDirectoryName(fileName), safeFileName +
extension);
        }

        /// <summary> 
        /// Combines two URL paths 
        /// </summary> 
        public static string CombinePaths(string path1, string path2)
        {


            if (path2.IsNullOrEmpty())
            {
                return path1;
            }

            if (path1.IsNullOrEmpty())
                return path2;

            if (path2.StartsWith("http://") || path2.StartsWith("https://"))
                return path2;

            var ch = path1[path1.Length - 1];

            if (ch != '/')
                return (path1.TrimEnd('/') + '/' + path2.TrimStart('/'));

            return (path1 + path2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
namespace Tuan5TMDT.Helper
{
    public class RegexUtils
    {
        /// <summary> 
        /// A regular expression for validating slugs. 
        /// Does not allow leading or trailing hypens or whitespace 
        /// </summary> 
        public static readonly Regex SlugRegex = new Regex(@"(^[a-z0-9])([a-z0-
            9_-]+)*([a-z0-9])$");
    }
}
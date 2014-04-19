using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.AnalysisObjects
{
    public static class StringToWordLister
    {
        private static Char[] SUPPORTEDNONWORDCHARACTERS = { '\r', '{', '}', '+', '-', '\\', ' ', ',', '.', ':', '\t', '\n', '!', '?', '/', '`', '@', '#', '$', '%', '^', '&', '*', '(', ')', '[', ']', '\"', ':', ';', '/', '>', '<' };



        /// <summary>
        /// Returns an array of words.
        /// </summary>
        /// <param name="text">
        /// Can be null
        /// Can be a string of arbitrary size
        /// </param>
        /// <returns>
        /// An array of strings with non word characters removed.
        /// </returns>
        public static string[] StringToWordArray(string text)
        {
            if (text == null)
            {
                string[] emptyArray = { };
                return emptyArray;
            }
            return text.Split(SUPPORTEDNONWORDCHARACTERS, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}

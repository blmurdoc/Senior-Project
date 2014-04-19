using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.AnalysisObjects
{
    public static class WordCounter
    {
        /// <summary>
        /// Returns the number of words in an array of words.
        /// </summary>
        /// <param name="wordArray">
        /// Can be null
        /// Can be an array of 0 or more strings.
        /// </param>
        /// <returns>
        /// 0 if wordList is null
        /// The number of elements in wordArray
        /// </returns>
        public static int WordCount(string[] wordArray)
        {

            int tempWordCount = 0;
            if (wordArray != null)
            {
                foreach (string word in wordArray)
                {
                    tempWordCount += 1;
                }
            }
            return tempWordCount;
        }
    }
}

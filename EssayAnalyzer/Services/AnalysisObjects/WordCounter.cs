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
        /// TODO: XML Comment
        /// </summary>
        public static int WordCount(string[] wordList)
        {

            int tempWordCount = 0;
            foreach (string word in wordList)
            {
                tempWordCount += 1;
            }
            return tempWordCount;
        }
    }
}

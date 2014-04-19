using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services.AnalysisObjects
{
    class HighFrequencyWordLister
    {
        /// <summary>
        /// Adds high frequency words to the HighFrequencyWords dictionary.
        /// Individual words that account for 2% or more of the total word count are considered high-frequency.
        /// </summary>
        /// <param name="wordlist">
        /// Ordered list of words to be analyzed.
        /// </param>
        public static List<string> HighFrequencyWords(string[] wordlist)
        {
            double HighFrequencyValue = (WordCounter.WordCount(wordlist) * .02);
            Dictionary<string, int> WordUsage = WordUsageCounter.WordUsageCount(wordlist);
            List<string> HighFrequencyWordList = new List<string>();

            foreach (var pair in WordUsage)
            {
                if (pair.Value >= HighFrequencyValue && pair.Value >= 5)
                    HighFrequencyWordList.Add(pair.Key);
            }

            return HighFrequencyWordList;
        }
    }
}

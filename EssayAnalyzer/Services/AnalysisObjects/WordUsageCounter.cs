using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;



namespace Services.AnalysisObjects
{
    public static class WordUsageCounter
    {
        /// <summary>
        /// Finds the number of occurances of each string in wordList.
        /// Returns a dictionary representation of this.
        /// </summary>
        /// <param name="wordList">
        /// Is null
        /// or
        /// An array of 0..N strings
        /// </param>
        /// <returns>
        /// If wordlist is NULL returns an Emptry Dictionary<string, int> 
        /// Else WordUsageCount(wordList) is a Dictionary<string, int> containing 
        /// a key for every unique string in wordList and a value representing the 
        /// occrances of that string.
        /// </returns>
        public static Dictionary<string, int> WordUsageCount(string[] wordList)
        {
            Dictionary<string, int> WordUsage = new Dictionary<string, int>();
            if (wordList != null)
            {
                foreach (string word in wordList)
                {
                    if (WordUsage.ContainsKey(word))
                    {
                        WordUsage[word] = WordUsage[word] + 1;
                    }
                    else
                    {
                        WordUsage.Add(word, 1);
                    }
                }
            }
            return WordUsage;
        
        }
    }
}

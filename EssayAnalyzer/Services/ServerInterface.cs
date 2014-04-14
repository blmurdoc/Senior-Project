using Services.ServiceObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServerInterface
    {
        private Char[] SUPPORTEDNONWORDCHARACTERS = { '\r', '{', '}', '+', '-', '\\', ' ', ',', '.', ':', '\t', '\n', '!', '?', '/', '`', '@', '#', '$', '%', '^', '&', '*', '(', ')', '[', ']', '\"', ':', ';', '/', '>', '<' };

        private Essay _essay;

        /// <summary>
        /// Returns the _essay field. If _essay is null creates a new _essay before returning it.
        /// </summary>
        public Essay _Essay
        {
            get
            {
                if (_essay == null)
                    _essay = new Essay();
                    _essay.Analysis = new Analysis();
                return _essay;
            }
        }

        /// <summary>
        /// Sets the _essay field to an Essay object.
        /// </summary>
        /// <param name="essay"> Essay that _essay wil be set to. </param>
        public void SetEssay(Essay essay)
        {
            _essay = essay;
        }

        /// <summary>
        /// Analyzes the given essay.
        /// </summary>
        public void AnalyzeEssay()
        {
            //throw new NotImplementedException();

            // TODO: This method must be implemented in stages.
            // You should focus on one test at a time and write the
            // minimal code to make the test pass. Because multiple
            // people will be working on this method, be sure to 
            // coordinate with each other so as not to overwrite
            // anything. Good Luck!!
        }

        /// <summary>
        /// TODO: Don't forget our XML comments on all methods.
        /// Also make sure that methods within this class outside
        /// of of the AnalyzeEssay should be private.
        /// </summary>
        public string[] StringToWordList(string text)
        {
            return text.Split(SUPPORTEDNONWORDCHARACTERS, StringSplitOptions.RemoveEmptyEntries);
        }

        

        /*
        /// <summary>
        /// TODO: XML Comment
        /// </summary>
        private void WordUsage(string[] wordList)
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
            // TODO: Directly access the analysis.IndividualWordFrequency.
            // No need for unneeded variables. 
            analysis.WordFrequency = WordUsage;
        }*/

        /// <summary>
        /// Adds high frequency words to the HighFrequencyWords dictionary.
        /// Individual words that account for 2% or more of the total word count are considered high-frequency.
        /// </summary>
        /// <param name="highFrequencyValue">
        /// Determines how often a word must appear to be considered high-frequency.
        /// </param>
        private void HighFrequencyWords()
        {
            double highFrequencyValue = (_essay.Analysis.TotalWordCount * .02);

            foreach (var pair in _essay.Analysis.IndividualWordFrequency)
            {
                if (pair.Value >= highFrequencyValue)
                    _essay.Analysis.HighFrequencyWordList.Add(pair.Key);
            }
        }

        /*
        /// <summary>
        /// TODO: XML Comment
        /// </summary>
        private void ProximityWordAnalysis(string[] wordList)
        {
            Dictionary<string, int[]> WordUsage = new Dictionary<string, int[]>();
            int wordNumber = 0;
            foreach (string word in wordList)
            {
                wordNumber += 1;
                if (WordUsage.ContainsKey(word))
                {
                    WordUsage[word] = new int[] { (WordUsage[word][1] + (1 * 1 / (wordNumber - WordUsage[word][2]))), wordNumber };
                }
                else
                {
                    WordUsage.Add(word, new int[] { 1,wordNumber } );
                }
            }
            analysis.WordProximity = WordUsage;
        }*/
    }
}
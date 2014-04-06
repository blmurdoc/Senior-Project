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
        /*
         TODO: I've renamed some of the attributes of the new Analysis class to 
         * better reflect what they are supposed to represent. I would rename the
         * private methods. Some of the logic is good for the private methods, but
         * I would consider rewritting them when fixing the tests, and only write
         * what is needed to fix the test. If there is something else you want to 
         * place in the method, first write a test. TDD
         */

        // TODO: Don't forget to erase these todos as you go :)

        /// <summary>
        /// Represents the essay object the user uploads.
        /// </summary>
        public Essay _Essay
        {
            get
            {
                if (_essay == null)
                    _essay = new Essay();
                return _essay;
            }
        }
        private Essay _essay;

        /// <summary>
        /// Analyzes the given essay.
        /// </summary>
        public void AnalyzeEssay()
        {
            throw new NotImplementedException();

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
        private string[] StringToWordList(string text)
        {
            return text.Split(new Char[] { ' ', ',', '.', ':', '\t', '\n', '!', '?', '/' });
        }

        /// <summary>
        /// TODO: XML Comment
        /// </summary>
        private void WordCount(string[] wordList)
        {
            
            int tempWordCount = 0;
            foreach (string word in wordList)
            {
                tempWordCount += 1;
            }
            // TODO: access the analysis with _Essay.Analysis
            analysis.WordCount = tempWordCount;
        }

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
        }

        /// <summary>
        /// TODO: XML Comment
        /// </summary>
        private void HighFrequencyWords()
        {
            List<String> HighFrequencyWordList = new List<String>();
            Dictionary<string, int> WordFrequency = analysis.WordFrequency;
            double highFrequencyValue = (analysis.WordCount*.02);
            foreach (var pair in WordFrequency)
            {
                if (pair.Value >= highFrequencyValue)
                {
                    HighFrequencyWordList.Add(pair.Key);
                }
            }
            analysis.HighFrequencyWordList = HighFrequencyWordList;
        }

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
        }
    }
}
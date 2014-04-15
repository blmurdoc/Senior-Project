using Services.ServiceObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.AnalysisObjects;

namespace Services
{
    public class ServerInterface
    {
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
            string[] wordArray = StringToWordLister.StringToWordArray(_essay.UploadedText);
            _essay.Analysis.TotalWordCount = WordCounter.WordCount(wordArray);
            _essay.Analysis.IndividualWordFrequency = WordUsageCounter.WordUsageCount(wordArray);
        }



        /*
        /// <summary>
        /// TODO: XML Comment
        /// </summary>
<<<<<<< HEAD
=======
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
        private void HighFrequencyWords()
        {
            double highFrequencyValue = (_essay.Analysis.TotalWordCount * .02);

            foreach (var pair in _essay.Analysis.IndividualWordFrequency)
            {
                if (pair.Value >= highFrequencyValue)
                    _essay.Analysis.HighFrequencyWordList.Add(pair.Key);
            }
        }

        
        /// <summary>
        /// Analyzes how close each word in the given list is to each other.
        /// </summary>
        /// <param name="wordList">
        /// Ordered list of words to be analyzed.
        /// </param>
        private void ProximityWordAnalysis(string[] wordList)
        {      
            int wordNumber = 0;
            foreach (string word in wordList)
            {
                wordNumber += 1;
                if (_essay.Analysis.IndividualWordProximity.ContainsKey(word))
                {
                    _essay.Analysis.IndividualWordProximity[word] = new int[] { (_essay.Analysis.IndividualWordProximity[word][1] + (1 * 1 / (wordNumber - _essay.Analysis.IndividualWordProximity[word][2]))), wordNumber };
                }
                else
                {
                    _essay.Analysis.IndividualWordProximity.Add(word, new int[] { 1, wordNumber });
                }
            }
        }

    }
}
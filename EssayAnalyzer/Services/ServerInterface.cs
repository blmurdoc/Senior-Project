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
            //string[] wordList = StringToWordList(_Essay.UploadedText);
            //WordCount(_Essay.Analysis, wordList);
            //WordUsage(_Essay.Analysis, wordList);
            //HighFrequencyWords(_Essay.Analysis);
            //ProximityWordAnalysis(_Essay.Analysis, wordList);
        }

        public string[] StringToWordList(string text)
        {
            return text.Split(new Char[] { ' ', ',', '.', ':', '\t', '\n', '!', '?', '/' });
        }

        public void WordCount(Analysis analysis, string[] wordList)
        {
            
            int tempWordCount = 0;
            foreach (string word in wordList)
            {
                tempWordCount += 1;
            }
            analysis.WordCount = tempWordCount;
        }

        public void WordUsage(Analysis analysis, string[] wordList)
        {
            Dictionary<string, int> WordUsage = new Dictionary<string, int>();
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
            analysis.WordFrequency = WordUsage;
        }

        public void HighFrequencyWords(Analysis analysis)
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

        public void ProximityWordAnalysis(Analysis analysis, string[] wordList)
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
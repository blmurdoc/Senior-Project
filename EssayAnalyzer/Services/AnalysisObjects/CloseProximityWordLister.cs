using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.AnalysisObjects;

namespace Services.AnalysisObjects
{
    public static class CloseProximityWordLister
    {
        /// <summary>
        /// Analyzes how close each word in the given list is to each other.
        /// </summary>
        /// <param name="wordList">
        /// Ordered list of words to be analyzed.
        /// </param>
        public static List<string> ProximityWordAnalysis(string[] wordList)
        {
            int Threshhold = 10;
            int WordListIndex = 0;
            string CurrentWord = null;
            List<string> CloseWordProximityList = new List<string>();


            while (WordListIndex < wordList.Length)
            {
                CurrentWord = wordList[WordListIndex];

                for (int i = 1; i < Threshhold; i++)
                {
                    if (WordListIndex + i < wordList.Length && wordList[WordListIndex + i] == CurrentWord)
                    {
                        var alreadyExists = CloseWordProximityList.Where(j => j == wordList[WordListIndex]).SingleOrDefault();
                        if(alreadyExists == null)
                            CloseWordProximityList.Add(CurrentWord);
                        break;
                    }
                }

                WordListIndex++;
            }

            return CloseWordProximityList;
        }
    }
}

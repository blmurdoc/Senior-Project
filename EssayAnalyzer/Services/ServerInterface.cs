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
        // public for testing purposes. 
        private CachedCurrentUser User = new CachedCurrentUser();

        /// <summary>
        /// Must first save all additions to the cached user. 
        /// Then calls the database function to verify the user's credentials.
        /// </summary>
        public bool Login(string username, string password)
        {
            return true;
        }

        /// <summary>
        /// Accesses the cached user and returns their essays.
        /// </summary>
        public List<Essay> GetCurrentUsersEssays()
        {
            return User.OwnedEssays;
        }

        /// <summary>
        /// Adds an essay to the cached user. Returns the new essayID.
        /// </summary>
        public int AddEssay(Essay essay)
        {

            if (essay != null)
            {
                essay.EssayID = 1;
                if (User.OwnedEssays == null)
                    User.OwnedEssays = new List<Essay>();
                User.OwnedEssays.Add(essay);
                return essay.EssayID;
            }
            return -1;
        }

        /// <summary>
        /// Analyzes the given essay.
        /// </summary>
        public void AnalyzeEssay(int essayID)
        {
            var essay = User.OwnedEssays.Where(i => i.EssayID == essayID).SingleOrDefault();
            if (!(essay.EssayID > 0))
            {
                throw new System.ArgumentException("Invalid Essay ID");
            };
            Analysis analysis = new Analysis();
            string[] wordList = StringToWordList(essay.UploadedText);
            WordCount(analysis, wordList);
            WordUsage(analysis, wordList);
            HighFrequencyWords(analysis);
            ProximityWordAnalysis(analysis, wordList);
            /*String TestWord = ReturnFirstWorldBolded(essay);
            string backgroundChange = String.Format("<body bgcolor='FF0000'>{0}</body>", essay.UploadedText);
            
            essay.Analysis = backgroundChange;*/
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

        /// <summary>
        /// Accesses the cached user and returns their added words.
        /// </summary>
        public List<Word> GetCachedUsersAddedWords()
        {
            return User.AddedWords;
        }

        /// <summary>
        /// Calls the database function to create a new user. 
        /// Doesn't change the cached user.
        /// </summary>
        public int CreateAccount(string userName, string password)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a new word to the cached user's words. 
        /// </summary>
        public bool AddWordToDictionary(int userID, Word word)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Accesses the external synonym database for synonyms of the given word. 
        /// Returns a set number (maybe 5 options if there are enough) of synonyms.
        /// </summary>
        public List<Word> GetSynonyms(Word word)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Accesses the external synonym database for synonyms of the given word. 
        /// Returns a set number (maybe 5 options if there are enough) of synonyms.
        /// </summary>
        private string ReturnFirstWorldBolded(Essay essay)
        {
            var firstWord = essay.UploadedText.Split(' ');
            return "<b>" + firstWord[0] + "</b>" + firstWord[1];
        }
    }
}
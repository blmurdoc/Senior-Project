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
            String TestWord = ReturnFirstWorldBolded(essay);
            string backgroundChange = String.Format("<body bgcolor='FF0000'>{0}</body>", essay.UploadedText);
            
            essay.Analysis = backgroundChange;
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
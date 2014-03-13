using Services.DatabaseObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// Deal directly with the database.
    /// </summary>
    public class DatabaseInterface
    {
        /// <summary>
        /// Consults the database for the userID, password combination to verify the credentials. 
        /// </summary>
        public bool VerifyLogin(string username, string password)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a new user account into the database.
        /// </summary>
        public int CreateAccount(string userName, string password)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a new essay associated with the given userID.
        /// </summary>
        public void AddEssay(int userID, DatabaseEssay databaseEssay)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns all essays the given user has added to the database.
        /// </summary>
        public List<DatabaseEssay> GetUsersEssays(int userID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns all words the given user has added to the database.
        /// </summary>
        public List<DatabaseAdditionalWord> GetUsersAddedWords(int userID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a word associated with the user to the database.
        /// </summary>
        public bool AddWordToDictionary(int userID, DatabaseAdditionalWord word)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Services.ServiceObjects;

namespace Services.Testing
{
    public class ServerInterfaceTests
    {
        static List<Word> EmptyWordList = new List<Word>();
        static List<Essay> EmptyList = new List<Essay>(); 
        ServerInterface ServerInterface = new ServerInterface();
        CachedCurrentUser User = new CachedCurrentUser() { UserID = 1, UserName = "U2", Password = "password", AddedWords = EmptyWordList, OwnedEssays = EmptyList };
        

        [Fact]
        public void AddEssay_AddedWithNonEmptyString_SuccessfulEssayAdd()
        {
            /// Initialize
            /// 
            ServerInterface.User = User;
            Essay essay = new Essay() { EssayID = 1, Name = "Foo", Analysis = "TestAnalysis", UploadedText = "An apple." };

            /// Test
            /// 
            ServerInterface.AddEssay(essay);

            /// Assert
            // Ensure essay was successfully added to cachfed user's essays.
            Assert.True(ServerInterface.User.OwnedEssays.Contains(essay));
        }

        [Fact]
        public void GetCurrentUserEssays_UserHasEssays_ReturnsListOfUserEssays()
        {
            /// Initialize
            //
            ServerInterface.User = User;
            Essay essay = new Essay() { EssayID = 1, Name = "Foo", Analysis = "TestAnalysis", UploadedText = "An apple." };

            /// Test
            /// 
            ServerInterface.AddEssay(essay);
            List<Essay> TestList = new List<Essay>(new Essay[] { essay });

            ///Assert
            // Ensure list of all cached essays is returned successfully.
            Assert.Equal(ServerInterface.User.OwnedEssays, TestList);
        }

        [Fact]
        public void GetCachedUsersAddedWords_WordsAddedToDictionary_ReturnsListOfAddedWords()
        {
            /// Initialize
            //
            ServerInterface.User = User;
            Word TestWord = new Word();

            /// Test
            ///
            ServerInterface.AddWord(TestWord);
            List<Word> TestList = new List<Word>(new Word[] { TestWord });

            ///Assert
            // Ensure list of words added to dictionary is returned successfully.
            Assert.Equal(User.AddedWords, TestList);
        }

    }
}

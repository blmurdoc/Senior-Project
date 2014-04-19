using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.AnalysisObjects;
using Xunit;

namespace Services.UnitTests.SystemInterfaceTests
{
    public class WordCountTests
    {
        ServerInterface _ServerInterface = new ServerInterface();

        [Fact]
        public void StringToWordList_NullString_EmptyDictionary()
        {
            /// Initialize
            // Populate the test essay
            string text = null;
            string[] wordList = StringToWordLister.StringToWordArray(text);

            /// Test
            // Call the MUT
            int wordCount = WordCounter.WordCount(wordList);

            /// Assert
            // Ensure that the word count was calculated correctly
            Assert.Equal(wordCount, 0);
        }

        [Fact]
        public void StringToWordList_NullStringArrayDirectCall_EmptyDictionary()
        {
            /// Initialize
            // Populate the test essay
            string[] wordList = null;

            /// Test
            // Call the MUT
            int wordCount = WordCounter.WordCount(wordList);

            /// Assert
            // Ensure that the word count was calculated correctly
            Assert.Equal(wordCount, 0);
        }

        [Fact]
        public void StringToWordList_EmptyString_EmptyDictionary()
        {
            /// Initialize
            // Populate the test essay
            string text = "";
            string[] wordList = StringToWordLister.StringToWordArray(text);


            /// Test
            // Call the MUT
            int wordCount = WordCounter.WordCount(wordList);

            /// Assert
            // Ensure that the word count was calculated correctly
            Assert.Equal(wordCount, 0);
        }


        [Fact]
        public void StringToWordList_SimpleSingleQuote_SingleQuoteIs1Word()
        {
            /// Initialize
            // Populate the test essay
            string text = "It's its the're their";
            string[] wordList = StringToWordLister.StringToWordArray(text);

            /// Test
            // Call the MUT
            int wordCount = WordCounter.WordCount(wordList);

            /// Assert
            // Ensure that the word count was calculated correctly
            Assert.Equal(wordCount, 4);
        }

        [Fact]
        public void StringToWordList_Complex_CorrectCount()
        {
            /// Initialize
            // Populate the test essay
            string text = "Once upon a midnight dreary, while I pondered weak and weary,\n Over many a quaint and curious volume of forgotten lore,\nWhile I nodded, nearly napping, suddenly there came a tapping,\nAs of some one gently rapping, rapping at my chamber door.\n Tis some visitor, I muttered, tapping at my chamber door\nOnly this, and nothing more.";
            string[] wordList = StringToWordLister.StringToWordArray(text);

            /// Test
            // Call the MUT
            int wordCount = WordCounter.WordCount(wordList);

            /// Assert
            // Ensure that the word count was calculated correctly
            Assert.Equal(wordCount, 57);
        }

        [Fact]
        public void StringToWordList_EmptyString_IsZero()
        {
            /// Initialize
            // Populate the test essay
            String text = "";
            string[] wordList = StringToWordLister.StringToWordArray(text);


            /// Test
            // Call the MUT
            int wordCount = WordCounter.WordCount(wordList);

            /// Assert
            // Ensure that the word count was calculated correctly
            Assert.Equal(wordCount, 0);
        }
    }
}

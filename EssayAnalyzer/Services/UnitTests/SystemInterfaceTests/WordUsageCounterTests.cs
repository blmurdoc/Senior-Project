using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.AnalysisObjects;
using Xunit;

namespace Services.UnitTests.SystemInterfaceTests
{
    public class WordUsageCounterTests
    {
        ServerInterface _ServerInterface = new ServerInterface();

        [Fact]
        public void StringToWordList_NullString_EmptyDictionary()
        {
            /// Initialize
            // Populate the test essay
            string text = null;
            string[] wordList = StringToWordLister.StringToWordArray(text);

            /// Mock the expected answer
            Dictionary<string, int> expectedAnswer = new Dictionary<string, int>() ;

            /// Test
            // Call the MUT
            Dictionary<string, int> wordUsage = WordUsageCounter.WordUsageCount(wordList);

            /// Assert
            // Ensure that the word count was calculated correctly
            Assert.Equal(wordUsage, expectedAnswer);
        }

        [Fact]
        public void StringToWordList_NullStringArrayDirectCall_EmptyDictionary()
        {
            /// Initialize
            // Populate the test essay
            string[] wordList = null;
            Dictionary<string, int> expectedAnswer = new Dictionary<string, int>();

            /// Test
            // Call the MUT
            Dictionary<string, int> wordUsage = WordUsageCounter.WordUsageCount(wordList);

            /// Assert
            // Ensure that the word count was calculated correctly
            Assert.Equal(wordUsage, expectedAnswer);
        }



        [Fact]
        public void StringToWordList_EmptyString_EmptyDictionary()
        {
            /// Initialize
            // Populate the test essay
            string text = "";
            Dictionary<string, int> expectedAnswer = new Dictionary<string, int>();
            string[] wordList = StringToWordLister.StringToWordArray(text);


            /// Test
            // Call the MUT
            Dictionary<string, int> wordUsage = WordUsageCounter.WordUsageCount(wordList);

            /// Assert
            // Ensure that the word count was calculated correctly
            Assert.Equal(wordUsage, expectedAnswer);
        }

        [Fact]
        public void StringToWordList_FruitString_FruitDictionary()
        {
            /// Initialize
            // Populate the test essay
            string text = "apple apple banana apple apple banana";
            string[] wordList = StringToWordLister.StringToWordArray(text);

            /// Mock the expected answer
            // Populate the dictionary
            Dictionary<string, int> expectedAnswer = new Dictionary<string, int>();
            expectedAnswer.Add("apple", 4);
            expectedAnswer.Add("banana", 2);


            /// Test
            // Call the MUT
            Dictionary<string, int> wordUsage = WordUsageCounter.WordUsageCount(wordList);

            /// Assert
            // Ensure that the word count was calculated correctly
            Assert.Equal(wordUsage, expectedAnswer);
        }

        [Fact]
        public void StringToWordList_RealisticString_RealisticOutOfOrderDictionary()
        {
            /// Initialize
            // Populate the test essya
            string text = "The following code example creates an empty";
            string[] wordList = StringToWordLister.StringToWordArray(text);

            /// Mock the expected answer
            // Populate the dictionary
            Dictionary<string, int> expectedAnswer = new Dictionary<string, int>();
            expectedAnswer.Add("The", 1);
            expectedAnswer.Add("following", 1);
            expectedAnswer.Add("code", 1);
            expectedAnswer.Add("example", 1);
            expectedAnswer.Add("creates", 1);
            expectedAnswer.Add("an", 1);
            expectedAnswer.Add("empty", 1);

            /// Test
            // Call the MUT
            Dictionary<string, int> wordUsage = WordUsageCounter.WordUsageCount(wordList);

            /// Assert
            // Ensure that the wordUsage was calculated correctly
            Assert.Equal( wordUsage, expectedAnswer );
        }
    }
}

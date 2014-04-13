using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.ServiceObjects;
using Xunit;

namespace Services.UnitTests.SystemInterfaceTests
{
    public class StringToWordListTests
    {
        ServerInterface _ServerInterface = new ServerInterface();

        /*
         Test Methodology:
         * Naming:
         *  <Method under test>_<Condition under test>_<Expected outcome>()
         *  {
         *      /// Initialize
         *      Used to set up the condition under test
         *      
         *      /// Test
         *      Call the MUT (method under test)
         *      
         *      /// Assert
         *      Used to assert the expected outcome
         *  }
         */

        [Fact]
        public void StringToWordList_EmptyString_EmptyList()
        {
            /// Initialize
            // Populate the test essay
            string text = "";
            string[] expectedAnswer = { };

            /// Test
            // Call the MUT
            string[] wordList = _ServerInterface.StringToWordList(text);


            /// Assert
            // Ensure that the word count was calculated correctly
            Assert.Equal(wordList, expectedAnswer);
        }

        [Fact]
        public void StringToWordList_SimpleStringWithDeliminatorMiddle_SimpleWordListWithoutDeliminator()
        {
            /// Initialize
            // Populate the test essay
            string text = "Hello this is a great day. eh eh eh";
            string[] expectedAnswer = { "Hello", "this", "is", "a", "great", "day", "eh", "eh", "eh" };

            /// Test
            // Call the MUT
            string[] wordList = _ServerInterface.StringToWordList(text);


            /// Assert
            // Ensure that the word count was calculated correctly
            Assert.Equal(wordList, expectedAnswer);
        }

        [Fact]
        public void StringToWordList_SimpleStringWithDeliminatorStart_SimpleWordListWithoutDeliminators()
        {
            /// Initialize
            // Populate the test essay
            string text = ",Hello this is a great day eh eh eh";
            string[] expectedAnswer = { "Hello", "this", "is", "a", "great", "day", "eh", "eh", "eh" };

            /// Test
            // Call the MUT
            string[] wordList = _ServerInterface.StringToWordList(text);


            /// Assert
            // Ensure that the word count was calculated correctly
            Assert.Equal(wordList, expectedAnswer);
        }

        [Fact]
        public void StringToWordList_SimpleStringWithDeliminatorEnd_SimpleWordListWithoutDeliminators()
        {
            /// Initialize
            // Populate the test essay
            string text = "Hello this is a great day eh eh eh!";
            string[] expectedAnswer = { "Hello", "this", "is", "a", "great", "day", "eh", "eh", "eh" };

            /// Test
            // Call the MUT
            string[] wordList = _ServerInterface.StringToWordList(text);


            /// Assert
            // Ensure that the word count was calculated correctly
            Assert.Equal(wordList, expectedAnswer);
        }

        [Fact]
        public void StringToWordList_RepeatedDeliminators_SimpleWorldListWithoutDeliminators()
        {
            /// Initialize
            // Populate the test essay
            string text = "Have a great Summer!!!";
            string[] expectedAnswer = { "Have", "a", "great", "Summer" };

            /// Test
            // Call the MUT
            string[] wordList = _ServerInterface.StringToWordList(text);

            /// Assert
            // Ensure that the word count was calculated correctly
            Assert.Equal(wordList, expectedAnswer);
        }

        [Fact]
        public void StringToWordList_StringOfOnlyDeliminators_EmptyWordLIst()
        {
            /// Initialize
            // Populate the test essay
            string text = ". , ` \\ \n \t ,,, * + - / @ # $ % ^ & * ( )!!! !@#$!^#@!&#!@&**(()&^!@# <>:\";,./[]{}";
            string[] expectedAnswer = { };

            /// Test
            // Call the MUT
            string[] wordList = _ServerInterface.StringToWordList(text);

            /// Assert
            // Ensure that the word count was calculated correctly
            Assert.Equal(wordList, expectedAnswer);
        }

        [Fact]
        public void StringToWordList_ComplicatedRealisticEssay_ComplexeWordListWithoutDeliminators()
        {
            /// Initialize
            // Populate the test essay
            string text = "Once upon a midnight dreary, while I pondered weak and weary,\n Over many a quaint and curious volume of forgotten lore,\nWhile I nodded, nearly napping, suddenly there came a tapping,\nAs of some one gently rapping, rapping at my chamber door.\n Tis some visitor, I muttered, tapping at my chamber door\nOnly this, and nothing more.";
            string[] expectedAnswer = { "Once", "upon", "a", "midnight", "dreary", "while", "I", "pondered", "weak", "and", "weary", "Over", "many", "a", "quaint", "and", "curious", "volume", "of", "forgotten", "lore", "While", "I", "nodded", "nearly", "napping", "suddenly", "there", "came", "a", "tapping", "As", "of", "some", "one", "gently", "rapping", "rapping", "at", "my", "chamber", "door", "Tis", "some", "visitor", "I", "muttered", "tapping", "at", "my", "chamber", "door", "Only", "this", "and", "nothing", "more" };

            /// Test
            // Call the MUT
            string[] wordList = _ServerInterface.StringToWordList(text);

            /// Assert
            // Ensure that the word count was calculated correctly
            Assert.Equal(wordList, expectedAnswer);
        }

        [Fact]
        public void StringToWordList_SimpleSingleQuote_SingleQuoteIs1Word()
        {
            /// Initialize
            // Populate the test essay
            string text = "It's its the're their";
            string[] expectedAnswer = { "It's", "its", "the're", "their" };

            /// Test
            // Call the MUT
            string[] wordList = _ServerInterface.StringToWordList(text);

            /// Assert
            // Ensure that the word count was calculated correctly
            Assert.Equal(wordList, expectedAnswer);
        }
    }
}
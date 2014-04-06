using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.ServiceObjects;
using Xunit;

namespace Services.Testing
{
    public class ServerInterfaceTests
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
        public void AnalyzeEssay_GeneralCall_TotalWordCountIsCorrect()
        {
            /// Initialize
            // Populate the test essay
            _ServerInterface._Essay.UploadedText = "test essay";
            var wordCount = _ServerInterface._Essay.UploadedText.Split(' ').Count();

            /// Test
            // Call the MUT
            _ServerInterface.AnalyzeEssay();

            /// Assert
            // Ensure that the word count was calculated correctly
            Assert.Equal(wordCount, _ServerInterface._Essay.Analysis.TotalWordCount);
        }

        [Fact]
        public void AnalyzeEssay_GeneralCall_IndividualWordFrequencyIsCorrect()
        {
            /// Initialize
            // Populate the test essay
            _ServerInterface._Essay.UploadedText = "test test";

            /// Test
            // Call the MUT
            _ServerInterface.AnalyzeEssay();

            /// Assert
            // Ensure that the individual word frequency is calculated correctly.
            Assert.Equal(2, _ServerInterface._Essay.Analysis.IndividualWordFrequency["test"]);
        }

        [Fact]
        public void AnalyzeEssay_GeneralCall_OverusedWordIsInHighFrequencyList()
        {
            /// Initialize
            // Populate the test essay
            _ServerInterface._Essay.UploadedText = "test test test";

            /// Test
            // Call the MUT
            _ServerInterface.AnalyzeEssay();

            // Try to find the word in the high frequency list.
            bool inList = false;
            foreach(string s in _ServerInterface._Essay.Analysis.HighFrequencyWordList)
            {
                if (s == "test")
                    inList = true;
            }

            /// Assert
            // Ensure that the word is in the high frequency list
            Assert.True(inList);
        }

        [Fact]
        public void AnalyzeEssay_GeneralCall_UnderusedWordIsNotInHighFrequencyList()
        {
            /// Initialize
            // Populate the test essay
            _ServerInterface._Essay.UploadedText = "test test test";

            /// Test
            // Call the MUT
            _ServerInterface.AnalyzeEssay();

            // Try to find the word in the high frequency list.
            bool inList = false;
            foreach (string s in _ServerInterface._Essay.Analysis.HighFrequencyWordList)
            {
                if (s == "different")
                    inList = true;
            }

            /// Assert
            // Ensure that the word is in the high frequency list
            Assert.True(inList);
        }

        // TODO: jayseh: I'm not real sure how to test this one. 
        [Fact]
        public void AnalyzeEssay_GeneralCall_WordProximityIsCorrect()
        {
            /// Initialize
            //

            /// Test
            //

            /// Assert
            //
        }

        // TODO: jayseh: I'm not real sure how to test this one.
        [Fact]
        public void AnalyzeEssay_GeneralCall_WordNotInEssayIsNotInWordProximityDictionary()
        {
            /// Initialize
            //

            /// Test
            //

            /// Assert
            //
        }

        // TODO: Other tests probably exist. I'll leave it to jayse and jared to create
        // them similar to the ones above.
    }
}
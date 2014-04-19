using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.AnalysisObjects;
using Xunit;

namespace Services.UnitTests.SystemInterfaceTests
{
    public class WordProximityTests
    {
        [Fact]
        public void ProximityWordAnalysis_EmptyEssay_EmptyList()
        {
            /// Initialize
            /// Create an empty array of words.
            string[] TestDocument = { };

            /// Test
            /// Save output from test method ProximityWordAnalysis into a test list.
            List<string> TestList = CloseProximityWordLister.ProximityWordAnalysis(TestDocument);

            /// Assert
            /// Check that the test list is empty.
            Assert.Empty(TestList);
        }

        [Fact]
        public void ProximityWordAnalysis_NonEmptyEssayWithoutCloseProximityWords_EmptyList()
        {
            /// Initialize
            /// Create an array of words created containing no close proximity words from a test string.
            string[] TestDocument = StringToWordLister.StringToWordArray("This is a test document.");

            /// Test
            /// Save output from test method ProximityWordAnalysis into a test list.
            List<string> TestList = CloseProximityWordLister.ProximityWordAnalysis(TestDocument);

            /// Assert
            /// Check that the test list is empty.
            Assert.Empty(TestList);
        }

        [Fact]
        public void ProximityWordAnalysis_NonEmptyEssayWithCloseProximityWords_EmptyList()
        {
            /// Initialize
            /// Create an array of words created containing close proximity words from a test string.
            string[] TestDocument = StringToWordLister.StringToWordArray("This is a test document for a test.");
            List<string> ExpectedOutput = new List<string>();
            ExpectedOutput.Add("a");
            ExpectedOutput.Add("test");

            /// Test
            /// Save output from test method ProximityWordAnalysis into a test list.
            List<string> TestList = CloseProximityWordLister.ProximityWordAnalysis(TestDocument);

            /// Assert
            /// Check that the test list and expected output list are equal.
            Assert.Equal(TestList,ExpectedOutput);
        }
    }
}

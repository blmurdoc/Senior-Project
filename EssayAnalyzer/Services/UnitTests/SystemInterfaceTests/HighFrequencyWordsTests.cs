using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.AnalysisObjects;
using Xunit;

namespace Services.UnitTests.SystemInterfaceTests
{
    public class HighFrequencyWordsTests
    {
         [Fact]
         public void HighFrequencyWords_EssayHasNoHighFrequencyWords_EmptyList()
         {
             /// Initialize
             /// Create an array of words created containing no high frequency words from a test string.
             string[] TestWordList = StringToWordLister.StringToWordArray("This is a test document.");
             
             /// Test
             /// Save output from test method HighFrequencyWords into a test list.
             List<string> TestHighFreqList = HighFrequencyWordLister.HighFrequencyWords(TestWordList);
             
             /// Assert
             /// Check that the test list is empty.
             Assert.Empty(TestHighFreqList);
         }

         [Fact]
         public void HighFrequencyWords_EssayIsEmpty_EmptyList()
         {
             /// Initialize
             /// Create an empty array of words.
             string[] TestWordList = { };

             /// Test
             /// Save output from test method HighFrequencyWords into a test list.
             List<string> TestHighFreqList = HighFrequencyWordLister.HighFrequencyWords(TestWordList);

             /// Assert
             /// Check that the test list is empty.
             Assert.Empty(TestHighFreqList);
         }

         [Fact]
         public void HighFrequencyWords_HasHighFrequencyWords_ListContainsHighFrequencyWords()
         {
             /// Initialize
             /// Create an array of words containing one high frequency word from a test string.
             /// Create a list of words containing the expected output.
             string[] TestWordList = StringToWordLister.StringToWordArray("This is a test document that is very, very, very, very, very, repetitive.");
             List<string> ExpectedOutput = new List<string>();
             ExpectedOutput.Add("very");

             /// Test
             /// Save output from test method HighFrequencyWords into a test list.
             List<string> TestHighFreqList = HighFrequencyWordLister.HighFrequencyWords(TestWordList);

             /// Assert
             /// Check that the test list and expected output list are equal.
             Assert.Equal(TestHighFreqList,ExpectedOutput);
         }

         [Fact]
         public void HighFrequencyWords_ShortDocument_EmptyList()
         {
             /// Initialize
             /// Create an array of words containing no high frequency words from a test string that is short (25~ words long).
             string[] TestWordList = StringToWordLister.StringToWordArray("The minimum occurrence number for a high frequency word is 5 because if the essay is this short, 'is' will count as high frequency.");

             /// Test
             /// Save output from test method HighFrequencyWords into a test list.
             List<string> TestHighFreqList = HighFrequencyWordLister.HighFrequencyWords(TestWordList);

             /// Assert
             /// Check that the test list is empty.
             Assert.Empty(TestHighFreqList);
         }
    }
}

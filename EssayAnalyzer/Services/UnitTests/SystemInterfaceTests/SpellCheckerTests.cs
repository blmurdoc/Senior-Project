using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.AnalysisObjects;
using Xunit;

namespace Services.UnitTests.SystemInterfaceTests
{
    public class SpellCheckerTests
    {
        [Fact]
        public void GetMisspelledWords_EssayHasNoMisspelledWords_EmptyList()
        {
            /// Initialize
            /// Create new spellchecker object pointing to dictionary files.
            /// Create list to save output to and test array to store words for spellchecking.
            List<string> output_list = new List<string>();
            string[] test_array = StringToWordLister.StringToWordArray("This essay has no misspelled words.");
            
            /// Test
            /// Save output from test method GetMisspelledWords into a test list.
            output_list = SpellChecker.GetMisspelledWords(test_array);

            /// Assert
            /// Check that the list is empty.
            Assert.Empty(output_list);
        }

        [Fact]
        public void GetMisspelledWords_EssayHasSomeMisspelledWords_ListContainingOnlyMisspelledWords()
        {
            /// Initialize
            /// Create new spellchecker object pointing to dictionary files.
            /// Create dummy list for later comparison, list to save output to, and test array to store words for spellchecking.
            List<string> test_list = new List<string>();
            List<string> output_list = new List<string>();
            string[] test_array = StringToWordLister.StringToWordArray("Tihs esae mayb have some missspelled wrds.");

            /// Test
            /// Add misspelled words manually to test list for comparison with output list.
            /// Save output from test method HighFrequencyWords into a output list.
            test_list.Add("Tihs");
            test_list.Add("esae");
            test_list.Add("mayb");
            test_list.Add("missspelled");
            test_list.Add("wrds");
            output_list = SpellChecker.GetMisspelledWords(test_array);

            /// Assert
            /// Check that test list and output list contain the same words.
            Assert.Equal(test_list, output_list);
        }

        [Fact]
        public void GetMisspelledWords_EmptyEssay_EmptyList()
        {
            /// Initialize
            /// Create new spellchecker object pointing to dictionary files.
            /// Create list to save output to and test array to store words for spellchecking.
            List<string> output_list = new List<string>();
            string[] test_array = StringToWordLister.StringToWordArray("");
            

            /// Test
            /// Save output from test method GetMisspelledWords into a test list.
            output_list = SpellChecker.GetMisspelledWords(test_array);

            /// Assert
            /// Check that the list is empty.
            Assert.Empty(output_list);
        }
    }
}

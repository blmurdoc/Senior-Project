using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.AnalysisObjects;
using Xunit;

namespace Services.UnitTests.SystemInterfaceTests
{
    public class ThesaurusTests
    {
        [Fact]
        public void GetSynonyms_NoWordGiven_EmptyList()
        {
            /// Initialize
            /// Create string list to save output to and string to store word for synonym lookup.
            List<string> synonym_list;
            string test_string = "";

            /// Test
            /// Get the synonyms for the given word(nothing).
            synonym_list = Thesaurus.GetSynonyms(test_string);

            /// Assert
            /// Check that the list is empty.
            Assert.Empty(synonym_list);
        }

        [Fact]
        public void GetSynonyms_WordWithFewSynonyms_ListBelowCapacityAndNonEmpty()
        {
            /// Initialize
            /// Create a string list to save output to, a string to store word for synonym lookup,
            /// and integer marking maximum synonym list capacity.
            List<string> synonym_list;
            string test_string = "hate";
            int capacity = 10;

            /// Test
            /// Get the synonyms for the given word.
            synonym_list = Thesaurus.GetSynonyms(test_string);

            /// Assert
            /// Check that the list is not empty, but still below capacity.
            Assert.True(synonym_list.Count < capacity && synonym_list.Count > 0);
        }

        [Fact]
        public void GetSynonyms_WordWithManySynonyms_ListEqualsCapacity()
        {
            /// Initialize
            /// Create a string list to save output to, a string to store word for synonym lookup,
            /// and integer marking maximum synonym list capacity.
            List<string> synonym_list;
            string test_string = "love";
            int capacity = 10;

            /// Test
            /// Get the synonyms for the given word.
            synonym_list = Thesaurus.GetSynonyms(test_string);

            /// Assert
            /// Check that the list element count is equal to capacity.
            Assert.True(synonym_list.Count == capacity);
        }
    }
}

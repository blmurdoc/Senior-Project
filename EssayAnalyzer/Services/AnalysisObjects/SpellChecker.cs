using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHunspell;

namespace Services.AnalysisObjects
{
    class SpellChecker
    {
        private Hunspell _hunspell;

        public SpellChecker(string aff_path, string dic_path)
        {
            _hunspell = new Hunspell(aff_path, dic_path);
        }

        /// <summary>
        /// Spell checks an array of words.
        /// </summary>
        /// <param name="wordarray">Array of words to be spell checked.</param>
        /// <returns>A list of misspelled words within the array.</returns>
        public List<string> GetMisspelledWords(string[] wordarray)
        {
            List<string> temp_string_list = new List<string>();

            foreach(string str in wordarray)
            {
                if (!_hunspell.Spell(str))
                    temp_string_list.Add(str);
            }

            return temp_string_list;
        }
    }
}

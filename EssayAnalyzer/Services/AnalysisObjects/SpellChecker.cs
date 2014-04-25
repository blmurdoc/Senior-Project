using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHunspell;

namespace Services.AnalysisObjects
{
    public static class SpellChecker
    {
        /// <summary>
        /// Spell checks an array of words.
        /// </summary>
        /// <param name="wordarray">Array of words to be spell checked.</param>
        /// <returns>A list of misspelled words within the array.</returns>
        public static List<string> GetMisspelledWords(string[] wordarray)
        {
            string path = @"Hunspell\";
            List<string> temp_string_list = new List<string>();
            Hunspell _hunspell_EN = new Hunspell(path + "en_US.aff", path + "en_US.dic");
            
            foreach(string str in wordarray)
            {
                if (!_hunspell_EN.Spell(str))
                    temp_string_list.Add(str);
            }

            return temp_string_list;
        }
    }
}

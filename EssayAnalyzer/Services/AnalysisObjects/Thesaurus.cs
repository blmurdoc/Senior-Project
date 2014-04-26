using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHunspell;

namespace Services.AnalysisObjects
{
    public static class Thesaurus
    {
        /// <summary>
        /// Finds synonyms for the given word.
        /// </summary>
        /// <param name="word">Word to find synyonyms for.</param>
        /// <param name="capacity">Maximum number of synonyms the list may contain.</param>
        /// <returns>A list of synyonyms for the given word.</returns>
        public static List<string> GetSynonyms(string word)
        {
            string path = @"Hunspell\";
            MyThes _temp_MyThes = new MyThes(path + "th_en_US_new.dat");
            List<string> synonyms_list = new List<string>();

            if (_temp_MyThes.Lookup(word) == null)
                return synonyms_list;

            //Add synonyms to the output list
            foreach (ThesMeaning var in _temp_MyThes.Lookup(word).Meanings)
            {
                for (int i = 0; i < var.Synonyms.Count; i++)
                {
                    synonyms_list.Add(var.Synonyms[i]);

                    //Stop adding if list gets too big
                    if (synonyms_list.Count >= 10)
                        return synonyms_list;
                }
            }
            
            return synonyms_list;   
        }
    }
}

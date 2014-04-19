using Services.ServiceObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.AnalysisObjects;

namespace Services
{
    public class ServerInterface
    {
        /// <summary>
        /// Returns the _essay field. If _essay is null creates a new _essay before returning it.
        /// </summary>
        public Essay _Essay
        {
            get
            {
                if (_essay == null)
                {
                    _essay = new Essay();
                    _essay.Analysis = new Analysis();
                }
                return _essay;
            }
            set
            {
                _Essay = value;
            }
        }
        private Essay _essay;


        /// <summary>
        /// Sets the _essay field to an Essay object.
        /// </summary>
        public void SetEssay(Essay essay)
        {
            _Essay = essay;
        }

        /// <summary>
        /// Analyzes the given essay.
        /// </summary>
        public void AnalyzeEssay()
        {
            string[] wordArray = StringToWordLister.StringToWordArray(_essay.UploadedText);
            _Essay.Analysis.TotalWordCount = WordCounter.WordCount(wordArray);
            _Essay.Analysis.IndividualWordFrequency = WordUsageCounter.WordUsageCount(wordArray);
            _Essay.Analysis.HighFrequencyWordList = HighFrequencyWordLister.HighFrequencyWords(wordArray);
            _Essay.Analysis.CloseProximityWordList = CloseProximityWordLister.ProximityWordAnalysis(wordArray);
        }

    }
}
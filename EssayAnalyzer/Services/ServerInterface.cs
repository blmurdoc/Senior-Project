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
        private Essay _essay;

        /// <summary>
        /// Returns the _essay field. If _essay is null creates a new _essay before returning it.
        /// </summary>
        public Essay _Essay
        {
            get
            {
                if (_essay == null)
                    _essay = new Essay();
                    _essay.Analysis = new Analysis();
                return _essay;
            }
        }

        /// <summary>
        /// Sets the _essay field to an Essay object.
        /// </summary>
        /// <param name="essay"> Essay that _essay wil be set to. </param>
        public void SetEssay(Essay essay)
        {
            _essay = essay;
        }

        /// <summary>
        /// Analyzes the given essay.
        /// </summary>
        public void AnalyzeEssay()
        {
            string[] wordArray = StringToWordLister.StringToWordArray(_essay.UploadedText);
            _essay.Analysis.TotalWordCount = WordCounter.WordCount(wordArray);
            _essay.Analysis.IndividualWordFrequency = WordUsageCounter.WordUsageCount(wordArray);
            _essay.Analysis.HighFrequencyWordList = HighFrequencyWordLister.HighFrequencyWords(wordArray);
            _essay.Analysis.CloseProximityWordList = CloseProximityWordLister.ProximityWordAnalysis(wordArray);
        }

        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServiceObjects
{
    [DataContract]
    public class Analysis
    {
        [DataMember]
        public int TotalWordCount { get; set; }

        [DataMember]
        public List<String> MisspelledWords { get; set; }

        [DataMember]
        public Dictionary<string, int> IndividualWordFrequency { get; set; }

        [DataMember]
        public List<string> HighFrequencyWordList { get; set; }

        [DataMember]
        public Dictionary<string, int[]> IndividulWordProximity { get; set; }

        [DataMember]
        public List<string> CloseProximityWordList { get; set; }
    }
}
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
        public int WordCount { get; set; }

        [DataMember]
        public List<String> MispelldWords { get; set; }


        [DataMember]
        public Dictionary<string, int> WordFrequency { get; set; }

        [DataMember]
        public List<string> HighFrequencyWordList { get; set; }

        [DataMember]
        public Dictionary<string, int[]> WordProximity { get; set; }

        [DataMember]
        public List<string> CloseProximityWordList { get; set; }
    }
}

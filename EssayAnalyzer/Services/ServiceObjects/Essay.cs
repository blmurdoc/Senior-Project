using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServiceObjects
{
    [DataContract]
    public class Essay
    {
        [DataMember]
        public string UploadedText { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public Analysis Analysis { get; set; }
    }
}
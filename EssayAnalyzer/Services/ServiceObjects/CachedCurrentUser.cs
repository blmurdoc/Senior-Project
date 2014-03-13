using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServiceObjects
{
    [DataContract]
    public class CachedCurrentUser
    {
        [DataMember]
        public int UserID { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public List<Word> AddedWords { get; set; }

        [DataMember]
        public List<Essay> OwnedEssays { get; set; }
    }
}

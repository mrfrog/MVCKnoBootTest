using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Wcf.Interface
{
    [DataContract]
    public abstract class BaseInput
    {
        [DataMember]
        public int CurrentUserId { get; set; }

        [DataMember]
        public string LanguageId { get; set; }

        [DataMember]
        public string CompanyId { get; set; }
    }
}

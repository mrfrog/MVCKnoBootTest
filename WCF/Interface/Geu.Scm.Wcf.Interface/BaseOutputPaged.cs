using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Wcf.Interface
{
    [DataContract]
    public abstract class BaseOutputPaged<TOutput> : BaseOutput, IOutputPaged<TOutput>
    {
        [DataMember]
        public int PageIndex { get; set; }

        [DataMember]
        public int? PageSize { get; set; }

        [DataMember]
        public int TotalResults { get; set; }

        [DataMember]
        public int TotalPages { get; set; }

        [DataMember]
        public List<TOutput> Items { get; set; }
    }
}

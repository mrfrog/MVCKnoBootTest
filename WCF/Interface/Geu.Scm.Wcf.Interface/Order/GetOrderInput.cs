using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Wcf.Interface.Order
{
    [DataContract]
    public class GetOrderInput : BaseInputPaged
    {

        [DataMember]
        public DateTime? IssueDateFrom { get; set; }

        [DataMember]
        public DateTime? IssueDateTo { get; set; }

        [DataMember]
        public int? OrderStatusId { get; set; }

    }
}

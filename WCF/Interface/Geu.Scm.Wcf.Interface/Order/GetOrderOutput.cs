using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Wcf.Interface.Order
{
    [DataContract]
    public class GetOrderOutput : BaseOutputPaged<Order>
    {
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Wcf.Interface.Order
{
    [ServiceContract]
   public interface IOrder
    {
        [OperationContract]
        GetOrderOutput GetOrder(GetOrderInput getOrderInput);

    }
}

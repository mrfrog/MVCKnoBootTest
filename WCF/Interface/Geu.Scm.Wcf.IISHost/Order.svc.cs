using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf.IISHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Order" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Order.svc or Order.svc.cs at the Solution Explorer and start debugging.
    public class Order : Interface.Order.IOrder
    {

        public Interface.Order.GetOrderOutput GetOrder(Interface.Order.GetOrderInput getOrderInput)
        {

            var output = new Interface.Order.GetOrderOutput();
            output.PageIndex = 1;
            output.PageSize = 5;
            output.TotalPages = 4;
            output.TotalResults = 20;
            output.Items = new List<Interface.Order.Order>();
            Interface.Order.Order o ;

            int limit = output.PageIndex == 0 ? 1 : output.PageIndex;
            for (int i = output.PageIndex; i <= limit * output.PageSize; i++)
            {
                o = new Interface.Order.Order();
                o.CompanyId = "Guess";
                o.OrderId = (i + 100).ToString();
                output.Items.Add(o);
            }      

        return output;
        }

    }
}

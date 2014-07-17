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
            output.PageSize = 2;
            output.TotalPages = 3;
            output.TotalResults = 100;
            output.Items = new List<Interface.Order.Order>();
            Interface.Order.Order o ;
            for (int i = 0; i < 20; i++)
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

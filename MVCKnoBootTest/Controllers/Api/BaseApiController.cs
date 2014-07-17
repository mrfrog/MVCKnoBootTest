using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MVCKnoBootTest.Controllers.Api
{
    public class BaseApiController : ApiController
    {
        private static System.ServiceModel.ChannelFactory<Wcf.Interface.Order.IOrder> _ChannelFactoryOrder = null;

        private static object _FactoryLock = new object();


        public static Wcf.Interface.Order.IOrder CreateChannel_Order()
        {
            if (_ChannelFactoryOrder == null)
            {
                lock (_FactoryLock)
                {
                    if (_ChannelFactoryOrder == null)
                        _ChannelFactoryOrder = new System.ServiceModel.ChannelFactory<Wcf.Interface.Order.IOrder>("Wcf.ServiceOrder");
                }
            }
            return _ChannelFactoryOrder.CreateChannel();
        }

    }
}


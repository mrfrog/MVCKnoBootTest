using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wcf.InterfaceClient
{
    public static class GeuScmChannelFactory
    {
        private static System.ServiceModel.ChannelFactory<Interface.Security.ISecurity> _ChannelFactorySecurity = null;
        private static System.ServiceModel.ChannelFactory<Interface.Order.IOrder> _ChannelFactoryOrder = null;
        private static object _FactoryLock = new object();


        public static Interface.Security.ISecurity CreateChannel_Security()
        {
            if (_ChannelFactorySecurity == null)
            {
                lock (_FactoryLock)
                {
                    if (_ChannelFactorySecurity == null)
                        _ChannelFactorySecurity = new System.ServiceModel.ChannelFactory<Interface.Security.ISecurity>("Geu.Scm.Security");
                }
            }
            return _ChannelFactorySecurity.CreateChannel();
        }

        public static Interface.Order.IOrder CreateChannel_Order()
        {
            if (_ChannelFactoryOrder == null)
            {
                lock (_FactoryLock)
                {
                    if (_ChannelFactoryOrder == null)
                        _ChannelFactoryOrder = new System.ServiceModel.ChannelFactory<Interface.Order.IOrder>("Geu.Scm.Order");
                }
            }
            return _ChannelFactoryOrder.CreateChannel();
        }


    }
}

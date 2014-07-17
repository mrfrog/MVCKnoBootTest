using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Wcf.Automapper
{
    public static class Helper
    {
        static Helper()
        {
            Mapper.CreateMap<Engine.SqlServer.PurchaseOrderSelect_Result, Interface.Order.Order>();
            
        }

        public static TOutput Map<TOutput>(object i) 
        {
            return Mapper.Map<TOutput>(i);
        }
    }
}

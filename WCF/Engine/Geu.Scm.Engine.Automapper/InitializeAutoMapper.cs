using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Geu.Scm.Engine.Automapper
{
   public static class InitializeAutoMapper
    {
       static InitializeAutoMapper()
       {
           Mapper.CreateMap<TRB_Channel, ChannelViewModel>();
       }
    }
}

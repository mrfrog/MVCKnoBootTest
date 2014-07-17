﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Wcf.Interface
{
    [DataContract]
    public abstract class BaseInputPaged : BaseInput, IInputPaged
    {
        [DataMember]
        public int PageIndex { get; set; }

        [DataMember]
        public int? PageSize { get; set; }

    }
}

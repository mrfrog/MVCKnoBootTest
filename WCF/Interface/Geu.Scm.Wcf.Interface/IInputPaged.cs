using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wcf.Interface
{
    public interface IInputPaged
    {
        int PageIndex { get; set; }
        int? PageSize { get; set; }
    }
}

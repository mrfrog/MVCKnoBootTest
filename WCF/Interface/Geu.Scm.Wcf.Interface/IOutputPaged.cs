using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wcf.Interface
{
    public interface IOutputPaged<TOutput>
    {
        int PageIndex { get; set; }
        int? PageSize { get; set; }
        int TotalResults { get; set; }
        int TotalPages { get; set; }
        List<TOutput> Items { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geu.Scm.Biz
{
    class OrderBiz
    {
        void GetAllopenOrder()
        {
             List<Engine.SqlServer.PurchaseOrderSelect_Result> list;
            using (Engine.SqlServer.Scm_Entities cnx = new Engine.SqlServer.Scm_Entities())
            {
                 list = cnx.PurchaseOrderSelect(1, "GRU", "eng", null, null, 1).ToList();
            }
            list[0].
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCKnoBootTest.Controllers
{
    public class OrderApiController : ApiController
    {
        // GET api/orderapi
        public Wcf.Interface.Order.GetOrderOutput GetListOrder(string pageIndex)
        {
            Wcf.Interface.Order.GetOrderInput input = new Wcf.Interface.Order.GetOrderInput();
            input.CurrentUserId = 1;
            input.CompanyId = "Guess";
            input.LanguageId = "en";
            input.PageIndex = Convert.ToInt32(pageIndex);
            Wcf.Interface.Order.GetOrderOutput list = BaseApiController.CreateChannel_Order().GetOrder(input);
            return list;
        }

        // GET api/orderapi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/orderapi
        public void Post([FromBody]string value)
        {
        }

        // PUT api/orderapi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/orderapi/5
        public void Delete(int id)
        {
        }
    }
}

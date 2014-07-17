using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Wcf.Interface.Order;

namespace MVCKnoBootTest.Controllers.Api
{
    public class OrdersController : ApiController
    {
        // GET api/orderapi
        public GetOrderOutput GetListOrder(string pageIndex)
        {
            GetOrderInput input = new GetOrderInput();
            input.CurrentUserId = 1;
            input.CompanyId = "Guess";
            input.LanguageId = "en";
            input.PageIndex = Convert.ToInt32(pageIndex);
            GetOrderOutput list = BaseApiController.CreateChannel_Order().GetOrder(input);
            return list;
        }

        // GET api/<controller>/5
        public Order Get(string id)
        {
            GetOrderInput input = new GetOrderInput();
            input.CurrentUserId = 1;
            input.CompanyId = "Guess";
            input.LanguageId = "en";
            input.PageIndex = 0;
            GetOrderOutput list = BaseApiController.CreateChannel_Order().GetOrder(input);

            Order o = list.Items.Find(order => order.OrderId == id.ToString());

            return o;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
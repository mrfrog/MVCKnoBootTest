using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCKnoBootTest.Controllers.Api
{
    public class OrdersController : ApiController
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

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
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
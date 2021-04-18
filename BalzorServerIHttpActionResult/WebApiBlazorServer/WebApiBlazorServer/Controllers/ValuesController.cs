using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;

namespace WebApiBlazorServer.Controllers
{
    public class Customer
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
    }
    public class ValuesController : ApiController
    {
        // GET api/values
        //public IEnumerable<string> Get()
        //public Customer Get()
        //public IEnumerable<Customer> Get()
        //{
        //    List<Customer> lst = new List<Customer>
        //    {
        //        new Customer{CustomerCode = "1", CustomerName = "CMM" },
        //        new Customer{CustomerCode = "2", CustomerName = "CYY" }
        //    };
        //    //Customer custom = new Customer()
        //    //{ CustomerCode = "1", CustomerName = "CMM" };

        //    //return custom;
        //    return lst;
        //    //return new string[] { "value1", "value2" };
        //}

        public HttpResponseMessage Get()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "value");
            response.Content = new StringContent("hello", Encoding.Unicode);
            //response.Headers.CacheControl = new CacheControlHeaderValue()
            //{
            //    MaxAge = TimeSpan.FromMinutes(20)
            //};
            return response;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

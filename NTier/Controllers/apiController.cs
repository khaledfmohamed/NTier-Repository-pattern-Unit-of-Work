using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NTier.Controllers
{
    public class ApiController : System.Web.Http.ApiController
    {
        // GET: api/api
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet()]
        public string Number()
        {
            return "Number";
        }

        // GET: api/api/5
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/api
        public HttpResponseMessage Post([FromBody]string value)
        {
            return new HttpResponseMessage()
            {
                 
            };
        }

        // PUT: api/api/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/api/5
        public void Delete(int id)
        {
        }
    }
}

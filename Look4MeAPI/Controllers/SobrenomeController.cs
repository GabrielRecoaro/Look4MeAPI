using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Look4MeAPI.Controllers
{
    public class SobrenomeController : ApiController
    {
        // GET: api/Sobrenome
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Sobrenome/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Sobrenome
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Sobrenome/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Sobrenome/5
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Look4MeAPI.Models;

namespace Look4MeAPI.Controllers
{
    public class SobrenomeController : ApiController
    {
        [HttpGet]
        [ActionName("DefaultApi")]
        public Sobrenome GetSpecified(string sobrenome)
        {
            return new Sobrenome().getSobrenomeBySobrenome(sobrenome);
        }

        public string Get()
        {
            return new Sobrenome().getAllSobrenomes();

        }
    }
}
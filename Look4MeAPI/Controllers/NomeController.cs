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
    public class NomeController : ApiController
    {
        [HttpGet]
        [ActionName("DefaultApi")]
        public Nome GetSpecified(string nome)
        {
            return new Nome().getNomeByNome(nome);
        }

        public string Get()
        {
            return new Nome().getAllNomes();

        }
    }
}
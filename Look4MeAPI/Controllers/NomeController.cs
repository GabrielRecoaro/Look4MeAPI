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
        public Pais GetSpecified(string pais)
        {
            return new Pais().getPaisByPais(pais);
        }

        public Pais GetSpecified(string continente)
        {
            return new Pais().getPaisByContinente(continente);
        }

        public string Get()
        {
            return new Pais().getAllPaises();

        }
    }
}
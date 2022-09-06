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
        List<Sobrenome> sobrenomes = new List<Sobrenome>(new Sobrenome[] { new Sobrenome(1, "Jard", "França", "Estados Unidos", "Alemanha", "357 Pessoas com o sobrenome Jard na Árvore Familiar compartilhada."),
                                                            new Sobrenome(2, "Sousa", "Brasil", "Portugal", "Estados Unidos", "458.473 Pessoas com o sobrenome Sousa na Árvore Familiar compartilhada."),});




        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Sobrenome/getSobrenome/5
        [HttpGet]
        [ActionName("getSobrenome")]
        public Sobrenome Get(int idsobrenome)
        {
            var sobrenome = sobrenomes.FirstOrDefault((p) => p.IDsobrenome == idsobrenome);
            if (sobrenome == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound);
               throw new HttpResponseException( resp);
            }
            return sobrenome;
        }

        //exemplo de método com busca em Banco de dados
        [HttpGet]
        [ActionName("getAll")]
        public IEnumerable GetAllSobrenomes()
        {
            try
            {
                DBConnection db = new DBConnection();
                var l = db.BuscaTodos();
                db.Fechar();
                return l;
            }
            catch (Exception e)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                throw new HttpResponseException(resp);
            }
        }
        // POST: api/Sobrenome
        [HttpPost]
        [ActionName("addItens")]
        public HttpResponseMessage Post([FromBody] List<Sobrenome> itens)
        {
            if (itens == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotModified);
            }
            sobrenomes.AddRange(itens);
            var response = new HttpResponseMessage(HttpStatusCode.Created);
            return response;
        }

        // PUT: api/Sobrenome/5
        [HttpPut]
        [ActionName("updateItem")]
        public HttpResponseMessage Put(int id, [FromBody] Sobrenome item)
        {

            if (item == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotModified);
            }

            int index = sobrenomes.IndexOf((Sobrenome)sobrenomes.Where((p) => p.IDsobrenome == id).FirstOrDefault());
            sobrenomes[index] = item;

            return new HttpResponseMessage(HttpStatusCode.Accepted);
        }

        [HttpGet]
        [ActionName("getByCategoria")]
        public IEnumerable GetSobrenomesByCountry(string pais1)
        {
            return sobrenomes.Where(
                (p) => string.Equals(p.Pais1, pais1,
                    StringComparison.OrdinalIgnoreCase));
        }

        [HttpDelete]
        [ActionName("delete")]
        public HttpResponseMessage Delete(int idsobrenome)
        {
            Sobrenome l = (Sobrenome)sobrenomes.Where((p) => p.IDsobrenome == idsobrenome);
            int index = sobrenomes.IndexOf(l);
            sobrenomes.RemoveAt(index);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }


    }

}

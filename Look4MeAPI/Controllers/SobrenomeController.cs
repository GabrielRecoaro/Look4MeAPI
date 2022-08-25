using System;
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
        List<Sobrenome> sobrenome = new List<Sobrenome>(new Sobrenome[] { new Sobrenome(1, "Harry Potter", "Fantasia", 20.25M),
                                                            new Sobrenome(2, "Orgulho e Preconceito", "Romance", 78.09M),
                                                            new Sobrenome(3, "Crime e Castigo", "Drama", 57M),
                                                            new Sobrenome(4, "O Gato Preto", "Terror", 10.34M),
                                                            new Sobrenome(5, "Memórias Postumas de Bras Cubas", "Romance", 9.99M),
                                                            new Sobrenome(6, "Java 8", "Programaçao", 156.98M)});




        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Sobrenome/getSobrenome/5
        [HttpGet]
        [ActionName("getSobrenome")]
        public Sobrenome Get(int id)
        {
            var livro = sobrenome.FirstOrDefault((p) => p.Id == id);
            if (livro == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound);
                return resp;
            }
            return livro;
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
            sobrenome.AddRange(itens);
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

            int index = sobrenome.IndexOf((Sobrenome)sobrenome.Where((p) => p.Id == id).FirstOrDefault());
            sobrenome[index] = item;

            return new HttpResponseMessage(HttpStatusCode.Accepted);
        }

        [HttpGet]
        [ActionName("getByCategoria")]
        public IEnumerable GetSobrenomesByCategory(string categoria)
        {
            return sobrenome.Where(
                (p) => string.Equals(p.Categoria, categoria,
                    StringComparison.OrdinalIgnoreCase));
        }

        [HttpDelete]
        [ActionName("delete")]
        public HttpResponseMessage Delete(int id)
        {
            Sobrenome l = (Sobrenome)sobrenome.Where((p) => p.Id == id);
            int index = sobrenome.IndexOf(l);
            sobrenome.RemoveAt(index);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }


    }

}

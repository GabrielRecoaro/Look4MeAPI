using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Look4MeAPI.Models
{
    public class Sobrenome
    {
        public Sobrenome()
        {

        }

        public Sobrenome(int idsobrenome, string nome, string pais1, string pais2, string pais3, string arvore)
        {
            IDSobrenome = idsobrenome;
            Nome = nome;
            Pais1 = pais1;
            Pais2 = pais2;
            Pais3 = pais3;
            Arvore = arvore;
        }
        public int idsobrenome { get; set; }
        public string nome { get; set; }
        public string pais1 { get; set; }
        public string pais2 { get; set; }
        public string pais3 { get; set; }
        public string arvore { get; set; }


    }
}
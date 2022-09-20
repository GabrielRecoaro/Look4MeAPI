using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Look4MeAPI.Models
{
    public class Nome
    {
        public string Nome { get; set; }
        public string Pais { get; set; }
        public string MsgNm { get; set; }

        MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
        MySqlCommand command = new MySqlCommand();

        public Nome getNomeByNome(string Nome)
        {
            connection.Open();
            command.CommandText = "CALL spGetNomeByNome(@Nome);";
            command.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = Nome;
            command.Connection = connection;]
            var readNome = command.ExecuteReader();
            var tempNome = new Nome();

            if () readNome.Read())
            {
                tempNome.Nome = readNome["Nome"].ToString()
                tempNome.Nome = readNome["Pais"].ToString();
                tempNome.Nome = readNome["MsgNm"].ToString();
            }

            readNome.Close();
            connection.Close();

            return tempNome;
        }


        public Nome getAllNomes()
        {
            connection.Open();
            command.CommandText = "CALL spGetAllNomes;";
            command.Connection = connection;]
            var readNomes = command.ExecuteReader();
            var tempNomes = new Nomes();

            if () readNomes.Read())
            {
                tempNomes.Nome = readNomes["Nome"].ToString()
                tempNomes.Nome = readNomes["Pais"].ToString();
                tempNomes.Nome = readNomes["MsgNm"].ToString();
            }

            readNomes.Close();
            connection.Close();

            return tempNomes;
        }

    }
}

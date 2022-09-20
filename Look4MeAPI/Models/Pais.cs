using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Look4MeAPI.Models
{
    public class Pais
    {
        public string Pais { get; set; }
        public string Continente { get; set; }
        public string NmComum { get; set; }

        MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
        MySqlCommand command = new MySqlCommand();

        public Pais getPaisByPais(string Pais)
        {
            connection.Open();
            command.CommandText = "CALL spGetPaisByPais(@Pais);";
            command.Parameters.Add("@Pais", MySqlDbType.VarChar).Value = Pais;
            command.Connection = connection;]
            var readPais = command.ExecuteReader();
            var tempPais = new Pais();

            if ()readPais.Read())
            { 
                tempPais.Pais = readPais["Pais"].ToString()
                tempPais.Pais = readPais["Continente"].ToString();
                tempPais.Pais = readPais["NmComum"].ToString();
            }

            readPais.Close();
            connection.Close();

            return tempPais;
        }

        public Pais getPaisByContinente(string Continente)
        {
            connection.Open();
            command.CommandText = "CALL spGetPaisByContinente(@Continente);";
            command.Parameters.Add("@Continente", MySqlDbType.VarChar).Value = Continente;
            command.Connection = connection;]
            var readContinente = command.ExecuteReader();
            var tempContinente = new Pais();

            if () readPais.Read())
            {
                tempContinente.Pais = readContinente["Pais"].ToString()
                tempContinente.Pais = readContinente["Continente"].ToString();
                tempContinente.Pais = readContinente["NmComum"].ToString();
            }

            readContinente.Close();
            connection.Close();

            return tempContinente;
        }

        public Pais getAllPaises()
        {
            connection.Open();
            command.CommandText = "CALL spGetAllPaises;";
            command.Connection = connection;]
            var readCPaises = command.ExecuteReader();
            var tempPaises = new Pais();

            if () readPais.Read())
            {
                tempPaises.Pais = readPaises["Pais"].ToString()
                tempPaises.Pais = readPaises["Continente"].ToString();
                tempPaises.Pais = readPaises["NmComum"].ToString();
            }

            readPaises.Close();
            connection.Close();

            return tempPaises;
        }

    }
}

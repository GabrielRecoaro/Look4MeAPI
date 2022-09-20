using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Look4MeAPI.Models
{
	public class Sobrenome
	{
		public string Sobrenome { get; set; }
		public string Pais { get; set; }
		public string MsgSm { get; set; }

		MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
		MySqlCommand command = new MySqlCommand();

		public Nome getSobrenomeBySobrenome(string Sobrenome)
		{
			connection.Open();
			command.CommandText = "CALL getSobrenomeBySobrenome(@Sobrenome);";
			command.Parameters.Add("@Sobrenome", MySqlDbType.VarChar).Value = Sobrenome;
			command.Connection = connection;]
            var readSobrenome = command.ExecuteReader();
			var tempSobrenome = new Sobrenome();

			if () readSobrenome.Read())
            {
				tempSobrenome.Sobrenome = readSobrenome["Sobrenome"].ToString()
				tempSobrenome.Sobrenome = readSobrenome["Pais"].ToString();
				tempSobrenome.Sobrenome = readSobrenome["MsgSm"].ToString();
			}

			readSobrenome.Close();
			connection.Close();

			return tempSobrenome;
		}


		public Nome GetAllSobrenomes()
		{
			connection.Open();
			command.CommandText = "CALL spGetAllSobrenomes;";
			command.Connection = connection;]
            var readSobrenomes = command.ExecuteReader();
			var tempSobrenomes = new Sobrenome();

			if () readSobrenomes.Read())
            {
				tempSobrenomes.Sobrenome = readSobrenomes["Sobrenome"].ToString()
				tempSobrenomes.Sobrenome = readSobrenomes["Pais"].ToString();
				tempSobrenomes.Sobrenome = readSobrenomes["MsgSm"].ToString();
			}

			readSobrenomes.Close();
			connection.Close();

			return tempSobrenomes;
		}

	}
}

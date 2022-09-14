using System;
using Look4MeAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Look4MeAPI.Controllers
{
    public class DBConnection
    {
    
        MySqlConnection conn2;

        static string host = "localhost";

        static string database = "dbLook4Me";

        static string userDB = "root";

        static string password = "12345678";

        public static string strProvider = "server=" + host +
                                            ";Database=" + database +
                                            ";User ID=" + userDB +
                                            ";Password=" + password;

        public static Boolean novo = false;
        public String sql;

        public DBConnection()
        {

            conn2 = new MySqlConnection(strProvider);

            conn2.Open();

        }
        public List<Sobrenome> BuscaTodos()
        {

            MySqlDataReader reader;

            sql = "SELECT * FROM tbSobrenome;";
            MySqlCommand cmd = new MySqlCommand(sql, conn2);

            reader = cmd.ExecuteReader();
            List<Sobrenome> l = new List<Sobrenome>();

            if (reader.HasRows)
            {
  
                while (reader.Read())
                {
                    l.Add(new Sobrenome(int.Parse(reader["IDsobrenome"].ToString()), reader["Nome"].ToString(), reader["Pais1"].ToString(), reader["Pais2"].ToString(), reader["Pais3"].ToString(), reader["Arvore"].ToString()));

                }
            }
            return l;

        }

        public void Fechar()
        {
            conn2.Close();
        }
    }
}
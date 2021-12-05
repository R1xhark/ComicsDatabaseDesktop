using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ComicsDatabaseDesktop.Database
{
    class ConnectSQL
    {
        public void Connector()
        {
            MySql.Data.MySqlClient.MySqlConnection pripoj;
            string Pripojeni;

            Pripojeni = "server=127.0.0.1;uid=root;" +
                "pwd=|pryxi!Am4yZxE0N};database=test";



            try
            {
                pripoj = new MySql.Data.MySqlClient.MySqlConnection();
                pripoj.ConnectionString = Pripojeni;
                pripoj.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
       
    }
}

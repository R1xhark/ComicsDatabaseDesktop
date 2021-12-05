using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ComicsDatabaseDesktop.Database
{
    class SQLMethods
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public  SQLMethods()
        {
            Initilize();
        }
        public void Initilize()
        {
            server = "hopefully running";
            database = "komiksy";
            uid = "root";
            password = "|pryxi!Am4yZxE0N}";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        }
    }
        }
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinFormsApp
{
    class DataBase
    {
        MySqlConnection connection = new("server=localhost;port=3306;username=root;password=root;database=trello");

        public void OpenConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
        public static int getUserID(string login)
        {
            DataBase db = new DataBase();
            MySqlCommand Id = new MySqlCommand("SELECT `id` FROM `users` WHERE `login` = @uL", db.getConnection());
            Id.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;

            db.OpenConnection();
            object ID = Id.ExecuteScalar();
            db.CloseConnection();
            int id = Convert.ToInt32(ID);
            return id;
        }
    }
}

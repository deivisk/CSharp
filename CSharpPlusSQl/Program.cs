using System;
using MySql.Data.MySqlClient;

namespace CSharpPlusSQl
{
    class Program
    {
        static void Main(string[] args)
        {
            connection();
        }


        static void connection()
        {
            var settings = new MySqlConnectionStringBuilder
            {
                Server = "127.0.0.1",
                UserID = "root",
                Password = "danger123",
                Port = 3306,
                Database = "SQL!!"
            };


            try
            {
                MySqlConnection conn = new MySqlConnection(settings.ConnectionString);
                conn.Open();

                Console.WriteLine("Connection successful");
            }
            catch
            {
                Console.WriteLine("Connection failed!");

            }
        }
    }
}

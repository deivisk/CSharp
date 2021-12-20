using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace JaunaSchema
{
    class CL
    {
        static void Kods()
        {
            List<Customer> lst = Connect();

            foreach (Customer a in lst)
            {
                Console.WriteLine(a.LastName);
            }
        }

        static List<Customer> Connect()
        {
            List<Customer> local = new List<Customer>();
            var settings = new MySqlConnectionStringBuilder
            {
                Server = "127.0.0.1",
                UserID = "root",
                Password = "danger123",
                Port = 3306,
                Database = "JaunaSchema"
            };


            try
            {
                MySqlConnection conn = new MySqlConnection(settings.ConnectionString);
                conn.Open();

                String readCommand = "SELECT FirstName, Lastname FROM JaunaSchema.Customers;";

                MySqlCommand m = new MySqlCommand(readCommand, conn);
                MySqlDataReader dataReader = m.ExecuteReader();

                while (dataReader.Read())
                {

                    Customer localObj = new Customer();
                    localObj.FirstName = dataReader["FirstName"].ToString();
                    localObj.LastName = dataReader["LastName"].ToString();

                    local.Add(localObj);
                }

                dataReader.Close();
                conn.Close();

            }
            catch
            {
                Console.WriteLine("Connection failed!");

            }

            return local;
        }
    }
}

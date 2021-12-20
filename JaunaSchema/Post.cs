using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace JaunaSchema
{
    class Post
    {
        public static void InsertAuthor(String firstName, String LastName, CL conn)
        {
            try
            {
                conn.Open();
                MySqlCommand insert = conn.GetConnetion().CreateCommand();
                insert.CommandText = "INSERT INTO Customers(FirstName, LastName) VALUES(@name, @lastName)";
                insert.Parameters.AddWithValue("@name", firstName);
                insert.Parameters.AddWithValue("@lastName", LastName);
                insert.ExecuteNonQuery();

                conn.Close();
            }
            catch
            {
                Console.WriteLine("Connection failed!");
            }
        }
        public static List<Customer> SelectCustomer(CL conn)
        {
            List<Customer> local = new List<Customer>();

            try
            {
                conn.Open();
                String readCommand = "SELECT FirstName, Lastname FROM JaunaSchema.Customers;";

                MySqlCommand m = new MySqlCommand(readCommand, conn.GetConnetion());
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

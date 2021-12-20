using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace JaunaSchema
{
    class Program
    {
        static void Main(string[] args)
        {

            CL Connection = new CL();

            List<Customer> lst = Post.SelectCustomer(Connection);
            
            foreach(Customer a in lst)
            {
                Console.WriteLine(a.LastName);
            }

            Post.InsertAuthor("Juris", "Kļava", Connection);
        }
    }
}

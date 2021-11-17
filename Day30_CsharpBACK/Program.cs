using System;
using System.Collections.Generic;

namespace Day30_CsharpBACK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet vārdu:");
            string name = Console.ReadLine();
            Console.WriteLine("Ievadiet uzvārdu:");
            string LastName = Console.ReadLine();
            Console.WriteLine("Ievadiet telefona numuru:");
            string PHnumb = Console.ReadLine();
            Console.WriteLine("Ievadiet E-pastu:");
            string Email = Console.ReadLine();

            Customer Cust = new Customer();
            Cust.InitCustomer(name,LastName,PHnumb,Email);

            Console.WriteLine("");

            Cust.Print();
        }
            /*List<string> Vertibas = new List<string>();

            String memory = "";

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadi info");

                memory = Console.ReadLine();

                Vertibas.Add(memory);

                Console.WriteLine("");
            }

            for(int i = 0; i < Vertibas.Count; i++)
            {
                Console.WriteLine(Vertibas[i]);
            }

            Console.WriteLine("");

            Console.WriteLine("Apgrieztā secībā:");

            Vertibas.Reverse();

            for (int i = 0; i < Vertibas.Count; i++)
            {
                Console.WriteLine(Vertibas[i]);
            }
            */
    }
}

using System;

namespace Day14
{
    class Program
    {
        static void Main(string[] args)
        {
            string izvele = "";

            while(izvele != "0")
            {
                Console.WriteLine("1 - Pievienot studentu sarakstam");
                Console.WriteLine("2 - Izsaukt studentu sarakstu");
                Console.WriteLine("0 - iziet");

            

                izvele = Console.ReadLine();

                if(izvele == "0")
                {
                    Console.WriteLine("Adios amigos");
                    break;
                }


                if(izvele == "1")
                {
                    Console.WriteLine("Ievadiet studenta vārdu, uzvārdu");

                    String a = Console.ReadLine();

                    StudentList.AddList(a);

                }
                if(izvele == "2")
                {
                    StudentList.ShowList();
                }

            }


        }
    }
}

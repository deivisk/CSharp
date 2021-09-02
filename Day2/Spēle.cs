using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet minējamo vārdu!");
            String vārds = Console.ReadLine();


            Console.WriteLine("Ievadiet pavedienu!");
            String pavediens = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Jūsu pavediens - " + pavediens);

            String minējums = Console.ReadLine();


            if (vārds == minējums)
            {
                Console.WriteLine("Tu uzvarēji!");
            }
            else
            {
                Console.WriteLine("Nepareizi, mēģini vēlreiz!");
                minējums = Console.ReadLine();
            }
        }
    }
}

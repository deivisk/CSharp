using System;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit = "";

            int Sum = 0;

            while (exit != "Nē")
            {

                 Cip = Ievade();

                Sum++;


                Console.WriteLine("Vai Jūs vēlaties turpināt darbu? 'Jā' vai 'Nē' ");

                exit = Console.ReadLine();


            }

            Console.WriteLine(Sum);


        }
        static void Ievade()
        {

            Console.WriteLine("Ievadiet skaitli");

            Convert.ToInt32(Console.ReadLine());

        }


    }
}

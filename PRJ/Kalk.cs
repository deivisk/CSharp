using System;
using System.Collections.Generic;
using System.Text;

namespace PRJ
{
    class Kalk
    {
        public static void Kalkul()
        {
            Console.WriteLine("Izvēlne");
            Console.WriteLine();
            Console.WriteLine("1. Pirmais");
            Console.WriteLine("2. Otrais");
            Console.WriteLine("3. Trešais");

            String a = Console.ReadLine();

            if(a == "1")
            {
                Console.WriteLine("Apsveicam, Tu izvēlējies pirmo!");
                Console.WriteLine();
                first();
            }
            if(a == "2")
            {
                Console.WriteLine("Apsveicam, Tu izvēlējies otro!");
                Console.WriteLine();
                second();
            }
            if(a == "3")
            {
                Console.WriteLine("Apsveicam, Tu izvēlējies trešo!");
                Console.WriteLine();
                third();
            }

        }


        public static void first()
        {


            int speed = 8;
            int grip = 4;
            int acceleration = 4;

            Console.WriteLine("Jūsu pirmais ir šāds:");
            Console.WriteLine("Ātrums: " + speed);
            Console.WriteLine("Saķere: " + grip);
            Console.WriteLine("Uzrāviens: " + acceleration);

            Console.WriteLine();
            Console.WriteLine("Sacensības? J/N");
            string answer = Console.ReadLine();
            if(answer == "J")
            {
                Console.WriteLine("Sākam!");
                Race();
            }
            else
            {
                Console.WriteLine("Ko tad?");
                first();
            }

        }

        public static void second()
        {
            Console.WriteLine("Jūsu otrais ir šāds:");
            Console.WriteLine("Ātrums: 4");
            Console.WriteLine("Saķere: 8");
            Console.WriteLine("Uzrāviens: 4");
        }
        public static void third()
        {
            Console.WriteLine("Jūsu trešais ir šāds:");
            Console.WriteLine("Ātrums: 4");
            Console.WriteLine("Saķere: 4");
            Console.WriteLine("Uzrāviens: 8");
        }
        public static void Race()
        {
            Random random = new Random();

            if()

        }

    }
}

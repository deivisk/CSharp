using System;
using System.Collections.Generic;
using System.Text;

namespace Day30_CsharpBACK
{
    class Customer
    {
        public String name{ get; set; }
        public String LName{ get; set; }
        public String PNumb { get; set; }
        public String Email{ get; set; }

        public void InitCustomer(String name, String LName, String PNumb, String Email)
        {
            this.name = name;
            this.LName = LName;
            this.PNumb = PNumb;
            this.Email = Email;
        }
        public void Print()
        {
            Console.WriteLine("Vārds: " + name);
            Console.WriteLine("Uzvārds: " + LName);
            Console.WriteLine("telefona numurs: " + PNumb);
            Console.WriteLine("Epasts: " + Email);
        }
    }
}

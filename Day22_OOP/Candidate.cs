using System;
using System.Collections.Generic;
using System.Text;

namespace Day22_OOP
{
    class Candidate
    {
        public String name;
        public String LastName;
        public Double HRmark;
        public Double TVmark;
        public Double avarage;

        public Candidate(String name, String LastName, Double HRmark, Double TVmark, Double avarage)
        {
            name = Console.ReadLine();
            LastName = Console.ReadLine();
            this.name = name;
            this.LastName = LastName;
            this.HRmark = HRmark;
            this.TVmark = TVmark;
            this.avarage = avarage;
        }
        public void izvade()
        {
            Console.WriteLine("Vārds, uzvārds " + name + LastName);
            Console.WriteLine("Dotā atzīme no HR - " + HRmark);
            Console.WriteLine("Dotā atzīme no tehniskā vadītāja - " + TVmark);
            Console.WriteLine("Vidējā atzīme - " + avarage);
        }
    }
}

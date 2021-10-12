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
        public Double average;

        public Candidate(String name, String LastName, Double HRmark, Double TVmark, Double average)
        {
            this.name = name;
            this.LastName = LastName;
            this.HRmark = HRmark;
            this.TVmark = TVmark;
            this.average = average;
        }

        public void izvade()
        {
            Console.WriteLine("Studenta vārds, uzvārds " + name + LastName);
            Console.WriteLine("Dotā atzīme no HR - " + HRmark);
            Console.WriteLine("Dotā atzīme no tehniskā vadītāja - " + TVmark);
            Console.WriteLine("Vidējā atzīme - " + average);
            Console.WriteLine();
        }
    }
}

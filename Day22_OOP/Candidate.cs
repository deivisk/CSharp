﻿using System;
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

        public kautkas(String name, String LastName, Double HRmark, Double TVmark)
        {
            this.name = name;
            this.LastName = LastName;
            this.HRmark = HRmark;
            this.TVmark = TVmark;
        }
        public static void izvade()
        {
            Console.WriteLine("vārds, uzvārds " + name + LastName);
            Console.WriteLine("Dotā atzīme no HR - " + HRmark);
            Console.WriteLine("Dotā atzīme no tehniskā vadītāja - " TVmark);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Day24_JSON
{
    class User
    {
        public String Nick { get; set; }
        public String pass { get; set; }
        public String name { get; set; }
        public String last { get; set; }

        public void InitUser(String Nick, String pass, String name, String last)
        {
            this.Nick = Nick;
            this.pass = pass;
            this.name = name;
            this.last = last;

        }
        public void print()
        {
            Console.WriteLine(Nick + " " + pass + " " + name + " " + last);
        }
    }
}

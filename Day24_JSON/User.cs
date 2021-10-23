using System;
using System.Collections.Generic;
using System.Text;

namespace Day24_JSON
{
    class User
    {
        String Nick { get; set; }
        String pass { get; set; }
        String name { get; set; }
        String last { get; set; }

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

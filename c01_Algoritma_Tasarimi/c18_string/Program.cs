﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c18_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(new string('-', i));

            }

            KarakterSeti.karakterSeti();
            KarakterSeti.karakterSeti(128,255);
            KarakterSeti.karakterSeti(128,255,20);


        }
    }
}

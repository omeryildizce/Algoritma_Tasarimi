using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c17_char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 65; i <= 90; i++)
            {
                Console.Write("{0,-2}", (char)i);
            }
            Console.WriteLine();
            for (int i = 32; i <= 126; i++)
            {
               
                if(i %32 ==0)
                    Console.WriteLine();
                Console.Write("{0,-2}", (char)i);
            }
            Console.WriteLine();
        }
    }
}

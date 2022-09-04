using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c18_string
{
    public class KarakterSeti
    {
        public static void karakterSeti(int baslangic = 65, int son = 90, int satirKarakter = 10)
        {
            for(int i = baslangic; i < son; i++)
            {
                Console.Write("{0,5}", (char)i);
                if ((i-baslangic) % satirKarakter == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}

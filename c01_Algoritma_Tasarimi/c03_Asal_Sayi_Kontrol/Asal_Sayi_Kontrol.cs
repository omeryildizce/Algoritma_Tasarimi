using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c03_Asal_Sayi_Kontrol
{
    public class Asal_Sayi_Kontrol
    {
        /// <summary>
        /// Parametre olarak gelen sayının asal sayı olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="sayi"></param>
        /// <returns></returns>
        public static bool Asalmi(int sayi)
        {
            if (sayi <= 1)
            {
                Console.WriteLine("En küçk asal sayı ikidir.");
                return false;
            }
            else
            {
                int kontrol = 0;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        kontrol++;
                        break;
                    }
                }

                if (kontrol > 0)
                    return false;
                else
                    return true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c11_for_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tekSayilarinToplami = 0, ciftSayilarinToplami = 0;
            int limit = 0;
            Console.WriteLine("Limit Değeri: ");
            limit = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= limit; i+=2)
            {
                Console.Write("{0,4}",i);
                if ((i + 1) % 50 == 0)
                {
                    Console.WriteLine();
                }
                tekSayilarinToplami += i; 
            }
            Console.WriteLine("\nTek Sayıların Toplam: " + tekSayilarinToplami);
            Console.WriteLine();
            for (int i = 2; i <= limit; i += 2)
            {
                Console.Write("{0,4}", i);
                if (i % 50 == 0)
                {
                    Console.WriteLine();
                }
                ciftSayilarinToplami += i;
            }
            Console.WriteLine("\nÇift Sayıların Toplam: " + ciftSayilarinToplami);

        }
    }
}

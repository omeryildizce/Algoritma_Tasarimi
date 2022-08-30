using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c07_cift_sayilarin_toplami
{
    public class CiftSayiToplami
    {
        public static int ciftSayilariTopla(int x)
        {
            int toplam = 0;
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 == 0)
                {
                    toplam += i;
                }
            }
            return toplam;
        }
        public static int ciftSayilariTopla1 (int x)
        {
            int toplam = 0;
            for (int i = 0; i <= x; i+=2)
            {
                toplam += i;
            }
            return toplam;
        }
        public static int ciftSayilariTopla2(int x)
        {
            int n = x / 2;
            return n * (n + 1);
        }
    }
}

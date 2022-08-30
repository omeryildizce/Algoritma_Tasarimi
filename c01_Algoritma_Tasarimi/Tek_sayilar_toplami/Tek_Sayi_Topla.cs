using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tek_sayilar_toplami
{
    public class Tek_Sayi_Topla
    {
        public static int for_ile_topla(int n)
        {
            int toplam = 0;
            for (int i = 1; i <= n; i+=2)
            {
                toplam += i;
            }
            return toplam;
        }
        public static int for_ve_if_ile_topla(int n)
        {
            int toplam = 0;
            for (int i = 1; i <= n; i++ )
            {
                if (i % 2 == 1)
                {
                    toplam += i;
                }
            }
            return toplam;
        }
        public static int nkare(int sayi)
        {
            int n = (sayi + 1) / 2;

            return n * n; 
        }

    }
}

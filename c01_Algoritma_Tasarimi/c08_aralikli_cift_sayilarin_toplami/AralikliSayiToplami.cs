using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c08_aralikli_cift_sayilarin_toplami
{
    public class AralikliSayiToplami
    {
        public static int ciftSayi(int sayi1, int sayi2)
        {
            int toplam1 = 0;
            int toplam2 = 0;
            int n = 0;
            if (sayi1 %2 ==0)
            {
                sayi1 = sayi1 - 1;
            }
                   
            n = sayi1 / 2;
            toplam1 = n*(n+1) ;
            if (sayi2%2==1)
            {
                sayi2 = sayi2 - 1;
            }
           n = sayi2 / 2 ;
            toplam2 = n*(n+1) ;
            return toplam2 - toplam1;
        }
    }
}

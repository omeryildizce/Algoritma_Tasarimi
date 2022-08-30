using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c08_aralikli_cift_sayilarin_toplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ilk_deger = 7;
            int son_deger = 9;

            Console.WriteLine(AralikliSayiToplami.ciftSayi(ilk_deger, son_deger));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c04_Rakamlar_Toplami
{
    public class Rakamlar_Toplami
    {
        public static int Rakamlar_Topla(int sayi)
        {
            int result = 0;
            int rakam = 0;
            while (true)
            {
                if (sayi > 0)
                {
                    rakam = sayi % 10;
                    sayi -= rakam;
                    sayi /= 10;
                    result += rakam;
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }
}

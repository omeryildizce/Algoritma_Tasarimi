using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c02_Mutlak_Deger
{
    public class Mutlak_Deger
    {
        public static int MutlakDeger(int sayi)
        {
            if (sayi <0)
            {
                return sayi * (-1);       
            }
            else
            {
                return sayi;
            }
        }

    }
}

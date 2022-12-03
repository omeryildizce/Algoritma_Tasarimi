using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c20_okek_obeb
{
    public class Hesapla
    {
        /// <summary>
        /// Paremetre olarak aldığı iki sayıyının okekini bulur.
        /// </summary>
        /// <param name="s1">Sayı 1</param>
        /// <param name="s2">Sayı 2</param>
        /// <returns>Okek</returns>
        public static int Okek(int s1, int s2)
        {
            int s = 1;
            while (s1 != 1 || s2 != 1) 
            {
                int bol = 2;
                for (int i = 1; i <= (s1 > s2 ? s1 : s2); i++)
                {
                    if (s1 % bol == 0 || s2 % bol == 0)
                    {
                        s *= bol;
                        if(s1 % bol == 0)
                        {
                            s1 /= bol;
                        }
                        if (s2 % bol == 0)
                        {
                            s2 /= bol;
                        }
                    }
                    else
                    {
                        bol++;
                    }
                }
            }

            return s;
        }
        /// <summary>
        /// Paremetre olarak aldığı iki sayıyının obebini bulur.
        /// </summary>
        /// <param name="s1">Sayı 1</param>
        /// <param name="s2">Sayı 2</param>
        /// <returns>Okek</returns>
        public static int Obeb(int s1, int s2)
        {
            int s = 1;
            int bolen = 2;
            while (s1 != 1 || s2 != 1 )
            {
                for (int i = 1; i < (s1 > s2 ? s1 : s2); i++)
                {
                    if (s1 % bolen == 0 || s2 % bolen == 0)
                    {
                        if (s1 % bolen == 0  && s2 % bolen == 0)
                        { 
                            s *= bolen;
                        }
                        if (s1 % bolen == 0)
                        {
                            s1 /= bolen;
                        }
                        if (s2 % bolen == 0)
                        {
                            s2 /= bolen;
                        }
                    }
                    else
                    {
                        bolen++;
                    }
                }
            } 
            return s;
        }
        /// <summary>
        /// Faktoriyel hesabı yapan method
        /// </summary>
        /// <param name="n">n!</param>
        /// <returns>n!</returns>
        public static int Faktoriyel(int n)
        {
            if (n == 0)
            { return 1; }

            return n * Faktoriyel(n-1);
        }
    }
}

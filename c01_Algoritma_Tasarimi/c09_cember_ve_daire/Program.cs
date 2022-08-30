using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c09_cember_ve_daire
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double r = 3.2;
            double alfa = 60;
            Console.WriteLine("Çemberin çevresi: 2 * {0} * {1} = {2:f2}", Cember.pi, r, Cember.cevre(r));
            Console.WriteLine("Dairenin alanı:   {0} * {1} * {1} = {2:f2}",Daire.pi, r, Daire.alan(r));
            Console.WriteLine("Dairenin dilim alanı:   {0} * {1} * {1} * {3}/360 = {2:f2}", Daire.pi, r, Daire.alan(r, alfa), alfa);

        }
    }
}

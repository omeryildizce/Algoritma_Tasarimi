using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c01_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi  = new Kisi("Ahmet", 18);
            Console.WriteLine(kisi.Adi +": "+ kisi.Yas);
            Kisi kisi1 = new Kisi("Mehmet");
            Console.WriteLine(kisi1.Adi + ": " + kisi1.Yas);
            Kisi kisi2 = new Kisi();
            Console.WriteLine(kisi2.Adi + ": " + kisi2.Yas);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c03_Modelleme
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Araclar();
            List<Arac> filo = new List<Arac>();
            filo.Add(new Arac
            {
                Marka = "Skoda",
                Model = "Octavia",
                Renk = Renk.Beyaz.ToString(),
                Yil = 2012,
                Motor = Motor.Dizel.ToString(),
                Hacim = 1.6
            }) ;
            filo.Add(new Arac
            {
                Marka = "Opel",
                Model = "Corsa",
                Renk = Renk.Beyaz.ToString(),
                Yil = 2014,
                Motor = Motor.Benzin.ToString(),
                Hacim = 1.4
            });
            filo.Add(new Arac
            {
                Marka = "Renault",
                Model = "Fluence",
                Renk = Renk.Siyah.ToString(),
                Yil = 2017 ,
                Motor = Motor.Dizel.ToString(),
                Hacim = 1.6
            });
            foreach (Arac arac in filo)
            {
                arac.ToString();
            }
            filo.RemoveAt(1);
        }

        private static void Araclar()
        {
            Arac benimAracim = new Arac
            {
                Marka = "Skoda",
                Model = "SuperB",
                Renk = Renk.Gri.ToString(),
                Yil = 2020,
                Motor = Motor.Dizel.ToString(),
                Hacim = 1.6
            };

            Arac seninAracin = new Arac
            {
                Marka = "Skoda",
                Model = "Octavia",
                Renk = Renk.Beyaz.ToString(),
                Yil = 2019,
                Motor = Motor.Benzin.ToString(),
                Hacim = 1.5
            };

            benimAracim.ToString();
            seninAracin.ToString();
            benimAracim.Temizle();
            seninAracin.Temizle();
        }
    }
 
}

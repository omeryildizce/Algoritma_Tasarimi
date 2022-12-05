using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c03_Modelleme
{
    public class Tasit
    {
        public string Motor { get; set; }
        public double Hacim { get; set; }
        public void Temizle() => Console.WriteLine("Taşıt Temizlendi!");

    }
    public enum Motor
    {
        Dizel,
        Benzin,
        Lpg,
        Elektirik,
        Jet
    }
    public enum Renk
    {
        Beyaz,
        Siyah,
        Gri,
        Kırmızı,
        Sarı,
        Yeşil,
        Mavi
    }

}

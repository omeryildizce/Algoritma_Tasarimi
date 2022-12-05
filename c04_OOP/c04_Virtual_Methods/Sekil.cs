using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c04_Virtual_Methods
{
    public class Pozisyon
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString() => 
            $"X : {X} - Y : {Y}";
    }
    public class Boyut
    {
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }

        public override string ToString() =>
            $"Genişlik : {Genislik} - Yükseklik : {Yukseklik}";
    }

    public class Sekil
    {
        public Pozisyon Pozisyon { get; } = new Pozisyon();
        public Boyut Boyut { get;} = new Boyut();
        public virtual void Ciz() => Console.WriteLine($"Şekil {Pozisyon} - {Boyut}");
        public virtual void Tasi(Pozisyon pozisyon)
        { 
            Pozisyon.X = pozisyon.X;
            Pozisyon.Y = pozisyon.Y;
            Console.WriteLine($"Taşındı: {Pozisyon}");
        }
    }
}

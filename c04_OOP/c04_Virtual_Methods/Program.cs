﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c04_Virtual_Methods
{
    internal class Program
    {
        public static void SekilCiz(Sekil sekil) =>
            sekil.Ciz(); 
        static void Main(string[] args)
        {
            // virtual_method();
            // polymorph();
            // abstract_sinif();
            Sekil s1= new Dikdortgen(50,50,100,100);
            SekilCiz(s1);
        }   

        private static void abstract_sinif()
        {
            Sekil s1 = new Dikdortgen();
            s1.Pozisyon.X = 50;
            s1.Pozisyon.Y = 50;
            s1.Boyut.Genislik = 100;
            s1.Boyut.Yukseklik = 200;
            SekilCiz(s1);
        }

        private static void polymorph()
        {
            var r = new Elips();
            r.Pozisyon.X = 55;
            r.Pozisyon.Y = 25;
            r.Boyut.Genislik = 200;
            r.Boyut.Yukseklik = 100;
            SekilCiz(r);
            r.Tasi(new Pozisyon { X = 20, Y = 30 });
            SekilCiz(r);
        }

        private static void virtual_method()
        {
            var r = new Dikdortgen();
            r.Pozisyon.X = 23;
            r.Pozisyon.Y = 43;
            r.Boyut.Genislik = 100;
            r.Boyut.Yukseklik = 50;
            r.Ciz();
            var e = new Dikdortgen();
            e.Pozisyon.X = 23;
            e.Pozisyon.Y = 43;
            e.Boyut.Genislik = 100;
            e.Boyut.Yukseklik = 50;
            e.Ciz();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c03_Modelleme
{
    public class Arac : Tasit
    {
        #region Fields değişkenler
        private string marka, model, renk;
        private int yil;
        #endregion

        #region Properties 
        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public string Renk { get => renk; set => renk = value; }
        public int Yil { get => yil; set => yil = value; }
        #endregion

        #region Constructors
        public Arac()
        {

        }
        public Arac(string marka, string model, string renk, int yil)
        {
            Marka= marka;
            Model= model;
            Renk= renk;
            Yil= yil;
        }
        #endregion

        #region Methods
        public void Calistir() => Console.WriteLine("Araç çalıştı!");
        public void Durdur() => Console.WriteLine("Araç durdu!");
        public override string ToString()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"{Marka}");
            Console.WriteLine($"{Model}");
            Console.WriteLine($"{Renk}");
            Console.WriteLine($"{Yil}");
            Console.WriteLine($"{Motor}");
            Console.WriteLine($"{Hacim}");
            Console.WriteLine();
            return Marka + " " + Model;
        }

        #endregion

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c05_interface
{
    public class YatirimHesabi : IBankaHesap
    {
        private decimal _bakiye;
        public decimal Bakiye => _bakiye;

        public bool Cek(decimal miktar)
        {
            if (_bakiye >= miktar)
            {
                _bakiye -= miktar;
                return true;
            }
            Console.WriteLine("\aCakiye yetersiz!");
            return false;
        }

        public void Yatir(decimal miktar)
        => _bakiye += miktar;

        public override string ToString()
        => $"Yatırım hesabı bakiye bilgisi {_bakiye,6} TL";
    }
}

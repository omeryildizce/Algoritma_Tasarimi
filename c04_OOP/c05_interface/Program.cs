using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c05_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBankaHesap mevduatHesap= new MevduatHesabi();
            ITransfer aktifHesap = new AktifHesap();
            aktifHesap.Yatir(250);
            mevduatHesap.Yatir(500);
            aktifHesap.TransferYap(mevduatHesap, 200);
            Console.WriteLine(mevduatHesap.ToString());
            Console.WriteLine(aktifHesap.ToString());
        }
    }
}

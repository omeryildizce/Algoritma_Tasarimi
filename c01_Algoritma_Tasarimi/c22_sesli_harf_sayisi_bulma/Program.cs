using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c22_sesli_harf_sayisi_bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ifadenin okunması
            string ifade = Console.ReadLine();
            // sesli harf
            int sesliHarf = 0;
            for (int i = 0; i < ifade.Length; i++)
            {
                // kontrol
                if (ifade[i] == 'a' || ifade[i] == 'A' ||
                    ifade[i] == 'e' || ifade[i] == 'E' ||
                    ifade[i] == 'ı' || ifade[i] == 'I' ||
                    ifade[i] == 'i' || ifade[i] == 'İ' ||
                    ifade[i] == 'o' || ifade[i] == 'O' ||
                    ifade[i] == 'ö' || ifade[i] == 'Ö' ||
                    ifade[i] == 'u' || ifade[i] == 'U' ||
                    ifade[i] == 'ü' || ifade[i] == 'Ü' )
                {
                    sesliHarf++;
                }
            }
            Console.WriteLine("{0} ifadesinde {1} sesli harfler.", ifade, sesliHarf);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c02_StreamWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // dinamik yol
                string[] yol = Directory.GetCurrentDirectory().Split('\\');
                string dosyaYol = "";
                for (int i = 0; i < yol.Length - 3; i++)
                {
                    dosyaYol += yol[i] + "\\";

                }
                dosyaYol += "Adlar.txt";
                string[] adlar = new string[] { "Zara", "Ayça", "Mehmet", "Selin", "Kaan" };
                using (StreamWriter sw = new StreamWriter(dosyaYol))
                {
                    foreach (string ad in adlar)
                    {
                        sw.WriteLine(ad);
                    }
                    Console.WriteLine("\n Adlar.txt dosyası başarılı bir şekilde oluşturuldu.");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}

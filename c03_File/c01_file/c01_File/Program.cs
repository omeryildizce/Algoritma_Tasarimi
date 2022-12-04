using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c01_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = "";
            string dosyaYolu = Dosya.FizikselYol("Adlar.txt");
            try
            {
                FileStream fs = new FileStream(dosyaYolu, FileMode.Append, FileAccess.Write, FileShare.None);
                while (ad != "cikis")
                {
                    Console.WriteLine("\nDosyaya kaydetmek için bir isim giriniz: ");
                    ad = Console.ReadLine();
                    if (ad != "cikis")
                    {
                        if (fs.CanWrite)
                        {
                            byte[] yaz = Encoding.UTF8.GetBytes(ad);
                            fs.Write(yaz, 0, yaz.Length);
                            fs.WriteByte(13);
                        }
                        else
                        {
                            Console.WriteLine("Yazma yetkisi yok!");
                        }
                    }
                }
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

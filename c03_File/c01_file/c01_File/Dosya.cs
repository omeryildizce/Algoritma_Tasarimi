using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c01_File
{
    public class Dosya
    {
        public static string FizikselYol(string dosyaAdi)
        { 
            // dinamik konum
            string[] yol = Directory.GetCurrentDirectory().Split('\\');
            string dosyaYol = "";
            for (int i = 0; i < yol.Length - 3; i++)
            {
                dosyaYol += yol[i] + '\\';
            }
            dosyaYol += dosyaAdi;
            return dosyaYol;
             
            
        }
    }
}

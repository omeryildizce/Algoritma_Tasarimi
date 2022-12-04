using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c02_Extension_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Merhaba sevimli dünya";
            Console.WriteLine(StringExtension.KelimeSayisi(s));
            Console.WriteLine(s.KelimeSayisi());
            Console.WriteLine($"{s.KelimeSayisi()}");


        }
    }
    public static class StringExtension
    {
        public static int KelimeSayisi(this string s) => s.Split().Length;
    }
}

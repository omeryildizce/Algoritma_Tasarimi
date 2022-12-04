using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c01_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] X = Matris.Olustur();
            //Matris.Yazdir(X);
            //Matris.Yazdir(Matris.SifirMatrisiOlustur(3,3));
            //Matris.Yazdir(Matris.BirMatrisiOlustur(3, 3));
            //Matris.Yazdir(Matris.KosegenMatrisiOlustur(3));
            //Matris.Yazdir(Matris.SkalerMatrisiOlustur(3));
            //Console.WriteLine("{0}", Matris.KareMatrisMi(X) ? "Kare Matris" : "Kare matris değil!");
            //Matris.Yazdir(Matris.BirimMatrisOlustur(3));
            //Console.WriteLine("{0}", Matris.BirimMatrisMi(X) ? "Birim Matris" : "Birim matris değil!");
            //int[,] Y = Matris.KosegenMatrisiOlustur(5);
            //Matris.Yazdir(Y);
            //int[] D = Matris.DiyagonalElemanlarınListesi(Y);
            //Matris.Yazdir(D);
            //Console.WriteLine("Matrisin izi: {0}", Matris.Izi(Y));
            //int[,] Z = Matris.Olustur(3, 2);
            //Matris.Yazdir(Z);
            //Matris.Yazdir(Matris.Transpoz(Z));
            //int[,] X = Matris.Olustur(4, 3);
            //Matris.Yazdir(X);
            //int[,] Y = Matris.YenidenSekillendir(X, 6, 2);
            //Matris.Yazdir(Y);
            //int[,] X = Matris.Olustur(3, 4);
            //int[,] Y = Matris.Olustur(5, 4);
            //Matris.Yazdir(X);
            //Matris.Yazdir(Y);
            //Console.WriteLine("{0}", Matris.EsitMi(X, Y) ? "Matrisler eşit.": "Matrisler eşit değill.");

            //int[,] X = Matris.Olustur(2, 2);
            //Matris.Yazdir(X);
            //Console.WriteLine("|X| = {0}", Matris.Determinant(X));
            //int[,] X = Matris.Olustur(3, 3);
            //Matris.Yazdir(X);
            //Console.WriteLine("|X| = {0}", Matris.Determinant(X));
            //int[,] X = Matris.Olustur();
            //Matris.Yazdir(X);
            //X = Matris.SkalerCarpim(X,5);
            //Matris.Yazdir(X);
            //int[,] X = Matris.Olustur(7,8);
            //Matris.Yazdir(X);
            //Console.WriteLine("{0}", Matris.ElemanlarinToplami(X));
            //int[,] X = Matris.SimetrikMatrisOlustur(4);
            //Matris.Yazdir(X);
            //Console.WriteLine("{0}", Matris.SimetrikMi(X) ? "Simetrik" : "Simetrik değil!");
            //int[,] X = Matris.KosegenMatrisiOlustur(3,1,5);
            //Matris.Yazdir(X);
            //Console.WriteLine("{0}", Matris.KosegenMatrisMi(X) ? "Köşegen Matris" : "Köşegen Matris Değil!");
            //int[,] X = Matris.UstUcgenMatrisiOlustur(5, -2, 3);
            //Matris.Yazdir(X);
            //int[,] X = Matris.AltUcgenMatrisiOlustur(5, -2, 3);
            //Matris.Yazdir(X);
            //int[,] X = Matris.AltUcgenMatrisiOlustur(3);
            //Matris.Yazdir(X);
            //Console.WriteLine("{0}", Matris.UstUcgenMatrisiMi(X) ? "Üst Üçgen Matrisi" : "Üst Üçgen Matrisi Değil!");
            //int[,] Y = Matris.UstUcgenMatrisiOlustur(3);
            //Matris.Yazdir(Y);
            //Console.WriteLine("{0}", Matris.UstUcgenMatrisiMi(Y) ? "Üst Üçgen Matrisi" : "Üst Üçgen Matrisi Değil!");
            int[,] X = Matris.AltUcgenMatrisiOlustur(3);
            Matris.Yazdir(X);
            Console.WriteLine("{0}", Matris.AltUcgenMatrisiMi(X) ? "Alt Üçgen Matrisi" : "Alt Üçgen Matrisi Değil!");
            int[,] Y = Matris.UstUcgenMatrisiOlustur(3);
            Matris.Yazdir(Y);
            Console.WriteLine("{0}", Matris.AltUcgenMatrisiMi(Y) ? "Alt Üçgen Matrisi" : "Alt Üçgen Matrisi Değil!");
        }
    }
}

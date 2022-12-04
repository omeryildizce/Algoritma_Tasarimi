using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c01_Matrix
{
    internal class Matris
    {
        /// <summary>
        /// Matris Oluştur.
        /// </summary>
        /// <param name="satir">Satır Sayısı</param>
        /// <param name="sutun">Sütun Sayısı</param>
        /// <param name="min">min değer</param>
        /// <param name="mak">max değer</param>
        /// <returns>X matrisi</returns>
        public static int[,] Olustur(int satir = 3, int sutun = 3, int min = 1, int mak = 9)
        {
            int[,] X = new int[satir, sutun];
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Thread.Sleep(1);
                    X[i, j] = new Random().Next(min, mak);
                     
                }
            }
            return X;
        }
        /// <summary>
        /// Parametre olarak aldığı matrisi ekrana yazar.
        /// </summary>
        /// <param name="X"></param>
        public static void Yazdir(int[,] X)
        {
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    Console.Write("{0,3}", X[i,j]);
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Parametre olarak aldığı matrisi ekrana yazar.
        /// </summary>
        /// <param name="X"></param>
        public static void Yazdir(int[] X)
        {
            for (int i = 0; i < X.GetLength(0); i++)
            { 
                Console.Write("{0,3}", X[i]);
            }
            Console.WriteLine();

        }
        /// <summary>
        /// Sıfır matrisi oluşturur
        /// </summary>
        /// <param name="satir">Satır</param>
        /// <param name="sutun">Sütun</param>
        /// <returns>Sıfır Matrisi</returns>
        public static int[,] SifirMatrisiOlustur(int satir = 3, int sutun = 3)
        {
            return  Olustur(satir, sutun, 0,0);
             
        }
        /// <summary>
        /// Bir matrisi oluşturur
        /// </summary>
        /// <param name="satir">Satır</param>
        /// <param name="sutun">Sütun</param>
        /// <returns>Bir Matrisi</returns>
        public static int[,] BirMatrisiOlustur(int satir = 3, int sutun = 3)
        {
            return Olustur(satir, sutun, 1, 1);

        }
        /// <summary>
        /// Köşegen matrsisi oluşturma.
        /// </summary>
        /// <param name="boyut"></param>
        /// <param name="min"></param>
        /// <param name="mak"></param>
        /// <returns></returns>
        public static int[,] KosegenMatrisiOlustur(int boyut = 3, int min = 1, int mak = 9)
        {
            int[,] X = SifirMatrisiOlustur(boyut, boyut);
            for (int i = 0; i < boyut; i++)
            {
                Thread.Sleep(1);
                X[i, i] = new Random().Next(min, mak);
            }
            return X;
        }
        /// <summary>
        /// Skaler Matris oluşturma.
        /// </summary>
        /// <param name="boyut">Satir ve boyut</param>
        /// <param name="skaler">Köşegen değeri</param>
        /// <returns>Skaler Matrisi</returns>
        public static int[,] SkalerMatrisiOlustur(int boyut = 3, int skaler = 3)
        {
             
            return KosegenMatrisiOlustur(boyut, skaler,skaler);
        }
        /// <summary>
        /// Kare matris kontrolu yapar.
        /// </summary>
        /// <param name="X">Matris</param>
        /// <returns>Sonuç</returns>
        public static bool KareMatrisMi(int[,] X)
        {
            return X.GetLength(0) == X.GetLength(1) ? true : false;
        }
        /// <summary>
        /// Birim matrisi oluşturur
        /// </summary>
        /// <param name="boyut">satır ve boyut</param>
        /// <returns>Matris</returns>
        public static int[,] BirimMatrisOlustur(int boyut = 3)
        {
            return SkalerMatrisiOlustur(boyut, 1);
        }
        /// <summary>
        /// Birim matris kontrol
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns></returns>
        public static bool BirimMatrisMi(int[,] X)
        {
            bool s = true;
            for (int i = 0; i < X.GetLength(0) && s == true; i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    // diyagonal elemanlar dışındakiler 0 mı?
                    if (X[i,j] == 0 && i!=j)
                    {
                        s = false;
                        break;
                    }
                    // diyagonal elamanlar 1 mi?
                    else
                    {
                        if (X[i,i] != 1 && i == j)
                        {
                            s = false;
                            break;
                        }
                    }
                }
            }
            return s;
        }
        /// <summary>
        /// Diyagonal elemanların lisstesini bir dizi olarak döner.
        /// </summary>
        /// <param name="X">Matris</param>
        /// <returns>Diyagonal elemanlar lstesi</returns>
        public static int[] DiyagonalElemanlarınListesi(int[,] X)
        {
            if(KareMatrisMi(X))
            {
                int[] D = new int[X.GetLength(0)];
                for (int i = 0; i < X.GetLength(0); i++)
                {
                    D[i] = X[i, i];
                }
                return D;
            }
            else
            {
                Console.WriteLine("Lütfen Kare matris giriniz!");
                return new int[0];
            } 
        }
        /// <summary>
        /// Bir Matrisin izini hesaplar.
        /// </summary>
        /// <param name="X">Matris</param>
        /// <returns>İzi</returns>
        public static int Izi(int[,] X)
        {
            int t = 0;
            if (KareMatrisMi(X))
            {
                int[] D = DiyagonalElemanlarınListesi(X);
                for (int i = 0; i < X.GetLength(0); i++)
                {
                    t += X[i, i];
                }
                return t;
            }
            else return t;
        }
        /// <summary>
        /// Bir matrisin transpozunu alır.
        /// </summary>
        /// <param name="X">Matris</param>
        /// <returns>Transpoz</returns>
        public static int[,] Transpoz(int[,] X)
        {
            int[,] T = new int[X.GetLength(1), X.GetLength(0)];
            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    T[i,j] = X[j, i];
                }
            }
            return T;
        }
        public static int[,] YenidenSekillendir(int[,] X, int yeniSatir, int yeniSutun)
        {
            if (X.Length == yeniSatir * yeniSutun)
            {
                int[] D = new int[X.Length];
                int sayac = 0;
                int[,] Y = new int[yeniSatir, yeniSutun];
                for (int i = 0; i < X.GetLength(0); i++)
                {
                    for (int j = 0; j < X.GetLength(1); j++)
                    {
                        D[sayac++] = X[i, j];
                    }
                }
                Yazdir(D);
                sayac = 0;
                for (int i = 0; i < yeniSatir; i++)
                {
                    for (int j = 0; j < yeniSutun; j++)
                    {
                        Y[i, j] = D[sayac++];
                    }
                }
                return Y;
            }
            else
            {
                Console.WriteLine("Bir hata oluştu.");
                return null;
            }
        }
        public static bool EsitMi(int[,] X, int[,] Y)
        {
            bool s = true;
            if (X.GetLength(0) == Y.GetLength(0) && X.GetLength(1) == Y.GetLength(1))
            {
                // eleman kontrolü
                for (int i = 0; i < X.GetLength(0); i++)
                {
                    for (int j = 0; j < X.GetLength(1); j++)
                    {
                        if (X[i,j] != Y[i,j])
                        {
                            s = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                s= false;
            }
            return s;
        }
        /// <summary>
        /// Detarminant hesabı yapar
        /// </summary>
        /// <param name="X">Matris</param>
        /// <returns>Determinant</returns>
        public static int Determinant(int[,] X)
        {
            int d = -1;
            if (KareMatrisMi(X))
            {
                if (X.Length == 4)
                {
                    d = X[0, 0] * X[1, 1] - X[0, 1] * X[1, 0];
                }
                else if (X.Length == 9)
                {
                    d = X[0, 0] * (X[1, 1] * X[2, 2] - X[1, 2] * X[2, 1]) - X[0, 1] * (X[1, 0] * X[2, 2] - X[2, 0] * X[1, 2]) + X[0, 2] * (X[1, 0] * X[2, 1] - X[1, 1] * X[2, 0]);
                }
                else
                {
                    Console.WriteLine("Tanımlı bir boyut yok!");
                }
                return d;
            }
            else
            {
                Console.WriteLine("Parametre kare matris olmalı.");
                return d;
            }
        }
        /// <summary>
        /// Skaler bir değer ile matrisi çarpar.
        /// </summary>
        /// <param name="X">Matris</param>
        /// <param name="c">Skaler Değer</param>
        /// <returns>Çarpım Sonucu</returns>
        public static int[,] SkalerCarpim(int[,] X, int c)
        {
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    X[i, j] *= c;
                }
            }
            return X;
        }
        /// <summary>
        /// Bir matrisdeki elemanların toplamını bulur.
        /// </summary>
        /// <param name="X">Matris</param>
        /// <returns>Toplam</returns>
        public static int ElemanlarinToplami(int[,] X) 
        {
            int t = 0;
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    t += X[i, j];
                }
            }
            return t;
        }
        /// <summary>
        /// Simetrik matris oluşturma
        /// </summary>
        /// <param name="boyut">satir ve sütun</param>
        /// <param name="min">minumum</param>
        /// <param name="mak">maximum</param>
        /// <returns>Matris</returns>
        public static int[,] SimetrikMatrisOlustur(int boyut = 3, int min = 1, int mak =  9)
        {
            int[,] X = KosegenMatrisiOlustur(boyut, min, mak);
            for (int i = 1; i < X.GetLength(0); i++)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    Thread.Sleep(1);
                    X[i, j] = new Random().Next(min, mak);
                    X[j, i] = X[i, j];
                }
            }
            return X;
            
        }
        /// <summary>
        /// Matrisinin simetrik özelliğini kontrol eder 
        /// </summary>
        /// <param name="X">Matris</param>
        /// <returns>Simetrik mi?</returns>
        public static bool SimetrikMi(int[,] X)
        {
            int[,] Y = Matris.Transpoz(X);
            return EsitMi(X, Y);
        }
        /// <summary>
        /// Köşegen Matris kontrolü yapar
        /// </summary>
        /// <param name="X">Matris</param>
        /// <returns>Köşegen matrisi</returns>
        public static bool KosegenMatrisMi(int[,] X)
        {
            bool s = true;
            if(Matris.KareMatrisMi(X))
            {
                for (int i = 0; i < X.GetLength(0); i++)
                {
                    for (int j = 0; j < X.GetLength(1); j++)
                    {
                        if (X[i,j] != 0)
                        {
                            if (i != j)
                            {
                                s = false;
                                break;  
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Kare Matris Değil");
                s = false;
            }
            return s;
        }
        /// <summary>
        /// Üst üçgen matrisi oluşturur
        /// </summary>
        /// <param name="boyut">satir ve sütun</param>
        /// <param name="min"></param>
        /// <param name="mak"></param>
        /// <returns>Matris</returns>
        public static int[,] UstUcgenMatrisiOlustur(int boyut = 3, int min = 1, int mak = 9)
        {
            int[,] X = KosegenMatrisiOlustur(boyut, min, mak);
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = i; j < X.GetLength(1); j++)
                {
                    Thread.Sleep(1);
                    X[i, j] = new Random().Next(min, mak);
                }
            }
            return X;
        }
        /// <summary>
        /// Alt üçgen matrisi oluşturur
        /// </summary>
        /// <param name="boyut">satir ve sütun</param>
        /// <param name="min"></param>
        /// <param name="mak"></param>
        /// <returns>Matris</returns>
        public static int[,] AltUcgenMatrisiOlustur(int boyut = 3, int min = 1, int mak = 9)
        {
            int[,] X = KosegenMatrisiOlustur(boyut, min, mak);
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j <= i ; j++)
                {
                    Thread.Sleep(1);
                    X[i, j] = new Random().Next(min, mak);
                }
            }
            return X;
        }
        /// <summary>
        /// Matrisin ust üçgen matrisi olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="X">Matris</param>
        /// <returns>Sonuc</returns>
        public static bool UstUcgenMatrisiMi(int[,] X)
        {
            bool s = true;
            for (int i = 1; i < X.GetLength(0); i++)
            {
                for (int j = 0; j <= i-1; j++)
                {
                    if (X[i,j] != 0)
                    {
                        s = false;
                        break;
                    }
                }
            }
            return s;
        }
        /// <summary>
        /// Matrisin alt üçgen matrisi olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="X">Matris</param>
        /// <returns>Sonuc</returns>
        public static bool AltUcgenMatrisiMi(int[,] X)
        {
            bool s = true;
            for (int i = 0; i < X.GetLength(0)  -1 ; i++)
            {
                for (int j = i+1; j < X.GetLength(1 ); j++)
                {
                    if (X[i, j] != 0)
                    {
                        s = false;
                        break;
                    }
                }
            }
            return s;
        }

    }
}

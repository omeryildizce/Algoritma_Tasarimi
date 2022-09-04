using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c14_tek_boyutlu_dizi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1D Array
            int[] array = new int[5];

            // get lenght of the array
            int n = array.Length;

            // random number generator for the array
            for (int i = 0; i < n; i++)
            {
                array[i] = new Random().Next(0,100);
                Console.WriteLine(array[i]);
                Thread.Sleep(1);

            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c06_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // enumarator__();
            Collection<int> a;
            ICollection b;
            ICollection<int> c;
        }

        private static void enumarator__()
        {
            string s = "Merhaba";
            IEnumerator rator = s.GetEnumerator();
            while (rator.MoveNext())
            {
                Console.WriteLine(rator.Current);
            }

            foreach (char c in s)
            {
                Console.WriteLine(c);
            }
        }
    }
    internal class MyGenCollection : IEnumerable<int>
    {
        int[] data = { 1, 2, 3 };

        public IEnumerator<int> GetEnumerator()
        {
            foreach (int i in data)
            {
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (int i in data)
            {
                yield return i;
            }
        }
    }

    internal class MyCollection : IEnumerable
    {
        int[] data = { 1, 2, 3 };

        public IEnumerator GetEnumerator()
        {
            foreach (int i in data)
            {
                yield return i;
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Libriary: IEnumerable 
    {
        class myEnumerator : IEnumerator
        {
            int i = -1;

            public object Current => intd[i];

            public bool MoveNext()
            {
                if (i == intd.Length-1)
                {
                    Reset();
                    return false;
                }
                i++;
                return true;
            }

            public void Reset()
            {
                i = -1;
            }
        }
        static protected int[] intd = { 1, 2, 3, 4, 5 };
        public IEnumerator GetEnumerator()
        {
            return new myEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Libriary a = new Libriary();
            foreach (var i in a)
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}

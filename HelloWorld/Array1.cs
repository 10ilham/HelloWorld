using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Array1
    {
        static void Main(string[] args)
        {
            int[] bil = new int[10];
            Console.WriteLine("{0}{1,8}", "indeks", "nilai");
            for (int i = 0; i < bil.Length; i++)
            {
                bil[i] = i + i;
            }
            for(int i = 0; i < bil.Length; i++)
            {
                Console.WriteLine("{0}{1,8}", i, bil[i]);
            }
            Console.Read();
        }
    }
}

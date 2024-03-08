using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class LoopingForeach
    {
        static void Main(string[] args)
        {
            string[] angka = { "one", "two", "three" };

            foreach (string elmen in angka)
            {
                Console.WriteLine(elmen);
            }
            Console.Read();
        }
    }
}

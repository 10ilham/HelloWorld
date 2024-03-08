using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class loopingdowhile
    {
        static void Main(string[] args)
        {
            int i = 10;
            do
            {
                Console.WriteLine("Data ke-" + i.ToString());
                i--;
            } while (i >= 1);
            Console.Read();
        }
    }
}

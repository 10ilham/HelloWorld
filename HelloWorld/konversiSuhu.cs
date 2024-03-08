using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class konversiSuhu
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Konversi Suhu");
            Console.WriteLine("-----------");

            try
            {
                Console.Write("Masukkan Suhu dalam Celsius : ");
                double c = Convert.ToDouble(Console.ReadLine());

                double f = (c * 9 / 5) + 32;
                double r = c * 4 / 5;
                double k = c + 273.15;

                Console.WriteLine("Hasil Konversi :");
                Console.WriteLine("Fahrenheit : " + f); 
                Console.WriteLine("Reamur : " + r);
                Console.WriteLine("Kelvin : " + k);
            }
            catch (FormatException)
            {
                Console.WriteLine("Inputan celcius tidak valid, gunakan angka ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Inputan terlalu besar untuk di olah");
            }catch (Exception f1)
            {
                Console.WriteLine("Terjadi kesalahan" + f1.Message);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class ConversiWaktu
    {
        static void Main(string[] args)
        {
            int detik;

            try
            {
                Console.Write("Masukan Total Detik : ");
                detik = Convert.ToInt32(Console.ReadLine());
                int jam = detik / 3600;
                detik %= 3600;
                int menit = detik / 60;
                detik %= 60;

                Console.WriteLine("Hasil konversi : ");
                Console.WriteLine("Jam : " + jam);
                Console.WriteLine("Menit : " + menit);
                Console.WriteLine("Detik : " + detik);
            } catch (FormatException){
                Console.WriteLine("Inputan waktu tidak valid, gunakan angka ");
            }catch (OverflowException)
            {
                Console.WriteLine("Angka inputan terlalu besar untuk di konversi");

            }catch (Exception a1)
            {
                Console.WriteLine("Terjadi kesalahan" + a1.Message);

            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class LatArray
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan Jumlah Baris Array :");
            int baris = int.Parse(Console.ReadLine());

            Console.Write("Masukan Jumlah Kolom Array :");
            int kolom = int.Parse(Console.ReadLine());

            int[,] array = new int[baris, kolom];
            for (int i = 0; i < baris; i++)
            {
                for (int j = 0; j < kolom; j++)
                {
                    Console.Write($"Masukan Nilai Untuk Nilai Array [{i},{j}]:");
                    array[i, j] = int.Parse(Console.ReadLine());

                }

            }

            Console.WriteLine("\nElemen array yang dimasukkan:");
            // Menampilkan nilai setiap elemen array
            for (int i = 0; i < baris; i++)
            {
                for (int j = 0; j < kolom; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int max = array[0, 0];
            int min = array[0, 0];
            for (int i = 0; i < baris; i++)
            {
                for (int j = 0; j < kolom; j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }

                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }

            Console.WriteLine("\nNilai terbesar: " + max);
            Console.WriteLine("Nilai terkecil: " + min);
            Console.Read();
        }
    }
}

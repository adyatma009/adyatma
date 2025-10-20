using System;

namespace praktik_7._3_fungsi
{
    internal class Program
    {
        static int kali(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.Write("Masukkan angka pertama: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int hasil = kali(x, y);
            Console.WriteLine("Hasil perkalian: " + hasil);
        }
    }
}

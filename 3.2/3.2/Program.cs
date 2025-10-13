using System;

namespace pengurangan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan Angka Pertama:   ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan Angka Ke Dua:    ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hasil penguranga:  " + (a - b));

            Console.Write("Masukan Angka Ke Tiga:   ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Angka Ke Empat:  ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("hasil pengurangan:   " + (c - d));
        }
    }
}

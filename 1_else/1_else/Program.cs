using System;

namespace _1_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukan angka: ");
            int angka = int .Parse(Console.ReadLine()); 

            if (angka >= 0 )
            {
                Console.WriteLine("angka positif: ");
            }
            else
            {
                Console.WriteLine("angka negatif: ");
            }
        }
    }
}

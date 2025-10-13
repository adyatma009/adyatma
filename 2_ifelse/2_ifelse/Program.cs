using System;

namespace _2_ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukan angka:");
            int angka = int .Parse(Console.ReadLine());

            if (angka > 0)
            {
                Console.WriteLine("angka positif");
            }
            else if (angka < 0)
            {
                Console.WriteLine("angka negatif ");
            }
            else
            {
                Console.WriteLine("angka nol");
            }
        }
        

    }
}

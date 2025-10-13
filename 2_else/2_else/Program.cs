using System;

namespace _2_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukan umur: ");
            int umuer = int .Parse(Console.ReadLine());

            if ( umuer >=17 )
            {
                Console.WriteLine("anda sudah dewasa ");
            }
            else
            {
                Console.WriteLine("anda belum dewasa");
            }
        }
    }
}

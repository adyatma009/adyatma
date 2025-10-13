using System;

namespace _4_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukan nilai");
            int nilai = int .Parse(Console.ReadLine());

            if (nilai >= 90)
            {
                Console.WriteLine("peringkat A ");
            }
            else if (nilai >= 75)
            {
                Console.WriteLine(" peringkat B ");
            }
            else if (nilai >=60)
            {
                Console.WriteLine("peringkat B");
            }
            else
            {
                Console.WriteLine("peingkat D");
            }
        }
    }
}

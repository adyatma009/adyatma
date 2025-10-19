using System;

namespace tugas_5__2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int i = 1;
            Console.WriteLine("jumlah total dari bilangan 1 sampai 5");
            while (i <= 5)
            {
                total += i;
                i++;
            }
            Console.WriteLine("/nHasil akhir penjumlahan adalah: " + total);
        }
    }
}

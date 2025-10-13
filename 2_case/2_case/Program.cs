using System;
using System.Reflection;

namespace _2_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("masukan angka (1-12)");
            int bulan = int.Parse(Console.ReadLine());

            switch(bulan)
            {
                case 1: Console.WriteLine("januari"); break;
                    case 2: Console.WriteLine("febuari"); break;
                    case 3: Console.WriteLine("maret"); break;
                    case 4: Console.WriteLine("april"); break;
                    case 5: Console.WriteLine("mei"); break;
                    case 6: Console.WriteLine("juni"); break;
                    case 7: Console.WriteLine("juli"); break;
                    case 8: Console.WriteLine("agustus"); break;
                    case 9: Console.WriteLine("september"); break;
                    case 10: Console.WriteLine("oktober"); break;
                    case 11: Console.WriteLine("november"); break;
                    case 12: Console.WriteLine("desember"); break;
            }
        }
    }
}

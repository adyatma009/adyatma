using System;

namespace _6._3_M.Adyatma_Arfa_Wibowo___X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nama = new string[3];
            int[] nilai = new int [3];

            Console.Write("Masukan nama siswa ke-1:");
            nama[0] = Console .ReadLine();
            Console.Write("Masukan nilai siswa ke-1:");
            nilai[0] = int.Parse(Console.ReadLine());


            Console.Write("Masukan nama sisiwa ke-2:");
            nama[1] = Console .ReadLine();
            Console.Write("Masukan nilai ke-2:");
            nilai[1] = int.Parse(Console.ReadLine());


            Console.Write("Masukan nama ke-3:");
            nama[2] = Console .ReadLine();
            Console.Write("Masukan nilai ke-3::");
            nilai[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("\n===== DATA SISWA =====");
            Console.WriteLine("Nama: " + nama[0] + " | " + nilai[0]);
            Console.WriteLine("Nama: " + nama[1] + " | " + nilai[1]);
            Console.WriteLine("Nama: " + nama[2] + " | " + nilai[2]);
        }
    }
}

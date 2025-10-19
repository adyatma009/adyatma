using System;

namespace _6._1_M.Adyatma_Arfa_WIbowo_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] siswa = new string[5];

            siswa[0] = "andi";
            siswa[1] = "budi";
            siswa[2] = "citra";
            siswa[3] = "dewi";
            siswa[4] = "eka";

            Console.WriteLine("DAFTAR NAMA SISWA :");
            Console.WriteLine("siswa ke-1 : " + siswa[0]);
            Console.WriteLine("siswa ke-2 : " + siswa[1]);
            Console.WriteLine("siswa ke-3 : " + siswa[2]);
            Console.WriteLine("siswa ke-4 : " + siswa[3]);
            Console.WriteLine("siswa ke-5 : " + siswa[4]);
        }
    }
}

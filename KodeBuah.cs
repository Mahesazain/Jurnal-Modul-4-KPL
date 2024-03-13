using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302220105
{
    internal class KodeBuah
    {
        private string[,] kodebuahArray = new string[,]
        {
            { "Apel", "A00" },
            { "Aprikot", "B00" },
            { "Alpukat", "C00" },
            { "Pisang", "D00" },
            { "Paprika", "E00" },
            { "Blackberry", "F00" },
            { "Ceri", "H00" },
            { "Kelapa", "I00" },
            { "Jagung", "J00" },
            { "Kurma", "K00" },
            { "Durian", "L00" },
            { "Anggur", "M00" },
            { "Melon", "N00" },
            { "Semangka", "O00" }
        };

        public string GetKodeBuah(string buah)
        {
            for (int i = 0; i < kodebuahArray.GetLength(0); i++)
            {
                if (kodebuahArray[i, 0].ToLower() == buah.ToLower())
                {
                    return kodebuahArray[i, 1];
                }
            }
            return "Kodebuah tidak ditemukan.";
        }

        public string GetKodeBuah2()
        {
            for (int i = 0; i < kodebuahArray.GetLength(0); i++)
            {
                Console.WriteLine(kodebuahArray[i, 1]);
            }
            return "Kodebuah tidak ditemukan.";
        }
    }
}

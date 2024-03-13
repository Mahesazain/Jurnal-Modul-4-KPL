using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302220105
{
    internal class KodeBuah1
    {
        public enum NamaBuah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka };
        public enum KodeBuah { A00, B00, C00, D00, E00, F00, H00, I00, J00, K00, L00, M00 , N00, O00 }

        public void getKodeBuah()
        {
            Console.WriteLine("Nama Buah\tKode Buah");
            for (int i = 0; i < 11; i++)
            {
                string kelPad = ((NamaBuah)i).ToString().PadRight(15);
                Console.Write(kelPad + "\t" + ((KodeBuah)i).ToString());
                Console.WriteLine();
            }
        }
    }
}

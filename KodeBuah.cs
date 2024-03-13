using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302220105
{
    internal class KodeBuah
    {
        public String namabuah;
        public String kodebuah;
        public List<KodeBuah> listKodeBuah = new List<KodeBuah>();
        public KodeBuah(String a = "", String k = "")
        {
            this.namabuah = a;
            this.kodebuah = k;
        }

        public void setKodeBuah()
        {
            this.listKodeBuah.Add(new KodeBuah("Apel", "A00"));
            this.listKodeBuah.Add(new KodeBuah("Aprikot", "B00"));
            this.listKodeBuah.Add(new KodeBuah("Alpukat", "C00"));
            this.listKodeBuah.Add(new KodeBuah("Pisang", "D00"));
            this.listKodeBuah.Add(new KodeBuah("Paprika", "E00"));
            this.listKodeBuah.Add(new KodeBuah("Blackberry", "F00"));
            this.listKodeBuah.Add(new KodeBuah("Ceri", "H00"));
            this.listKodeBuah.Add(new KodeBuah("Kelapa", "I00"));
            this.listKodeBuah.Add(new KodeBuah("Jagung", "J00"));
            this.listKodeBuah.Add(new KodeBuah("Kurma", "K00"));
            this.listKodeBuah.Add(new KodeBuah("Durian", "L00"));
            this.listKodeBuah.Add(new KodeBuah("Anggur", "M00"));
            this.listKodeBuah.Add(new KodeBuah("Melon", "N00"));
            this.listKodeBuah.Add(new KodeBuah("Semangka", "O00"));
        }

        public void getKodeBuah()
        {
            Console.WriteLine("Buah\tKode Buah");
            foreach (KodeBuah k in this.listKodeBuah)
            {
                string kelPad = k.namabuah.PadRight(15);
                Console.Write(kelPad + "\t" + k.kodebuah);
                Console.WriteLine();
            }

        }

    }
}

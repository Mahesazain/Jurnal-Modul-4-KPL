namespace modul4_1302220105
{
    class Program
    {
        static void Main(string[] args)
        {
            KodeBuah kodeBuah = new KodeBuah();
            kodeBuah.GetKodeBuah2();

            Console.WriteLine("GetKodeBuah");
            for (int i = 0; i < 2; i++)
            {
                KodeBuah myKodeBuah = new KodeBuah();
                Console.Write("Masukkan nama Buah : ");
                string Buah = Console.ReadLine();
                string KodeBuah = myKodeBuah.GetKodeBuah(Buah);
                Console.WriteLine($"Kode pos untuk '{Buah}' adalah: {KodeBuah}");
            }


        }
    }
}
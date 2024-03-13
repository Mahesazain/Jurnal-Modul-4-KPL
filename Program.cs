namespace modul4_1302220105
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contoh pertama :");
            KodeBuah kodebuah = new KodeBuah();
            kodebuah.setKodeBuah();
            kodebuah.getKodeBuah();

            Console.WriteLine("\nContoh kedua :");
            KodeBuah1 kodepos1 = new KodeBuah1();
            kodepos1.getKodeBuah();

        }
    } 
}
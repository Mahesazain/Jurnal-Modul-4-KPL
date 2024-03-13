namespace modul4_1302220105
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KodeBuah :");
            KodeBuah kodebuah = new KodeBuah();
            kodebuah.setKodeBuah();
            kodebuah.getKodeBuah();

            Console.WriteLine("\nKodeBuah1 :");
            KodeBuah1 kodepos1 = new KodeBuah1();
            kodepos1.getKodeBuah();

        }
    } 
}
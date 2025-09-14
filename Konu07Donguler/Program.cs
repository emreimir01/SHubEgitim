namespace Konu07Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu07 Döngüler");
            // For Döngüsü
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("For Döngüsü: {0}", i ); 
            }
            Console.WriteLine();
            // While döngüsü
            int j = 0;
            while (j <= 10)
            {
                Console.WriteLine("While Döngüsü: {0}", j);
                j++;
            }
            Console.WriteLine();
            // Do-While Döngüsü
            int k = 0;
            do
            {
                Console.WriteLine("Do-While Döngüsü: {0}", k);
                k++;
            } while (k <= 10);
            Console.WriteLine();
            // Foreach Döngüsü
            string[] kategoriler = { "Bilgisayar", "Telefon", "Elektronik", "Beyaz Eşya" };
            Console.WriteLine("Kategoriler:");
            foreach (var item in kategoriler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            // İç İçe Döngüler
            string[] urunler = { "Laptop", "Masaüstü", "Tablet" };
            foreach (var kategori in kategoriler)
            {
                Console.WriteLine(kategori); // Kategori adını yazdırır.
                foreach (var urun in urunler) // Urunler dizisinde dönmeye başla.
                {
                    Console.WriteLine(urun);
                }

            }
            Console.WriteLine();

            // İç içe for döngüsü
            for ( int i = 0; i < 5; i++)
            {
                Console.WriteLine("i: "+ i);
                for (int m = 0; m < 3; m++)
                {
                    Console.WriteLine(" k: " + m);
                }
            }
        }
    }
}

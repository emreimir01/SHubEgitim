namespace Konu06Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu06 Diziler");
            int[] sayi; // Dizi tanımlama
            int[] ogrenciler = new int[6]; // Öğrenciler adında int veri tipinde ve 6 elemandan oluşan dizi tanımladık. Dizi boyutu değiştirilemez.

            ogrenciler[0] = 100; // Dizinin 0. elemanına 100 değerini atadık.
            ogrenciler[1] = 200;
            ogrenciler[2] = 300;
            ogrenciler[3] = 400;
            ogrenciler[4] = 500;
            ogrenciler[5] = 500; // Dizi değerleri aynı olabilir.
            // Dizideki değere ulaşma
            Console.WriteLine("ogrenciler[5]: "+ ogrenciler[5]);
            ogrenciler[5] = 600; // Dizinin 5. elemanını güncelledik.
            Console.WriteLine("ogrenciler[5]: " + ogrenciler[5]);
            // ogrenciler[6] = 700; // Hata: Dizi boyutunu aştık.
            Console.WriteLine();

            string[] isimler = new string[5]; // 5 elemanlı string dizi 
            isimler[0] = "Ahmet";
            isimler[1] = "Mehmet";
            isimler[2] = "Ayşe";
            isimler[3] = "Fatma";
            isimler[4] = "Zeynep";
            Console.WriteLine("isimler[4]: "+ isimler[4]);

            Console.WriteLine();

            int[] ogrenciler2 = { 10, 20, 30, 40, 50 }; // Dizi tanımlama ve değer atama
            Console.WriteLine("Seçilen Öğrenci No: "+ ogrenciler2[3]);
            ogrenciler2[3] = 100; // Dizi elemanını güncelleme
            Console.WriteLine("Seçilen Öğrenci No: " + ogrenciler2[3]);

            Console.WriteLine();

            string[] urunler = { "Laptop", "Telefon", "Tablet", "Klavye", "Mouse" };
            Console.WriteLine(urunler[1]);

        }
    }
}

namespace Konu17HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 17 Hata Yönetimi");
            Console.WriteLine();
            Console.WriteLine("Kdv hesaplamak için fiyat giriniz: ");
            var fiyat = Console.ReadLine();
            // KDVHesapla(double.Parse(fiyat));
            try // Try yaz taba 2 kez bas
            {
                KDVHesapla(double.Parse(fiyat)); // try bloğunda bulunan kodlar çalıştırılması denenir. Bir hata olursa 
            }
            catch (Exception hata) // catch bloğunda oluşan hata yakalanarak işlem yapılır.
            {
                Console.WriteLine("Hata oluştu! Lütfen sadece sayısal değer giriniz!");
                // throw; // throw hata fırlatır.
                // oluşan hatayı veritabanına kaydederek loglayabilir ve kendimize mail atarak haber vermesini sağlayabiliriz.
                Console.WriteLine(hata.Message); // hata mesajını ekrana yazdırır. 
            }
            finally // finally bloğu try-catch bloklarından sonra çalışır. Hata olsa da olmasa da çalışır.
            {
                Console.WriteLine("İşlem tamamlandı.");
                Console.WriteLine("Kdv hesaplamak için fiyat giriniz: ");
                var fiyat2 = Console.ReadLine();
                KDVHesapla(double.Parse(fiyat2));
            }
            static void KDVHesapla(double fiyat)
            {
                Console.WriteLine("Fiyat: " + fiyat);
                Console.WriteLine("Kdv: " + (fiyat * 0.20));
                Console.WriteLine("Kdv dahil toplam tutar: " + (fiyat + (fiyat * 0.20)));
            }
        }
    }
}

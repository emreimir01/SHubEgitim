namespace Konu04KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu04 Karar Yapıları");
            /*Console.WriteLine("Bir sayı giriniz: ");
            var sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0) // eğer sayı 0'dan büyükse
            {
                Console.WriteLine("Sayı pozitiftir.");
            }
            else if (sayi < 0) // eğer sayı 0'dan küçükse
            {
                Console.WriteLine("Sayı negatiftir.");
            }
            else // eğer sayı 0 ise
            {
                Console.WriteLine("Sayı sıfırdır.");
            }*/

            /* Console.WriteLine("Kullanıcı Adınızı Giriniz: ");
            string kullaniciAdi = Console.ReadLine();

            Console.WriteLine("Şifrenizi Giriniz: ");
            string sifre = Console.ReadLine();

            if (kullaniciAdi == "admin" && sifre == "12345")
            {
                Console.WriteLine("Giriş Başarılı!");
                Console.WriteLine("Hoşgeldin Emre");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız! Kullanıcı adı veya şifre yanlış.");
            }*/

            int saat = DateTime.Now.Hour;
            if ( saat < 18)
            {
                Console.WriteLine("İyi günle, saat: "+ saat);
            } // Birden fazla kod satırı yazacaksak süslü parantez kullanmalıyız.
            else
                Console.WriteLine("İyi akşamlar, saat: " + saat); // Tek satır kod yazacaksak süslü parantez kullanmayabiliriz.

            // Switch-case yapısı ile akış kontrolü
            int ay = DateTime.Now.Month;
            Console.WriteLine("Bulunduğumuz ay: " + ay);
            switch (ay)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız.");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız.");
                    break;
                case 3:
                    Console.WriteLine("Mart ayındasınız.");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayındasınız.");
                    break;
                case 5:
                    Console.WriteLine("Mayıs ayındasınız.");
                    break;
                case 6:
                    Console.WriteLine("Haziran ayındasınız.");
                    break;
                case 7:
                    Console.WriteLine("Temmuz ayındasınız.");
                    break;
                case 8:
                    Console.WriteLine("Ağustos ayındasınız.");
                    break;
                case 9:
                    Console.WriteLine("Eylül ayındasınız.");
                    break;
                case 10:
                    Console.WriteLine("Ekim ayındasınız.");
                    break;
                case 11:
                    Console.WriteLine("Kasım ayındasınız.");
                    break;
                case 12:
                    Console.WriteLine("Aralık ayındasınız.");
                    break;
                default:
                    Console.WriteLine("Geçersiz ay değeri.");
                    break;
            }

        }
    }
}

namespace Konu05Metotlar
{
    internal class Program
    {
        static void ToplamaYap() // metot tanımlama
        {
            Console.WriteLine(10+8);
            //void olan metotlar geriye değer döndürmeyen metotlardır
            // Aynı isimde metotlar farklı parametrelerle kullanılırsa buna overloading-aşırı yükleme denir.
            //Metot kullanımında kullanılan parametreler(sayi1, sayi2) metodun kullanıldığı yerde metoda gönderilmek zorundadır, aksi halde program hata verir
        }
        static void ToplamaYap(int sayi1, int sayi2) // metotlar dışarıdan parametre alarak çalışabilir.
        {
            Console.WriteLine(sayi1 + sayi2);

        }
        static int ToplamaYap(int sayi1, int sayi2, int sayi3) // metotlar dışarıdan parametre alarak çalışabilir.
        {
            return sayi1 + sayi2 + sayi3; // int olan metotlar geriye değer döndüren metotlardır. 

        }

        static bool MailGonder(string mailAdresi)
        {
           if (!string.IsNullOrEmpty(mailAdresi)) // Eğer mail adresi boş değilse
            {
                // Mail gönderme işlemleri
                return true; // mail gönderme başarılı
            }
           else
            {
                return false; // mail gönderme başarısız
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Konu05 Metotlar");
            Console.WriteLine();
            ToplamaYap(); // metot çağırmazsak çalışmaz.
            ToplamaYap(10, 20);
            int sonuc = ToplamaYap(10, 20, 30);
            Console.WriteLine("Hesaplanmış Fiyat: " + sonuc);

            Console.WriteLine("Mail Adresiniz:");
            var email = Console.ReadLine();

            var mailGonderildiMi = MailGonder(email);
            if (mailGonderildiMi==true)
                           {
                Console.WriteLine("Mail Gönderme İşlemi Başarılı");
            }
            else
            {
                Console.WriteLine("Mail Gönderme İşlemi Başarısız");
            }


        }
    }
}

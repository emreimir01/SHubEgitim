namespace Konu01Degiskenler
{
    internal class Program // Sınıf
    {
        static void Main(string[] args) // Method 
        {
            Console.WriteLine("Hello, World!"); // Ekrana yazdırma komutu 
            Console.WriteLine("Merhaba Dünya!");

            Console.Write("Console."); // Write komutu gönderilen değeri yan yana yazdırır.
            Console.Write(".Write");
            Console.Read(); // Ekrandan girilecek 1 karakteri okur.
            Console.ReadLine(); // Ekrandan girilecek satırı okur.

            // C#'ta değişken tanımlama
            // Tamsayı veri tipleri
            byte plaka_kodu; // 0 - 255 arası değer alır. 1 byte yer kaplar.
            plaka_kodu = 34; // Değişkene değer atama
            Console.WriteLine(plaka_kodu); // Değişkeni ekrana yazdırma

            // Değişkenler bellekte stack ve heap olmak üzere iki farklı alanda tutulur. Değer tipli değişkenler stack'te, referans tipli değişkenler ise heap'te tutulur.

            byte birSayi, birSayiDaha; // Bir tiple birden fazla değişken tanımlanabilir.

            birSayi = 0;
            birSayiDaha = 255;
            Console.WriteLine(birSayi);
            Console.WriteLine(birSayiDaha);

            sbyte sbyteTuru = 127; // -128 - 127 arası değer alır. 1 byte yer kaplar.
            short kisa = 32767; //    +32,768 ile  -32,767 arası değer alır. 2 byte yer kaplar.
            ushort birazUzun = 65535; // 0 ile 65,535 arası değer alır. 2 byte yer kaplar.
            int tamsayi = 1234567890; // 32 bit 4 byte yer kaplar.
            uint uzuntamsayi = 1234567890; // 0 ile +4,294,967,295 arası değer alır. 32 bit 4 byte yer kaplar.
            long dahauzuntamsayi = 1234567890123456789; // 64 bit 8 byte yer kaplar.
            ulong enuzuntamsayi = 12345678901234567890; // 0 ile +18,446,744,073,709,551,615 arası değer alır. 64 bit 8 byte yer kaplar.

            // Kesirlii sayı değişkenleri
            float kesirliSayi = 3.14f; // 32 bit 4 byte yer kaplar. Sonuna f eklenmeli. 6-7 basamağa kadar hassasiyet.
            double kesirliSayi2 = 3.14; // 64 bit 8 byte yer kaplar. 15-16 basamağa kadar hassasiyet.

            // Decimal Veri Tipi
            decimal urunFiyati = 9999; // 12 byte 28-29 basamağa kadar hassasiyet.

            // Char Veri Tipi
            char karakter = 'ç'; // Klavyeden girilen her bir karakter için kullanılır. Tek tırnak içinde tanımlanır. 2 byte yer kaplar.

            // String Veri Tipi
            string degisken; // Klavyeden girilecek karakterlerden oluşan yapı için kullanılır. Çift tırnak içinde tanımlanır. 
            string metin = "String veri tipinde tüm karakterleri kullanabiliyoruz";

            Console.WriteLine(metin); // Debug mod-debugging: Hata ayıklama satırın solundaki şeride tıklayıp kırmızı nokta oluşturuyoruz bunun adı breakpoint.

            // Boolean Veri Tipi
            // Geriye true veya false dönen veri tipidir. 1 byte yer kaplar.
            bool islemSonuc = false; 
            // İşlem başarılı ise eğer
            islemSonuc = true;

            byte? kilo = null; // Eğer bir değişkene başlangıç değeri olarak null vermek istersek veri tipinin yanına ? koyarız.
            kilo = 90; // Sonradan değer atayabiliriz.

            // Bir ürünün satışta olup olmadığını bilgisini tutacak değişken
            bool? isSatistami = null;
            // Kontrol ettik 
            isSatistami = true;

            // Var ile değişken tanımlama
            var birDegisken = 18; // Var ile oluşturulan değişkenlerde değişkenin veri tipi c# tarafından değişkene atanan değere göre otomatik algılanır.

            var strMetin = "var kullanırsak değişkene değer atamak zorundayız"; // Değişkene değer ataması yapılmazsa hata verir.
            var sonuc = false;

            Console.WriteLine(birDegisken.GetType()); // GetType() metodu değişkenin veri tipini verir.
            Console.WriteLine(strMetin.GetType());

            sonuc = true;
            // var ile tanımlanan değişkenin tipi sonradan değiştirilemez ancak içindeki değer değiştirilebilir.

            Console.WriteLine("Object Veri Tipi");
            object nesne = "Bu bir nesnedir"; // Object veri tipi tüm veri tiplerinin atandığı en genel veri tipidir. 4 byte yer kaplar.
            Console.WriteLine(nesne  + "-Tipi"+ nesne.GetType());
            nesne = 18; // Object ile tanımlanan nesne değiştirilebilir.
            Console.WriteLine(nesne + "-Tipi" + nesne.GetType());

            object a = 10; // tam sayı
            object b = 'k'; // karakter
            object c = "metin"; // string
            object d = 12.9f; // float

            Console.WriteLine("C# ta sabit tanımlama");
            // C#'ta sabit tanımlama
            const int kdvOrani = 18; // Sabit tanımlama için const anahtar kelimesi kullanılır. Sabitlere sonradan değer atanamaz.
            Console.WriteLine("KDV Orani:" + kdvOrani);

            // Ekrandan değer alma 
            Console.WriteLine("Ekrandan değer alma");
            var deger = Console.ReadLine(); // Ekrandan girilen değer string olarak alınır.
            Console.WriteLine("Girdiğiniz değer:" + deger);



        }
    }
}

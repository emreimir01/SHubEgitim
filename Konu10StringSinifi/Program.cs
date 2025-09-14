namespace Konu10StringSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu10 String Sınıfı\n");
            string degisken;
            char karakter = 'A';
            string metinlericin = "Yan yana karakterlerden oluşan metinler için";
            Ornek1();
            StringMetotlari();
            SplitMetodu();
        }
        static void Ornek1()
        {
            string birMetin = "Ankara başkenttir";
            String birsayi = "123456789";
            System.String birTarih = "02.05.2021";
            string kod = "//5456dfgd\n"; //buradaki \n kodu enter görevi görür ve kendinden sonra gelecek olan metni bir alt satıra kaydırır
            Console.WriteLine(birMetin.GetType());
            Console.WriteLine(birsayi.GetType());
            Console.WriteLine(birTarih.GetType());
            Console.WriteLine(kod);

            string s = "Barış Manço";
            Console.WriteLine("For Döngüsü");
            for (int i  = 0; i  < s.Length; i ++)
            {
                Console.WriteLine(s[i]); // s değişkeninin [i] deki indekslerinin çıktısı.
            }
            Console.WriteLine("Foreach Döngüsü");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }

        static void StringMetotlari()
        {
            string metin = "Stringin birçok Metodu vardır. Metotlar stringi değiştirir.";
            Console.WriteLine("Metinin karakter sayısı (metin.Lenght): " + metin.Length); // Length metodu metin içindeki karakter sayısını verir.
            var klon = metin.Clone(); // Clone metodu metnin bir kopyasını oluşturur.
            Console.WriteLine("metnin klonu: "+ klon);

            metin = "My name is Emre";
            Console.WriteLine(metin + " EndsWith e: " + metin.EndsWith("e"));
            Console.WriteLine(metin + " EndsWith r: " + metin.EndsWith("r"));

            Console.WriteLine();

            Console.WriteLine(metin + " StartsWith M: " + metin.StartsWith("M"));
            Console.WriteLine(metin + " StartsWith m: " + metin.StartsWith("m"));

            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine(metin + " IndexOf name: " + metin.IndexOf("name"));
            Console.WriteLine(metin + " IndexOf Name: " + metin.IndexOf("Name"));
            Console.WriteLine(metin + " LastIndexOf i: " + metin.LastIndexOf("i"));

            Console.WriteLine();

            Console.WriteLine(metin + " Insert 0: " + metin.Insert(0, "Merhaba : "));// metnin değeri değişmiyor sadece başına merhaba ekleniyor
            Console.WriteLine(metin);

            Console.WriteLine();
            Console.WriteLine(metin + " Substring 2: " + metin.Substring(2));
            Console.WriteLine(metin + " Substring 2, 5: " + metin.Substring(2, 5));

            Console.WriteLine(metin+ " ToLower: "+ metin.ToLower());
            Console.WriteLine(metin+ " ToUpper: "+ metin.ToUpper());
            Console.WriteLine(metin+ " metin.ToLower().Replace: "+ metin.ToLower() .Replace(" ", "-"));

            Console.WriteLine(metin + " Remove 2: " + metin.Remove(2));

        }
        static void SplitMetodu()
        {
            string sehirler = "Ankara,İstanbul,İzmir,Bursa,Adana";
            string[] sehirlerArray = sehirler.Split(','); // Split metodu metni belirtilen karakterden bölerek diziye atar.
            Console.WriteLine("4. Şehir: "+ sehirlerArray[3]);
            foreach (var item in sehirlerArray)
            {
                Console.WriteLine("Şehir: "+ item);
            }
            Console.WriteLine();
        }
    }
}

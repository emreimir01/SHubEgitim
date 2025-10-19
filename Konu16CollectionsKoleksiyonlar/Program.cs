using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Konu16CollectionsKoleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 16 Collections Koleksiyonlar");
            Ornek1();
            Ornek2();
            Ornek3();
            Ornek4();
            Ornek5();
            ListKullanimi();
        }
        static void Ornek1()
        {
            ArrayList arrayList = new();
            arrayList.Add(1);
            arrayList.Add("iki");
            arrayList.Add(3.0);
            arrayList.Add(true);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("ArrayList ilk eleman: "+ arrayList[0]); // listede indexini verdiğimiz elemana ulaşma    
        }
        static void Ornek2()
        {
            ArrayList arrayList = new();
            arrayList.Add("İstanbul"); // array liste add metodu ile eleman ekleme 
            arrayList.Add("Ankara");
            arrayList.Add("İzmir");
            arrayList.Add("Bursa");
            arrayList.Add("Antalya");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("ArrayListde sıralama yapabiliriz");
            arrayList.Sort(); // array liste sort metodu ile sıralama yapma
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            arrayList.Reverse(); // array liste reverse metodu ile ters çevirme
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Ornek3()
        {
            var strings = new StringCollection();
            strings.Add("İstanbul");
            strings.Add("Ankara");
            strings.Add("İzmir"); // sadece string ekleyebiliyoruz

            // STRING COLLECTION
            
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }


        }
        static void Ornek4()
        {
            var dictionary = new StringDictionary(); // key value şeklinde veri saklayabiliriz

            dictionary.Add("01", "Adana");
            dictionary.Add("02", "Adıyaman");
            dictionary.Add("34", "İstanbul");
            Console.WriteLine();

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
            // key ve value ları ayrı ayrı almak istersek
            Console.WriteLine();
            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in dictionary.Values)
            {
                Console.WriteLine(item);
            }

        }
        static void Ornek5()
        {
            Console.WriteLine();
            Dictionary<string, string> dictionary = new(); // hangi veri tipinde olacağını belirleyebildiğimiz liste sistemi
            dictionary.Add("book", "Kitap");
            dictionary.Add("18", "Çankırı");
            dictionary.Add("34", "İstanbul");
            Console.WriteLine(dictionary["book"]);

            Console.WriteLine();

            Dictionary<int, string> dictionary2 = new(); // hangi veri tipinde olacağını belirleyebildiğimiz liste sistemi
            dictionary2.Add(1, "Adana");
            dictionary2.Add(18, "Çankırı");
            dictionary2.Add(34, "İstanbul");

            Console.WriteLine();

            Console.WriteLine("dictionary2 values: ");
            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine();
            Console.WriteLine("dictionary2 keys: ");
            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Key);
            }


        }
        static void ListKullanimi()
        {
            Console.WriteLine("List kullanimi");
            Console.WriteLine();
            List<string> sehirler = new(); // string tipinde liste oluşturma
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("İzmir");
            sehirler.Add("Bursa");
            Console.WriteLine("Şehirler: ");
            Console.WriteLine();
            foreach (var item in sehirler)
            {
                Console.WriteLine(item);
            }
            List<User> users = new(); // User tipinde liste oluşturma

            users.Add(new User
            {
                Id = 1,
                Name = "Emre",
                Email = "emreimir01@gmail.com",
                Password= "emreimir40"
            });
            users.Add(new User
            {
                Id = 2,
                Name = "Batuhan",
                Email = "batudemx27@gmail.com",
                Password = "batudemx40"
            });
            Console.WriteLine("Kullanıcılar: ");

            foreach (var item in users)
            {
                Console.WriteLine($"Id: {item.Id}\nName: {item.Name}\nEmail: {item.Email}\nPassword: {item.Password}\n");
            }
            var yeniKullanici = new User
            {
                Id = 3,
                Name = "Ali",
                Email = "alidem33@gmail.com"
            };

            Console.WriteLine("Kullanıcılar listesinde yeniKullanici var mı? : ");
            Console.WriteLine(users.Contains(yeniKullanici));
            users.Add(yeniKullanici);
            Console.WriteLine(users.Contains(yeniKullanici));

            Console.WriteLine("Kullanıcılar 2: ");

            foreach (var item in users)
            {
                Console.WriteLine($"Id: {item.Id}\nName: {item.Name}\nEmail: {item.Email}\nPassword: {item.Password}\n");
            }

            users.AddRange(); // addrange metodu çoklu kayıt eklememizi sağlar.



        }
    }
}

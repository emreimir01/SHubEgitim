namespace Konu08SiniflarClasses
{   
    internal class Ev // Sınıf tanımlama
    {
        internal string sokakAdi;
        internal int kapiNo;

    }
    public class Deneme
    {
        public string UrunAdi = "public ögeye herkes erişebilir";
        protected class test // Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir.
        {
            string UrunAdi; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu08 Sınıflar/Classes");
            /* 
                *Erişim belirteçleri 4 ana sınıfa ayrılır:
                    * Public: Her yerden erişilebilir. Erişim kısıtlaması yoktur.
                    * Protected: Sadece aynı sınıf ve türetilmiş sınıflardan erişilebilir.
                    * internal: Sadece aynı proje içinden erişilebilir.
                    * private: Yalnız bulunduğu sınıftan erişilebilir, dıştaki sınıflardan erişilemez.
             */
            #region Örnek1

            
            Ev ilkEv = new Ev(); // Soyut bir yapı olan ev sınıfından, somut bir nesne olan ilkEv tanımladık.
            ilkEv.sokakAdi = "Çiçek sk.";
            ilkEv.kapiNo = 10;
            Console.WriteLine("ilkEv sokak adı: "+ ilkEv.sokakAdi);
            Console.WriteLine("ilkEv kapi No: "+ ilkEv.kapiNo);

            Console.WriteLine();

            Ev yazlikEv = new Ev();
            yazlikEv.sokakAdi = "Damla sk.";
            yazlikEv.kapiNo = 11;
            Console.WriteLine("yazlikEv sokak adı: "+ yazlikEv.sokakAdi);
            Console.WriteLine("yazlikEv kapı no: "+ yazlikEv.kapiNo);
            Console.WriteLine();
            Ev koyEvi = new()
            {
                kapiNo = 12,
                sokakAdi = "Arden Sokak"
            };
            Console.WriteLine("koyEvi sokak adı: " + koyEvi.sokakAdi);
            Console.WriteLine("koyEvi kapı no: " + koyEvi.kapiNo);
            #endregion
            #region Örnek2
            Kullanici kullanici = new()
            {
                Ad = "Emre",
                Soyad = "İmir",
                id = 1,
                Email = "emreimir01@gmail.com",
                KullaniciAdi = "emreimir",
                Sifre = "12345"

            };
            Console.WriteLine("Kullanici Adi Giriniz: ");
            var kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifre Giriniz: ");
            var Sifre = Console.ReadLine();

            if (kullanici.KullaniciAdi == kullaniciAdi && kullanici.Sifre == Sifre)
            {
                Console.WriteLine("Giriş Başarılı! Hoşgeldiniz " + kullanici.Ad + " " + kullanici.Soyad);
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre hatalı!");
            }
            #endregion
            #region Örnek3
            Araba araba = new()
            {
                Id = 1,
                Marka = "BMW",
                Model = "3.20i",
                KasaTipi = "Sedan",
                YakitTipi = "Benzin",
                VitesTipi = "Otomatik",
                Renk = "Beyaz"
            };
            Araba araba2 = new()
            {
                Id = 2,
                Marka = "Toyota",
                Model = "Corolla",
                KasaTipi = "Sedan",
                YakitTipi = "Dizel",
                VitesTipi = "Manuel",
                Renk = "Gri"
            };
            #endregion
            #region Örnek4
            Kategori kategori = new()
            {
                id = 1,
                KategoriAdi = "Elektronik"
            };
            Kategori kategori2 = new()
            {
                id = 2,
                KategoriAdi = "Bilgisayar"
            };
            Kategori kategori3 = new()
            {
                id = 3,
                KategoriAdi = "Telefon"
            };
            Console.WriteLine($"Anasayfa Hakkımızda  {kategori.KategoriAdi} {kategori2.KategoriAdi} {kategori3.KategoriAdi} İletişim");
            #endregion
            #region Örnek5
            SiniftaMetotKullanimi metotKullanimi = new();
            var sonuc = metotKullanimi.LoginKontrol("emre", "1234");
            if (sonuc) // if bu şekilde kullanırsak sonuc == true anlamına gelir.
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız");
            }
            var toplamasonucu = metotKullanimi.ToplamaYap(5, 10);
            Console.WriteLine("Toplama sonucu: "+ toplamasonucu);

            Console.WriteLine("Statik değişken: "+ SiniftaMetotKullanimi.StatikDegisken); // statik değişkeni sınıfınadı.değişkenadı şeklinde çağırabiliriz.

            Console.WriteLine("Dinamik değişken: "+ metotKullanimi.DinamikDegisken); 
            #endregion
            User user = new User()
            {
                Id = 1, Ad = "Emre", Soyad = "İmir", Email = "emre@user.com", KullaniciAdi = "emreimir", Sifre = "1234", KayitTarihi = DateTime.Now, PhoneNumber = "5551234567"
            };
            var KullaniciGirisSonuc = user.KullaniciGiris(user.Email, user.Sifre);
            Console.WriteLine("Kullanici Giris Sonuc: "+ KullaniciGirisSonuc);
        }
    }
    class Kullanici
    {
        internal int id;
        internal string KullaniciAdi;
        internal string Sifre;
        internal string Email;
        internal string Ad;
        internal string Soyad;
    }
    class Araba
    {
        internal int Id;
        internal string Marka;
        internal string Model;
        internal string KasaTipi;
        internal string YakitTipi;
        internal string VitesTipi;
        internal string Renk;
    }
}

namespace Konu12KalitimInheritance
{
    class Arac
    {
        public string AracTuru;
        
        public void KornaCal()
        {
            Console.WriteLine("Kornaya basıldı!");
        }
    }
    class Otomobil : Arac // İki nokta üst üste araç dediğimizde araç sınıfındaki içerikler otomobil sınıfında kullanılabilir.
    {
        public string Marka {  get; set; }
        public string Model {  get; set; }
    }
    class Tren : Arac
    {
        public string Model { get; set; }
        public string VagonSayisi { get; set; }
    }
    class Gemi : Arac
    {
        public int Uzunluk { get; set; }
        public int KamaraSayisi  { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu12 Kalıtım/Inheritance");

            Arac arac = new Arac();
            arac.AracTuru = string.Empty;
            arac.KornaCal();

            Otomobil otomobil = new Otomobil();
            otomobil.AracTuru = "Otomobil"; // Normalde otomobil classında AracTuru diye bir özellik yok ama Arac sınıfından miras aldığımız için kullanabiliyoruz.
            otomobil.Marka = "BMW";
            otomobil.Model = "M3";
            Console.WriteLine("otomobil.Aracturu : " + otomobil.AracTuru);
            otomobil.KornaCal(); // KornaCal metodu bir üst sınıf olan Arac sınıfından geliyor.

            Console.WriteLine();

            Kategori kategori = new Kategori()
            {
                Id = 1,
                Name = "Elektronik",
                UstMenudeGoster = true,

            };
            if (kategori.UstMenudeGoster)
            {
                Console.WriteLine(kategori.Name);
            }
            Console.WriteLine();
            
            Urun urun = new Urun()
            {
                Id = 1, Name = "Klavye", Fiyat = 399, Kdv = 20
            };
            Console.WriteLine("Ürün bilgileri: ");
            Console.WriteLine("Ürün Adı:"+ urun.Name);
            Console.WriteLine("Ürün fiyatı: "+ urun.Fiyat);

            Console.WriteLine();

            Cizici[] birCizici = new Cizici[4];
            birCizici[0] = new DogruCiz();
            birCizici[1] = new DaireCiz();
            birCizici[2] = new KareCiz();
            birCizici[3] = new Cizici();

             foreach (var item in birCizici)
            {
                item.Ciz(); // her nesnenin içindeki ciz metodunu çalıştırır.
            }




        }
    }
    // Polimorfizm - Çok Biçimlilik
    public class Cizici
    {
        public virtual void Ciz() // virtual keywordü ile bu metodu override - ezilebilir hale getiriyoruz.
        {
            Console.WriteLine("Cizici");
        }
    }
    public class DogruCiz : Cizici
    {
        public override void Ciz() // override boşluk dediğimizde ezilebilir metotlar gelir.
        {
            Console.WriteLine("Düz Çizgi");
        }
    }
    public class DaireCiz : Cizici
    {
        public override void Ciz() // override boşluk dediğimizde ezilebilir metotlar gelir.
        {
            Console.WriteLine("Daire Çizgi");
        }
    }
    public class KareCiz : Cizici
    {
        public override void Ciz() // override boşluk dediğimizde ezilebilir metotlar gelir.
        {
            Console.WriteLine("Kare Çizgi");
        }
    }
}

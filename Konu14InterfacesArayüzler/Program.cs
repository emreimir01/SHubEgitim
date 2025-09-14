namespace Konu14InterfacesArayüzler
{
    public interface  OrnekArayuz // Class yerine interface yazıyoruz
    {
        public int Id { get; set; } // Interface içinde özellikler tanımlayabiliriz.
    }
    interface IDemo
    {
        void Goster(); // Interface içinde metot imzası tanımlayabiliriz. (gövdesiz)
    }
    interface icerebilecekleri : IDemo // Bir interface başka bir interface'i kalıtabilir.
    {
        public int sayi1 { get; set; }
        public int sayi { get; set; }
        static int sayi2 { get; set; } // Interface içinde static özellik tanımlayabiliriz.
        void Topla(); // Metot imzası
        int toplamaYap();
    }
    class ArayuzKullanimi : icerebilecekleri
    {
        public int sayi1 { get; set; }
        public int sayi { get; set; }


        public void Goster()
        {
            Console.WriteLine("void göster metodu");
        }

        public void Topla()
        {
            Console.WriteLine("void topla metodu");
        }

        public int toplamaYap()
        {
            return sayi + sayi1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 14 Interfaces");
            ArayuzKullanimi arayuzKullanimi = new ArayuzKullanimi();
            arayuzKullanimi.sayi = 5;
            arayuzKullanimi.sayi1 = 10;
            arayuzKullanimi.Goster();
            arayuzKullanimi.Topla();
            Console.WriteLine("Toplama işlemi sonucu: " + arayuzKullanimi.toplamaYap());

            Kategori kategori = new()
            {
                Id = 1,
                KategoriAdi = "Bilgisayar",
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };
            Console.WriteLine($"Kategori Id: {kategori.Id}, CreateDate: {kategori.CreateDate}, UpdateDate: {kategori.UpdateDate}");
        }
    }
}

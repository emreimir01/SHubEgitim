namespace Konu08SiniflarClasses
{
    internal class Urun
    {
        // Class içinde değişken-field tanımlama
        internal int Id;
        internal string Adi;
        internal decimal Fiyat;
        // class içinde property tanımlama
        public string UrunAciklamasi { get; set; } // Property oluşturmanın kısayolu prop yazmak.
        public string Markasi { get; set; }
        public bool Durum { get; set; }
        public int KategoriId { get; set; }
        public Kategori? Kategori { get; set; } // Navigation property, ürün ve kategori arasında ilişki kurar.
    }
}

namespace Konu14InterfacesArayüzler
{
    internal class Urun : ISinifGereksinimleri
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UrunAdi { get; set; }
        public string Barkod { get; set; }
        public decimal Fiyat { get; set; }
        public int Stok { get; set; }
    }
    
    
}

namespace Konu12KalitimInheritance
{
    internal class Urun : OrtakOzellikler
    {
        public string? TeknikOzellikler { get; set; } // soru işareti bu alanın null olabileceğini gösterir.
        public decimal Fiyat { get; set; }
        public int Kdv { get; set; }
        public int İskonto { get; set; }

    }
}

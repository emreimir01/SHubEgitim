namespace Konu11Enumlar
{
    internal class Program
    {
        //Enum(Numaratör) lar nesneleri numaralandırmak için kullanılır
        /*
        * Enum tipler üzerindeki kısıtlar
        * 1-Enum blokunda metot tanımlanamaz
        * 2-Arayüz(Interface) kullanamazlar
        * 3-enum blokunda property kullanılmaz
        */
        enum Aylar: byte // byte koleksiyondaki numaraların  veri tipinin  byte türünden olacağını belirtiyor.
        {
            Ocak = 1, // Eğer Ocak'a 1 değeri atamasaydık varsayılan olarak 0 değeri atanırdı.
            Şubat,
            Mart,
            Nisan,
            Mayıs,
            Haziran,
            Temmuz,
            Ağustos,
            Eylül,
            Ekim,
            Kasım,
            Aralık
        }
        enum SiparisDurumu
        {
            Hazırlanıyor, Hazırlandı, KargoBekleniyor, KargoyaVerildi, TeslimEdildi
        }
        enum Meyveler
        {
            Elma = 3, Armut = 5, Çilek = 11
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Konu11 Enumlar");

            byte a = (byte)Meyveler.Armut;
            byte b = (byte)Meyveler.Çilek;
            byte c = (byte)Meyveler.Elma;
            Console.WriteLine($"{Meyveler.Armut}={a}, {Meyveler.Çilek} = {b}, {Meyveler.Elma} = {c}");
            Console.WriteLine();
            Ornek1(SiparisDurum: 1);
            Ornek1(3);

        }
        static void  Ornek1(int SiparisDurum)
        {
            if (SiparisDurum == (int)SiparisDurumu.Hazırlanıyor)
            {
                Console.WriteLine("Siparişiniz Hazırlanıyor..");
            }
            if (SiparisDurum == (int)SiparisDurumu.Hazırlandı)
            {
                Console.WriteLine("Siparişiniz Hazırlandı..");
            }
            if (SiparisDurum == (int)SiparisDurumu.KargoBekleniyor)
            {
                Console.WriteLine("Siparişiniz Kargoya verilmesi bekleniyor..");
            }
            if (SiparisDurum == (int)SiparisDurumu.KargoyaVerildi)
            {
                Console.WriteLine("Siparişiniz Kargoya verildi..");
            }
            if (SiparisDurum == (int)SiparisDurumu.TeslimEdildi)
            {
                Console.WriteLine("Siparişiniz Teslim edildi..");
            }
        }
    }
}

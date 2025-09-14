namespace Konu13KapsüllemeEncapsulation
{
    internal class Bolum
    {
        private string BolumAdi; // Dışarıdan erişime kapalı değişken 
        // Accessor - Getter
        public string GetBolumAdi()
        {
            return BolumAdi;
        } // Geriye private BolumAdi değişkenini döndüren metot
        public void SetBolumAdi(string istenenEgitim)
        {
            if (istenenEgitim == "Grafik Tasarım")
            {
                Console.WriteLine("Kurumumuzda"+ istenenEgitim+ "Eğitimi Verilmemektedir");
            }
            else
                BolumAdi = istenenEgitim; // Mutator - Setter Seçilen eğitim onaylandı.
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 13 Encapsulation");
            Bolum bolum = new Bolum();
            Console.WriteLine("Eğitim almak istediğiniz bölümü giriniz: ");
            // Metot ile kapsülleme
            Console.WriteLine("Metot ile kapsülleme");
            var BolumAdi = Console.ReadLine();
            bolum.SetBolumAdi(BolumAdi);
            Console.WriteLine("Seçtiğiniz bölüm: "+ bolum.GetBolumAdi());

            // Property ile kapsülleme
            Console.WriteLine();
            Console.WriteLine("Property ile kapsülleme: ");
            Fakulte fakulte = new Fakulte();
            fakulte.Bolum = BolumAdi; // set bloğu çalışır
            Console.WriteLine("Seçtiğiniz bölüm: " + fakulte.Bolum); // get bloğu çalışır

        }

    }
    // Property ile kapsülleme
    public class  Fakulte
    {
        private string bolum;
        public string Bolum { 
            get { return bolum; } 
            set 
            {
                if (value == "Grafik Tasarım")
                {
                    Console.WriteLine("Kurumumuzda " + value + " Eğitimi Verilmemektedir");
                }
                else
                    bolum = value;
            } 
            }

    }
}

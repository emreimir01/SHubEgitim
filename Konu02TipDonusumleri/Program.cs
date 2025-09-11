namespace Konu02TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu01 Tip Dönüşümleri");
            // Implicit Casting - Otomatik Dönüşüm
            // Explicit Casting - Manuel Dönüşüm
            Console.WriteLine("Implicit Casting - Otomatik Dönüşüm"); // Implicit Castingde daha küçük veri tipleri daha büyük veri tiplerine otomatik olarak dönüştürülür.
            
            int sayi = 9;
            double kesirliSayi = sayi; // int veri tipi double veri tipine otomatik olarak dönüştürülür.
            Console.WriteLine("sayi: "+ sayi);
            Console.WriteLine("kesirli sayi: "+ kesirliSayi);

            Console.WriteLine("\n Explicit Casting - Manuel Dönüşüm ");
            double kesirliSayi2 = 9.78;
            int tamsayi = (int)kesirliSayi2; // double veri tipi int veri tipine manuel olarak dönüştürülür.
            Console.WriteLine("\nKesirli Sayı:" + kesirliSayi2);
            Console.WriteLine("Tam Sayı:" + tamsayi);

            // Diğer Dönüşüm Yöntemleri
            int tamsayi2 = 10;
            double kesirliSayi3 = 5.25;
            bool islemSonuc = true;
            Console.WriteLine("Lütfen bir sayi giriniz");
            var girilenDeger = Console.ReadLine();
            Console.WriteLine("Girilen Değerin Veri Tipi: "+ girilenDeger.GetType());

            var parsayi = int.Parse(girilenDeger); // string ifadeyi int veri tipine dönüştürür.

            Console.WriteLine( parsayi + tamsayi2);
            Console.WriteLine(double.Parse(girilenDeger) + kesirliSayi3);
            Console.WriteLine(decimal.Parse(girilenDeger) + tamsayi2);

            // Convert Sınıfı ile Dönüşüm
            Console.WriteLine(tamsayi2.GetType());
            Console.WriteLine(Convert.ToString(tamsayi2).GetType());
            Console.WriteLine(Convert.ToDouble(tamsayi2).GetType());
            Console.WriteLine(Convert.ToInt32(tamsayi2).GetType());

            object nesne = "123456";
            Console.WriteLine("nesnenin verip tipi:"+ nesne.GetType());
            nesne = Convert.ToDecimal(nesne); // nesne değişkeninin veri tipi decimal olur.
            Console.WriteLine("nesnenin verip tipi:" + nesne.GetType());
            Console.WriteLine("nesnenin değeri: "+ nesne);



        }

    }
}

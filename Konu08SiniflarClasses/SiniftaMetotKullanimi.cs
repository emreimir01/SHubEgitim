namespace Konu08SiniflarClasses
{
    internal class SiniftaMetotKullanimi
    {
        string kurucuMetot;
        public SiniftaMetotKullanimi() // Constructor - Kurucu metot kısayolu ctor yazmak.
        {
            Console.WriteLine();
            kurucuMetot = "Sınıflarda constructor (kurucu metot) özelliği vardır ve bu metotlar sınıftan bir nesne oluşturulduğunda " +
                "otomatik olarak çalışır ve içerisindeki kodları çalıştrır. Kurucu metotlar değişkenler gibi veri tipi almazlar ve void ifadesi de bulunmaz," +
                " sınıfın adıyla aynı ad kullanılarak oluşturulur.";
            Console.WriteLine(kurucuMetot);
            Console.WriteLine();
        }
        public bool LoginKontrol(string kullanici, string sifre)
        {
            if (kullanici == "emre" && sifre == "1234")
            {
                return true;
            }
            return false;
         }   
         public int ToplamaYap(int sayi1, int sayi2)
         {
            return sayi1 + sayi2;
         }
        public static string StatikDegisken = "Sınıflarda metot ve değişken de kullanabiliriz";
        public string DinamikDegisken = "Bu değişken static değil";

    }
}

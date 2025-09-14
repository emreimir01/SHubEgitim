namespace Konu09StructYapilar
{
    public struct Yapi
    {
        // public string Ad = "Ahmet"; // Struct kullanımında classdan farklı olarak öğelere başlangıç değeri atanmaz.
        public int sayi;
        public string metin;
        public void Metot()
        {
            Console.WriteLine("Yapı içindeki metot çalıştı");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu09 Struct/Yapılar");
            Yapi ilkyapi = new Yapi(); 
            ilkyapi.metin = "Yapi metni";
            ilkyapi.sayi = 100;
            ilkyapi.Metot();
            Console.WriteLine(ilkyapi.metin);
        }
    }
}

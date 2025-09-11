namespace Konu03Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu03 Operatörler");
            // 1- Aritmetik Operatörler
            int sayi1 = 3;
            int sayi2 = 4;
            int sayi3 = 5;
            Console.WriteLine();
            Console.WriteLine($"Sayilar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}"); // String tırnağının önüne $ işareti koyarak string interpolation yapabiliriz.
            Console.WriteLine("1234"+ sayi3); // string ile int toplanırsa birleştirme (concatenation) olur.
            Console.WriteLine();
            // Hesaplama İşlemleri
            Console.WriteLine("sayi + sayi2: "+(sayi1 + sayi2));
            Console.WriteLine("sayi - sayi2: "+(sayi1 - sayi2));
            Console.WriteLine("sayi * sayi2: "+(sayi1 * sayi2));
            Console.WriteLine("sayi / sayi2: "+(sayi1 / sayi2));
            Console.WriteLine("sayi % sayi2: "+(sayi1 % sayi2));

            Console.WriteLine();
            // 2- Artırım ve Azaltım Operatörleri
            sayi2++; // değişken değerini artırır.
            Console.WriteLine("sayi2 : " + sayi2);
            sayi2--; // değişken değerini azaltır.
            Console.WriteLine("sayi2 : " + sayi2);

            Console.WriteLine();

            // 3- Atama Operatörleri
            Console.WriteLine("sayi1 += sayi2: "+ (sayi1 += sayi2));
            Console.WriteLine("sayi1 -= sayi2: "+ (sayi1 -= sayi2));
            Console.WriteLine("sayi1 *= sayi2: "+ (sayi1 *= sayi2));
            Console.WriteLine("sayi1 /= sayi2: "+ (sayi1 /= sayi2));
            Console.WriteLine("sayi1 %= sayi2: "+ (sayi1 %= sayi2));

            Console.WriteLine();

            // 4- İlişkisel Operatörler: Birden fazla değeri karşılaştırmak için kullanılır. Sonuç bool türündedir.
            Console.WriteLine($"Sayilar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}");
            Console.WriteLine("sayi1 == sayi2: " + (sayi1 == sayi2));
            Console.WriteLine("sayi1 != sayi2: " + (sayi1 != sayi2));
            Console.WriteLine("sayi1 > sayi2: " + (sayi1 > sayi2));
            Console.WriteLine("sayi1 < sayi2: " + (sayi1 < sayi2));
            Console.WriteLine("sayi1 >= sayi2: " + (sayi1 >= sayi2));
            Console.WriteLine("sayi1 <= sayi2: " + (sayi1 <= sayi2));
            Console.WriteLine();

            // 5- Ternary Operatör: 3 operand alır. Koşul ? Doğru ise : Yanlış ise
            Console.WriteLine("Ternary: " + ((sayi1 == sayi2) 
                ? $"sayı 1({sayi1})sayi 2({sayi2})ye eşit" 
                : $"sayı 1({sayi1}) sayı 2({sayi2})ye eşit değil"));

            // 6- Mantıksal Operatörler: Birden fazla koşulu birleştirmek için kullanılır. Sonuç bool türündedir.
            Console.WriteLine("Mantıksal Operatörler:");
            Console.WriteLine("And & Operatörü:");
            Console.WriteLine("(sayi1 == sayi2) && (sayi1 < sayi2):"+ ((sayi1 == sayi2 ) && (sayi1 < sayi2)));

            Console.WriteLine();





        }
    }
}

namespace _03_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    Console.WriteLine("Hello, World!");
        //    Random rnd = new();// Bilgisayar tarafında rastgele sayı üretmeye yarar.
        //                       //şans oyunları oyun similatörleri ve çark sistemi bu ve benzeri yapılarda kullanılır.
        //basla:
        //    int sayi = rnd.Next(1, 10);

        //    Console.WriteLine(sayi);
        //    goto basla;
        Basla:
            Console.WriteLine("Lütfen 1 ila 10 arasında şanlı sayınızı giniz");
            
            int sanliSayi = int.Parse(Console.ReadLine());
            Random ran = new Random();// bir sınıfan nesne türetme new keywordü ile yapılır.
            int randomSayi = ran.Next(1, 10);
            if (sanliSayi == randomSayi)
            {
                Console.WriteLine("Tebrikler şanslısınız");
            }
            else
            {
                Console.WriteLine("Tekrar deneyin Üretilen ransom sayı: {0}", randomSayi);
            }
            goto Basla;
        }
    }
}

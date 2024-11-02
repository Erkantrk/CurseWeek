namespace _04_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine(Carp());
           //Console.WriteLine(Carpma(55,45));
            // Carpim();
            
            Console.WriteLine(Method("nasılsın"));
        }
        static int Carp()
        {
            Console.WriteLine("Sayı 1");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı 2");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            
            return Carpma(sayi, sayi2);
        }
        static void Carpim()
        {
            Console.WriteLine("Sayı 1");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı 2");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Çarpım" + sayi * sayi2);
            
        }
        static int Carpma(int s1, int s2)
        {
            int toplam = s1 * s2;
            return toplam;
        }
        static string Method(string metin)
        {
            Console.WriteLine(metin);
            string metin2 = "iyim";
            return metin2;
        }
    }
}

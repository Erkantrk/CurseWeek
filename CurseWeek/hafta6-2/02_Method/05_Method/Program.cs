namespace _05_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OVERLOAD METHOD - AŞIRI YÜKLENMİŞ

            // Bir metodun aynı isimle birden fazla kez tanımlanmış olmasıdır.
            // Methodlar aynı isimle tanımlandıklarında METOT IMZALARININ FARKLI OLMASI GEREKLİDİR.
            // Metot İmzası: * Parametre sayısı * Parametre veritipi
            //Console.WriteLine();
            //Console.WriteLine("Erkan");
            //Console.WriteLine(26);
            //Console.WriteLine(true);

            Topla();
            Topla(20, 40);
            Topla(20.5, 40.5);
            Topla("test", 20, 40);
            Topla("Metin", true, 10.55, DateTime.Now);

            //kullanıcıdan 4 adet sayı alınacak ve bu sayıların tek mi çift mi olduğunu ekrana yazdıran methodu yazınız aynı isimde olsun ve overload bir method olsun 2 ayrı method olacak tek olanlar için ayrı çift olanlar için ayrı method olacak




        }
        /// <summary>
        /// parametresiz toplama işlemi
        /// </summary>
        static void Topla()
        {
            int sayi = 10;
            int sayi2 = 20;
            Console.WriteLine(sayi + sayi2);
        }
        /// <summary>
        /// iki int parametreli toplama methodu
        /// </summary>
        /// <param name="sayi"></param>
        /// <param name="sayi2"></param>
        static void Topla(int sayi, int sayi2)
        {
            Console.WriteLine(sayi + sayi2);
        }
        /// <summary>
        /// <see cref="https://www.w3schools.com/"/>
        /// </summary>
        /// <param name="sayi"></param>
        /// <param name="sayi2"></param>
        static void Topla(double sayi, double sayi2)
        {
            Console.WriteLine(sayi + sayi2);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="metin"></param>
        /// <param name="sayi"></param>
        /// <param name="sayi2"></param>
        static void Topla(string metin, int sayi, double sayi2)
        {
            Console.WriteLine(metin + sayi + sayi2);
        }
        static void Topla(string metin, object obj, object obj2, object obj3)
        {
            Console.WriteLine($"{metin}\n{obj}\n{obj2}\n{obj3}");
        }
    }
}

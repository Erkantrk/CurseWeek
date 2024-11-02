namespace _06_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //kullanıcıdan 4 adet sayı alınacak ve bu sayıların tek mi çift mi olduğunu ekrana yazdıran methodu yazınız aynı isimde olsun ve overload bir method olsun 2 ayrı method olacak tek olanlar için ayrı çift olanlar için ayrı method olacak
            Console.WriteLine("Lütfen 4 adet sayı giriniz");
            int[] sayilar = new int[4];
            int j = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"sayi{i + 1}");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            SayilariYazdir(sayilar);
            SayilariYazdir(sayilar, 0);

            

        }
        static void SayilariYazdir(int[] sayilar)
        {
            Console.WriteLine("Tek sayılar:");
            foreach (var sayi in sayilar)
            {
                if (sayi % 2 != 0)
                {
                    Console.WriteLine(sayi);
                }
                else
                {
                    SayilariYazdir(sayilar,0);
                }

            }
        }
        static void SayilariYazdir(int[] sayilar,int sayi0=0)
        {
            Console.WriteLine("Cift sayılar:");
            foreach (var sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine(sayi);
                }
               
            }
        }
    }
}

namespace _02_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 0 girilene kadar pozitif sayılar girmesi istensin. 0 girilene kadar girilen pozitif sayılar toplansın ve ortalaması hesaplansın.
            // Kullanıcı 0 girdiğinde döngü bitsin ve toplam,ortalama ekrana yazdırılsın.
            // ** Kullanıcı ilk sayıyı 0 girerse tekrar sayı istensin
            // ** kullanıcı negatif sayı girerse "lütfen Pozitif Sayı Giriniz!!" uyarısını verilsin.

            int sayac = 0;
            int toplam = 0;
            while (true)
            {
                Console.WriteLine("Bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi == 0 && sayac == 0)
                {
                    continue;
                }
                if (sayi == 0)
                {
                    break;
                }
                if (sayi < 0)
                {
                    Console.WriteLine("Lütfen Pozitif sayı giriniz!!!");
                    continue;
                }
                toplam += sayi;
                sayac++;


            }
            Console.WriteLine("Toplam:" + toplam);
            Console.WriteLine("Ortalama:" + (toplam / sayac));
        }
    }
}

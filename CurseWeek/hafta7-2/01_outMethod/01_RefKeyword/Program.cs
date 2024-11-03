namespace _01_RefKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ref Anahtar Kelimesi: Gerçek hayatta, bir arkadaşınıza bir defter verip üzerine yazmasını istediğinizi düşünün. 
            // Eğer defteri geri alırsanız, yazılanları görebilirsiniz. 
            // Bu, ref ile aynı şeydir. Değişkeni referans olarak gönderiyoruz, bu yüzden geri aldığımızda güncellenmiş haliyle geri geliyor.

            int sayi = 10;
            sayi = 20;
            Console.WriteLine(sayi);
            Test(ref sayi);
            Console.WriteLine(sayi);
            int s = 0;
            Guncelle(ref s);

            double fiyat = 100;
            double fiyat2 = 120;
            double fiyat3 = 200;
            UrunYazdir(ref fiyat, ref fiyat2, ref fiyat3);
            Console.WriteLine("kdv durumları: {0}, {1}, {2} ", fiyat, fiyat2, fiyat3);
        }
        static void UrunYazdir(ref double fiyat1, ref double fiyat2 ,ref double fiyat3)
        {
            fiyat1 = fiyat1 +(fiyat1* 0.10);
            fiyat2 = fiyat2 +(fiyat1 * 0.20);
            fiyat3 = fiyat3+(fiyat3 * 0.01);
        }
        static void Guncelle(ref int sayi )
        {
            sayi = 20;
        }
        static void Test(ref int sayi)
        {
            sayi = 100;
        }
    }
}

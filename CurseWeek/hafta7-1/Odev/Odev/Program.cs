namespace Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayan metot 
            //ve 3.ürün almak isterse 3.ürüne %50 indirim uygulayarak metot ile kodlayınız
            Indirim();

        }
        static void Indirim()
        {
            Console.WriteLine("1.Ürün Fiyatı:");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2. Ürün Fiyatı:");
            double fiyat2 = Convert.ToDouble(Console.ReadLine());

            if (fiyat > fiyat2)
            {
                fiyat = fiyat-(fiyat *0.3);
            }
            else
            {
                fiyat2 = fiyat2 - (fiyat2 * 0.3);
            }
            Console.WriteLine("3. Ürünü almak istermisiniz 3. ürüne özel %50 indirim var :) (E/H)");
            string cevap = Console.ReadLine().ToUpper();
            if (cevap == "E")
            {
                Indirim(fiyat,fiyat2 );
            }
            else
            {
                Console.WriteLine("Ödeme: " + (fiyat + fiyat2));
            }
        }
        static void Indirim(double f1, double f2)
        {
            Console.WriteLine("3.Ürün Fiyatı:");
            double fiyat3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ödeme: {f1 + f2 + (fiyat3 / 2)}");
        }
    }
}

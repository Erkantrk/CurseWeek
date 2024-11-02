namespace _01_Parameters_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = ++a;
            int c = a++;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(a);
            //Optional Parameters (İsteğe Bağlı Parametreler): Bir mağazaya gittiğinizi düşünün. 
            //Bir bilgisayar alıyorsunuz, bilgisayarın adı ve fiyatını biliyorsunuz, ama kategori kısmını belirtmeden de alabilirsiniz, 
            //çünkü varsayılan olarak "Bilgisayar" kategorisine giriyor. Bu isteğe bağlı bir bilgidir. Eğer siz kategori belirtmezseniz, sistem otomatik olarak varsayılan değeri alır.

            // Optional parametreyi kullanarak, kategori kısmını göndermeden de metodu çağırabiliriz. Bu durumda kategori "Bilgisayar" olur.

            //string sonuc = Yazdir("Erkan");
            //Console.WriteLine(sonuc);

            //UrunYadir("Klavye", 2000);
            //UrunYadir("İphone", 20000, "Telefon");

            Insan(adSoyad: "Erkan Türk", yas: 29, tc: "8464658486846468", cisiyet: "Erkek");
        }
        static string Yazdir(string ad, string soyad = "Türk")
        {
            return ad + " " + soyad;
        }
        static void UrunYadir(string adi, double fiyat, string kategory = "Elektronik")
        {
            Console.WriteLine($"Ürün adi: {adi}, Ürün Fiyati: {fiyat}, Kategorisi: {kategory}");
        }
        static void Insan(string adSoyad, int yas, string tc, string meslek = "serbes meslek", string cisiyet = "Belitmek istemiyom ya", string ulke = "Türkiye")
        {
            Console.WriteLine($"AdSoyad:{adSoyad}, Yaş: {yas}, Tc: {tc}, Mesleği: {meslek}, Cinsiyet {cisiyet}, Ülke: {ulke}");

        }
        
    }
}

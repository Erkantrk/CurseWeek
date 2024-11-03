using System.Security.Cryptography;

namespace _01_outMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Out keyword
            //out keywordü ile dışarıda null olarak tanımlanan bir değer var ise onun içini doldurabiliyoruz out keywordu ile
            //out ile geriyedeğer döndüren method arasındaki fark return ile bir değer döner iken out ile birden fazla değeri dışarıya değer olarak göndeririz.
            #region out örnek1
            //int sayi;
            //int sayi2 = 5;

            //test(out sayi2);
            //Console.WriteLine(sayi2);
            #endregion
            #region out örnek2
            //double  fiyat2, fiyat3;
            //UrunFiyatGetir(out fiyat2, out fiyat3);
            //Console.WriteLine($"çarpımı: {fiyat2} Toplamı: {fiyat3}");
            #endregion
            #region out örnek3
            //int d1, d2;
            //int deger = 0;
            //int deger2 = 0;
            //DegerCikar(out d1, out d2);
            //deger2 = GeriyeDegerDonder(deger);
            //Console.WriteLine(deger2);
            //Console.WriteLine("değerler"+d1+d2);

            #endregion

            #region out TryParse örnek4



            //Console.WriteLine("Lütfen sayı giriniz");
            //string s = Console.ReadLine();
            //Console.WriteLine("Lütfen 2. sayı giriniz");
            //string s2 = Console.ReadLine();


            //if (int.TryParse(s, out int b))
            //{
            //    int c = 20;

            //    int sonuc = b + c;
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı dönüşüm");
            //}
            //if (int.TryParse(s2, out int j))
            //{
            //    int sonuc = j + j;
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı dönüşüm");
            //}
            #endregion

            #region
            //string urun = "ELMA";
            //int elma = 1;
            //Console.WriteLine("Elma için bire basınız yada elma yazınız");
            //string input = Console.ReadLine().ToUpper();

            //if (int.TryParse(input, out int b))// TryParse true yada false değeri döner
            //{
            //    if (b==elma)
            //    {
            //        Console.WriteLine("Elma alındı Fiyatı 100 amasya elması");
            //    }

            //}
            //else if (urun == input)
            //{
            //    Console.WriteLine("Elma alındı Fiyatı 100");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı işlem");
            //}
            #endregion

            // üç parametreli hesapla diye bir method olacak ilk parametresi norma 2. ve 3. parametresi out int olacak ve 
            // kare hesapla
            //küp hesaplayacak bu method
            int s;
            int s2;
            Hesapla(20, out s, out s2);
            Console.WriteLine(s + " " + s2);
        }
        static void Hesapla(int s, out int kare, out int kup)
        {
            kare = s * s;
            kup = s * s * s;
        }
        static void UrunFiyatGetir( out double f1, out double f2)
        {
            int f;
            Console.WriteLine("birinci ürün fiyatı giriniz:");
            f = Convert.ToInt32(Console.ReadLine());
            f1 = f ;
            f2 = f * 0.20;
        }
        static void test(out int a)
        {
            a = 10;
        }
        static int GeriyeDegerDonder( int b)
        {
            int a;
            a = 10;
            b = 20;
            return a + b;
        }
        static void DegerCikar(out int a, out int b)
        {
            a = 10;
            b = 20;
        }
    }
}

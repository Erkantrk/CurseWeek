namespace _01_Switch_Case_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region sayı switch case
            //Switch Case yapısı Bir koşul yapısıdır uygun olan koşula göre Case tarafındaki yapı çalışır eğer uygun yapı yok ise içerisinde bize otomatik olarak default tanımlanan işlem görünür.

            //Console.WriteLine("Bir den 3 e kadar bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //switch (sayi)
            //{
            //    case 1:
            //        Console.WriteLine("Bir");
            //        break;
            //    case 2: Console.WriteLine("iki"); break;
            //    case 3: Console.WriteLine("Üç"); break;
            //    default:
            //        Console.WriteLine("Yanlış bir sayı girildi");
            //        break;
            //}
            #endregion

            #region şehir girme 
            //Console.WriteLine("Bir şehir giriniz");
            //string deger = Console.ReadLine().ToLower();
            //switch (deger)
            //{
            //    case "istanbul":
            //        Console.WriteLine($"{deger}'un Plakası 34");
            //        break;
            //    case "izmir":
            //        Console.WriteLine($"{deger}'in Plakası 35");
            //        break;
            //    case "ankara":
            //        Console.WriteLine($"{deger}'nın Plakası 06");
            //        break;
            //    case "adana":
            //        Console.WriteLine($"{deger}'nın Plakası 01");
            //        break;
            //    default:
            //        Console.WriteLine("Girdiğiniz şehir bulunamadı");
            //        break;
            //}
            #endregion

            #region GOTO

            //Console.WriteLine("Yapmak istediniz işlemi giriniz \nSatisyap \nürün ekle ");
            //string deger = Console.ReadLine().ToLower();

            //switch (deger)
            //{
            //    case "stok eksilt":
            //        Console.WriteLine("Stok düşüldü");
            //        break;
            //    case "ürün ekle":
            //        Console.WriteLine("Ürün eklendi");
            //        break;
            //    case "satis yap":
            //        Console.WriteLine("Satış işlemi başarılı");
            //        goto case "stok eksilt";// goto ile istediğimiz bir case yapısına dönüş sağlayabiliriz.
            //    default:
            //        Console.WriteLine("Hatalı seçim");
            //        break;
            //}

            #endregion

            #region haftanın hangi günü
            // kullanıcıdan 1-7 arasında bir sayı girmesini isteyeceğiz kullanıcıya haftanın hangi günü diye soracağız kullının verdiği cevaba göre switch case yapında bize pazartesi salı diye cevap dönecek. hatalı girişde 1-7 arasında bir değer giriniz diye uyarı verecek 
            //Console.WriteLine("Haftanın hangi günü");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //switch (sayi)
            //{
            //    case 1:Console.WriteLine("Pazartesi"); break;
            //    case 2: Console.WriteLine("Salı"); break;
            //    case 3: Console.WriteLine("Çarşamba"); break;
            //    case 4: Console.WriteLine("Perşembe"); break;
            //    case 5: Console.WriteLine("Cuma"); break;
            //    case 6: Console.WriteLine("Cumartesi"); break;
            //    case 7: Console.WriteLine("Pazar"); break;


            //    default:Console.WriteLine("Yanlış değer girdiniz 1 ila 7 arasında bir değer giniz");
            //        break;
            //}
            #endregion

            #region Klavyeden iki sayı , bir ilem (+,-,*,/)girilecek.Sayılar girilen işleme göre sonucu ekrana yazdıran Switch case
            //int s1, s2;
            //Console.WriteLine("1.Sayı");
            //s1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayı");
            //s2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Yapmak istediğiniz işlem \n+ \n*\n/\n-");
            //string islem = Console.ReadLine();
            //switch (islem)
            //{
            //    case "+": Console.WriteLine("Sonuc:" + (s1 + s2)); break;
            //    case "*": Console.WriteLine("Sonuc:" + (s1 * s2)); break;

            //    case "-": Console.WriteLine("Sonuc:" + (s1 - s2)); break;
            //    case "/":
            //        if (s2 != 0)
            //        {

            //            Console.WriteLine("Sonuc:" + (s1 / s2));
            //        }
            //        else
            //        {

            //            Console.WriteLine("Hata: Bir sayı sıfıra bölünemezç");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Geçersiz bir işlem");
            //        break;
            //}
            #endregion
            //Kullanıcıdan cinsiyetini isteyelim. Girilen cinsiyete göre 
            //emeklilik yaşını söyleyen kodu yazınız. Yanlış cinsiyet verildiğinde hatalı işlem fırlatın. Erkekte 60, Kadında 50

            //Console.WriteLine("Cinsiyetinizi girin (E/K)");
            //char cinsiyet = Convert.ToChar(Console.ReadLine().ToUpper());
            //switch (cinsiyet)
            //{
            //    case 'E': Console.WriteLine("Emeklilik yaşınız 60 "); break;//Char ifadeler '' stringler "" yazılmalıdır.
            //    case 'K': Console.WriteLine("Emeklilik yaşınız 50 "); break;
            //    default:
            //        Console.WriteLine("E veya K olarak belirte bilirsiniz ");
            //        break;
            //}
            #region 
            // kullanıcıdan alınsan sayi değeri % 5  5 in katımı swicth case yapısında kontrol edilecek ve içinde bir yapı daha olacak orada da 10 katımı olarak kontrol edilecek. (% mod alma )

            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = int.Parse(Console.ReadLine());

            //switch (sayi % 5 )
            //{
            //    case 0: Console.WriteLine("Gelen sayı 5 in katıdır.");
            //        switch (sayi % 10)
            //        {
            //            case 0: Console.WriteLine("Gelen değer 10 un katıdır.");
            //                break;
            //            default: Console.WriteLine("10 katı değildir");
            //                break;
            //        }
            //        break;
            //    case 1: Console.WriteLine("Gelen sayı  5 yada katı değildir.");
            //        break;
            //    default:Console.WriteLine("Gelen sayı  5 yada katı değildir."); break;
            //}

            //switch (sayi % 5)
            //{
            //    case 0:
            //        Console.WriteLine("Gelen sayı 5 in katıdır.");
            //        if (sayi % 10 == 0)
            //        {
            //            Console.WriteLine("Sayı 10 katıdır");

            //        }
            //        else
            //        {

            //            Console.WriteLine("10 un katı değildir");
            //        }
            //        break;
            //    case 1:
            //        Console.WriteLine("Gelen sayı  5 yada katı değildir.");
            //        break;
            //    default: Console.WriteLine("Gelen sayı  5 yada katı değildir."); break;
            //}
            #endregion

        }
    }
}

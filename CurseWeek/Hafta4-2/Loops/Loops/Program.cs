namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Ödev while

            // Kullanıcıdan 0 girilene kadar pozitif sayılar girmesi istensin. 0 girilene kadar girilen pozitif sayılar toplansın ve ortalaması hesaplansın.
            // Kullanıcı 0 girdiğinde döngü bitsin ve toplam,ortalama ekrana yazdırılsın.
            // ** Kullanıcı ilk sayıyı 0 girerse tekrar sayı istensin
            // ** kullanıcı negatif sayı girerse "lütfen Pozitif Sayı Giriniz!!" uyarısını verilsin.


            #endregion
            #region do while örnek
            //string kad = "admin";
            //bool locked = true;

            //do
            //{
            //    Console.WriteLine("Lütfen kullanıcı adınızı giriniz");
            //    string kullaniciGiris = Console.ReadLine();
            //    if (kullaniciGiris != kad)
            //    {
            //        Console.WriteLine("Kullanıcı adını yanlış girdiniz");
            //        locked = false;
            //        Thread.Sleep(5000);// bekletmek için Thread.Sleep() kullanıp milisaniye cinsinden süreyi veriyoruz.
            //        Console.WriteLine("Hesabınız açılmıştır doğru şekilde bilgileri giniz.");
            //        locked = true;
            //    }
            //    else if (kullaniciGiris == kad)
            //    {
            //        locked = false;
            //    }
            //} while (locked);
            //Console.WriteLine("Giriş başarılı");
            #endregion
            #region örnek 1 while
            // Loops (döngüler) while
            // while koşulu sadece true oldugu sürece çalışır true değilse hiçbir zaman çalışmaz.
            //int sayac = 1;
            //while (sayac<11)// sonsuz şekilde artartar 
            //{
            //    Console.WriteLine(sayac);
            //    Thread.Sleep(1000);// bir saniyelik bekleme süresi verdik
            //    sayac++;
            //}
            #endregion

            #region örnek 2 while
            //int sayac = 1;
            //while (sayac<11)
            //{
            //    Console.WriteLine(sayac);
            //    Thread.Sleep(1000);
            //    if (sayac == 5)
            //    {
            //        break;
            //    }
            //    sayac++;
            //}
            #endregion

            #region örnek 3 while false notu
            //int sayac = 1;
            //while (false)// false oldugu sürece while e girmez o yüzden de içindeki kodları soluklaştırır.
            //{
            //    Console.WriteLine(sayac);
            //    Thread.Sleep(1000);
            //    if (sayac == 5)
            //    {
            //        break;
            //    }
            //    sayac++;
            //}
            #endregion
            #region örnek 4 while 
            //int s = 1;
            //while (s < 12)
            //{
            //    s++;
            //    if (s == 10)
            //    {
            //        continue;
            //    }
            //    if (s == 11)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(s);


            //}

            #endregion

            #region örnek 5 while 
            //string kad = "admin";
            //bool locked = true;



            // while (locked)
            //{
            //    Console.WriteLine("Lütfen kullanıcı adınızı giriniz");
            //    string kullaniciGiris = Console.ReadLine();
            //    if (kullaniciGiris != kad)
            //    {
            //        Console.WriteLine("Kullanıcı adını yanlış girdiniz");
            //        locked = false;
            //        Thread.Sleep(5000);// bekletmek için Thread.Sleep() kullanıp milisaniye cinsinden süreyi veriyoruz.
            //        Console.WriteLine("Hesabınız açılmıştır doğru şekilde bilgileri giniz.");
            //        locked = true;
            //    }
            //    else if (kullaniciGiris == kad)
            //    {
            //        locked = false;
            //    }
            //}
            //Console.WriteLine("Giriş başarılı");

            #endregion
            #region 200 den başlayarak 0 a kadar olan ve 3'ün katı olan sayıları ekrana yazdırınız.


            //int say1 = 200;
            //while (say1 > 0)
            //{
            //    if (say1 % 3 == 0)
            //    {
            //        Console.WriteLine(say1);

            //    }
            //    say1--;

            //}

            #endregion
            #region 1 ile 5 arasındaki sayıların toplamını ekrana yazdıran while döngüsü
            //int i = 1;
            //int toplam = 0;
            //while (i<6)
            //{
            //    toplam = toplam + i;
            //    i++;
            //}
            //Console.WriteLine(toplam);

            #endregion

            #region  200 den 0 ara kadar çift ve tek sayıların toplamlarını yazınız.

            //int sayac = 200;
            //int cift = 0;
            //int tek = 0;
            //while (sayac > 0)
            //{
            //    if (sayac % 2 == 0)
            //    {
            //        cift += sayac;
            //    }
            //    else
            //    {
            //        tek += sayac;
            //    }
            //    sayac--;
            //}
            //Console.WriteLine("Tek toplam" + tek);
            //Console.WriteLine("Çift Toplam" + cift);
            #endregion
            #region while örnek7 
            //Değer true olduğu sürece dönen döngü
            //bool durum = true;
            //while (durum == true)
            //{
            //    Console.WriteLine(durum);
            //    Console.WriteLine("Devam etmek istiyormusunuz Evet ise E hayır ise H ye basınız");
            //    string cevap = Console.ReadLine().ToLower();
            //    if (cevap == "h")
            //    {
            //        durum = false;
            //    }

            //}

            #endregion

        }
    }
}

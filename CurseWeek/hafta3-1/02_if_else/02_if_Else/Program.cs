using System.Diagnostics.Contracts;

namespace _02_if_Else
{
    internal class Program
    {

        static void Main(string[] args)
        {

            #region kullanıcıdan alınan değer
            // kullanıcıdan aylık geliri istenecek 
            // kullanıcının maaşı 5500 tl ve   az  ise %12 vergi uygulanacak ve vergi ulanmış maaaşı gösterilecek
            // kullanıcın maaşı 5500 tlden fazla % 20 lik vergi uygulanacak ve vergi uygulanmış maaş gösterilecek
            //Console.WriteLine("Lütfen Maaşınız giriniz");
            //double gelir = Convert.ToDouble(Console.ReadLine());
            //double yeniGelir;

            //if (gelir <= 5500)
            //{
            //    yeniGelir = gelir - gelir * 0.12;
            //    Console.WriteLine("Yeni geliriniz\n{0}", yeniGelir);
            //}
            //else
            //{
            //    yeniGelir = gelir - gelir * 0.20;
            //    Console.WriteLine("Yeni geliriniz:\n" + yeniGelir);
            //}

            #endregion
            #region Fark bul
            // kullanıcıdan 2 adet sayı isteyeceğiz ve iki sayından büyük olanı küçük olandan çıkarıp farkı bulacağız.
            //Console.WriteLine("Lütfen Birinci sayıyı giriniz.");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen İkinci sayıyı giriniz.");
            //int sayi2 = int.Parse(Console.ReadLine());
            //int sonuc;
            //if (sayi1 > sayi2)
            //{
            //    sonuc = sayi1 - sayi2;
            //    Console.WriteLine($"{sayi1}in {sayi2}'den farkı:{sonuc}");
            //}
            //else if (sayi2 > sayi1)
            //{
            //    sonuc = sayi2 - sayi1;
            //    Console.WriteLine($"{sayi2}in {sayi1}'den farkı:{sonuc}");
            //}
            //else
            //{
            //    Console.WriteLine("Sayılar birbirine eşittir.");
            //}

            #endregion
            #region Kullanıcının yaş girmesi
            ////Kullanıcıdan yaşını girmesini isteyelim.
            ////Girilen yaş, yaş grubuna göre ayıralım.
            ////0-12 yaş arasında : Çocuk
            ////13-19 yaş arasında: Genç 
            ////20-64 yaş arasında : Yetişkin
            ////65 ve 120 yaş arasında : Yaşlı 
            ////Girilen - değer alırsa yani negatifse "Geçersiz yaş girdiniz" uyarısı verelim.
            //Console.WriteLine("Lütfen Yaşınızı giriniz.");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //if (yas >= 0 && yas <= 12)
            //{
            //    Console.WriteLine("Çocuk");
            //}
            //else if (yas >= 13 && yas <= 19)
            //{
            //    Console.WriteLine("Genç");
            //}
            //else if (yas >= 20 && yas <= 64)
            //{
            //    Console.WriteLine("Yetişkin");
            //}
            //else if (yas >= 65 && yas <= 120)
            //{
            //    Console.WriteLine("Yaşlı");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz yaş girdiniz");
            //}
            #endregion
            #region Hava durumu 
            //Kullanıcıdan şu anki hava sıcaklığını isteyip;
            //Hava sıcaklığı; 5 derece altındaysa "Hava soğuk,Kalın giysiler giyin" uyarısı yapsın.
            // 5 ile 15 arasında ise ; "Hava serin ceket giymeyi unutma" uyarısı.
            //15 ile 25 arasında ise ; "Hava ılık. Rahat şeyler giyebilirsin" uyarısı versin.
            //25 üzeri ise; Hava sıcaK uyarısı versin. 

            //Console.WriteLine("Lütfen hava sıcaklığını giriniz");
            //double sicaklik = Convert.ToDouble(Console.ReadLine());
            //if (sicaklik < 5)
            //{
            //    Console.WriteLine("Hava soğuk sıkı giyin");
            //}
            //else if (sicaklik >= 5 && sicaklik <= 15)
            //{
            //    Console.WriteLine("Hava serin ceket giymeyi unutma");
            //}
            //else if (sicaklik >= 15 && sicaklik <= 25)
            //{
            //    Console.WriteLine("Hava ılık.Rahat şeyler giyinebilirsin");
            //}
            //else
            //{
            //    Console.WriteLine("Güneşe Mermi atabilirsin.");
            //}
            #endregion

            #region kullanıcıdam 3 adet sayı alma ve sıralama 
            // Kullanıcıdan 3 adet sayı alınız ve bu sayıları şekil A görüldüğü gibi büyükten küçüğe sıralı bir şekilde ekrana yazdırınız
            //Şekil a: 15>13>5
            //int sayi1, sayi2, sayi3;// aynı türden birden fazla değişken tanımlama yöntemi
            //Console.WriteLine("Birinci sayıyı giriniz");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı giriniz");
            //sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Üçüncü sayıyı giriniz");
            //sayi3 = Convert.ToInt32(Console.ReadLine());

            //if (sayi1>sayi2&&sayi1>sayi3)
            //{
            //    Console.WriteLine("En büyük sayı:" + sayi1);
            //    if (sayi2 > sayi3)
            //    {
            //        Console.WriteLine("Ortanca sayı:" + sayi2);
            //        Console.WriteLine("En küçük sayı:" + sayi3);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ortanca sayı:" + sayi3);
            //        Console.WriteLine("En küçük sayı:" + sayi2);
            //    }
            //}
            //else if (sayi2>sayi1&&sayi2>sayi3)
            //{
            //    Console.WriteLine("En büyük sayı:" + sayi2);
            //    if (sayi3 > sayi1)
            //    {
            //        Console.WriteLine("Ortanca sayı:" + sayi3);
            //        Console.WriteLine("En küçük sayı:" + sayi1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ortanca sayı:" + sayi1);
            //        Console.WriteLine("En küçük sayı:" + sayi3);
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("En büyük sayı:" + sayi3);
            //    if (sayi1 > sayi2)
            //    {
            //        Console.WriteLine("Ortanca sayı:" + sayi1);
            //        Console.WriteLine("En küçük sayı:" + sayi2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ortanca sayı:" + sayi2);
            //        Console.WriteLine("En küçük sayı:" + sayi1);
            //    }
            //}
            #endregion
            #region Kullanıcının giridiği çift sayı
            //Kullanıcıdan alınacak 3 adet sayının içinde 2'nin katları olan sayıların toplamını yapınız ve kullanıcıya gösteriniz.
            int s1, s2, s3, s4;
            Console.WriteLine("Birinci sayıyı giriniz");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçüncü sayıyı giriniz");
            s3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dördüncü sayıyı giriniz");
            s4 = int.Parse(Console.ReadLine());

            double ciftToplam = 0;
            double tekToplam = 0;
            if (s1 % 2 == 0)
            {
                ciftToplam += s1;// s1 in içindeki değeri çift toplamın içine atar ve her çift sayıda artırarak devam eder
                Console.WriteLine("Girilen değer Çiftir");
            }
            else
            {
                tekToplam += s1;
                Console.WriteLine("Girilen değer tektir");
            }
            if (s2 % 2 == 0)
            {
                ciftToplam += s2;
                Console.WriteLine("Girilen değer Çiftir");
            }
            else
            {
                tekToplam += s2;
                Console.WriteLine("Girilen değer tektir");
            }
            if (s3 % 2 == 0)
            {
                ciftToplam += s3;
                Console.WriteLine("Girilen değer Çiftir");
            }
            else
            {
                tekToplam += s3;
                Console.WriteLine("Girilen değer tektir");
            }
            if (s4 % 2 == 0)
            {
                ciftToplam += s4;
                Console.WriteLine("Girilen değer Çiftir");
            }
            else
            {
                tekToplam += s4;
                Console.WriteLine("Girilen değer tektir");
            }

            Console.WriteLine("Tek sayıların toplamı:" + tekToplam);
            Console.WriteLine("Çift sayıların toplamı:" + ciftToplam);
            #endregion
        }
    }
}

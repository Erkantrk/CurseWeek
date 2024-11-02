using System.Transactions;

namespace _02_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             01-SnakeCase=ad_soyad
             02-CamelCase=adSoyad
             03-KebabCase=ad-soyad
             04-UpperCase=ADSOYAD
             05-LowerCase=adsoyad
            *** Yazılım adlandırma kuralları (Case-Sensitive)***
            Yanlış yazım biçimleri= 2sayı,?sayı,ad soyad, ad!soyad sayı?
            İışçğüö... Türkçe karakterler kullanmıyoruz.
            Doğru yazım biçimi= sayi2, _Sayi,adSoyad,ad_soyad sayi_,


             */

            //isim = erkan türk
            //
            string adSoyad = "Erkan Türk";// sağdaki değeri soldaki değere aktarır.
            long tc = 12345678910;
            Console.WriteLine("Adınız soyadınız:" + adSoyad);
            Console.WriteLine("Tc kimlik numaranız:" + tc);

        }
    }
}
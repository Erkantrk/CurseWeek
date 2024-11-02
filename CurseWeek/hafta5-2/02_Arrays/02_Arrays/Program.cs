namespace _02_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region object
            //object her tipi içerisinde barındıran veri yapısıdır.
            //object[] nesneler = new object[10];
            //nesneler[0] = "Erkan";
            //nesneler[1] = 29;
            //nesneler[2] = 'E';
            //nesneler[3] = 7000.50;
            //nesneler[4] = true;
            //nesneler[5] = DateTime.Now;

            //foreach (var nesne in nesneler)
            //{
            //    Console.WriteLine(nesne);
            //}
            #endregion

            #region Arrays methods clear
            //string[] adlar = { "Erkan", "Tahsin", "Onur", "Altan", "Salih", "Kerem" };

            ////Array.Clear(adlar); tüm dizinin elemanlarını siler.
            //Array.Clear(adlar, 1, 3);//index ve uzunluk vererek silmek istediğimiz elemanları bu şekilde dizide silebiliriz.

            //foreach (string ad in adlar)
            //{
            //    Console.WriteLine(ad);
            //}

            #endregion
            #region Arrays methods copy
            //string[] adlar = { "Erkan", "Tahsin", "Onur", "Altan", "Salih", "Kerem" };
            //string[] adlar2 = new string[10];

            ////Array.Copy(adlar, adlar2, 3);// 0 ile 2. index arasında 3 elemanı aktarır.
            //Array.Copy(adlar, 1, adlar2, 2, 4);
            //Array.Clear(adlar, 1, 4);
            //adlar[1] = "Mahmut";
            //adlar[2] = "Kaan";
            //adlar[3] = "Hakan";
            //adlar[4] = "Berkay";
            //foreach (string ad in adlar)
            //{
            //    Console.WriteLine(ad);

            //}
            //Thread.Sleep(2000);
            //Console.Clear();//ekranı temizleme işlemi yapar.
            //foreach (string ad in adlar2)
            //{
            //    Console.WriteLine(ad);
            //}
            #endregion
            #region indexof()
            //string[] adlar = { "Erkan", "Tahsin", "Onur", "Altan", "Salih", "Kerem","Salih" };
            //int index = Array.IndexOf(adlar, "Salih");// ilk bulduğu elemanın indexini dönderir.
            //Console.WriteLine(index);//dizinin içindeki elemanları vererek index numarasını elde ederiz
            //Console.WriteLine(adlar[index]);//dönen index değerini vererek value(eleman) yu elde ederiz.
            #endregion

            #region Lastindexof()
            //string[] adlar = { "Erkan", "Tahsin", "Onur", "Altan", "Salih", "Kerem", "Salih" };
            //int index = Array.LastIndexOf(adlar, "Salih");// son bulduğu elemanın indexini dönderir.
            //Console.WriteLine(index);//dizinin içindeki elemanları vererek index numarasını elde ederiz
            //Console.WriteLine(adlar[index]);//dönen index değerini vererek value(eleman) yu elde ederiz.
            #endregion
            #region short()
            //string[] adlar = { "Zeynel", "Erkan", "Tahsin", "Onur", "Altan", "Salih", "Kerem", "Salih" };
            //Array.Sort(adlar);//Short A dan Z ye sıralar Rakamsal olarak da sıralama yapar.

            //foreach (var ad in adlar)
            //{
            //    Console.WriteLine(ad);
            //}
            #endregion

            #region reverse()
            //string[] adlar = { "Zeynel", "Erkan", "Tahsin", "Onur", "Altan", "Salih", "Kerem", "Salih" };
            //Array.Sort(adlar);// alfabetik sıralar
            //Array.Reverse(adlar);//ve tersine çevirir.

            //foreach (var ad in adlar)
            //{
            //    Console.WriteLine(ad);
            //}
            #endregion

            #region resize()
            //int[] sayilar = new int[5];
            //sayilar[0] = 1;
            //sayilar[1] = 2;
            //sayilar[2] = 3;
            //sayilar[3] = 4;
            //sayilar[4] = 5;

            ////for (int i = 0; i < sayilar.Length; i++)
            ////{
            ////    Array.Resize(sayilar[i], 6);
            ////}
            //Array.Resize(ref sayilar, 8);
            //sayilar[5] = 10;
            //sayilar[6] = 11;
            //sayilar[7] = 12;


            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}
            //string[] adlar = { "Zeynel", "Erkan", "Tahsin", "Onur", "Altan", "Salih", "Kerem", "Salih" };

            //Console.WriteLine(adlar[adlar.Length - 1]);

            //foreach (var ad in adlar)
            //{
            //    Console.WriteLine(ad);
            //}
            #endregion

            #region Ürün silme
            //string[] urunler = { "Çikolata", "Kola", "Fanta", "Kraker" };
            //int[] fiyat = { 20, 30, 30, 15 };
            //Console.WriteLine("Silmek için 3 e basın");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int balance = 0;
            //if (balance >= fiyat[sayi])// ürün fiyatı kontrol etme
            //{

            //}
            //if (sayi == 3)
            //{
            //    for (int i = 0; i < urunler.Length; i++)
            //    {
            //        Console.WriteLine($"{i}-{urunler[i]}:{fiyat[i]}");
            //    }
            //    int silinecekNo = Convert.ToInt32(Console.ReadLine());
            //    if (silinecekNo >= 0 && silinecekNo < urunler.Length)
            //    {
            //        for (int i = silinecekNo; i < urunler.Length - 1; i++)
            //        {
            //            urunler[i] = urunler[i + 1];//ürünleri kaydırma işlemi yapıyoruz
            //            fiyat[i] = fiyat[i + 1];
            //        }
            //        Array.Resize(ref urunler, urunler.Length - 1);//Ürünler dizini küçültüyoruz.
            //        Array.Resize(ref fiyat, fiyat.Length - 1);
            //        Console.WriteLine("Ürün silindi.");
            //    }
            //    foreach (var urun in urunler)
            //    {
            //        Console.WriteLine(urun);
            //    }
            //    foreach (var item in fiyat)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion

            #region örnek
            //Sayısal olarak eleman tutan 12 elemanlı bir dizinin 5 elemanı tek sayı, 7 elemanı da çift sayıdır. Dizinin tek ve çift elemanlarını ayrı ayrı toplayıp gösteriniz.
            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14 };
            //Console.WriteLine("Eleman sayısı: " + sayilar.Count());//eleman sayısını countla alabiliriz.
            //Console.WriteLine("------------------");
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            //Console.WriteLine("------------------");
            //int tekToplam = 0, ciftToplam = 0;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 0)
            //    {
            //        ciftToplam += sayilar[i];
            //    }
            //    else
            //    {
            //        tekToplam += sayilar[i];
            //    }
            //}
            //Console.WriteLine("Tek Toplam:" + tekToplam);
            //Console.WriteLine("Çift Toplam:" + ciftToplam);

            #endregion
            #region Örnek2
            //Adınızın harflerini alt alta sıralayın ve harflerin sayısal karşılıklarını listeleyiniz.
            Console.WriteLine("Adınızı giriniz");
            string isim = Console.ReadLine();
            int kucukTopla = 0, buyukToplam = 0;
            for (int i = 0; i < isim.Length; i++)
            {
                Console.WriteLine(isim[i]);
            }
            Console.WriteLine("Küçük harflerler için sayı");
            Console.WriteLine(isim.ToLower());
            for (int i = 0; i < isim.Length; i++)
            {
                Console.WriteLine(Convert.ToInt32(isim[i]));
                kucukTopla += isim[i];
            }
            Console.WriteLine("Büyük harflerler için sayı");
            isim = isim.ToUpper();
            for (int i = 0; i < isim.Length; i++)
            {
                Console.WriteLine(Convert.ToInt32(isim[i]));
                buyukToplam += isim[i];
            }
            Console.WriteLine("Küçük toplam: " + kucukTopla);
            Console.WriteLine("Büyük toplam: " + buyukToplam);
            #endregion
            #region ToDo
            //Kullanıcıdan alınacak ürün sayısına göre ürün isimleri istenerek bir diziye atılacak ve sonrasında her bir ürün adı yazılarak karşısında fiyatı istendikten sonra bütün ürünlerin isimleri karşısında fiyatlarını listeleyiniz.
            #endregion

        }
    }
}

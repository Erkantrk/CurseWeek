namespace _01_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /************Arrays-Diziler*******************
            string ad="erkan","Türk" // tutulmaz
            veriTipi[] diziAdi={"Erkan","Türk","Mustafa","Kılıç"} 
            index numaraları 0 dan başlar ve 1 er 1 er artar.
            Arrayler kendilerine ait metotlara sahiplerdir.
            Array[] ile tanımlanır
            tek veri tipinde verilen uzunluk kadar eleman tutar.
            
            */
            #region Arrays
            //string[] adlar = { "Erkan", "Mahmut", "Can" };//dolu dizi tanumlama yöntemi
            //string[] bosDizi = new string[5];// boş dizi tanımlama yöntemimiz

            //bosDizi[0] = "Erkan";
            //bosDizi[1] = "Mustafa";
            //bosDizi[2] = "Tahsin";
            //bosDizi[3] = "Altan";
            //bosDizi[4] = "Onur";

            //Console.WriteLine(bosDizi[2]);

            //int[] dizi = new int[5];
            //dizi[0] = 11;
            //dizi[1] = 12;
            //dizi[2] = 13;
            //dizi[3] = 14;
            //dizi[4] = 15;
            ////dizi[5] = 16;//Hata:Sistem.IndexOutOfRangeException:

            //Console.WriteLine(dizi[5]);
            #endregion
            #region Array Ornek
            //string[] Adlar = new string[5];// boş dizi tanımlama yöntemimiz

            //Adlar[0] = "Erkan";
            //Adlar[1] = "Mustafa";
            //Adlar[2] = "Tahsin";
            //Adlar[3] = "Altan";
            //Adlar[4] = "Onur";
            //for (int i = 0; i < Adlar.Length; i++)
            //{
            //    Console.WriteLine(Adlar[i]);
            //}
            //Console.WriteLine("*********");
            //int k = 0;
            //while (k < Adlar.Length)
            //{
            //    Console.WriteLine(Adlar[k]);
            //    k++;
            //}
            //Console.WriteLine("*********");
            //foreach (string ad in Adlar)// array yapısında en sık kullanılan döngü çeşidi
            //{
            //    Console.WriteLine(ad);
            //}
            //Console.WriteLine("*********");
            #endregion
            #region Kullanıcıya kaç personeli olduğunu sorunuz. Verilen cevapdan sonra her personelin adını sorup bir diziye ekleyiniz. Dizi tamamlandığında personel isimlerini ekrana yazdırınız.

            //Console.WriteLine("Personel sayınızı giriniz");
            //int personelSayisi = Convert.ToInt32(Console.ReadLine());

            //string[] personeller = new string[personelSayisi];

            //for (int i = 0; i < personeller.Length; i++)
            //{
            //    Console.WriteLine("Personel adı");
            //    string ad = Console.ReadLine();

            //    personeller[i] = ad;
            //}
            //Console.WriteLine("*********");
            //int j = 0;
            //foreach (string personel in personeller)
            //{
            //    j++;

            //    Console.WriteLine("{0}.Personel Adı:{1}", j, personel);
            //}

            #endregion
            #region ornek 1
            //// İçerisinde ürün fiyatları bulunan bir int dizisi oluşturup değerlerini oluşturma anında atayalım.
            //// Sonrasında her bir ürünün fiyatının yüzde 10 zam yapılmış halini ekrana yazdıralım.
            //Console.WriteLine("Kaç adet ürün aldınız.");
            //int urunSayisi = Convert.ToInt32(Console.ReadLine());

            //int[] urunler = new int[urunSayisi];

            //for (int i = 0; i < urunler.Length; i++)
            //{
            //    Console.WriteLine("Ürün fiyatı giriniz");
            //    int urunFiyat = Convert.ToInt32(Console.ReadLine());
            //    urunler[i] = urunFiyat;
            //}

            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine("Ürünlerin kdv uygulanmış hali {0}", urun + urun * 0.10);
            //}
            #endregion

            #region ornek 2
            // 5 karakter uzunluğunda bir string dizisi oluşturup değerlerini oluşturma anında atayalım ve dizinin içindeki en uzun değeri bulup ekrana yazdıralım.
            //string[] stringDizi = { "Erkan", "Onur", "Tahsin", "Altan Emre", "Ali" };
            //string enUzunKelime = "";
            //foreach (var eleman in stringDizi)
            //{
            //    if (eleman.Length > enUzunKelime.Length)
            //    {
            //        enUzunKelime = eleman;
            //    }
            //}
            //Console.WriteLine("İsimler içindeki en uzun kelime: {0}", enUzunKelime);
            #endregion

            #region ornek 3
            // Diziye rastgele atanan 10 adet sayının ortalamasını bulup ekrana yazdıran programı yazalım.

            //int[] sayilar = new int[10];
            //Random ran = new Random();
            //int counter = 0;
            //foreach (int sayi in sayilar)
            //{
            //    sayilar[counter] = ran.Next(1, 100);
            //    Console.WriteLine(sayilar[counter]);
            //    counter++;
            //}
            //Console.WriteLine("Foreach ile oluşturulan random sayılar");
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = ran.Next(1, 100);
            //    Console.WriteLine(sayilar[i]);
            //}
            //Console.WriteLine("For ile oluşturulan random sayılar");
            //int toplam = 0;
            //foreach (var sayilar1 in sayilar)
            //{
            //    toplam = toplam + sayilar1;
            //}
            //Console.WriteLine("Ortalama: {0}", toplam / sayilar.Length);
            #endregion

            #region Ornek4
            //5 karakter uzunluğunda bir string dizisi oluşturup klavyeden 5 değerin girilmesini sağlayıp dizinin içerisindeki bütün harfleri alt alta ekrana yazdıran programı yazalım.
            //string[] kelimeler = new string[1];
            //int say = 0;
            //foreach (string kelime in kelimeler)
            //{

            //    Console.WriteLine("Kelime giriniz");
            //    kelimeler[say] = Console.ReadLine();
            //    say++;
            //}
            //foreach (string kelime in kelimeler)
            //{
            //    foreach (char harf in kelime)
            //    {
            //        Console.WriteLine(harf);

            //    }
            //}
            #endregion

        }
    }
}

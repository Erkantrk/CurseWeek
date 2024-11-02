namespace _01_Tur_donusum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region tür dönüşümü char
            //int test = 36;

            //char test1 = Convert.ToChar(test);// convert ile sayı olan değerimizi metinsel chara dönüşüm yöntemi ile türünü belirliyoruz.

            //Console.WriteLine(test1);
            #endregion

            #region int tür dönüşümü
            //int sayi = 10;
            //string s = Convert.ToString(sayi);// ToString stringe dönüştürme.
            //Console.WriteLine(s);
            //string harf = "10";// konsolda 10 ifadesi aslında bu şekilde tür dönüşümüne uğruyor.
            #endregion

            #region string dönüşümü
            //string s = "10";
            //int sayi = Convert.ToInt32(s);
            //Console.WriteLine(sayi);
            //int s1 = 10;
            #endregion
            #region

            //Console.WriteLine("bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());// kullanıcıdan değer alma işlemiden bir tür dönüşümü yaparız çünkü tüm yazılım dillerinde girilen değerler metinseldir.

            //int sayi1 = 20;

            //sayi1 = sayi + sayi1;
            //Console.WriteLine(sayi1);
            #endregion

            #region tür dönüşümü char
            //char harf = ' ';
            //int harfiSayiyaCevir = Convert.ToInt32(harf);
            //Console.WriteLine(harfiSayiyaCevir);
            #endregion
            #region tür dönüşümü double
            //double sayi = 51.9;
            //int sayi2 = (int)sayi;// casting yöntemi dediğimiz tür dönüşümü
            //int sayi3 = Convert.ToInt32(sayi);// sayıyı yuvarlar 
            //Console.WriteLine(sayi2);
            #endregion

            #region tür dönüşümü string
            //string metin = "10";
            //int s1 = Convert.ToInt32(metin);
            //int s = 10;
            //Console.WriteLine("metinsel:"+metin + s);
            //Console.WriteLine("sayısal{0}:",s1 + s);
            #endregion

            // ÖRNEK:
            // Kullanıcıdan 2 kardeşin yaşını alarak ortalamasını ekrana yazdırınız.

            //Console.WriteLine("Lütfen Yaşınızı giriniz");
            //int yas = int.Parse(Console.ReadLine());//int pars da dönüşüm yöntemidir fakat default 32 bit alır
            //Console.WriteLine("Lütfen 2. yaşı girin");
            //int yas2 = Convert.ToInt32(Console.ReadLine());

            //double sonuc = (yas + yas2) / 2.0;

            //Console.WriteLine("Ortalama:{0}", sonuc);

            // kullanıcıdan 3 adet ürün fiyatı alacağız ve 3 adet ürün fiyat gösterin

            //Console.WriteLine("Lütfen 1. ürünün fiyatını giriniz");
            //double fiyat1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Lütfen 2. ürünün fiyatını giriniz");
            //double fiyat2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Lütfen 3. ürünün fiyatını giriniz");
            //double fiyat3 = Convert.ToDouble(Console.ReadLine());

            //double toplam = fiyat1 + fiyat2 + fiyat3;
            //toplam += toplam*0.20; //+= dediğimizde sabit olan değişkenimize ekleme yapar. 

            //Console.WriteLine(toplam);

            #region string array türü
            //String karakterler aslında bir array (koleksiyondur)

            //string ad = " muhammet ali ";

            ////kolekiyonlar içerisindeki değerleri INDEX adı verilen 0 dan başlar 1'er 1'er artan bir numaralandırma yöntemi ile tutar

            //Console.WriteLine(ad.IndexOf('a'));// ilk buldugu index i dönderir
            //Console.WriteLine(ad.LastIndexOf('a'));// son buldugu index i dönderir.

            //string metin = "    ali      ";
            //Console.WriteLine(metin);
            //Console.WriteLine(metin.Trim(' '));//sağdan soldan tüm boşlukları siler 
            //Console.WriteLine(metin.TrimStart(' '));//sadece soldan siler 
            //Console.WriteLine(metin.TrimEnd(' '));// sadece sağdan siler

            //string ad = "erkan";
            //string soyad = "TÜRK";

            //Console.WriteLine(ad.ToUpper());// ToUpper girilen değeri büyük harflere çevirir.
            //Console.WriteLine(soyad.ToLower());//ToLower girilen değeri küçük harflere çevirir.

            string metin = "Bu Türkiye yaşanmaz oldu.";

            //Console.WriteLine(metin.Substring(3));// ilk 3 harfi siler
            //Console.WriteLine(metin.Substring(3, 7));//3 harften başlar 7 harfi yazar devamınıda siler



            #endregion

            // **Datetime Tipi**

            DateTime zaman = DateTime.Now;// zaman veri tipi
            Console.WriteLine(zaman); // zamanın tamamını alır saniyesine kadar
            Console.WriteLine(zaman.Year);// sadece yılı alır
            Console.WriteLine(zaman.Month);// sadece ayı alır
            Console.WriteLine(zaman.Day);// sadece günü alır
            Console.WriteLine(zaman.Hour);// sadece saati alır
            Console.WriteLine(zaman.Minute);// sadece dakikayı alır
            Console.WriteLine(zaman.Second); // sadece saniyeyi alır           
            Console.WriteLine(zaman.ToString("yyyy-MM-dd"));// kendi belirlediğimiz formatla gösterir.
            Console.WriteLine(zaman.ToString("dd-MM-yyyy HH:mm:ss"));
            // zaman türünde yeni bir zaman türetmek istediğimizde new kelimesini kullanırız.
            DateTime zaman2 = new DateTime(2000, 12, 24, 12, 34, 45);// kendimiz de değer verebiliyoruz.
            Console.WriteLine(zaman2);


        }
    }
}

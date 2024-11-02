namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region operatörler
            // Atama operatötleri
            /*
             =, atama operatörü, Sağdaki veriyi Soldaki değişkene atar
            +=, artırma operatörü
            -=, azaltma operatörü
             

             */

            //Compresion operator (karşılaştırma operatörü)
            /*
            True veya False değer döner.
             == , eşit mi ? 
            !=,eşit değilse?
            >, büyüktür
            >=,büyük eşittir
            <, küçüktür
            <=, küçük eşittir.
            */
            //Mantıksal operatörler
            /*
            &&,ve (and)
            ||, veya (or)

            %, mod alma operatörü 
            
            */
            #endregion
            #region örnek 1 
            //int sayi = 10;
            //int sayi2 = 20;

            //bool karsilastir = sayi > sayi2;//false
            //bool karsilastir2 = sayi <= sayi2;//true
            //bool karsilastir3 = sayi >= sayi2;//false
            //// değişkeni kullanmadığımızda soluk renkde gösterir.


            //Console.WriteLine(karsilastir);//false
            //Console.WriteLine(karsilastir2);//true
            //Console.WriteLine(karsilastir3);//false
            #endregion
            #region mantıksal operatörler
            //&& ve operatöründe karşılaştırılan değerlerin hepsi tru olduğu sürece true döner.
            //&&, (ve/and) çarpma işlemi mantığı ile düşüne bilirsiniz
            // başlangıç koşul sonuç
            /*

                1        0      0
                0        1      0
                1        1      1
                0        0      0

            */
            //|| veya bir koşul true ise sonuç true döner
            /*|| (veya/or) toplama mantığı ile düşüne bilirsiniz.
            // başlangıç koşul sonuç
                   1       1    1
                   0       1    1
                   1       0    1
                   0       0    0
            
            
            
            */
            //int sayi = 10;
            //bool mantiksal = sayi > 5 && sayi < 12;// true
            //bool mantiksal2 = sayi <= 5 && sayi >= 12;//false
            //bool mantiksal3 = sayi < 5 && sayi > 12;//false
            //bool mantiksal4 = sayi >= 5 && sayi >= 12;//true


            //bool mantiksal5 = sayi < 5 || sayi < 12;//true
            //bool mantiksal6 = sayi < 13 || sayi < 14;//true
            //bool mantiksal7 = sayi > 11 || sayi > 12;//false
            //bool mantiksal8 = sayi <= 9 || sayi <= 10;//true
            //Console.WriteLine(mantiksal5);
            //Console.WriteLine(mantiksal6);
            //Console.WriteLine(mantiksal7);
            //Console.WriteLine(mantiksal8);


            #endregion

            #region mod alma
            // mod alma işlemi
            //%: bir sayının bölme sonucunda kalanı verir.

            //int sayi = 10;
            //double sayi2 = 3;

            //double sonuc = sayi / sayi2;
            //Console.WriteLine(sonuc);
            //int s1 = 10;
            //int s2 = 3;
            //int s = s1 % s2;
            //Console.WriteLine(s);

            #endregion


            #region Atama ve işlemli Atama operatörü
            //atama operatörü
            //int sayi = 17;
            //sayi = sayi + 2;
            //sayi = sayi - 1;
            //sayi = sayi * 2;
            //sayi = sayi / 2;
            //sayi += 2;
            //sayi -= 2;
            //sayi *= 2;
            //sayi /= 2;
            //int sonuc = sayi;
            //Console.WriteLine(sonuc);



            #endregion
            #region kullanıcıdan değer alma ve kontrol
            // kullanıcıdan adı ve şifre alınacak kullanıcı adı admin ve şifre 123 ise giriş başarılı yazacak.
            //string userName = "Admin";
            //string password = "123";
            //Console.WriteLine("Lütfen kullanıcı adınızı giriniz");
            //string kullaniciadi = Console.ReadLine();
            //Console.WriteLine("Lütfen Parolanızı giriniz");
            //string parola = Console.ReadLine();
            //bool dogrulama = userName == kullaniciadi && password == parola;
            //Console.WriteLine("Giriş durumu:" + dogrulama);



            #endregion


        }
    }
}
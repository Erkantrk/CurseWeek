namespace _01_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int toplam = 0;
            //int sayi;
            //do
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;
            //} while (sayi != 0);
            //Console.WriteLine("Toplam:" + toplam);

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;// her döngüye girdiğinde sayıyı artırır ve koşulu kontrol eder eğer koşul true ise devam eder bu işleme
            //} while (i <= 10);

            //1 ile 100 arasında rastgele sistem tarafından belirlenen sayıyı bulma.

            //Random ran = new();
            //int tutulanSayi = ran.Next(1, 100);
            //int girilenSayi;

            //do
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    girilenSayi = int.Parse(Console.ReadLine());
            //    if (girilenSayi > tutulanSayi)
            //    {
            //        Console.WriteLine("Daha küçük bir sayı giriniz");

            //    }
            //    else if (girilenSayi < tutulanSayi)
            //    {
            //        Console.WriteLine("Daha büyük bir sayı giriniz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tebrikler doğru tahmin");
            //    }
            //} while (true);

            // kullanıcıdan isim soy isim alınacak ve  eğer döngünün 1 defa çalışmasını istiyor ise bunu kullanıcı belirtecek birden fazla çalışmasını istiyor isek kullanıcı kaç defa çalışacağını söyleyecek ve ona göre kulanıcı adı ve soyadı sorulacak. do while ile yazılacak.
            //int sayi = 1;
            //Console.WriteLine("Kaç kere dönsün:");
            //int s = int.Parse(Console.ReadLine());
            //do
            //{
            //    Console.WriteLine("Adnız giriniz:{0}", sayi);
            //    string ad = Console.ReadLine();
            //    Console.WriteLine("Soyadınızı giriniz:{0}", sayi);
            //    string soyad = Console.ReadLine();
            //    sayi++;
            //} while (s >= sayi);

            // continue ve break kullanımı
            //int sayi = 0;
            //do
            //{
            //    sayi++;
            //    if (sayi == 5 || sayi == 6)
            //    {
            //        continue;// belirttiğimiz koşula geldiğinde döngü o koşulu atlıyor.
            //    }
            //    if (sayi == 9)
            //    {
            //        break;// break  döngüyü sonlandırmak için kullanılır
            //    }
            //    Console.WriteLine(sayi);

            //} while (sayi<=10);
            //kullanıcı adı sorma 
            string kad = "admin";
            bool locked = true;

            do
            {
                Console.WriteLine("Lütfen kullanıcı adınızı giriniz");
                string kullaniciGiris = Console.ReadLine();
                if (kullaniciGiris != kad)
                {
                    Console.WriteLine("Kullanıcı adını yanlış girdiniz");
                    locked = false;
                    Thread.Sleep(5000);// bekletmek için Thread.Sleep() kullanıp milisaniye cinsinden süreyi veriyoruz.
                    Console.WriteLine("Hesabınız açılmıştır doğru şekilde bilgileri giniz.");
                    locked = true;
                }
                else if (kullaniciGiris == kad)
                {
                    locked = false;
                }
            } while (locked);
            Console.WriteLine("Giriş başarılı");
        }
    }
}

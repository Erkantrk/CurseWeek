namespace _01_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region methodlar
            /*
           METHODS - FONKSİYONLAR

           Metotlar: Yazılımcılar tarafından geliştirilen ve diğer yazılımcıların kullanımına sunulan hazır kod yapılarıdır. Metoda bir isim verilir ve o isim altında bir iş yapar kod bloğu yazılır ve yazılımcı o işi yapmak için kod bloğunu yazmak yerine metodu ismini yazarak çağırır.Çağrılan metot kendi içindeki kod bloğunu çalıştırır. Bu sayede yazılımcı tanımlı işin kodunu defalarca yazmaktan kurtulur.

           Metotlar ve Fonksiyonlar () ile tanımlanır.
           Metotlar iç içe TANIMLANAMAZLAR.
           Metotlar çağrılmadığı sürece bir işlem yapmazlar.
           Metotlar UNIQUE(benzersiz) olmalıdır. Aynı isme sahip metotların, metot imzaları farklı olmalıdır.(parametre sayısı,parametre veri tipi)

           Fonksiyonlar ise yazılımcının kendisinin oluşturduğu metotlardır.

           Metotlar 2'ye ayrılır.

           *Değer Döndüren(parametreli/parametresiz)
           *Değer Döndürmeyen(parametreli/parametresiz)


           Parametre: metot parantezleri içerisine yazılan ve metodu kullanırken gönderilecek verilerdir. 


            */
            #endregion




            #region method örnekler
            //string ad = "Erkan";
            //string ad1 ;
            //YazIsim("Erkan");
            //YazIsim(ad);
            //Yaz();
            //YazIsim(ad1 = Console.ReadLine());

            //Console.WriteLine("Form kaç defa çalışsın");
            //int cevap = Convert.ToInt32(Console.ReadLine());
            //if (cevap == 1)
            //{
            //    Islem();
            //}
            //else if (cevap != 1)
            //{
            //    for (int i = 0; i < cevap; i++)
            //    {
            //        Islem();
            //    }
            //}
            #endregion

            #region 4 adet method oluşturun her method 2 parametre alsın ve methodlar toplama çıkarma çarpma bölme işlemi yapsın
            Toplama(10, 20);
            Carpma(10, 20);
            Bolme(10, 20);
            Cikarma(10, 20);
            string[] dizi = { "deneme1", "deneme2", "deneme3" };
            string[] dizi1 = { "deneme1", "deneme2", "deneme3" };
            string[] dizi2 = { "deneme1", "deneme2", "deneme3" };
            string[] dizi3 = { "deneme1", "deneme2", "deneme3" };
            string[] dizi4 = { "deneme1", "deneme2", "deneme3" };
            string[] dizi5 = { "deneme1", "deneme2", "deneme3" };
            string[] dizi6 = { "deneme1", "deneme2", "deneme3" };
            Dizi(dizi);
            Dizi(dizi2);
            Dizi(dizi3);
            Dizi(dizi4);
            Dizi(dizi5);
            Dizi(dizi6);
            #endregion
            #region method geriye değer döndüren
            int sayi = GeriyeDegerDonder();
            Console.WriteLine(sayi);
            sayi = GeriyeDegerDonderParametreli(20, 30);
            Console.WriteLine(sayi);
            sayi = GeriyeDegerDonderParametreli(GeriyeDegerDonder(), 30);
            Console.WriteLine(sayi);
            #endregion
            #region method örnekler
            #endregion




        }

        static void Toplama(int s1, int s2)
        {
            Console.WriteLine(s1 + s2);
        }
        static void Carpma(int s1, int s2)
        {
            Console.WriteLine(s1 * s2);
        }
        static void Bolme(int s1, int s2)
        {
            Console.WriteLine(s1 / s2);
        }
        static void Cikarma(int s1, int s2)
        {
            Console.WriteLine(s1 - s2);
        }
        static void Yaz()// parametresiz iş yapan method
        {
            Console.WriteLine("Ad giriniz:");
        }
        static void YazIsim(string ad, int topla)// parametreli iş yapan method
        {
            Console.WriteLine(ad);
        }
        static void Islem()
        {
            Console.WriteLine("Adınız:");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaş:");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tc");
            string TC = Console.ReadLine();

            Console.WriteLine($"Ad:{ad}\nSoyad:{soyad}\nYaş:{yas}\nTC:{TC}");
        }
        static void Dizi(string[] dizi)
        {
            foreach (var eleman in dizi)
            {
                Console.WriteLine(eleman);
            }
        }

        static int GeriyeDegerDonder()
        {
            int s1 = 10;
            int s2 = 20;
            int toplam = s1 + s2;
            return toplam;
        }
        static int GeriyeDegerDonderParametreli(int s1, int s2)
        {
            
            int toplam = s1 + s2;
            return toplam;
        }
    }
}

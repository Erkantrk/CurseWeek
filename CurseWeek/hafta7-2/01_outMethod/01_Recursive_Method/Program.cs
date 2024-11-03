using System.Collections;

namespace _01_Recursive_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recursive metotlar:Bir işin tamamını bitirmek yerine küçük parçalara bölüp her seferinde bir kısmını yapmaya benzeyen işlemlerdir.
            //test();sonsuz döngü
            int s = 1;
            int s2 = 2;
            Console.WriteLine("Çoklu form için 1 e basınız Tekli form için 2 te basınız:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (s == sayi)
            {
                int s3 = 0;
                Console.WriteLine("Kaç adet olsun");
                int s4 = Convert.ToInt32(Console.ReadLine());
                CokluForm(s4, s3);
            }
            else if (s2 == sayi)
            {
                Form();
            }
            else
            {
                Console.WriteLine("Yanlış veya hatalı tuşlama 1 veya 2 ye basınız");
            }
        }
        static void test()
        {
            Console.WriteLine("test çalıştı");
            test();
        }
        static void Form()
        {
            Console.WriteLine("Adınızınızı giriniz");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaşınızı giriniz");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ad: {ad}\nSoyad: {soyad}\nYas {yas}");
        }
        static void CokluForm(int sayi, int sayi2)
        {
           // ArrayList list = new ArrayList();
            Console.WriteLine("Adınızınızı giriniz");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaşınızı giriniz");
            int yas = Convert.ToInt32(Console.ReadLine());

            //list.Add(ad);
            //list.Add(soyad);
            //list.Add(yas);

            if (sayi > sayi2)
            {
                CokluForm(sayi - 1, sayi2);
            }
            
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}

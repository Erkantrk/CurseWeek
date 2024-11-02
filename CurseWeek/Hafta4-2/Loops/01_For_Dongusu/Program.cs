namespace _01_For_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for loops (döngü)
            //for(başlangıç;koşul;artış/azalış)
            #region örnek 1 for
            //for (int i = 0; i < 50; i++) // i yi for un parantezleri içerisinde artırma 
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region örnek 1 for
            //for (int i = 0; i < 50;) // i yi for un  süslü parantezleri içerisinde artırma 
            //{

            //    Console.WriteLine(i);
            //    i++;
            //}
            #endregion
            #region örnek 1 for
            //for (int i = 0; i < 50;) // i 0 olarak değerini alma ama 1 olarak gösterme 
            //{

            //    Console.WriteLine("i:{0}",i +2);
            //    i++;
            //}
            #endregion
            #region örnek 1 for
            //for (int i = 0; i < 50;) // i 0 olarak değerini alma ama 1 olarak gösterme 
            //{
            //    ++i;
            //    Console.WriteLine(i);

            //}

            //for (; ; )// sonsuz döngü
            //{
            //    Console.WriteLine("Sonsuz döngü");

            //}

            #endregion

            #region Çarpım tablosu
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("-------------");
            //    Console.WriteLine("{0}'ler çarpı",i );
            //    Console.WriteLine("-------------");
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine("{0}x{1}={2}", i, j, i * j);
            //    }

            //}
            #endregion

            #region Pascal Üçgeni
            //for (int i = 0; i <=100 ; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}
            #endregion
            #region alfabe örneği
            //string alfabe = "!*.-abcçdefgğhıijklmnoöprsştuüvyzqwx123456789";
            //Random rand = new Random();
            //for (int i = 0; i < 15; i++)
            //{
            //    Console.WriteLine(alfabe[rand.Next(0,alfabe.Length)]);
            //}

            #endregion
            #region karakter çevirme
            ////Klavyeden girilen bir cümlenin her harfini döngü ile alt alta ekrana yazdıran programı yazalım.
            //Console.WriteLine("bir cümle giriniz");
            //string cumle = Console.ReadLine();
            //for (int i = 0; i < cumle.Length; i++)
            //{
            //    Console.WriteLine(cumle[i]);
            //    Thread.Sleep(1000);
            //}
            #endregion

            #region char değerler
            //for (char karakter = 'a';karakter  <= 'z';karakter ++)
            //{
            //    Console.WriteLine(karakter);
            //}
            #endregion
            #region char değerler
            //for (string karakter = "a"; karakter.Length <= "z"; karakter++)
            //{// char da ki girilen değerlerin rakamsal bir karşılığı olduğu için döngü olur ama string olarak bu şekilde yapılamaz
            //    Console.WriteLine(karakter);
            //}
            #endregion
            //for (; ; )
            //{
            //    Console.WriteLine("Merhaba");
            //    int i = 0;
            //    for (; ; )
            //    {
            //        if (i <= 100)
            //        {
            //            Console.WriteLine(i + " " + " ");
            //            i++;
            //        }
            //        else
            //        {
            //            break;// bu alandaki break ifadesi sadece iç taraftaki for döngüsünden çıkartmak için kullanılır.
            //        }
            //    }
            //    Console.WriteLine("içteki döngüden çıktı");
            //    //break;
            //}
            //Console.WriteLine("Dıştaki döngüden çıktı");

            #region 5 er 5 er artırma
            //for (int i = 0; i < 100; i+=5)// sayıyı 5 er 5 er aartırmak için i+= ile değeri vermemiz gerekiyor.
            //{
            //    Console.WriteLine(i);
            //}

            //
            #endregion
            #region ders çalışmna
            /*
            https://www.w3schools.com/
            https://medium.com/
            https://leetcode.com/
            https://www.hackerrank.com/
            
            */
            #endregion
        }
    }
}

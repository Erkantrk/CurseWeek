using System.Data;

namespace _01_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region try-catch örnek
            // Try Catch: program çalışırken bir hata alınır ise Exceptionlar tarafından programın akışını bozmadan hatayı gösterir ve işlemler devam eder.
            int sayi2 = 0;
            try
            {

                Console.WriteLine("Bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi / sayi2);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format hatası!");
                string hata = "hata" + ex.Message;
                Console.WriteLine(hata);
                Console.WriteLine(ex);
            }
            catch (DivideByZeroException ex)
            {
                string hata = "hata" + ex.Message;
                Console.WriteLine(hata);
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {

                string hata = "hata" + ex.Message;
                Console.WriteLine(hata);
                Console.WriteLine(ex);
            }


            Console.WriteLine("Bir sayı giriniz");
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ikinci sayı giriniz");
            int s2 = int.Parse(Console.ReadLine());
            int sonuc = s1 * s2;
            Console.WriteLine("sonuc:" + sonuc);
            #endregion

            #region örnek 1
            //try
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    int sayi = int.Parse(Console.ReadLine());

            //    switch (sayi % 5)
            //    {
            //        case 0:
            //            Console.WriteLine("Gelen sayı 5 in katıdır.");
            //            switch (sayi % 10)
            //            {
            //                case 0:
            //                    Console.WriteLine("Gelen değer 10 un katıdır.");
            //                    break;
            //                default:
            //                    Console.WriteLine("10 katı değildir");
            //                    break;
            //            }
            //            break;
            //        case 1:
            //            Console.WriteLine("Gelen sayı  5 yada katı değildir.");
            //            break;
            //        default: Console.WriteLine("Gelen sayı  5 yada katı değildir."); break;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //    throw;  // fırlatma kısmı 

            //}

            #endregion
            #region örnek 2 finally
            try
            {
                Console.WriteLine("Bir sayı giriniz");
                int sayi = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Hata oluştu!");
            }
            finally // finally her türlü çalışan bir yapıdır. bina giriş kapısı gibi düşüne bilirsiniz siz açıyorsunuz ama kendisi otomatik kapatıyor.
            {
                Console.WriteLine("Ben arsızım her türlü çalışırım");
            }
            #endregion
        }
    }
}

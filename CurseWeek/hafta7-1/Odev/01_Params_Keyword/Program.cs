namespace _01_Params_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            // Kişi sayısını önceden bilmek zorunda değilsiniz. 'params' ile aynı şekilde bir metoda değişken sayıda argüman geçirebilirsiniz.
            int[] dizi = { 20, 30, 40, 60, 70 };
            string[] metin = { "Tahsin", "Erkan", "Hakan" };
            DiziYazdir();
            // DiziYazdir([20, 30, 40, 50, 60] , [50,60,70,85]); ikinci bir dizi tanımlamaya kalktığımızda hata verir.
            DiziYazdir2([20, 30, 40, 50, 60], [500, 600, 700, 850], 26, 'E', 20, 60, 50);
            Thread.Sleep(5000);
            Console.WriteLine("**********************************");
            DiziYazdir2([20, 30, 40, 50, 60], [500, 600, 700, 850], 26);

            DiziYazdir3(20, 30, 40, 50, 60,12312,3123,21312312,123213,33,434,5,"asdkjaskldj");
        }
        static void DiziYazdir(int[] sayilar)
        {
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
        }
        static void DiziYazdir2(int[] dizi, int[] dizi2, int sayi, params object[] objects)
        {
            foreach (var d in dizi)
            {
                Console.WriteLine(d);
            }

            foreach (var d in dizi2)
            {
                Console.WriteLine(d);
            }

            foreach (var obj in objects)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(sayi);
        }
        static void DiziYazdir3(params int[] dizi)
        {
            foreach (var d in dizi)
            {
                Console.WriteLine(d);
            }
        }
    }
}

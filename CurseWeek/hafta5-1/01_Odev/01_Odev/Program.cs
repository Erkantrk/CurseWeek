namespace _01_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region odev
            //Sistemin rastgele üretmiş olduğu sayıyı kullanıcının bulması için bir kod bloğu yazarak, eğer kullanıcının girdiği sayı üretilen sayıdan büyük ise kullanıcının büyük bir sayı girdiğini, 
            //küçük sayı girdiyse kullanıcının küçük sayı girdiğini uyarısını veriniz.
            //ve kullanıcnın bu 3 adımlı tahmin oyununda 5 hakkı olsun.
            //Rastgele üretilen sayı(10,100) arasında olsun.
            //try-catch do while
            #endregion
            Random r = new();
            int randomSayi = r.Next(10, 100);
            int hak = 1;

            try
            {
                do
                {
                    Console.WriteLine("{0}.Hakkınız.Bir sayı giriniz", hak);
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(sayi);

                    if (sayi < randomSayi)
                    {
                        Console.WriteLine("Girdiğiniz sayı üretilen sayıdan küçüktür.");
                        Console.WriteLine("*******");
                        if (hak == 5)
                        {
                            Console.WriteLine("Hakkınız bitmiştir. {0}", randomSayi);
                            break;
                        }
                    }
                    else if (sayi > randomSayi)
                    {
                        Console.WriteLine("Girdiğiniz sayı üretilen sayıdan büyüktür");
                        Console.WriteLine("********");
                        if (hak == 5)
                        {
                            Console.WriteLine("Hakkınız bitmiştir. {0}", randomSayi);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tebrikler Dohru sayıyı buldunuz");
                        Console.WriteLine("**********");
                        break;
                    }
                    hak++;
                } while (true);
            }
            catch (Exception)
            {

                Console.WriteLine("Hatalı işlem ");

            }
        }
    }
}

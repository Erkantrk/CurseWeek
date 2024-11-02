namespace OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Console.WriteLine("Lütfen Cinsiyetiniz giriniz");
                string cinsiyet = Console.ReadLine().ToLower();
                switch (cinsiyet)
                {
                    case "erkek":
                        Console.WriteLine("Yaş:");
                        int yas = Convert.ToInt32(Console.ReadLine());
                        if (yas > 59)
                        {
                            Console.WriteLine("Maaş:");
                            double maas = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Emeklilik ikraminiz" + (maas * 10));
                        }
                        else
                        {
                            Console.WriteLine("Prim Gün sayısı:");
                            int prim = Convert.ToInt32(Console.ReadLine());
                            if (prim >= 6000)
                            {
                                Console.WriteLine("Maaş:");
                                double maas = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Emeklilik ikraminiz" + (maas * 11));
                            }
                            else
                            {
                                Console.WriteLine("Emeklilik Yalan oldu Çalışmaya devam");
                            }
                        }
                        break;
                    case "kadın":
                        Console.WriteLine("Yaş:");
                        int yas2 = Convert.ToInt32(Console.ReadLine());
                        if (yas2 > 49)
                        {
                            Console.WriteLine("Maaş:");
                            double maas = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Emeklilik ikramiyeniz " + (maas * 10));
                        }
                        else
                        {
                            Console.WriteLine("Prim gün sayısı");
                            int prim = Convert.ToInt32(Console.ReadLine());
                            if (prim >= 5600)
                            {
                                Console.WriteLine("Maaş:");
                                double maas = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Emeklilik ikramiyeniz " + (maas * 11));
                            }
                            else
                            {
                                Console.WriteLine("Emeklilik hayal oldu çalışmaya devam");
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Hatalı cinsiyet");
                        break;


                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata" + ex);

            }
        }
    }
}

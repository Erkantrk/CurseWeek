namespace Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan vize ve final notları istenecek  0 ila 100 arasında bir değer girmeli.
            //kullanıcının girdiği değerlere göre vize notunun %40 final notunun ise %60 ı alınacak
            //ortama kontrol edilip harf notu olarak ekrana çıktı yazdırılacak.
            //0-20 ff 21-45 dd 46-60 cc 61-75 bb 76-100 arasında aa yazdıracak.

            Console.WriteLine("Lütfen Vize notunuz giriniz");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen Final Notunuzu giriniz");
            int final = Convert.ToInt32(Console.ReadLine());

            if (vize < 0 || vize > 100 || final<0 || final>100)
            {
                Console.WriteLine("Vize ve Final Notu 0 ila 100 arasında olmalıdır");
            }           
            else
            {
                double ortalama = vize * 0.40 + final * 0.60;
                if (ortalama >= 0 && ortalama <= 20)
                {
                    Console.WriteLine("Harf Notunuz:FF Ortalamanız:{0}", ortalama);
                }
                else if (ortalama >= 21 && ortalama <= 45)
                {
                    Console.WriteLine("Harf Notunuz:DD Ortalamanız:{0}", ortalama);
                }
                else if (ortalama >= 46 && ortalama <= 60)
                {
                    Console.WriteLine($"Harf Nonutuz:CC Ortalamanız:{ortalama}");
                }
                else if (ortalama >= 61 && ortalama <= 75)
                {
                    Console.WriteLine("Harf Notunuz:BB Ortlamanız:{0}", ortalama);
                }
                else
                {
                    Console.WriteLine("Harf Notunuz:AA Ortlamanız:{0}", ortalama);
                }
            }

        }
    }
}

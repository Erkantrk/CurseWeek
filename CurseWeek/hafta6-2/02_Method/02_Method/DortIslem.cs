using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Method
{
      static class DortIslem
     {
        
        //Solid Prensibleri
        internal static void Toplama(int s1, int s2)
        {
            Console.WriteLine(s1 + s2);
        }
        internal static void Carpma(int s1, int s2)
        {
            Console.WriteLine(s1 * s2);
        }
        internal static void Bolme(int s1, int s2)
        {
            Console.WriteLine(s1 / s2);
        }
        internal static void Cikarma(int s1, int s2)
        {
            Console.WriteLine(s1 - s2);
        }

        internal static void Islemler()
        {
            Console.WriteLine("1.Sayıyı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yapmak istediğin işemi giriniz\n+\n-\n*\n/");
            char islem = Convert.ToChar(Console.ReadLine());

            if (islem == '+')
            {
                Toplama(sayi, sayi2);
            }
            else if (islem == '-')
            {
                Cikarma(sayi, sayi2);
            }
            else if (islem == '/')
            {
                Bolme(sayi, sayi2);
            }
            else if (islem == '*')
            {
                Carpma(sayi, sayi2);
            }
            else
            {
                Console.WriteLine("Hatalı işlem");
            }
        }

     }

}

namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tekli yorum satırı 
            /*
             çoklu yorum satırı
             #region bilgilendirme ve kod kalabalığını gizlemek içişn kullanılan yapıdır kapanışı için #endregion dememiz gerekir
            breakpoint bizim kod bloğumuzu adım adım izlememizi ve kontrol etmemizi sağlar.
             */
            #region değişkenler
            // tüm program dillerinde gelen değerler metinsel değerlerdir
            // string metinsel değerleri tutar 
            //******Metinsel********
            //string ad = "Erkan TÜRK";// değişkenler sadece bir değer tutar ve aynı değişken ismini tekrar tanımlayamayız string keyword u ile 
            //string ad= aynı isim olduğu için tanımlama yapılamaz.
            //ad = "Volkan Acar";
            //char harf = 'A';// char tek bir harf tanımlamak için kullanırız.
            // *******Tam sayı türleri******** 
            //int yas = 21;//int değişkeni 10 haneli tam sayı türünde değer  alır.
            // long longTest = 1213;
            // byte byteTest = 254;//0 ila 255 arasında 8 bitlik değer alır 
            //****Ondalıklı sayı türleri****
            //double pi = 3.14;// double değişkeni ondalıklı sayılar için kullandığımız bir yapıdır.
            // float pi1 = 3.14F;// float değişkeni ondalıklı sayılar için kullandığımız bir yapıdır. F işareti ile virgülden sonraki basamağı belirtir.
            //decimal pi2 = 3.1494m;// decimal değişkeni ondalıklı sayılar için kullandığımız bir yapıdır. m işareti ile virgülden sonraki basamağı belirtir.
            // ***Doğru yanlış değer dönderen veri yapısı***
            //bool dogru = false;// true veya false değer dönderir bize

            //tarih zaman değeri
            //DateTime bugun = DateTime.Now;

            //**Bit**
            /*
            8bit=>1byte
            1024=>1kb
            1024=>1mb
            1024=>1gb
            1024=>1tb           
            
            */
            //$ string interpolition süslü parantezlerin içerisine değişkenleri tanımlamamızı sağlar.
            //Console.WriteLine($"int tipinin max değeri     : {int.MaxValue} ve min değeri     : {int.MinValue}");
            //Console.WriteLine($"byte tipinin max değeri    : {byte.MaxValue} ve min değeri    : {byte.MinValue}");
            //Console.WriteLine($"long tipinin max değeri    : {long.MaxValue} ve min değeri    : {long.MinValue}");
            //Console.WriteLine($"double tipinin max değeri  : {double.MaxValue} ve min değeri  : {double.MinValue}");
            //Console.WriteLine($"decimal tipinin max değeri : {decimal.MaxValue} ve min değeri : {decimal.MinValue}");
            //Console.WriteLine($"float tipinin max değeri   : {float.MaxValue} ve min değeri   : {float.MinValue}");



            //Console.WriteLine("string{int}");// örnek olarak burada string interpolition olmadan yazılan kod

            //Console.WriteLine("Adınız Soyadınız"+ ad);//Console.WriteLine Bize çıktı verme işlemi yapar 

            #endregion
            #region değişken tanımlama
            //int yas = 21;
            //string adinizSoyadınız = "Erkan Türk";
            //char cinsiyet = 'E';
            //long tc = 12345678910;
            //DateTime bugun = DateTime.Now;
            //bool gunDogrumu = true;
            //double maas = 5500.50;

            //Console.WriteLine("Adınız Soyadınız {0}: Yaşınız{1}: Maaşınız {2}", adinizSoyadınız, yas,maas);
            //Console.WriteLine("Cinsiyetiniz:" + cinsiyet);
            //Console.WriteLine($"Tc kimlik numaranız{tc}\n bugünün tarihi:{bugun} ");// \n ifadesi bir aşşağı satıra atar yazdığımız işlemleri
            //Console.Write(gunDogrumu);



            #endregion
        }
    }
}
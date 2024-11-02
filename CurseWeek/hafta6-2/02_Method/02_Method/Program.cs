namespace _02_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Static: methodlar sadece Sınıf üzerinden erilebilen yapılardır.Eğer benim sınıfım static ise static bir method kullanmam gerekir.
        
             DataAccessModifier:Tanımlanan yapıların erişilebilirliğini tanımlar.
                    *public: Solution altındaki bütün projelerin ve proje altındaki tanımların hepsinin erişimine açık demektir.
                    *internal: Kendi tanımlı olduğu proje altında erişime açık demektir.
                    *private: Kendi tanımlı olduğu class alrtında erişime açık demektir. Bir erişşim belirteci verilmezse yapılar default PRIVATE tanımını alır.
                    *protected: Miras alınan classlar altında erişime açık demektir.
                    *sealed mühürlü kendi içerisinde erişime açık nesne oluşturulamaz yapılardır.
        
        */
            //DortIslem dort = new DortIslem();

            //DortIslem.Islemler();
            Matematik.Yaz();//static yapılar sınıf üzerinden çağırılır
            Matematik matetik = new Matematik();
            matetik.Nonstatic();// non static yapılar ise nesne oluşturulup nesne üzerinden çağırılır.
            Random rnd = new Random();
            
        }

    }
    class Matematik
    {
        internal static void Yaz()
        {
            Console.WriteLine("Merhaba");
        }
        internal void Nonstatic()
        {
            Console.WriteLine("NonStatic tanımlar Class üzerinden nesne oluşturularak erişilir.");
        }
    }
}

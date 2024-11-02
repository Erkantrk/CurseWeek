namespace Proje_Otomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region proje
            /* 

          Müşteri Daha önceden tanımlanmış bir ürün listesinden bir ürün seçecek. 
         Para girişi yapacak. Girilen para seçilen ürünün fiyatını karşılar ise ürün alındı, aksi durumda para ekle seçeneği ile tekrar para girmesi sağlanacak.

          // Admin => Ürün Ekleyecek, Ürün Silecek, Fiyat Güncelleyecek aynı ürün liste de var ise eklenmeyecek yok ise eklenecek
            Admin şifresi 3 defa yanlış girilince 10 saniye bekletecek hesap kitlenmiştir uyarısı veririp açıldığında bilgilendirecek
          */
            #endregion

            bool admin = false;// admin modunda mı ?
            string pass = "123";
            string inputPassword;//kullanıcının girdiği değer
            int wrongAttempts = 0;
            bool locked = false;//hesap kitli mi

            //ürünler dizisi
            string[] products = { "kola", "fanta", "büsküvi", "çikolata" };//ürünler listesi
            double[] prices = { 30, 30, 40, 20 };//ürün fiyat
            double balance = 0;// kullanıcının bakiyesi
            while (true)//ana döngü
            {
                try
                {
                    for (int i = 0; i < products.Length; i++)
                    {
                        Console.WriteLine($"{i}-{products[i]}: {prices[i]}"); // her ürünü listele
                    }
                    Console.WriteLine("Ürün Numarasını seçiniz (Admin girişi için -1 e basınız)");
                    int productNo = Convert.ToInt32(Console.ReadLine());
                    if (productNo == -1)
                    {
                        if (!locked)
                        {

                            while (wrongAttempts < 3)
                            {
                                Console.WriteLine("Admin şifresini giriniz");
                                inputPassword = Console.ReadLine();
                                if (inputPassword == pass)
                                {
                                    admin = true;
                                    Console.Clear();
                                    break; // içteki döngünden çıkar.
                                }
                                else
                                {
                                    wrongAttempts++;
                                    Console.WriteLine("Yanlış şifre! Kalan hakkınız:" + (3 - wrongAttempts));
                                }
                                if (wrongAttempts == 3)
                                {
                                    Console.WriteLine("^yanlış giriş yapıldı Hesap 10 saniye kitlendi.");
                                    locked = true;
                                    Thread.Sleep(10000);
                                    locked = false;
                                    wrongAttempts = 0;
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("Hesap kitli lütfen bekleyin");
                            Thread.Sleep(10000);
                            locked = false;
                        }
                        continue;//ana döngüye gönderdik.
                    }
                    Console.WriteLine("Para Girişi Yapınız:");
                    balance = Convert.ToDouble(Console.ReadLine());
                    if (balance >= prices[productNo]) //yeterli bakiye var mı ?
                    {
                        Console.WriteLine("Ürünü aldınız.\nAfiyet Olsun.\nPara Üstü:" + (balance - prices[productNo]));
                        Thread.Sleep(2000);
                        balance = 0;
                        Console.Clear();
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("Yetersiz Bakiye!");
                            Console.WriteLine("Para Ekle-1\nPara iade-2");
                            int secim = Convert.ToInt32(Console.ReadLine());
                            if (secim == 1)
                            {
                                Console.WriteLine("Para ekle:");
                                balance += Convert.ToInt32(Console.ReadLine());
                                if (balance >= prices[productNo]) //yeterli bakiye var mı ?
                                {
                                    Console.WriteLine("Ürünü aldınız.\nAfiyet Olsun.\nPara Üstü:" + (balance - prices[productNo]));
                                    Thread.Sleep(2000);
                                    balance = 0;
                                    Console.Clear();
                                    break;
                                }
                            }
                            else if (secim == 2)
                            {
                                Console.WriteLine("Para iade edildi");
                                balance = 0;
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı tuşlama");
                                Thread.Sleep(2000);
                            }
                        }
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine("Hatalı işlem:" + ex.Message);
                    Thread.Sleep(2000);
                }

                if (admin)
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("********************* ADMİN PANEL ************************");
                        Console.WriteLine("1-Ürün Ekle\n2-Ürün Güncelle\n3-Ürün Sil\n4-Ürün Listele\n5-Çıkış");
                        int secim = Convert.ToInt32(Console.ReadLine());
                        if (secim == 1)
                        {
                            Console.WriteLine("Ürün Adı:");
                            string urunAdi = Console.ReadLine();
                            urunAdi = urunAdi.ToLower();
                            bool kontrol = false;
                            for (int i = 0; i < products.Length; i++)
                            {
                                if (products[i].ToLower() == urunAdi)
                                {
                                    kontrol = true;
                                    break;//eğer bulursa döngüden çık
                                }
                            }
                            if (kontrol)//ürün zaten varsa
                            {
                                Console.WriteLine("Ürün zaten mevcut. Güncelleme yada silme işlemi için listeyi kontrol edin");
                                Thread.Sleep(3000);
                                continue;
                            }
                            Console.WriteLine("Ürün fiyatı:");
                            double fiyat = Convert.ToDouble(Console.ReadLine());

                            Array.Resize(ref products, products.Length + 1);
                            Array.Resize(ref prices, prices.Length + 1);
                            products[products.Length - 1] = urunAdi;//yeni ürün ekleme
                            prices[prices.Length - 1] = fiyat;//yeni ürün ekleme
                            Console.WriteLine("Ürün eklendi");
                            Thread.Sleep(2000);


                        }
                        else if (secim == 2)
                        {

                            for (int i = 0; i < products.Length; i++)
                            {
                                Console.WriteLine($"{i}-{products[i]}: {prices[i]}"); // Ürünleri listele
                            }
                            Console.WriteLine("Güncellenecek Ürün Numarası:");
                            int guncellenecekNo = Convert.ToInt32(Console.ReadLine());

                            if (guncellenecekNo >= 0 && guncellenecekNo < products.Length)
                            {
                                Console.WriteLine("Yeni Ürün Adı:");
                                string yeniUrun = Console.ReadLine().ToLower();

                                Console.WriteLine("Yeni Ürün Fiyatı:");
                                double yeniFiyat = Convert.ToDouble(Console.ReadLine());

                                products[guncellenecekNo] = yeniUrun;
                                prices[guncellenecekNo] = yeniFiyat;
                                Console.WriteLine("Ürün Güncellendi");
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Seçim");
                            }

                        }
                        else if (secim == 3)
                        {
                            for (int i = 0; i < products.Length; i++)
                            {
                                Console.WriteLine($"{i}-{products[i]}: {prices[i]}"); // Ürünleri listele
                            }
                            Console.WriteLine("Silinecek Ürün Numarası:");
                            int silinecekNo = Convert.ToInt32(Console.ReadLine());
                            if (silinecekNo >= 0 && silinecekNo < products.Length)
                            {
                                for (int i = silinecekNo; i < products.Length - 1; i++)
                                {
                                    products[i] = products[i + 1];
                                    prices[i] = prices[i + 1];
                                }
                                Array.Resize(ref products, products.Length - 1);
                                Array.Resize(ref prices, prices.Length - 1);
                                Console.WriteLine("Ürün Silindi");
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Seçim");
                            }
                        }
                        else if (secim == 4)
                        {
                            for (int i = 0; i < products.Length; i++)
                            {
                                Console.WriteLine($"{i}-{products[i]}: {prices[i]}"); // Ürünleri listele
                            }
                            Thread.Sleep(2000);
                        }
                        else if (secim == 5)
                        {
                            admin = false;
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Yanlış seçim");
                        }
                    }
                    admin = false;//Admin girişi sonrasında tekrar admin modunu kapattık.
                }

            }

        }
    }
}

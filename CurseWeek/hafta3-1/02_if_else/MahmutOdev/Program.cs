namespace Odevkontrol2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Basla:
            Console.Write("Lütfen alışveriş tutarınızı giriniz: ");
            double alisveristutari = Convert.ToDouble(Console.ReadLine());
            if (alisveristutari < 1)
            {
                Console.WriteLine("Alışveriş tutarınız sifirdan büyük olmalıdır.");
                goto Basla;
            }
            Console.Write("Lütfen yaşınızı giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lüften üye tipinizi giriniz (Standart,Gold,Premium): ");
            string üyetipi = Console.ReadLine().ToLower();
            Console.Write("Lüften alışveriş yaptığınız günü giriniz (Örnek:Pazar): ");
            string alisverisgünü = Console.ReadLine().ToLower();
            double alisveristutarıilk = alisveristutari;
            if (alisveristutari >= 1001)
            {
                double indirim = alisveristutari * 0.10;
                alisveristutari = alisveristutari - indirim;
                if (yas <= 18)
                {
                    double indirim1 = alisveristutari * 0.10;
                    alisveristutari = alisveristutari - indirim1;
                    if (üyetipi == "gold")
                    {
                        double indirim2 = alisveristutari * 0.05;
                        alisveristutari = alisveristutari - indirim2;
                        if (alisverisgünü == "cumartesi" || alisverisgünü == "pazar")
                        {
                            double indirim3 = alisveristutari * 0.05;
                            alisveristutari = alisveristutari - indirim3;
                            double toplamindirim6 = indirim + indirim1 + indirim2 + indirim3;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Alışveriş tutarınız 1000 TL üzerinde olduğu için %10 indirim kazandınız.\n*Yaşınız 18 ve 18'den küçük olduğu için %10 indirim kazandınız.\n*Gold üye olduğunuz için %5 indirim kazandınız.\n*Haftasonu alışveriş yaptığınız için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim6, alisveristutari);
                        }
                        else
                        {
                            double toplamindirim7 = indirim + indirim1 + indirim2;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Alışveriş tutarınız 1000 TL üzerinde olduğu için %10 indirim kazandınız.\n*Yaşınız 18 ve 18'den küçük olduğu için %10 indirim kazandınız.\n*Gold üye olduğunuz için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim7, alisveristutari);
                        }
                    }
                    else if (üyetipi == "premium")
                    {
                        double indirim4 = alisveristutari * 0.10;
                        alisveristutari = alisveristutari - indirim4;
                        if (alisverisgünü == "cumartesi" || alisverisgünü == "pazar")
                        {
                            double toplamindirim8 = indirim + indirim1 + indirim4;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Alışveriş tutarınız 1000 TL üzerinde olduğu için %10 indirim kazandınız.\n*Yaşınız 18 ve 18'den küçük olduğu için %10 indirim kazandınız.\n*Premium üye olduğunuz için %10 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim8, alisveristutari);
                        }
                        else
                        {
                            double toplamindirim9 = indirim + indirim1 + indirim4;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Alışveriş tutarınız 1000 TL üzerinde olduğu için %10 indirim kazandınız.\n*Yaşınız 18 ve 18'den küçük olduğu için %10 indirim kazandınız.\n*Premium üye olduğunuz için %10 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim9, alisveristutari);
                        }
                    }
                    else
                    {
                        if (alisverisgünü == "cumartesi" || alisverisgünü == "pazar")
                        {
                            double indirim5 = alisveristutari * 0.05;
                            alisveristutari = alisveristutari - indirim5;
                            double toplamindirim10 = indirim + indirim1 + indirim5;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Alışveriş tutarınız 1000 TL üzerinde olduğu için %10 indirim kazandınız.\n*Yaşınız 18 ve 18'den küçük olduğu için %10 indirim kazandınız.\n*Haftasonu alışveriş yaptığınız için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: Standart \n-Alışveriş yaptığınız gün: {1} \n-Alışveriş tutarınız: {2} \n-Yararlandığınız indirim: {3} \n-İndirimli fiyat: {4}", yas, alisverisgünü, alisveristutarıilk, toplamindirim10, alisveristutari);
                        }
                        else
                        {
                            double toplamindirim11 = indirim + indirim1;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Alışveriş tutarınız 1000 TL üzerinde olduğu için %10 indirim kazandınız.\n*Yaşınız 18 ve 18'den küçük olduğu için %10 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: Standart \n-Alışveriş yaptığınız gün: {1} \n-Alışveriş tutarınız: {2} \n-Yararlandığınız indirim: {3} \n-İndirimli fiyat: {4}", yas, alisverisgünü, alisveristutarıilk, toplamindirim11, alisveristutari);
                        }
                    }
                }
                else if (yas >= 65)
                {
                    double indirim6 = alisveristutari * 0.15;
                    alisveristutari = alisveristutari - indirim6;
                    if (üyetipi == "gold")
                    {
                        double indirim7 = alisveristutari * 0.05;
                        alisveristutari = alisveristutari - indirim7;
                        if (alisverisgünü == "cumartesi" || alisverisgünü == "pazar")
                        {
                            double toplamindirim12 = indirim + indirim6 + indirim7;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Alışveriş tutarınız 1000 TL üzerinde olduğu için %10 indirim kazandınız.\n*Yaşınız 65 ve 65'den büyük olduğu için %15 indirim kazandınız.\n*Gold üye olduğunuz için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim12, alisveristutari);
                        }
                        else
                        {
                            double toplamindirim13 = indirim + indirim6 + indirim7;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Alışveriş tutarınız 1000 TL üzerinde olduğu için %10 indirim kazandınız.\n*Yaşınız 65 ve 65'den büyük olduğu için %15 indirim kazandınız.\n*Gold üye olduğunuz için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim13, alisveristutari);
                        }
                    }
                    else if (üyetipi == "premium")
                    {
                        if (alisverisgünü == "cumartesi" || alisverisgünü == "pazar")
                        {
                            double indirim8 = alisveristutari * 0.05;
                            alisveristutari = alisveristutari - indirim8;
                            double toplamindirim14 = indirim + indirim6 + indirim8;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Alışveriş tutarınız 1000 TL üzerinde olduğu için %10 indirim kazandınız.\n*Yaşınız 65 ve 65'den büyük olduğu için %15 indirim kazandınız.\n*Haftasonu alışveriş yaptığınız için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim14, alisveristutari);
                        }
                        else
                        {
                            double toplamindirim15 = indirim + indirim6;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Alışveriş tutarınız 1000 TL üzerinde olduğu için %10 indirim kazandınız.\n*Yaşınız 65 ve 65'den büyük olduğu için %15 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim15, alisveristutari);
                        }
                    }
                    else
                    {
                        if (alisverisgünü == "cumartesi" || alisverisgünü == "pazar")
                        {
                            double indirim9 = alisveristutari * 0.05;
                            alisveristutari = alisveristutari - indirim9;
                            double toplamindirim15 = indirim + indirim6 + indirim9;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Alışveriş tutarınız 1000 TL üzerinde olduğu için %10 indirim kazandınız.\n*Yaşınız 65 ve 65'den büyük olduğu için %15 indirim kazandınız.\n*Haftasonu alışveriş yaptığınız için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: Standart \n-Alışveriş yaptığınız gün: {1} \n-Alışveriş tutarınız: {2} \n-Yararlandığınız indirim: {3} \n-İndirimli fiyat: {4}", yas, alisverisgünü, alisveristutarıilk, toplamindirim15, alisveristutari);
                        }
                        else
                        {
                            double toplamindirim16 = indirim + indirim6;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Alışveriş tutarınız 1000 TL üzerinde olduğu için %10 indirim kazandınız.\n*Yaşınız 65 ve 65'den büyük olduğu için %15 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: Standart \n-Alışveriş yaptığınız gün: {1} \n-Alışveriş tutarınız: {2} \n-Yararlandığınız indirim: {3} \n-İndirimli fiyat: {4}", yas, alisverisgünü, alisveristutarıilk, toplamindirim16, alisveristutari);
                        }
                    }
                }
                else
                {
                    if (üyetipi == "gold")
                    {
                        double indirim22 = alisveristutari * 0.05;
                        alisveristutari = alisveristutari - indirim22;
                        if (alisverisgünü == "cumartesi" || alisverisgünü == "pazar")
                        {
                            double indirim23 = alisveristutari * 0.05;
                            alisveristutari = alisveristutari - indirim23;
                            double toplamindirim = indirim + indirim22 + indirim23;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Alışveriş tutarınız 1000 TL üzerinde olduğu için %10 indirim kazandınız.\n*Gold üye olduğunuz için %5 indirim kazandınız.\n*Haftasonu alışveriş yaptığınız için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim, alisveristutari);
                        }
                        else
                        {
                            double toplamindirim1 = indirim + indirim22;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Alışveriş tutarınız 1000 TL üzerinde olduğu için %10 indirim kazandınız.\n*Gold üye olduğunuz için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim1, alisveristutari);
                        }
                    }
                    else if (üyetipi == "premium")
                    {
                        double indirim24 = alisveristutari * 0.10;
                        alisveristutari = alisveristutari - indirim24;
                        if (alisverisgünü == "cumartesi" || alisverisgünü == "pazar")
                        {
                            double indirim25 = alisveristutari * 0.05;
                            alisveristutari = alisveristutari - indirim25;
                            double toplamindirim2 = indirim + indirim24 + indirim25;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Alışveriş tutarınız 1000 TL üzerinde olduğu için %10 indirim kazandınız.\n*Premium üye olduğunuz için %10 indirim kazandınız.\n*Haftasonu alışveriş yaptığınız için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim2, alisveristutari);
                        }
                        else
                        {
                            double toplamindirim3 = indirim + indirim24;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Alışveriş tutarınız 1000 TL üzerinde olduğu için %10 indirim kazandınız.\n*Premium üye olduğunuz için %10 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim3, alisveristutari);
                        }
                    }
                    else
                    {
                        if (alisverisgünü == "cumartesi" || alisverisgünü == "pazar")
                        {
                            double indirim26 = alisveristutari * 0.05;
                            alisveristutari = alisveristutari - indirim26;
                            double toplamindirim4 = indirim + indirim26;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Alışveriş tutarınız 1000 TL üzerinde olduğu için %10 indirim kazandınız.\n*Haftasonu alışveriş yaptığınız için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: Standart  \n-Alışveriş yaptığınız gün: {1} \n-Alışveriş tutarınız: {2} \n-Yararlandığınız indirim: {3} \n-İndirimli fiyat: {4}", yas, alisverisgünü, alisveristutarıilk, toplamindirim4, alisveristutari);
                        }
                        else
                        {
                            double toplamindirim5 = indirim;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Alışveriş tutarınız 1000 TL üzerinde olduğu için %10 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: Standart \n-Alışveriş yaptığınız gün: {1} \n-Alışveriş tutarınız: {2} \n-Yararlandığınız indirim: {3} \n-İndirimli fiyat: {4}", yas, alisverisgünü, alisveristutarıilk, toplamindirim5, alisveristutari);
                        }
                    }
                }
            }
            else
            {
                if (yas <= 18)
                {
                    double indirim10 = alisveristutari * 0.10;
                    alisveristutari = alisveristutari - indirim10;
                    if (üyetipi == "gold")
                    {
                        double indirim11 = alisveristutari * 0.05;
                        alisveristutari = alisveristutari - indirim11;
                        if (alisverisgünü == "cumartesi" || alisverisgünü == "pazar")
                        {
                            double indirim12 = alisveristutari * 0.05;
                            alisveristutari = alisveristutari - indirim12;
                            double toplamindirim22 = indirim10 + indirim11 + indirim12;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Yaşınız 18 ve 18'den küçük olduğu için %10 indirim kazandınız.\n*Gold üye olduğunuz için %5 indirim kazandınız.\n*Haftasonu alışveriş yaptığınız için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim22, alisveristutari);
                        }
                        else
                        {
                            double toplamindirim23 = indirim10 + indirim11;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Yaşınız 18 ve 18'den küçük olduğu için %10 indirim kazandınız.\n*Gold üye olduğunuz için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim23, alisveristutari);
                        }
                    }
                    else if (üyetipi == "premium")
                    {
                        double indirim13 = alisveristutari * 0.10;
                        alisveristutari = alisveristutari - indirim13;
                        if (alisverisgünü == "cumartesi" || alisverisgünü == "pazar")
                        {
                            double indirim14 = alisveristutari * 0.05;
                            alisveristutari = alisveristutari - indirim14;
                            double toplamindirim24 = indirim10 + indirim13 + indirim14;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Yaşınız 18 ve 18'den küçük olduğu için %10 indirim kazandınız.\n*Premium üye olduğunuz için %10 indirim kazandınız.\n*Haftasonu alışveriş yaptığınız için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\nYaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim24, alisveristutari);
                        }
                        else
                        {
                            double toplamindirim25 = indirim10 + indirim13;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Yaşınız 18 ve 18'den küçük olduğu için %10 indirim kazandınız.\n*Premium üye olduğunuz için %10 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim25, alisveristutari);
                        }
                    }
                    else
                    {
                        if (alisverisgünü == "cumartesi" || alisverisgünü == "pazar")
                        {
                            double indirim15 = alisveristutari * 0.05;
                            alisveristutari = alisveristutari - indirim15;
                            double toplamindirim26 = indirim10 + indirim15;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Yaşınız 18 ve 18'den küçük olduğu için %10 indirim kazandınız.\n*Haftasonu alışveriş yaptığınız için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\nYaşınız: {0} \n-Üye tipiniz: Standart \n-Alışveriş yaptığınız gün: {1} \n-Alışveriş tutarınız: {2} \n-Yararlandığınız indirim: {3} \n-İndirimli fiyat: {4}", yas, alisverisgünü, alisveristutarıilk, toplamindirim26, alisveristutari);
                        }
                        else
                        {
                            double toplamindirim27 = indirim10;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Yaşınız 18 ve 18'den küçük olduğu için %10 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: Standart \n-Alışveriş yaptığınız gün: {1} \n-Alışveriş tutarınız: {2} \n-Yararlandığınız indirim: {3} \n-İndirimli fiyat: {4}", yas, alisverisgünü, alisveristutarıilk, toplamindirim27, alisveristutari);
                        }
                    }
                }
                else if (yas >= 65)
                {
                    double indirim16 = alisveristutari * 0.15;
                    alisveristutari = alisveristutari - indirim16;
                    if (üyetipi == "gold")
                    {
                        double indirim17 = alisveristutari * 0.05;
                        alisveristutari = alisveristutari - indirim17;
                        if (alisverisgünü == "cumartesi" || alisverisgünü == "pazar")
                        {
                            double indirim18 = alisveristutari * 0.05;
                            alisveristutari = alisveristutari - indirim18;
                            double toplamindirim28 = indirim16 + indirim17 + indirim18;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Yaşınız 65 ve 65'den büyük olduğu için %15 indirim kazandınız.\n*Gold üye olduğunuz için %5 indirim kazandınız.\n*Haftasonu alışveriş yaptığınız için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim28, alisveristutari);
                        }
                        else
                        {
                            double toplamindirim29 = indirim16 + indirim17;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Yaşınız 65 ve 65'den büyük olduğu için %15 indirim kazandınız.\n*Gold üye olduğunuz için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim29, alisveristutari);
                        }
                    }
                    else if (üyetipi == "premium")
                    {
                        double indirim19 = alisveristutari * 0.10;
                        alisveristutari = alisveristutari - indirim19;
                        if (alisverisgünü == "cumartesi" || alisverisgünü == "pazar")
                        {
                            double indirim20 = alisveristutari * 0.05;
                            alisveristutari = alisveristutari - indirim20;
                            double toplamindirim30 = indirim16 + indirim19 + indirim20;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Yaşınız 65 ve 65'den büyük olduğu için %15 indirim kazandınız.\n*Premium üye olduğunuz için %10 indirim kazandınız.\n*Haftasonu alışveriş yaptığınız için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim30, alisveristutari);
                        }
                        else
                        {
                            double toplamindirim31 = indirim16 + indirim19;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Yaşınız 65 ve 65'den büyük olduğu için %15 indirim kazandınız.\n*Gold üye olduğunuz için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim31, alisveristutari);
                        }
                    }
                    else
                    {
                        if (alisverisgünü == "cumartesi" || alisverisgünü == "pazar")
                        {
                            double indirim21 = alisveristutari * 0.05;
                            alisveristutari = alisveristutari - indirim21;
                            double toplamindirim32 = indirim16 + indirim21;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Yaşınız 65 ve 65'den büyük olduğu için %15 indirim kazandınız.\n*Haftasonu alışveriş yaptığınız için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: Standart \n-Alışveriş yaptığınız gün: {1} \n-Alışveriş tutarınız: {2} \n-Yararlandığınız indirim: {3} \n-İndirimli fiyat: {4}", yas, alisverisgünü, alisveristutarıilk, toplamindirim32, alisveristutari);
                        }
                        else
                        {
                            double toplamindirim33 = indirim16;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Yaşınız 65 ve 65'den büyük olduğu için %15 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: Standart \n-Alışveriş yaptığınız gün: {1} \n-Alışveriş tutarınız: {2} \n-Yararlandığınız indirim: {3} \n-İndirimli fiyat: {4}", yas, alisverisgünü, alisveristutarıilk, toplamindirim33, alisveristutari);
                        }
                    }
                }
                else
                {
                    if (üyetipi == "gold")
                    {
                        double indirim27 = alisveristutari * 0.05;
                        alisveristutari = alisveristutari - indirim27;
                        if (alisverisgünü == "cumartesi" || alisverisgünü == "pazar")
                        {
                            double indirim28 = alisveristutari * 0.05;
                            alisveristutari = alisveristutari - indirim28;
                            double toplamindirim17 = indirim27 + indirim28;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Gold üye olduğunuz için %5 indirim kazandınız.\nHaftasonu alışveriş yaptığınız için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim17, alisveristutari);
                        }
                        else
                        {
                            double toplamindirim18 = indirim27;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Haftasonu alışveriş yaptığınız için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim18, alisveristutari);
                        }
                    }
                    else if (üyetipi == "premium")
                    {
                        double indirim29 = alisveristutari * 0.10;
                        alisveristutari = alisveristutari - indirim29;
                        if (alisverisgünü == "cumartesi" || alisverisgünü == "pazar")
                        {
                            double indirim30 = alisveristutari * 0.05;
                            alisveristutari = alisveristutari - indirim30;
                            double toplamindirim19 = indirim29 + indirim30;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Premium üye olduğunuz için %10 indirim kazandınız.\n*Haftasonu alışveriş yaptığınız için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim19, alisveristutari);
                        }
                        else
                        {
                            double toplamindirim20 = indirim29;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Premium üye olduğunuz için %10 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: {1} \n-Alışveriş yaptığınız gün: {2} \n-Alışveriş tutarınız: {3} \n-Yararlandığınız indirim: {4} \n-İndirimli fiyat: {5}", yas, üyetipi, alisverisgünü, alisveristutarıilk, toplamindirim20, alisveristutari);
                        }
                    }
                    else
                    {
                        if (alisverisgünü == "cumartesi" || alisverisgünü == "pazar")
                        {
                            double indirim31 = alisveristutari * 0.05;
                            alisveristutari = alisveristutari - indirim31;
                            double toplamindirim21 = indirim31;
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Haftasonu alışveriş yaptığınız için %5 indirim kazandınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: Standart \n-Alışveriş yaptığınız gün: {1} \n-Alışveriş tutarınız: {2} \n-Yararlandığınız indirim: {3} \n-İndirimli fiyat: {4}", yas, alisverisgünü, alisveristutarıilk, toplamindirim21, alisveristutari);
                        }
                        else
                        {
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n*Hiçbir indirimden faydalanamadınız.");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n-Yaşınız: {0} \n-Üye tipiniz: Standart \n-Alışveriş yaptığınız gün: {1} \n-Alışveriş tutarınız: {2}", yas, alisverisgünü, alisveristutarıilk);
                        }
                    }
                }
            }
            Console.WriteLine("\niyi günler. -Mahmut Çekem-");
            Console.ReadKey();
        }
    }
}





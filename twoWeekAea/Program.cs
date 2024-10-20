using System;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1 - Aşağıdaki çıktıyı yazan bir program.");
            Console.WriteLine("2 - Bir adet metinsel, bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız.");
            Console.WriteLine("3 - Rastgele bir sayı üretip, ekrana yazdırınız.");
            Console.WriteLine("4 - Rastgele bir sayı üretip, bunun 3'e bölümünden kalanı ekrana yazdırınız.");
            Console.WriteLine("5 - Kullanıcıya yaşını sorup, 18'den büyükse '+' küçükse '-' yazdıran bir uygulama.");
            Console.WriteLine("6 - Ekrana 10 defa 'Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.' yazan bir uygulama.");
            Console.WriteLine("7 - Kullanıcıdan 2 adet metinsel değer alıp bunların yerlerini değiştiriniz.");
            Console.WriteLine("8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız.");
            Console.WriteLine("9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.");
            Console.WriteLine("10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.");
            Console.WriteLine("11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.");
            Console.WriteLine("12 - Kullanıcıdan sınırsız sayıda sayı alıp, bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.");
            Console.WriteLine("13 - Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.");
            Console.WriteLine("14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.");
            Console.WriteLine("15 - Kullanıcıdan alınan hız ve zaman bilgileriyle, gidilen yolu hesaplayan bir metot yazınız.");
            Console.WriteLine("16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.");
            Console.WriteLine("17 - 'Zaman bir GeRi SayIm' cümlesini alıp, hepsi büyük harf ve hepsi küçük harfle yazdırınız.");
            Console.WriteLine("18 - '    Selamlar   ' metnini bir değişkene atayıp, başındaki ve sonundaki boşlukları siliniz.");
            Console.WriteLine("Lütfen bir soru numarası seçin (1-18) veya çıkmak için 0 girin:");
            //SORULARIN SEÇİMLERİNİN YAPILDIĞI YER
            if (int.TryParse(Console.ReadLine(), out int soruNumarasi))
            {
                if (soruNumarasi == 0)
                {
                    break;
                }

                switch (soruNumarasi)
                {
                    case 1:
                        Soru1();
                        break;
                    case 2:
                        Soru2();
                        break;
                    case 3:
                        Soru3();
                        break;
                    case 4:
                        Soru4();
                        break;
                    case 5:
                        Soru5();
                        break;
                    case 6:
                        Soru6();
                        break;
                    case 7:
                        Soru7();
                        break;
                    case 8:
                        Soru8();
                        break;
                    case 9:
                        Soru9();
                        break;
                    case 10:
                        Soru10();
                        break;
                    case 11:
                        Soru11();
                        break;
                    case 12:
                        Soru12();
                        break;
                    case 13:
                        Soru13();
                        break;
                    case 14:
                        Soru14();
                        break;
                    case 15:
                        Soru15();
                        break;
                    case 16:
                        Soru16();
                        break;
                    case 17:
                        Soru17();
                        break;
                    case 18:
                        Soru18();
                        break;
                    default:
                        Console.WriteLine("Geçersiz soru numarası. Lütfen 1-18 arasında bir sayı girin."); //Hatalı giriş durumunda kullanıcıya uyarı verilir.
                        break;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
            }
        }
    }
    //her soru için ayrı metotlar
    private static void Soru1()
    {
        Console.WriteLine("Merhaba\nNasılsın?\nİyiyim\nSen Nasılsın?");
    }

    private static void Soru2()
    {
        string metinsel = "Merhaba Ben Emre";
        int tamsayi = 45;
        Console.WriteLine($"{metinsel} {tamsayi} yaşındayım.");
    }

    private static void Soru3()
    {
        Random rnd = new Random();
        int sayi = rnd.Next(1, 100);
        Console.WriteLine($"Rastgele Üretilen Sayı: {sayi}");
    }

    private static void Soru4()
    {
        Random rnd = new Random();
        int sayi2 = rnd.Next(1, 100);
        Console.WriteLine($"Rastgele Üretilen Sayı: {sayi2} ve 3'e bölümünden kalan: {sayi2 % 3}");
    }

    private static void Soru5()
    {
        Console.WriteLine("Yaşınızı Giriniz: ");
        if (int.TryParse(Console.ReadLine(), out int yas))
        {
            Console.WriteLine(yas > 18 ? "+" : "-");
        }
        else
        {
            Console.WriteLine("Geçersiz yaş girdisi. Lütfen bir sayı giriniz.");
        }
    }

    private static void Soru6()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");
        }
    }

    private static void Soru7()
    {
        Console.WriteLine("Adınızı Giriniz: ");
        string? ad1 = Console.ReadLine();
        Console.WriteLine("Adınızı Giriniz: ");
        string? ad2 = Console.ReadLine();

        if (ad1 != null && ad2 != null)
        {
            string temp = ad1;
            ad1 = ad2;
            ad2 = temp;
            Console.WriteLine($"Ad1: {ad1} Ad2: {ad2}");
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen tekrar deneyin.");
        }
    }

    private static void Soru8()
    {
        BenDegerDondurmem();
    }

    private static void BenDegerDondurmem()
    {
        Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma.");
    }

    private static int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

    private static void Soru9()
    {
        Console.WriteLine(Topla(5, 6));
    }

    private static void Soru10()
    {
        Console.WriteLine("Kedileri Sever misiniz? (true/false): ");
        string? input = Console.ReadLine();
        if (input != null && bool.TryParse(input, out bool kedileriSeverMisiniz))
        {
            string cevap = kedileriSeverMisiniz ? "Harika" : "Aaa Niye";
            Console.WriteLine(cevap);
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen true veya false giriniz.");
        }
    }

    private static void Soru11()
    {
        Console.WriteLine("Lütfen 3 kişinin yaşlarını giriniz:");
        int yas1 = int.Parse(Console.ReadLine());
        int yas2 = int.Parse(Console.ReadLine());
        int yas3 = int.Parse(Console.ReadLine());

        int enYasli = Math.Max(yas1, Math.Max(yas2, yas3));
        Console.WriteLine($"En yaşlı kişinin yaşı: {enYasli}");
    }

    private static void Soru12()
    {
        Console.WriteLine("Sınırsız sayıda sayı girin (bitirmek için 'q' tuşlayın):");
        int enBuyuk = int.MinValue;
        string? input;
        while ((input = Console.ReadLine()) != "q")
        {
            if (int.TryParse(input, out int sayi))
            {
                if (sayi > enBuyuk)
                {
                    enBuyuk = sayi;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
            }
        }
        Console.WriteLine($"En büyük sayı: {enBuyuk}");
    }

    private static void Soru13()
    {
        Console.WriteLine("İlk ismi girin:");
        string? isim1 = Console.ReadLine();
        Console.WriteLine("İkinci ismi girin:");
        string? isim2 = Console.ReadLine();

        if (isim1 != null && isim2 != null)
        {
            string temp = isim1;
            isim1 = isim2;
            isim2 = temp;
            Console.WriteLine($"İsim1: {isim1}, İsim2: {isim2}");
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen tekrar deneyin.");
        }
    }

    private static bool TekMiCiftMi(int sayi)
    {
        return sayi % 2 == 0;
    }

    private static void Soru14()
    {
        Console.WriteLine("Bir sayı girin:");
        if (int.TryParse(Console.ReadLine(), out int sayi))
        {
            bool sonuc = TekMiCiftMi(sayi);
            Console.WriteLine(sonuc ? "Çift" : "Tek");
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
        }
    }

    private static double GidilenYol(double hiz, double zaman)
    {
        return hiz * zaman;
    }

    private static void Soru15()
    {
        Console.WriteLine("Hızı girin (km/s):");
        double hiz = double.Parse(Console.ReadLine());
        Console.WriteLine("Zamanı girin (saat):");
        double zaman = double.Parse(Console.ReadLine());

        double yol = GidilenYol(hiz, zaman);
        Console.WriteLine($"Gidilen yol: {yol} km");
    }

    private static double DaireAlani(double yaricap)
    {
        return Math.PI * yaricap * yaricap;
    }

    private static void Soru16()
    {
        Console.WriteLine("Yarıçapı girin:");
        double yaricap = double.Parse(Console.ReadLine());

        double alan = DaireAlani(yaricap);
        Console.WriteLine($"Dairenin alanı: {alan}");
    }

    private static void Soru17()
    {
        string cumle = "Zaman bir GeRi SayIm";
        Console.WriteLine(cumle.ToUpper());
        Console.WriteLine(cumle.ToLower());
    }

    private static void Soru18()
    {
        string metin = "    Selamlar   ";
        string temizMetin = metin.Trim();
        Console.WriteLine($"Orijinal: '{metin}'");
        Console.WriteLine($"Temizlenmiş: '{temizMetin}'");
    }
}

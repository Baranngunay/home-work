// 1.soru Switch case ile müşteriden alınan sipariş numarasına göre
// hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.

//while (true)
//{
//    Console.WriteLine();
//    Console.WriteLine("Sipariş numaranızı girin:");
//int siparisNumarasi;

//if (int.TryParse(Console.ReadLine(), out siparisNumarasi))
//{
//    switch (siparisNumarasi)
//    {
//        case 1:
//            Console.WriteLine("Sipariş edilen ürün: Telefon");
//            break;

//        case 2:
//            Console.WriteLine("Sipariş edilen ürün: Laptop");
//            break;

//        case 3:
//            Console.WriteLine("Sipariş edilen ürün: Tablet");
//            break;

//        case 4:
//            Console.WriteLine("Sipariş edilen ürün: Akıllı Saat");
//            break;

//        default:
//            Console.WriteLine("Geçersiz sipariş numarası");
//            break;
//    }
//}
//else
//{
//    Console.WriteLine("Geçersiz bir sayı girişi yaptınız.");
//}
//}

//2. soru kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş
//tutarını hesaplayan bir algoritma yazınız.(döngü için for döngüsü kullanınız)

//Console.Write("Kaç ürün almak istiyorsunuz?: ");
//int urunAdedi;

//if (int.TryParse(Console.ReadLine(), out urunAdedi) && urunAdedi > 0)
//{
//    double toplamTutar = 0;

//    for (int i = 1; i <= urunAdedi; i++)
//    {
//        Console.Write(i + ". Ürün fiyatını girin: ");
//        double urunFiyati;

//        if (double.TryParse(Console.ReadLine(), out urunFiyati) && urunFiyati >= 0)
//        {
//            toplamTutar += urunFiyati;
//        }
//        else
//        {
//            Console.WriteLine("Geçersiz fiyat girişi. Lütfen pozitif bir sayı girin.");
//            i--;
//        }
//    }

//    Console.WriteLine("Toplam alışveriş tutarı: {toplamTutar:C}");
//}
//else
//{
//    Console.WriteLine("Geçersiz ürün adedi girişi. Lütfen pozitif bir sayı girin.");
//}

//Console.ReadLine();

// 3. soru 3- Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.

//Do-While Döngüsü döngünün şartına bakmaksızın döngünün en az bir kere başlatılmasını sağlayan döngüdür
//int i = 5;

//do
//{
//    Console.WriteLine(i);
//    i++;

//} while (i < 4);

//Console.ReadLine();

//While döngüsü döngünün şartları göz önüne alınarak devam eden veya şart sağlanmıyorsa hiç başlamayan döngüdür.
//int i = 0;

//while (i < 10)
//{

//    Console.WriteLine(i);

//    i++;

//}

//4. soru Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.

//Console.WriteLine("Sayı giriniz");
//int sayi = Convert.ToInt32(Console.ReadLine());
//int toplam = 0;
//for (int i = 1; i < sayi; i++)
//{
//    if (sayi % i == 0)
//    {
//        toplam = toplam + i;
//    }
//}
//if (toplam == sayi)
//{
//    Console.WriteLine(sayi + " sayısı Mükemmel Sayıdır");
//}
//else
//{
//    Console.WriteLine(sayi + " sayısı Mükemmel Sayı Değildir");
//}
//Console.ReadLine();

using System.Diagnostics.Metrics;

//Clone(): String değişkeni ile oluşturduğumuz içeriğin bir klonunu oluşturarak kopyasını çıkartır.

//string metin = "BaranGunay";
//string cmetin = (string)metin.Clone();
//Console.WriteLine(cmetin);

//Contains(): Metot ile belirtilen karakter veya cümlenin string değişkeni içerisinde var olup olmama durumuna göre kontrol sağlar. Eğer varsa True yoksa False şeklinde geri döndürür.

//string metin= "EsmanurKilic";
//string cmetin = "Kilic;
//Console.WriteLine(metin.Contains(cmetin));

//3.IndexOf(): String değişkeni içerisinde metot ile belirtilen karakteri arar ve değişkendeki konumunu geri gönderir.

//string metin= "EsmanurKilic";
//Console.WriteLine(metin.IndexOf('u'));

//ToLower(): String değişkeni içerisinde ki metnin tüm karakterlerini küçük harf yapar.

//string metin= "EsmanurKilic";
//Console.WriteLine(metin.ToLower());

//ToUpper(): String değişkeni içerisinde ki metnin tüm karakterlerini büyük harf yapar.

//string metin= "EsmanurKilic";
//Console.WriteLine(metin.ToUpper());

//Insert(): String değişkeni içerisinde ki metnin metot ile belirlenen pozisyonuna ekleme yapar.

//string metin= "Esmanur";
//string metin2 = "Kilic";
//Console.WriteLine(metin.Insert(7, metin2));

//Remove(): String değişkeni içeresinde ki metin üzerinde silme işlemleri uygular. İki adet kullanım şekli vardır;

//Silinmesi istenen yerin başlangıç indeksi metotta belirtilir ve metinden başlangıç indeksinden sonra ki kısmı silinir.
//string metin= "EsmanurKilic";
//Console.WriteLine(metin.Remove(7));
//metin değişkeninden 7. indeksten başlayarak sonuna kadar silme işlemi gerçekleşir ve ekrana “Esmanur” yazdırır.

//2. Belli bir kısmın silinmesi istenme durumunda başlangıç indeksi ve nereye kadarlık kısmın silineceği metotta belirtilir bu sayede belirtilen değer kadar silme yapılmış olur.

//string metin= "EsmanurKilic";
//Console.WriteLine(metin.Remove(7, 3));

//Replace(): String değişkeni içerisindeki metni veya karakteri başka bir metin veya karakter ile değiştirmek için kullanılır.

//string metin= "EsmanurKilic";
//Console.WriteLine(metin.Replace("Esmanur", "Kilic"));

//Split(): String değişkeni içerisindeki metni belirtilen karaktere göre parçalara bölme işlemi yapar.

//string metin= "Esmanur,Kilic,1997";
//string[] dizi = metin.Split(',');

//for (int i = 0; i < dizi.Length; i++)
//{
//    Console.WriteLine(dizi[i]);
//}

//Trim(): String değişkeni içerisinde ki metnin başlangıcındaki ve bitişindeki boşlukları kaldırır.

//string metin= "   EsmanurKilic   ";
//Console.WriteLine(metin.Trim());

//Substring(): String değişkeni içerisinde ki metinden belirli bir bölümü almak için kullanılır. İki adet kullanım şekli vardır;

//1.İstenen bölümün başlangıç indeksi metotta belirtilir ve metinden başlangıç indeksinden sonuna kadar olan tüm kısım alınır.

//string metin= "EsmanurKilic";
//Console.WriteLine(metin.Substring(7));
//metin değişkeni içerisindeki metnin 7. indeksinden itibaren sonuna kadar devam eden kısmı alır ve ekrana “Kilic” yazar.

//2.İstenen bölümün başlangıç indeksi ve alınmak istenen karakter sayısı metotta belirtilir ve metinden başlangıç indeksinden başlayarak belirtilen karakter sayısı kadarki kısım alınır.

//string metin= "EsmanurKilic";
//Console.WriteLine(metin.Substring(7, 3));

//Length; String değişkeni içerisinde ki metnin uzunluğunu geri döndürür.

//string metin= "EsmanurKilic ";
//Console.WriteLine(metin.Length);
//metin değişkeni içerisindeki metnin uzunluğunu bulur ve ekrana “12” yazdırır.

//PadRight(); String değişkeni içerisindeki metine metotta belirtilen karakteri istenen sayı kadar metinin sağına ekleme işlemi yapar.

//string metin= "EsmanurKilic ";
//Console.WriteLine(metin.PadRight(14, 'a');
//metin değişkeni içerisindeki metinin sağına verilen sayıdan metnin uzunluğu çıkartılarak o kadar istenen karakter eklenir. Yani 2 tane ‘a’ karakteri eklenir ve ekrana “EsmanurKilicaa” yazar.

//PadLeft(); String değişkeni içerisindeki metine metotta belirtilen karakteri istenen sayı kadar metinin soluna ekleme işlemi yapar.

//string metin= "EsmanurKilic";
//Console.WriteLine(metin.PadLeft(14, 'a');

//6 - Bir mağazada alınan ürünün fiyatı 300 tl üzerinde ise 50 tl olan kargo ücreti alınmamaktadır.
//Ürünün fiyatı girildiğinde toplam ödemesi gereken tutarı gösteren programı yazınız.

//Console.Write("Ürün fiyatını girin: ");
//double urunFiyati;

//if (double.TryParse(Console.ReadLine(), out urunFiyati) && urunFiyati >= 0)
//{
//    double kargoUcreti = (urunFiyati >= 300) ? 0 : 50;
//    double toplamTutar = urunFiyati + kargoUcreti;

//    Console.WriteLine($"Ürün Fiyatı: {urunFiyati:C}");
//    Console.WriteLine($"Kargo Ücreti: {kargoUcreti:C}");
//    Console.WriteLine($"Toplam Ödeme: {toplamTutar:C}");
//}
//else
//{
//    Console.WriteLine("Geçersiz fiyat girişi. Lütfen pozitif bir sayı girin.");
//}
//Console.ReadLine();

//7 - iki ürünün kullanıcı tarafından fiyatı girildiğinde toplam fiyat 500 tl'den fazla ise
//2.üründen %40 indirim yaparak ödenecek tutarı gösteren uygulamayı yazınız.

//Console.Write("1. Ürün fiyatını girin: ");
//double urun1Fiyati;

//if (double.TryParse(Console.ReadLine(), out urun1Fiyati) && urun1Fiyati >= 0)
//{
//    Console.Write("2. Ürün fiyatını girin: ");
//    double urun2Fiyati;

//    if (double.TryParse(Console.ReadLine(), out urun2Fiyati) && urun2Fiyati >= 0)
//    {
//        double toplamFiyat = urun1Fiyati + urun2Fiyati;

//        if (toplamFiyat > 500)
//        {

//            double indirimMiktari = urun2Fiyati * 0.40;
//            double indirimliUrun2Fiyati = urun2Fiyati - indirimMiktari;

//            double odenecekTutar = urun1Fiyati + indirimliUrun2Fiyati;

//            Console.WriteLine($"Toplam Fiyat: {toplamFiyat:C}");
//            Console.WriteLine($"2. Ürün İndirimli Fiyatı: {indirimliUrun2Fiyati:C}");
//            Console.WriteLine($"Ödenecek Tutar: {odenecekTutar:C}");
//        }
//        else
//        {
//            Console.WriteLine($"Toplam Fiyat: {toplamFiyat:C}");
//            Console.WriteLine("İndirim uygulanmamıştır.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Geçersiz 2. ürün fiyatı girişi. Lütfen pozitif bir sayı girin.");
//    }
//}
//else
//{
//    Console.WriteLine("Geçersiz 1. ürün fiyatı girişi. Lütfen pozitif bir sayı girin.");
//}
//Console.ReadLine();

//8 - 1 - 200 arası içinde 3'e veya 5'e tam bölünebilen sayıları listeleyen ve kaç adet olduğunu yazdıran programı yazınız.

//int sayiAdedi = 0;

//Console.WriteLine("1 ile 200 arasında 3'e veya 5'e tam bölünebilen sayılar:");
//for (int i = 1; i <= 200; i++)
//{
//    if (i % 3 == 0 || i % 5 == 0)
//    {
//        Console.WriteLine(i);
//        sayiAdedi++;
//    }
//}

//Console.WriteLine($"Toplam bölünebilen sayı adedi: {sayiAdedi}");

//// Console uygulamasının penceresini açık tutmak için bir tuşa basılmasını bekleyin.
//Console.ReadLine();


using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Bir çalışanın aylık maaşı 8.500 TL’dir. Anlaşması dahilinde çalıştığı her yıl için maaşına %15 zam alacaktır.  Bu kişinin 5 yıl sonraki maaşını hesaplayan programı hazırlayınız.

        //double maas = 8500;

        //double maas1,maas2, maas3, maas4, maas5;

        //maas1 = maas * 1.15;

        //maas2 = maas1 * 1.15;

        //maas3 = maas2 * 1.15;

        //maas4 = maas3 * 1.15;

        //maas5 = maas4 * 1.15;

        //Console.WriteLine("Mevcut maaş miktarı: "+maas);
        //Console.WriteLine("1. yılda alınan zamlı maaş: " + maas1);
        //Console.WriteLine("2. yılda alınan zamlı maaş: " + maas2);
        //Console.WriteLine("3.yılda alınan zamlı maaş: " + maas3);
        //Console.WriteLine("4. yılda alınan zamlı maaş: " + maas4);
        //Console.WriteLine("5. yılda alınan zamlı maaş: " + maas5);

        #endregion

        #region Kullanıcıdan ekrandan 1 ile 10 arasında bir değer girmesini isteyiniz ve bu girilen değere göre kenarları “*” karakterlerinden oluşan bir kare şeklini ekrana çizdiriniz.






        #endregion
        #region Klavyeden girilen sayıdan başlayıp 1’e kadar sayıları 5’er 5’er azaltarak ekrana yazdıran programı hazırlayınız. (Tabii ki gerekli kontrolleri yaparaktan...)

        //Console.WriteLine("lütfen bir sayı giriniz: ");
        //int sayi = Convert.ToInt32(Console.ReadLine()); 



        //for(int i = sayi; i >=1 ; i=i-5)

        //{

        //    Console.WriteLine(i);
        //}      



        #endregion

        #region Klavyeden 0 (sıfır) değeri girilinceye kadar klavyeden okutulan değerlerin ortalamasını hesaplayıp ekrana yazan programı yazınız

        //Console.WriteLine("Sayı giriniz: ");
        //int sayi = Convert.ToInt32(Console.ReadLine());
        //int toplam = sayi; //sor
        //int i = 0, sayac = 1; //sor

        //while (sayi!=0) 
        //{
        //    Console.WriteLine("sayi giriniz: ");
        //    sayi= Convert.ToInt32(Console.ReadLine());  
        //    toplam += sayi;

        //    if(sayi!=0)
        //    {
        //        sayac++;    
        //    }

        //}


        //Console.WriteLine("girilen sayıların ortalaması= {0}", toplam/sayac);

        #endregion


        #region Kullanıcıdan alınan 2 sayıya yine kullanıcıdan alınacak işlem seçimine göre dört işlem uygulayan program kodunu yazınız. (Toplama için T veya t, Çıkartma için E/e, Çarpma için Ç/ç, Bölme için B/b kodlarını kullanınız. Eğer bu işlem kodları dışındaki girişler için hatalı giriş yapıldığına dair bir mesaj verdirebilirsiniz)
        //double sayi1, sayi2;
        //Console.WriteLine("Lütfen 1. sayıyı giriniz: ");
        //sayi1 = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("lütfen 2. sayıyı giriniz: ");
        //sayi2 = Convert.ToDouble(Console.ReadLine());


        //Console.WriteLine("lütfen yapmak istediğiniz işlemi yazınız: ");
        //Console.WriteLine("toplama:t, çıkarma:e, çarpma:ç, bölme:b"); // harf için char ı unutmaa ve harfleri tek tırnaklı olmalı
        //char islem = Convert.ToChar(Console.ReadLine());

        //if (islem == 't')
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}
        //else if (islem == 'e')
        //{
        //    Console.WriteLine(sayi1 - sayi2);

        //}
        //else if (islem == 'ç')
        //{
        //    Console.WriteLine(sayi1 * sayi2);
        //}
        //else if (islem == 'b')
        //{
        //    Console.WriteLine(sayi2 / sayi1);
        //}
        //else
        //{
        //    Console.WriteLine("hatali işlem.");
        //}






















        #endregion

        #region Bir mağaza müşterilerine yaptıkları alışveriş tutarına göre indirim yapmaktadır. 200 TL ye kadar olan alışverişler için %10, 200-400 TL arası olan alışverişler için %15, 400 TL den fazla olan alışverişler için %20 indirim uygulamaktadır. Buna göre bir kişinin ödeyeceği net miktarı hesaplayan programın kodunu yazınız.



















        #endregion























        Console.ReadKey();

    }
}
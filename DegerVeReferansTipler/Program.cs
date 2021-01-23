using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // belekte iki yerimiz var stack ve heap
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 = 30 olur çünkü buna deger tipler deniyor int, decimal, float, bool gibi deger tipler sadece steakde calısıyor

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = 999 olur çünkü buna referans tipler deniyor  array, class, interface tiplerde heap calısıyor.
            //new diye yaptığın tanımlamalar bellekte heap olusturuyor dolayısıyla sen sayilar1i sayilar2ye esitlediğin zaman 
            //artık sayilar1i heapdeki sayilar2ye eşitlemiş oluyorsun 
            //sayılar2nin ilk elemanını 999a cektiğinde bu degişikliği heap de yapmış oldun sayilar1 de heape baglı oldugu icin sayilar1[0] = 999 oluyor
            //peki sayilar1e tanımladığın heap ne oldu? .netin garbage disposalı bir süre sonra bunu temizliyor cunku baglı oldugu yer yok


        } 
    }
}

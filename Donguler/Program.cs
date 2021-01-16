using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        { 
            for (int i = 1; i < 10; i++)//i++ demek yerine i=i+1 diyebilirsin
            {
                Console.WriteLine(i);
                //bunu abapda yazsan 
                //data i type i. i = 1.
                //while i < 10.
                //i = i + 1.
                //write i.
                //endwhile.
            }
            for (int i = 1; i <= 10; i += 2)//i+=2 demek yerine i=i+2 diyebilirsin  
            {
                Console.WriteLine(i);
                //bunu abapda yazsan 
                //data i type i. i = 1.
                //while i le 10.
                //i = i + 2.
                //write i.
                //endwhile.
            }

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java";

            //array - dizi
            // phytondaki list 

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                                              "Programlamaya Başlangıç için Temel Kurs",
                                              "Java",
                                              "Phyton",
                                              "C#",
                                            };

            for (int i = 0; i<kurslar.Length; i++) //.lenghtveri sayısını dinamik okumak için
            {
                Console.WriteLine(kurslar[i]);
            } 
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)//kursları tek tek dolaş demek abap-loopa yakın bir anlam, string kurs yerine string xyz falan da diyebilirsin
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");



        }
    }
}

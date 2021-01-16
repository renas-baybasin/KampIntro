using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // tanımlayacağın seyin onune veri tipini yazmak zorundasın
            // abap gibi tek tırnak yapma
            // her satır bitince noktalı vırgul koy
            //DO NOT REPEAT YOURSELF diyelimki aşağıdaki gibi yazdın :
            //Console.WriteLine("Kategori");
            //Console.WriteLine("Kategori");
            //bu metni değiştirirsen her yerde değiştirmek zorunda kalırsın 
            //hayatta hardcode yazmak bu yuzden yasak demek ki :)

            //değer tutucu, alias
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000; //tam sayıları tutar belli bir yere kadar tutar
            double faizOrani = 1.45; // ondalıklı sayılar için 
            bool sistemeGirisYapmisMi = true; //javada boolean deniyor, bu ikili bir durum mesela sisteme log on oldu mu olmadı mı? true ya da false olan bir değer
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun) 
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun) 
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }



            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu"); 
            }


            Console.WriteLine(kategoriEtiketi); 
        }
    }
} 

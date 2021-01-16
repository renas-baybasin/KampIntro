using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Id = 12345;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 10;

            Urun urun2 = new Urun();
            urun2.Id = 54321;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 32;

            Urun[] urunler = new Urun[] {urun1, urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Id);
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("--------------------"); 
            }

            Console.WriteLine("----------METHODLAR----------");
            // cw yazıp tab tab yaparsan direkt console.writeline yapar

            //insatnce - örnek 
            SepetManager sepetManager = new SepetManager();
            //foreach (Urun urun in urunler)
            //{
            //    sepetManager.Ekle(urun);
            //}

            //encapsulation
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            //sepetManager.Ekle(); 

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);




        }
    }
}



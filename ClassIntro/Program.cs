using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Renas";
            int yas = 24;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 57;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);


            //string[] kurslar = new string[] { }; //önceki böyleydi
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var ders in kurslar) //ya da foreach (Kurs ders in kurslar) dersin
            {
                Console.WriteLine("");
                Console.WriteLine(ders.KursAdi + " : " + ders.Egitmen);
                Console.WriteLine("İzlenme Oranı : " + ders.IzlenmeOrani);
                Console.WriteLine("");
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}

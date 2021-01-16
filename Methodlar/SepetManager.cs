using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    //manager, service, dal, controller gibi bir seyle bitiyorsa = bu class bir operasyon tutuyordur demek
    class SepetManager
    {
        //naming convention public voidden sonra methodunun adı buyuk harfle basla
        //c# ta normal parantez görürsen anla ki orda bir method calısıyor
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Id + "/" + urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);

        }

    }
}

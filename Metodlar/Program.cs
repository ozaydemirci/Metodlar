using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //classlar kolaylık sağlar düzene sokar ve özellik tutar
            Urun urun1 = new Urun();//class örneği(ürün tipinde ürün)
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2 };//diziler çoğul isimlendirilir.

            foreach (Urun urun in urunler) // urunler tek tek gezerek ekrana basıyor.ortadaki urun gezerken süslü parantezde urun kadar döner yani takma isim.baştaki urun ise veri tipi, tip güvenliği olduğundan  
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
            }

            Console.WriteLine();

            Console.WriteLine("-------------METODLAR-------------");

            // instance- örnek
            // encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            // Buradan imzaya uyuyoruz
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,1);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,2);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuz", 12,3);
        }
    }
}
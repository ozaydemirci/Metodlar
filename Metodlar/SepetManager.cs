using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class SepetManager // manager görürsek operasyon tutuyordur.
    {
        // naming concention syntax
        // olaylar metodlar ile gerçekleşir 
        public void Ekle(Urun urun) 
        // bunun sayesinde Urunden urunlere ulaşırız ve burası imza oluyor
        // Urun-tipi ve özellikleri çekiyoruz, urun-isimlendirme
        {

            Console.WriteLine("Tebrikler! Sepete Eklendi: " + urun.Adi);
            

            
        }
        public void Ekle2(string urunAdi, string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi: " + urunAdi);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
     class Urun
    {   
        //Propert- Özellik bunlar
        public int Id { get; set; }//datayı diğerinden ayırt etmek için kullanılır.
        public string Adi { get; set; }

        public double Fiyati { get; set; }

        public string Aciklama { get; set; }

        public int StokAdedi { get; set; }


    }
}

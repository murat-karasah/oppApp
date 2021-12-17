using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppApp
{
   public class Ogrenci
    {
        public int  Id
        {
            get; // db veya farklı veri kaynağını programcıya gösterir
            set; // dış dünyadan alınan datanın private olarak saklanan field içerisine atamadğı fısım
        }
        public string ad
        {
            get; // db veya farklı veri kaynağını programcıya gösterir
            set; // dış dünyadan alınan datanın private olarak saklanan field içerisine atamadğı fısım
        }
        public string soyad
        { get;
            set;
        }

        public string dogumYeri
        {
            get;
            set;
        }
        public DateTime dogumTarihi
        {
            get;
            set;
        }

        public DateTime kursBitisTarihi
        {
            get;
            set;
        }
    }
}

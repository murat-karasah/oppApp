using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppApp
{
    public class DUrret
    {

        string[] Adlar = { "gül", "büşra", "semih", "şahin", "eda", "zeynep" };
        string[] Soyadlar = { "yılmaz", "şen", "muştu", "mert", "bal" };
        string[] Sehirler = { "İstanbul", "Ankara", "Çanakkale", "Adana", "İzmir", "Muğla" };
        static Random rnd = new Random();
        public string GetName()
        {
            int sayi = rnd.Next(0, Adlar.Length);
            return Adlar[sayi];
        }
        public string GetSurName()
        {
            int sayi = rnd.Next(0, Soyadlar.Length);
            return Soyadlar[sayi];
        }

        public string GetCity()
        {
            int sayi = rnd.Next(0, Sehirler.Length);
            return Sehirler[sayi];
        }

        public DateTime GetBackDate(int year)
        {
            year = -1 * rnd.Next(0, year);
            return DateTime.Now.AddYears(year);
        }

        public DateTime ForwadDate(int year)
        {
            year = rnd.Next(0, year);
            return DateTime.Now.AddYears(year);
        }
    }
}

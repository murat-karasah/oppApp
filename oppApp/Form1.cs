using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oppApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getir_Click(object sender, EventArgs e)
        {
            List<Ogrenci> olist = new List<Ogrenci>();
            for (int i = 1; i < 100; i++)
            {
                
                Ogrenci ogr = new Ogrenci();
                DUrret d = new DUrret();         
                ogr.Id = i;
                ogr.ad = d.GetName();
                ogr.soyad = d.GetSurName();
                ogr.dogumYeri = d.GetCity();
                ogr.dogumTarihi = d.GetBackDate(28);
                ogr.kursBitisTarihi = d.ForwadDate(3);
                olist.Add(ogr);
            }

            dataGridView1.DataSource = olist;

        }
    }
}

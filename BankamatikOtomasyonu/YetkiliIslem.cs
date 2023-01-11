using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankamatikOtomasyonu
{
    public partial class YetkiliIslem : Form
    {
        public YetkiliIslem()
        {
            InitializeComponent();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void btkekle_Click(object sender, EventArgs e)
        {
            MusteriEkle musteriEkle = new MusteriEkle();
            musteriEkle.Show();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            MusteriAra musteriAra = new MusteriAra();
            musteriAra.Show();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            MusteriGuncelle musteriGuncelle = new MusteriGuncelle();
            musteriGuncelle.Show();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            MusteriSil musteriSil = new MusteriSil();
            musteriSil.Show();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            MusteriListele musteriListele = new MusteriListele();
            musteriListele.Show();
        }
    }
}

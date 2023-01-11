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
    public partial class MusteriIslem : Form
    {
        public MusteriIslem()
        {
            InitializeComponent();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void MusteriIslem_Load(object sender, EventArgs e)
        {
            lbladsoyad.Text = Form1.adSoyad;
            lblhesapno.Text = Form1.mId.ToString();
        }

        private void btnparacek_Click(object sender, EventArgs e)
        {
            ParaCek paraCek = new ParaCek();
            paraCek.Show();
        }

        private void btnparayatir_Click(object sender, EventArgs e)
        {
            ParaYatır paraYatır = new ParaYatır();
            paraYatır.Show();
        }

        private void btnbakiye_Click(object sender, EventArgs e)
        {
            BakiyeGoruntulame bakiyeGoruntulame = new BakiyeGoruntulame();
            bakiyeGoruntulame.Show();
        }

        private void btnhavale_Click(object sender, EventArgs e)
        {
            HavaleEFT havaleEFT = new HavaleEFT();
            havaleEFT.Show();
        }

        private void btnsifredegis_Click(object sender, EventArgs e)
        {
            SifreDegistirme sifreDegistirme = new SifreDegistirme();
            sifreDegistirme.Show();
        }

        private void btnhesaphareket_Click(object sender, EventArgs e)
        {
            HesaplHareketleri hesaplHareketleri = new HesaplHareketleri();
            hesaplHareketleri.Show();
        }
    }
}

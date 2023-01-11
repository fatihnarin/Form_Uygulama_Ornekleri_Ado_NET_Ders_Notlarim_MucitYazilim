using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeUygulamasi
{
    public partial class Form1 : Form
    {
        int cay = 0, kahve = 0, kola = 0, su = 0;

        private void btnkolaarti_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(lblkola.Text);
            sayi++;
            kola = sayi;
            lblkola.Text = kola.ToString();
        }

        private void btnsuarti_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(lblsu.Text);
            sayi++;
            su = sayi;
            lblsu.Text = su.ToString();
        }

        private void btncayeksi_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(lblcay.Text);
            if (cay > 0)
            {
                sayi--;
                cay = sayi;
                lblcay.Text = cay.ToString();
            }
        }

        private void btnkahveeksi_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(lblkahve.Text);
            if (kahve > 0)
            {
                sayi--;
                kahve = sayi;
                lblkahve.Text = kahve.ToString();
            }

        }

        private void btnkolaeksi_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(lblkola.Text);
            if (kola > 0)
            {
                sayi--;
                kola = sayi;
                lblkola.Text = kola.ToString();
            }
        }

        private void btnsueksi_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(lblsu.Text);
            if (su > 0)
            {
                sayi--;
                su = sayi;
                lblsu.Text = su.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format(" Toplam Sipariş Adetleri \n Çay : {0} \n Kahve : {1}\n Kola : {2} \n Su : {3} \n",cay,kahve,kola,su));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cay = 0;
            kola = 0;
            su = 0;
            kahve = 0;

            lblcay.Text = "0";
            lblkola.Text = "0";
            lblkahve.Text = "0";
            lblsu.Text = "0";
        }

        private void btnkahvearti_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(lblkahve.Text);
            sayi++;
            kahve = sayi;
            lblkahve.Text = kahve.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btncayarti_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(lblcay.Text);
            sayi++;
            cay = sayi;
            lblcay.Text = cay.ToString();
        }
    }
}

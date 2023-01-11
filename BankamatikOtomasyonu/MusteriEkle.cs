using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankamatikOtomasyonu
{
    public partial class MusteriEkle : Form
    {
        SqlConnection con = new SqlConnection("server=.; initial catalog=BankamatikOtomasyonu; integrated security=sspi");

        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Musteriler (tcNo,adSoyad,adres,telefon,sifre,bakiye,durum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", con);
            komut.Parameters.AddWithValue("@p1",txttcno.Text);
            komut.Parameters.AddWithValue("@p2",txtadsoyad.Text);
            komut.Parameters.AddWithValue("@p3",txtadres.Text);
            komut.Parameters.AddWithValue("@p4",txttel.Text);
            komut.Parameters.AddWithValue("@p5",txttcno.Text);
            komut.Parameters.AddWithValue("@p6",txtbakiye.Text);
            komut.Parameters.AddWithValue("@p7",1);

            if (txttcno.Text=="" || txtadsoyad.Text == "" || txttel.Text == "" || txtbakiye.Text == "" ||txtadres.Text == "")
            {
                MessageBox.Show("Tüm alanları doldurunuz!!!");
            }
            else
            {
                con.Open();
                int sonuc = komut.ExecuteNonQuery();
                con.Close();
                if (sonuc == 1)
                {
                    MessageBox.Show("Musteri kaydı yapıldı");
                }
                else
                {
                    MessageBox.Show("Müşteri kaydedilemdi");
                }
            }
           
            

            txttcno.Text = "";
            txttel.Text = "";
            txtbakiye.Text = "";
            txtadsoyad.Text = "";
            txtadres.Text = "";
        }
    }
}

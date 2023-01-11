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
    public partial class MusteriGuncelle : Form
    {
        SqlConnection con = new SqlConnection("server=.; initial catalog=BankamatikOtomasyonu; integrated security=sspi");

        public MusteriGuncelle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Musteriler where Id=@p1 or TcNo=@p2", con);
            komut.Parameters.AddWithValue("@p1", txtaidtcara.Text);
            komut.Parameters.AddWithValue("@p2", txtaidtcara.Text);
            con.Open();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                txtid.Text = dr["ID"].ToString();
                txttcno.Text = dr["TcNo"].ToString();
                txtadsoyad.Text = dr["AdSoyad"].ToString();
                txtadres.Text = dr["Adres"].ToString();
                txttel.Text = dr["Telefon"].ToString();
                txtbakiye.Text = dr["Bakiye"].ToString();
            }
            else
            {
                MessageBox.Show(txtaidtcara.Text + "Nolu kayıt bulunamadı!!!");
                txtid.Text = "";
                txttcno.Text = "";
                txtadsoyad.Text = "";
                txtadres.Text = "";
                txttel.Text = "";
                txtbakiye.Text = "";

            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Musteriler set AdSoyad=@p1, Adres=@p2, Telefon=@p3 where Id='" + txtid.Text + "' or TcNo='" + txttcno.Text + "'", con);
            komut.Parameters.AddWithValue("@p1", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@p2", txtadres.Text);
            komut.Parameters.AddWithValue("@p3", txttel.Text);
            con.Open();
            try
            {
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc == 1)
                    MessageBox.Show("Guncelleme Yapıldı");
                else
                    MessageBox.Show("Guncelleme Yapılamadı!!!");
            }
            catch (Exception)
            {

                MessageBox.Show("Veritabanına bağlanılamadı!!!");
            }
            con.Close();
            txtaidtcara.Text = "";
            txtid.Text = "";
            txttcno.Text = "";
            txtadsoyad.Text = "";
            txtadres.Text = "";
            txttel.Text = "";
            txtbakiye.Text = "";

        }
    }
}

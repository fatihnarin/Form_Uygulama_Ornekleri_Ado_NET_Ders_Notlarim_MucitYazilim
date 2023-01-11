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
    public partial class MusteriSil : Form
    {
        SqlConnection con = new SqlConnection("server=.; initial catalog=BankamatikOtomasyonu; integrated security=sspi");

        public MusteriSil()
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
            DialogResult dr= MessageBox.Show("Müşteri Kaydını Silme İstediğinize Emin misiniz","Evet Dersen Kalıcı Olarak Silinir!!!",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dr==DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete Musteriler where Id=@p1 or TcNo=@p2", con);
                komut.Parameters.AddWithValue("@p1", txtid.Text);
                komut.Parameters.AddWithValue("@p2", txttcno.Text);
                con.Open();
                try
                {
                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc == 1)
                        MessageBox.Show("Silme İşlemi Yapıldı");
                    else
                        MessageBox.Show("Silme İşlemi Yapılamadı!!!");
                }
                catch (Exception)
                {

                    MessageBox.Show("Veritabanına bağlanılamadı!!!");
                }
                con.Close();
            }


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

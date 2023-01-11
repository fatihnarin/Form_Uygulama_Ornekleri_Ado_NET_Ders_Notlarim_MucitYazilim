using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankamatikOtomasyonu
{
    public partial class HavaleEFT : Form
    {
        SqlConnection con = new SqlConnection("server=.; initial catalog=BankamatikOtomasyonu; integrated security=sspi");

        public HavaleEFT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sayi = float.Parse(txtmiktar.Text);
            int aliciNo = int.Parse(txtno.Text);

            try
            {
                SqlCommand komut1 = new SqlCommand("select * from Musteriler where Id=@p1", con);
                komut1.Parameters.AddWithValue("@p1", txtno.Text);
                con.Open();
                SqlDataReader dr = komut1.ExecuteReader();
                if (dr.Read())
                {
                    con.Close();
                    if (sayi > Form1.mBakiye)
                    {
                        MessageBox.Show("Yetersiz bakiye");
                    }
                    else if (sayi < 5)
                    {
                        MessageBox.Show("En az 5 tl Havale/EFT Yapılabilir");
                    }
                    else
                    {
                        con.Open();
                        SqlCommand komut = new SqlCommand("update Musteriler set Bakiye-=@p1 where Id=@p2", con);
                        komut.Parameters.AddWithValue("@p1", sayi);
                        komut.Parameters.AddWithValue("@p2", Form1.mId);
                        int sonuc = komut.ExecuteNonQuery();

                        SqlCommand komut2 = new SqlCommand("update Musteriler set Bakiye+=@p1 where Id=@p2", con);
                        komut2.Parameters.AddWithValue("@p1", sayi);
                        komut2.Parameters.AddWithValue("@p2", aliciNo);
                        int sonuc2 = komut2.ExecuteNonQuery();
                        con.Close();
                        if (sonuc == 1 && sonuc2 == 1)
                        {
                            HareketKaydet.kaydet(Form1.mId, (sayi + " TL "+aliciNo +" nolu hesaba  Havale/EFT yapıldı"));
                            HareketKaydet.kaydet(aliciNo, (sayi + " TL " + Form1.mId + " nolu hesaptan  Havale/EFT alındı."));

                            MessageBox.Show("Havale/EFT İşlemi Yapıldı");
                            Form1.mBakiye -= sayi;
                        }
                        else if (sonuc == 1 && sonuc2 == 0)
                        {
                            con.Open();
                            SqlCommand komut3 = new SqlCommand("update Musteriler set Bakiye-=@p1 where Id=@p2", con);
                            komut3.Parameters.AddWithValue("@p1", sayi);
                            komut3.Parameters.AddWithValue("@p2", aliciNo);
                            komut3.ExecuteNonQuery();
                            MessageBox.Show("Havale/EFT İşlemi Yapılamadı!!!");
                            con.Close();
                        }
                        else if (sonuc == 0 && sonuc2 == 1)
                        {
                            con.Open();
                            SqlCommand komut4 = new SqlCommand("update Musteriler set Bakiye-=@p1 where Id=@p2", con);
                            komut4.Parameters.AddWithValue("@p1", sayi);
                            komut4.Parameters.AddWithValue("@p2", Form1.mId);
                            komut4.ExecuteNonQuery();
                            MessageBox.Show("Havale/EFT İşlemi Yapılamadı!!!");
                        }
                        else
                        {
                            MessageBox.Show("Havale/EFT İşlemi Yapılamadı!!!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show(txtno + " Hesap nolu Müşteri Bulunamadı!!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanına bağlanılamadı!!!");
            }
            con.Close();

            txtmiktar.Text = "";
            txtno.Text = "";
        }
    }
}

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
    public partial class ParaCek : Form
    {
        SqlConnection con = new SqlConnection("server=.; initial catalog=BankamatikOtomasyonu; integrated security=sspi");

        public ParaCek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sayi = float.Parse(maskedTextBox1.Text);
            if (sayi>Form1.mBakiye)
            {
                MessageBox.Show("Yetersiz bakiye");
            }
            else if (sayi<5)
            {
                MessageBox.Show("En az 5 tl çekilebilir");
            }
            else
            {

                try
                {
                    SqlCommand komut = new SqlCommand("update Musteriler set Bakiye-=@p1 where Id=@p2", con);
                    komut.Parameters.AddWithValue("@p1", sayi);
                    komut.Parameters.AddWithValue("@p2", Form1.mId);
                    con.Open();
                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc == 1)
                    {
                        HareketKaydet.kaydet(Form1.mId,(sayi +" TL Para Çekildi"));
                        MessageBox.Show("Para Çekme İşlemiYapıldı");
                        Form1.mBakiye -= sayi;

                    }
                    else
                        MessageBox.Show("Para Çekme İşlemi Yapılamadı!!!");
                }
                catch (Exception)
                {

                    MessageBox.Show("Veritabanına bağlanılamadı!!!");
                }
                con.Close();
            }
            maskedTextBox1.Text = "";
        }
    }
}

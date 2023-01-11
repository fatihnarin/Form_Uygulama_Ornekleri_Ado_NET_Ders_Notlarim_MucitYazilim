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
    public partial class SifreDegistirme : Form
    {
        SqlConnection con = new SqlConnection("server=.; initial catalog=BankamatikOtomasyonu; integrated security=sspi");

        public SifreDegistirme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool sonuc = false;
            try
            {
                SqlCommand komut1 = new SqlCommand("select * from Musteriler where Id=@p1 and Sifre=@p2", con);
                komut1.Parameters.AddWithValue("@p1", Form1.mId);
                komut1.Parameters.AddWithValue("@p2", txteski.Text);
                con.Open();
                SqlDataReader dr = komut1.ExecuteReader();
                if (dr.Read())
                {
                    sonuc = true;
                }
                con.Close();

                if (txteski.Text == "" || txtyeni.Text == "" || txtyenitekrar.Text == "")
                {
                    MessageBox.Show("Tüm alanları doldurnuz");
                }                
                else if (txtyeni.Text.Length < 5)
                {
                    MessageBox.Show("Yeni Şifreniz en az 5 karakterli olmalıdır");
                }
                else if (txtyenitekrar.Text != txtyeni.Text)
                {
                    MessageBox.Show("Yeni şifre ve Tekrarı aynı olmak zorunda!!!");
                }
                else if (sonuc == false)
                {
                    MessageBox.Show("Eski Şifrenizi yanlış girdiniz!!");
                }
                else
                {
                    SqlCommand komut = new SqlCommand("update Musteriler set Sifre=@p1 where Id=@p2", con);
                    komut.Parameters.AddWithValue("@p1", txtyeni.Text);
                    komut.Parameters.AddWithValue("@p2", Form1.mId);
                    con.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Şifreniz başarı ile değiştirildi");
                    con.Close();
                    HareketKaydet.kaydet(Form1.mId," Şifre değişdirildi.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Veri tabanı bağlantısı kurulamadı");
            }
            con.Close();
            txteski.Text = "";
            txtyeni.Text = "";
            txtyenitekrar.Text = "";
        }
    }
}

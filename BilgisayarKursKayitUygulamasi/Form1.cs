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

namespace BilgisayarKursKayitUygulamasi
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-3KJ91FM; initial catalog=BilKursKayitDB; " +
           "integrated security=sspi");
        SqlCommand cmd;
        public static string isim;
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciKayit kk = new KullaniciKayit();
            this.Hide();
            kk.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from login", con);
                SqlDataReader dr = cmd.ExecuteReader();
                bool sonuc = false;
                while (dr.Read())
                {
                    if (dr[4].ToString().Trim() == textBox1.Text && dr[5].ToString().Trim() == textBox2.Text)
                    {
                        isim = dr[1].ToString() + " " + dr[2].ToString();
                        sonuc = true;
                        MessageBox.Show("Giriş Başarılı", "Giriş Ekranı");
                        break;
                    }
                }
                if (sonuc)
                {
                    sonuc = false;
                    KursKayitIslemleri kki = new KursKayitIslemleri();
                    this.Hide();
                    kki.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı Kulanıcı adı veya parola", "Hatalı giriş deneme ekranı");
                }
                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Veritabanı bağlantısı kurulamadı", "Hata Ekranı");
            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class KullaniciKayit : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-3KJ91FM; initial catalog=BilKursKayitDB; " +
            "integrated security=sspi");
        SqlCommand cmd;
        public KullaniciKayit()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text=="" || textBox2.Text == "" || textBox3.Text == "" ||
                    textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                {
                    MessageBox.Show("Tüm alanları doldurunuz", "eksik işlem!!");
                }
                else if (textBox5.Text!=textBox6.Text)
                {
                    MessageBox.Show("Parola tekrar eşleşmiyor", "parola hatası!!");
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("insert into login(ad, soyad, telefon, kullaniciAdi, parola, parolaTekrar) values('" + textBox1.Text + "'" +
                        ",'" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "','" + textBox6.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kullanıcı kaydı başarılı", "Kayıt Ekranı");
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Bir hata ile karşılaşırdı","Hata Ekranı");
            }
            finally
            {
                con.Close();
            }

            
        }
    }
}

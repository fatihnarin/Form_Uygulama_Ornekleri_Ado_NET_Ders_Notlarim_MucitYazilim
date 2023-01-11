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
    public partial class KursKayitIslemleri : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-3KJ91FM; initial catalog=BilKursKayitDB; " +
          "integrated security=sspi");
        SqlCommand cmd;

        public void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            pictureBox1.ImageLocation = "";
        }
        public void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from ogrenciler", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            temizle();

        }
        public KursKayitIslemleri()
        {
            InitializeComponent();
        }

        private void KursKayitIslemleri_Load(object sender, EventArgs e)
        {
            label2.Text = "Hoş geldiniz " + Form1.isim;
            listele();
        }

        private void button1_Click(object sender, EventArgs e)//Resim Ekleme
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim dosyaları|*.jpg;*.png;*.tif||*.*";
            dosya.ShowDialog();
            pictureBox1.ImageLocation = dosya.FileName;
            textBox6.Text = dosya.FileName;

        }

        private void button5_Click(object sender, EventArgs e)//Temizlik
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)//Ekleme
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Tüm alanları eksiksiz giriniz", "Eksik uyarısı");
                }
                else
                {
                    cmd = new SqlCommand("insert into ogrenciler(Ad, Soyad, Telefon, Adres,ePosta,Resim) " +
             "values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci Kaydı Başarılı", "Öğrenci Kayıt Ekranı");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Veri tabanı bağlantısı kurulamadı", "HATA");
            }
            finally
            {
                con.Close();
                listele();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)//Güncelle
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Tüm alanları eksiksiz giriniz", "Eksik uyarısı");
                }
                else
                {
                    cmd = new SqlCommand("update ogrenciler set Ad= '" + textBox1.Text + "', Soyad='" + textBox2.Text + "', Telefon='" + textBox3.Text + "', Adres='" + textBox4.Text + "',ePosta='" + textBox5.Text + "',Resim='" + textBox6.Text + "'where numara= '" + int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "'", con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci güncelleme başarılı", "Öğrenci Güncelleme Ekranı");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Veri tabanı bağlantısı kurulamadı", "HATA");
            }
            finally
            {
                con.Close();
                listele();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Silenecek öğrenciyi seçin", "Uyarı");
                }
                else
                {
                    cmd = new SqlCommand("delete from ogrenciler where numara= '" + int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "'", con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Silme  başarılı", "Öğrenci silme Ekranı");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Veri tabanı bağlantısı kurulamadı", "HATA");
            }
            finally
            {
                con.Close();
                listele();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)//arama
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from ogrenciler where Ad like '" + textBox7.Text + "%'", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}

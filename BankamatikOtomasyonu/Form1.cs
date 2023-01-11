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
    public partial class Form1 : Form
    {
        SqlConnection con =new SqlConnection("server=.; initial catalog=BankamatikOtomasyonu; integrated security=sspi");
        public static string adSoyad;
        public static int mId=0;
        public static float mBakiye = 0.0f;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kAdi = textBox1.Text;
            string parola = textBox2.Text;
            bool sonuc = false;
            if (radioButton1.Checked)
            {
                if (kAdi=="admin" && parola=="123")
                {
                    YetkiliIslem yi = new YetkiliIslem();
                    yi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatali Giriş Denemesi!!!");
                }
            }
            else
            {
                con.Open();
                SqlCommand komut = new SqlCommand("select * from Musteriler where TcNo=@p1 and sifre=@p2", con);
                komut.Parameters.AddWithValue("@p1", kAdi);
                komut.Parameters.AddWithValue("@p2", parola);

                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    adSoyad = dr["AdSoyad"].ToString();
                    mId = int.Parse(dr["Id"].ToString());
                    mBakiye = float.Parse(dr["Bakiye"].ToString());
                    sonuc = true;
                }
                con.Close();
                if (sonuc)
                {
                    sonuc = false;
                    MusteriIslem mi = new MusteriIslem();
                    mi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatali Giriş Denemesi!!!");
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
         
        }
    }
}

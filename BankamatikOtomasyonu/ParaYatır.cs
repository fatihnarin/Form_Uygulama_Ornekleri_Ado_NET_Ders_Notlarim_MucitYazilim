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
    public partial class ParaYatır : Form
    {
        SqlConnection con = new SqlConnection("server=.; initial catalog=BankamatikOtomasyonu; integrated security=sspi");

        public ParaYatır()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sayi = float.Parse(maskedTextBox1.Text);
            if (int.Parse(maskedTextBox1.Text)<=10)
            {
                MessageBox.Show("En az 10 tl yatırılabilir");
            }
            else
            {
         
                try
                {
                    SqlCommand komut = new SqlCommand("update Musteriler set Bakiye+=@p1 where Id=@p2", con);
                    komut.Parameters.AddWithValue("@p1", sayi);
                    komut.Parameters.AddWithValue("@p2", Form1.mId);
                    con.Open();
                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc == 1)
                    {
                        HareketKaydet.kaydet(Form1.mId,(sayi+ " TL Para yatırıldı"));
                        MessageBox.Show("Para Yatırma İşlemi Yapıldı");
                        Form1.mBakiye += sayi;
                    }
                    else
                        MessageBox.Show("Para Yatırma İşlemi Yapılamadı!!!");
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

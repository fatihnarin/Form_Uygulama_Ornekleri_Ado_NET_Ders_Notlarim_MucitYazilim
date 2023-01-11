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

namespace DemirbasTakipProgrami
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-3KJ91FM; initial catalog=demirbasKayitDB; integrated security=sspi");
        SqlCommand cmd;
        SqlDataAdapter da;
        public void listele()
        {
            da = new SqlDataAdapter("select * from demirbaslar", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            temizle();
        }
        public void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            pictureBox1.ImageLocation = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" &&
            textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && pictureBox1.ImageLocation != "")
                {
                    cmd = new SqlCommand("insert into demirbaslar(UrunKodu,UrunAdi,AlanKisi,AlisTarih,GarantiSuresi,Miktar,Fiyat,Resim) " +
                    "values (@UrunKodu,@UrunAdi,@AlanKisi,@AlisTarih,@GarantiSuresi,@Miktar,@Fiyat,@Resim)", con);

                    cmd.Parameters.AddWithValue("@UrunKodu", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@UrunAdi", textBox2.Text);
                    cmd.Parameters.AddWithValue("@AlanKisi", textBox3.Text);
                    cmd.Parameters.AddWithValue("@AlisTarih", textBox4.Text);
                    cmd.Parameters.AddWithValue("@GarantiSuresi", int.Parse(textBox5.Text));
                    cmd.Parameters.AddWithValue("@Miktar", int.Parse(textBox6.Text));
                    cmd.Parameters.AddWithValue("@Fiyat", int.Parse(textBox7.Text));
                    cmd.Parameters.AddWithValue("@Resim", pictureBox1.ImageLocation);

                    con.Open();
                    cmd.ExecuteNonQuery();                   
                    MessageBox.Show("Kayıt yapıldı");
                }
                else
                {
                    MessageBox.Show("Tüm Alanları Doldurun!!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı İşlem!!");
            }
            finally
            {
                con.Close();
                listele();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofl = new OpenFileDialog();
            ofl.Filter = "Resim dosyalari |*.jpg; *.png; *.tif| Tum dosyolar |*.*";
            ofl.ShowDialog();
            pictureBox1.ImageLocation = ofl.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" &&
                            textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && pictureBox1.ImageLocation != "")
                {
                    cmd = new SqlCommand("update demirbaslar set UrunKodu=@UrunKodu,UrunAdi=@UrunAdi," +
                    "AlanKisi=@AlanKisi,AlisTarih=@AlisTarih,GarantiSuresi=@GarantiSuresi,Miktar=@Miktar," +
                    "Fiyat=@Fiyat,Resim=@Resim where id='" + dataGridView1.CurrentRow.Cells[0].Value + "' ", con);

                    cmd.Parameters.AddWithValue("@UrunKodu", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@UrunAdi", textBox2.Text);
                    cmd.Parameters.AddWithValue("@AlanKisi", textBox3.Text);
                    cmd.Parameters.AddWithValue("@AlisTarih", textBox4.Text);
                    cmd.Parameters.AddWithValue("@GarantiSuresi", int.Parse(textBox5.Text));
                    cmd.Parameters.AddWithValue("@Miktar", int.Parse(textBox6.Text));
                    cmd.Parameters.AddWithValue("@Fiyat", int.Parse(textBox7.Text));
                    cmd.Parameters.AddWithValue("@Resim", pictureBox1.ImageLocation);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Güncelleme yapıldı yapıldı");
                }
                else
                {
                    MessageBox.Show("Tüm Alanları Doldurun!!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı İşlem!!");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                cmd = new SqlCommand("delete from demirbaslar  where id='" + dataGridView1.CurrentRow.Cells[0].Value + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Silme yapıldı");
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı İşlem!!");
            }
            
            finally
            {
                con.Close();
                listele();
            }

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from demirbaslar where UrunKodu like'"+textBox8.Text+"%'", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            temizle();
        }
    }
}

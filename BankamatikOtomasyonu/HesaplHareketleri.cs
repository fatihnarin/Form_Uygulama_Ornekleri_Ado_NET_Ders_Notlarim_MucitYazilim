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
    public partial class HesaplHareketleri : Form
    {
        SqlConnection con = new SqlConnection("server=.; initial catalog=BankamatikOtomasyonu; integrated security=sspi");

        public HesaplHareketleri()
        {
            InitializeComponent();
        }

        private void HesaplHareketleri_Load(object sender, EventArgs e)
        {
            SqlCommand komut= new SqlCommand("select * from Hareketler where musteriId=@p1", con);
            komut.Parameters.AddWithValue("@p1", Form1.mId);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        
        }
    }
}

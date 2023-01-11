using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankamatikOtomasyonu
{
    public partial class BakiyeGoruntulame : Form
    {
        public BakiyeGoruntulame()
        {
            InitializeComponent();
        }

        private void BakiyeGoruntulame_Load(object sender, EventArgs e)
        {
            lblBakiye.Text = Form1.mBakiye.ToString() + " TL'DİR";
        }
    }
}

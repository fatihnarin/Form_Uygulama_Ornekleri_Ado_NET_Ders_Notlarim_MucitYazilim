
namespace BankamatikOtomasyonu
{
    partial class MusteriIslem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnhesaphareket = new System.Windows.Forms.Button();
            this.btnsifredegis = new System.Windows.Forms.Button();
            this.btnhavale = new System.Windows.Forms.Button();
            this.btnbakiye = new System.Windows.Forms.Button();
            this.btnparayatir = new System.Windows.Forms.Button();
            this.btnparacek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.lblhesapno = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncikis);
            this.groupBox1.Controls.Add(this.btnhesaphareket);
            this.groupBox1.Controls.Add(this.btnsifredegis);
            this.groupBox1.Controls.Add(this.btnhavale);
            this.groupBox1.Controls.Add(this.btnbakiye);
            this.groupBox1.Controls.Add(this.btnparayatir);
            this.groupBox1.Controls.Add(this.btnparacek);
            this.groupBox1.Location = new System.Drawing.Point(18, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(502, 542);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müsteri işlemleri";
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Red;
            this.btncikis.Location = new System.Drawing.Point(125, 473);
            this.btncikis.Margin = new System.Windows.Forms.Padding(4);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(240, 41);
            this.btncikis.TabIndex = 5;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnhesaphareket
            // 
            this.btnhesaphareket.Location = new System.Drawing.Point(125, 405);
            this.btnhesaphareket.Margin = new System.Windows.Forms.Padding(4);
            this.btnhesaphareket.Name = "btnhesaphareket";
            this.btnhesaphareket.Size = new System.Drawing.Size(240, 41);
            this.btnhesaphareket.TabIndex = 4;
            this.btnhesaphareket.Text = "Hesap Hareketleri";
            this.btnhesaphareket.UseVisualStyleBackColor = true;
            this.btnhesaphareket.Click += new System.EventHandler(this.btnhesaphareket_Click);
            // 
            // btnsifredegis
            // 
            this.btnsifredegis.Location = new System.Drawing.Point(125, 337);
            this.btnsifredegis.Margin = new System.Windows.Forms.Padding(4);
            this.btnsifredegis.Name = "btnsifredegis";
            this.btnsifredegis.Size = new System.Drawing.Size(240, 41);
            this.btnsifredegis.TabIndex = 4;
            this.btnsifredegis.Text = "Şifre Değiştirme";
            this.btnsifredegis.UseVisualStyleBackColor = true;
            this.btnsifredegis.Click += new System.EventHandler(this.btnsifredegis_Click);
            // 
            // btnhavale
            // 
            this.btnhavale.Location = new System.Drawing.Point(125, 269);
            this.btnhavale.Margin = new System.Windows.Forms.Padding(4);
            this.btnhavale.Name = "btnhavale";
            this.btnhavale.Size = new System.Drawing.Size(240, 41);
            this.btnhavale.TabIndex = 3;
            this.btnhavale.Text = "Havale/EFT";
            this.btnhavale.UseVisualStyleBackColor = true;
            this.btnhavale.Click += new System.EventHandler(this.btnhavale_Click);
            // 
            // btnbakiye
            // 
            this.btnbakiye.Location = new System.Drawing.Point(125, 201);
            this.btnbakiye.Margin = new System.Windows.Forms.Padding(4);
            this.btnbakiye.Name = "btnbakiye";
            this.btnbakiye.Size = new System.Drawing.Size(240, 41);
            this.btnbakiye.TabIndex = 2;
            this.btnbakiye.Text = "Bakiye Görüntüre";
            this.btnbakiye.UseVisualStyleBackColor = true;
            this.btnbakiye.Click += new System.EventHandler(this.btnbakiye_Click);
            // 
            // btnparayatir
            // 
            this.btnparayatir.Location = new System.Drawing.Point(125, 133);
            this.btnparayatir.Margin = new System.Windows.Forms.Padding(4);
            this.btnparayatir.Name = "btnparayatir";
            this.btnparayatir.Size = new System.Drawing.Size(240, 41);
            this.btnparayatir.TabIndex = 1;
            this.btnparayatir.Text = "Para Yatır";
            this.btnparayatir.UseVisualStyleBackColor = true;
            this.btnparayatir.Click += new System.EventHandler(this.btnparayatir_Click);
            // 
            // btnparacek
            // 
            this.btnparacek.Location = new System.Drawing.Point(125, 65);
            this.btnparacek.Margin = new System.Windows.Forms.Padding(4);
            this.btnparacek.Name = "btnparacek";
            this.btnparacek.Size = new System.Drawing.Size(240, 41);
            this.btnparacek.TabIndex = 0;
            this.btnparacek.Text = "Para Çek";
            this.btnparacek.UseVisualStyleBackColor = true;
            this.btnparacek.Click += new System.EventHandler(this.btnparacek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hesap No:";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(150, 18);
            this.lbladsoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(13, 17);
            this.lbladsoyad.TabIndex = 2;
            this.lbladsoyad.Text = ".";
            // 
            // lblhesapno
            // 
            this.lblhesapno.AutoSize = true;
            this.lblhesapno.Location = new System.Drawing.Point(150, 51);
            this.lblhesapno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhesapno.Name = "lblhesapno";
            this.lblhesapno.Size = new System.Drawing.Size(13, 17);
            this.lblhesapno.TabIndex = 2;
            this.lblhesapno.Text = ".";
            // 
            // MusteriIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 652);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblhesapno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbladsoyad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusteriIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriIslem";
            this.Load += new System.EventHandler(this.MusteriIslem_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnsifredegis;
        private System.Windows.Forms.Button btnhavale;
        private System.Windows.Forms.Button btnbakiye;
        private System.Windows.Forms.Button btnparayatir;
        private System.Windows.Forms.Button btnparacek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhesaphareket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label lblhesapno;
    }
}
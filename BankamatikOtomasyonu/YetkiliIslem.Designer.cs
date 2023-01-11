
namespace BankamatikOtomasyonu
{
    partial class YetkiliIslem
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btkekle = new System.Windows.Forms.Button();
            this.btnara = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoşgeldiniz Sayın  Admin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncikis);
            this.groupBox1.Controls.Add(this.btnlistele);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btnguncelle);
            this.groupBox1.Controls.Add(this.btnara);
            this.groupBox1.Controls.Add(this.btkekle);
            this.groupBox1.Location = new System.Drawing.Point(42, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 390);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yetkili işlemleri";
            // 
            // btkekle
            // 
            this.btkekle.Location = new System.Drawing.Point(83, 53);
            this.btkekle.Name = "btkekle";
            this.btkekle.Size = new System.Drawing.Size(160, 33);
            this.btkekle.TabIndex = 0;
            this.btkekle.Text = "Müşteri Ekle";
            this.btkekle.UseVisualStyleBackColor = true;
            this.btkekle.Click += new System.EventHandler(this.btkekle_Click);
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(83, 110);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(160, 33);
            this.btnara.TabIndex = 1;
            this.btnara.Text = "Müşteri Ara";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(83, 167);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(160, 33);
            this.btnguncelle.TabIndex = 2;
            this.btnguncelle.Text = "Müsteri Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(83, 224);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(160, 33);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "Müşteri Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(83, 281);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(160, 33);
            this.btnlistele.TabIndex = 4;
            this.btnlistele.Text = "Müsteri Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Red;
            this.btncikis.Location = new System.Drawing.Point(83, 338);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(160, 33);
            this.btncikis.TabIndex = 5;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // YetkiliIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "YetkiliIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YETKİLİ İŞLEMLERİ";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btkekle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

namespace BankamatikOtomasyonu
{
    partial class MusteriAra
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtbakiye = new System.Windows.Forms.MaskedTextBox();
            this.txttel = new System.Windows.Forms.MaskedTextBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.txttcno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtaidtcara = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 126);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbakiye
            // 
            this.txtbakiye.Location = new System.Drawing.Point(154, 473);
            this.txtbakiye.Margin = new System.Windows.Forms.Padding(4);
            this.txtbakiye.Mask = "000000000000";
            this.txtbakiye.Name = "txtbakiye";
            this.txtbakiye.ReadOnly = true;
            this.txtbakiye.Size = new System.Drawing.Size(246, 23);
            this.txtbakiye.TabIndex = 14;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(154, 414);
            this.txttel.Margin = new System.Windows.Forms.Padding(4);
            this.txttel.Mask = "+00 (999) 000-0000";
            this.txttel.Name = "txttel";
            this.txttel.ReadOnly = true;
            this.txttel.Size = new System.Drawing.Size(246, 23);
            this.txttel.TabIndex = 12;
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(154, 355);
            this.txtadres.Margin = new System.Windows.Forms.Padding(4);
            this.txtadres.Name = "txtadres";
            this.txtadres.ReadOnly = true;
            this.txtadres.Size = new System.Drawing.Size(246, 23);
            this.txtadres.TabIndex = 10;
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(154, 296);
            this.txtadsoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.ReadOnly = true;
            this.txtadsoyad.Size = new System.Drawing.Size(246, 23);
            this.txtadsoyad.TabIndex = 8;
            // 
            // txttcno
            // 
            this.txttcno.Location = new System.Drawing.Point(154, 236);
            this.txttcno.Margin = new System.Windows.Forms.Padding(4);
            this.txttcno.Name = "txttcno";
            this.txttcno.ReadOnly = true;
            this.txttcno.Size = new System.Drawing.Size(246, 23);
            this.txttcno.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "MÜŞTERİ ARA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 476);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bakiye :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 416);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 357);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Adres :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ad Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 239);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "TC NO :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 194);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Müsteri Id :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(154, 191);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(246, 23);
            this.txtid.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "ID/TC NO ile ARA :";
            // 
            // txtaidtcara
            // 
            this.txtaidtcara.Location = new System.Drawing.Point(154, 95);
            this.txtaidtcara.Margin = new System.Windows.Forms.Padding(4);
            this.txtaidtcara.Name = "txtaidtcara";
            this.txtaidtcara.Size = new System.Drawing.Size(246, 23);
            this.txtaidtcara.TabIndex = 0;
            // 
            // MusteriAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbakiye);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.txtaidtcara);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txttcno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusteriAra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriAra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtbakiye;
        private System.Windows.Forms.MaskedTextBox txttel;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.TextBox txttcno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtaidtcara;
    }
}
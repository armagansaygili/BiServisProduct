
namespace BiServisFirma
{
    partial class MusteriBilgi
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
            this.kullaniciAdi_tbx = new System.Windows.Forms.TextBox();
            this.ad_tbx = new System.Windows.Forms.TextBox();
            this.sad_tbx = new System.Windows.Forms.TextBox();
            this.tel_tbx = new System.Windows.Forms.TextBox();
            this.mail_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guncelle_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullaniciAdi_tbx
            // 
            this.kullaniciAdi_tbx.Location = new System.Drawing.Point(144, 38);
            this.kullaniciAdi_tbx.Name = "kullaniciAdi_tbx";
            this.kullaniciAdi_tbx.ReadOnly = true;
            this.kullaniciAdi_tbx.Size = new System.Drawing.Size(100, 20);
            this.kullaniciAdi_tbx.TabIndex = 0;
            // 
            // ad_tbx
            // 
            this.ad_tbx.Location = new System.Drawing.Point(144, 81);
            this.ad_tbx.Name = "ad_tbx";
            this.ad_tbx.ReadOnly = true;
            this.ad_tbx.Size = new System.Drawing.Size(100, 20);
            this.ad_tbx.TabIndex = 1;
            // 
            // sad_tbx
            // 
            this.sad_tbx.Location = new System.Drawing.Point(144, 125);
            this.sad_tbx.Name = "sad_tbx";
            this.sad_tbx.ReadOnly = true;
            this.sad_tbx.Size = new System.Drawing.Size(100, 20);
            this.sad_tbx.TabIndex = 2;
            // 
            // tel_tbx
            // 
            this.tel_tbx.Location = new System.Drawing.Point(144, 169);
            this.tel_tbx.Name = "tel_tbx";
            this.tel_tbx.ReadOnly = true;
            this.tel_tbx.Size = new System.Drawing.Size(100, 20);
            this.tel_tbx.TabIndex = 3;
            // 
            // mail_tbx
            // 
            this.mail_tbx.Location = new System.Drawing.Point(144, 215);
            this.mail_tbx.Name = "mail_tbx";
            this.mail_tbx.ReadOnly = true;
            this.mail_tbx.Size = new System.Drawing.Size(100, 20);
            this.mail_tbx.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "İsim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soyisim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefon Numarası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "E-Mail:";
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.Location = new System.Drawing.Point(144, 262);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(100, 23);
            this.guncelle_btn.TabIndex = 10;
            this.guncelle_btn.Text = "Kapat";
            this.guncelle_btn.UseVisualStyleBackColor = true;
            this.guncelle_btn.Click += new System.EventHandler(this.guncelle_btn_Click);
            // 
            // MusteriBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 306);
            this.Controls.Add(this.guncelle_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mail_tbx);
            this.Controls.Add(this.tel_tbx);
            this.Controls.Add(this.sad_tbx);
            this.Controls.Add(this.ad_tbx);
            this.Controls.Add(this.kullaniciAdi_tbx);
            this.Name = "MusteriBilgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MusteriBilgi";
            this.Load += new System.EventHandler(this.MusteriBilgi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullaniciAdi_tbx;
        private System.Windows.Forms.TextBox ad_tbx;
        private System.Windows.Forms.TextBox sad_tbx;
        private System.Windows.Forms.TextBox tel_tbx;
        private System.Windows.Forms.TextBox mail_tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button guncelle_btn;
    }
}

namespace BiServisFirma
{
    partial class BiservisAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiservisAna));
            this.musBil_btn = new System.Windows.Forms.Button();
            this.arizaEkle_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.arizaUcret_tbx = new System.Windows.Forms.TextBox();
            this.arizaBil_tbx = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.musSad_tbx = new System.Windows.Forms.TextBox();
            this.musAd_tbx = new System.Windows.Forms.TextBox();
            this.randevuDgv = new System.Windows.Forms.DataGridView();
            this.ranDetay_btn = new System.Windows.Forms.Button();
            this.ranSil_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.perIs_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randevuDgv)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // musBil_btn
            // 
            this.musBil_btn.Location = new System.Drawing.Point(106, 109);
            this.musBil_btn.Name = "musBil_btn";
            this.musBil_btn.Size = new System.Drawing.Size(100, 23);
            this.musBil_btn.TabIndex = 2;
            this.musBil_btn.Text = "Müşteri Bilgileri";
            this.musBil_btn.UseVisualStyleBackColor = true;
            this.musBil_btn.Click += new System.EventHandler(this.musBil_btn_Click);
            // 
            // arizaEkle_btn
            // 
            this.arizaEkle_btn.Location = new System.Drawing.Point(90, 109);
            this.arizaEkle_btn.Name = "arizaEkle_btn";
            this.arizaEkle_btn.Size = new System.Drawing.Size(100, 23);
            this.arizaEkle_btn.TabIndex = 9;
            this.arizaEkle_btn.Text = "Arıza Ekle";
            this.arizaEkle_btn.UseVisualStyleBackColor = true;
            this.arizaEkle_btn.Click += new System.EventHandler(this.arizaEkle_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.arizaEkle_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.arizaUcret_tbx);
            this.groupBox1.Controls.Add(this.arizaBil_tbx);
            this.groupBox1.Location = new System.Drawing.Point(610, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 149);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arıza Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arıza Ücreti:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arıza Bilgisi:";
            // 
            // arizaUcret_tbx
            // 
            this.arizaUcret_tbx.Location = new System.Drawing.Point(90, 71);
            this.arizaUcret_tbx.Name = "arizaUcret_tbx";
            this.arizaUcret_tbx.Size = new System.Drawing.Size(100, 20);
            this.arizaUcret_tbx.TabIndex = 1;
            // 
            // arizaBil_tbx
            // 
            this.arizaBil_tbx.Location = new System.Drawing.Point(90, 33);
            this.arizaBil_tbx.Name = "arizaBil_tbx";
            this.arizaBil_tbx.Size = new System.Drawing.Size(100, 20);
            this.arizaBil_tbx.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.musBil_btn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.musSad_tbx);
            this.groupBox2.Controls.Add(this.musAd_tbx);
            this.groupBox2.Location = new System.Drawing.Point(16, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 149);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Müşteri Soyisim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Müşteri İsim:";
            // 
            // musSad_tbx
            // 
            this.musSad_tbx.Location = new System.Drawing.Point(106, 71);
            this.musSad_tbx.Name = "musSad_tbx";
            this.musSad_tbx.Size = new System.Drawing.Size(100, 20);
            this.musSad_tbx.TabIndex = 1;
            // 
            // musAd_tbx
            // 
            this.musAd_tbx.Location = new System.Drawing.Point(106, 33);
            this.musAd_tbx.Name = "musAd_tbx";
            this.musAd_tbx.Size = new System.Drawing.Size(100, 20);
            this.musAd_tbx.TabIndex = 0;
            // 
            // randevuDgv
            // 
            this.randevuDgv.AllowUserToAddRows = false;
            this.randevuDgv.AllowUserToDeleteRows = false;
            this.randevuDgv.AllowUserToResizeColumns = false;
            this.randevuDgv.AllowUserToResizeRows = false;
            this.randevuDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.randevuDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.randevuDgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.randevuDgv.Location = new System.Drawing.Point(3, 16);
            this.randevuDgv.Name = "randevuDgv";
            this.randevuDgv.ReadOnly = true;
            this.randevuDgv.RowHeadersVisible = false;
            this.randevuDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.randevuDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.randevuDgv.Size = new System.Drawing.Size(796, 236);
            this.randevuDgv.TabIndex = 0;
            this.randevuDgv.DoubleClick += new System.EventHandler(this.ranDetay_btn_Click);
            // 
            // ranDetay_btn
            // 
            this.ranDetay_btn.Location = new System.Drawing.Point(6, 269);
            this.ranDetay_btn.Name = "ranDetay_btn";
            this.ranDetay_btn.Size = new System.Drawing.Size(112, 23);
            this.ranDetay_btn.TabIndex = 4;
            this.ranDetay_btn.Text = "Randevu Detayı";
            this.ranDetay_btn.UseVisualStyleBackColor = true;
            this.ranDetay_btn.Click += new System.EventHandler(this.ranDetay_btn_Click);
            // 
            // ranSil_btn
            // 
            this.ranSil_btn.Location = new System.Drawing.Point(684, 269);
            this.ranSil_btn.Name = "ranSil_btn";
            this.ranSil_btn.Size = new System.Drawing.Size(112, 23);
            this.ranSil_btn.TabIndex = 3;
            this.ranSil_btn.Text = "Randevuyu İptal Et";
            this.ranSil_btn.UseVisualStyleBackColor = true;
            this.ranSil_btn.Click += new System.EventHandler(this.ranSil_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.randevuDgv);
            this.groupBox3.Controls.Add(this.ranDetay_btn);
            this.groupBox3.Controls.Add(this.ranSil_btn);
            this.groupBox3.Location = new System.Drawing.Point(16, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(802, 308);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevular";
            // 
            // perIs_btn
            // 
            this.perIs_btn.Location = new System.Drawing.Point(316, 123);
            this.perIs_btn.Name = "perIs_btn";
            this.perIs_btn.Size = new System.Drawing.Size(226, 23);
            this.perIs_btn.TabIndex = 13;
            this.perIs_btn.Text = "Personel İşlemleri";
            this.perIs_btn.UseVisualStyleBackColor = true;
            this.perIs_btn.Click += new System.EventHandler(this.perIs_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 94);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // BiservisAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.perIs_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BiservisAna";
            this.Text = "BiservisAna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BiservisAna_FormClosed);
            this.Load += new System.EventHandler(this.BiservisAna_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randevuDgv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button musBil_btn;
        private System.Windows.Forms.Button arizaEkle_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arizaBil_tbx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox musSad_tbx;
        private System.Windows.Forms.TextBox musAd_tbx;
        private System.Windows.Forms.DataGridView randevuDgv;
        private System.Windows.Forms.Button ranDetay_btn;
        private System.Windows.Forms.Button ranSil_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button perIs_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox arizaUcret_tbx;
    }
}
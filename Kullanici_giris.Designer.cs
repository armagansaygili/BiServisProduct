
namespace BiServis
{
    partial class Kullanici_giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanici_giris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userName_tbx = new System.Windows.Forms.TextBox();
            this.userPass_tbx = new System.Windows.Forms.TextBox();
            this.grs_btn = new System.Windows.Forms.Button();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // userName_tbx
            // 
            resources.ApplyResources(this.userName_tbx, "userName_tbx");
            this.userName_tbx.Name = "userName_tbx";
            // 
            // userPass_tbx
            // 
            resources.ApplyResources(this.userPass_tbx, "userPass_tbx");
            this.userPass_tbx.Name = "userPass_tbx";
            // 
            // grs_btn
            // 
            this.grs_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grs_btn.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(this.grs_btn, "grs_btn");
            this.grs_btn.Name = "grs_btn";
            this.grs_btn.UseVisualStyleBackColor = true;
            this.grs_btn.Click += new System.EventHandler(this.grs_btn_Click);
            // 
            // cikis_btn
            // 
            this.cikis_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cikis_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cikis_btn.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(this.cikis_btn, "cikis_btn");
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.UseVisualStyleBackColor = true;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Kullanici_giris
            // 
            this.AcceptButton = this.grs_btn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cikis_btn;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.grs_btn);
            this.Controls.Add(this.userPass_tbx);
            this.Controls.Add(this.userName_tbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kullanici_giris";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userName_tbx;
        private System.Windows.Forms.TextBox userPass_tbx;
        private System.Windows.Forms.Button grs_btn;
        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.Button button2;
    }
}



namespace BiServisFirma
{
    partial class PersonelGiris
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
            this.girisLbl = new System.Windows.Forms.Label();
            this.userName_tbx = new System.Windows.Forms.TextBox();
            this.userPass_tbx = new System.Windows.Forms.TextBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.cikisBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // girisLbl
            // 
            this.girisLbl.AutoSize = true;
            this.girisLbl.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisLbl.Location = new System.Drawing.Point(46, 22);
            this.girisLbl.Name = "girisLbl";
            this.girisLbl.Size = new System.Drawing.Size(133, 34);
            this.girisLbl.TabIndex = 0;
            this.girisLbl.Text = "Giriş Yap";
            // 
            // userName_tbx
            // 
            this.userName_tbx.Location = new System.Drawing.Point(63, 76);
            this.userName_tbx.Name = "userName_tbx";
            this.userName_tbx.Size = new System.Drawing.Size(100, 20);
            this.userName_tbx.TabIndex = 1;
            // 
            // userPass_tbx
            // 
            this.userPass_tbx.Location = new System.Drawing.Point(63, 102);
            this.userPass_tbx.Name = "userPass_tbx";
            this.userPass_tbx.Size = new System.Drawing.Size(100, 20);
            this.userPass_tbx.TabIndex = 2;
            this.userPass_tbx.UseSystemPasswordChar = true;
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(78, 141);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(75, 23);
            this.girisBtn.TabIndex = 3;
            this.girisBtn.Text = "Giriş";
            this.girisBtn.UseVisualStyleBackColor = true;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // cikisBtn
            // 
            this.cikisBtn.Location = new System.Drawing.Point(78, 170);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(75, 23);
            this.cikisBtn.TabIndex = 4;
            this.cikisBtn.Text = "Çıkış";
            this.cikisBtn.UseVisualStyleBackColor = true;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // PersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 221);
            this.Controls.Add(this.girisLbl);
            this.Controls.Add(this.cikisBtn);
            this.Controls.Add(this.userName_tbx);
            this.Controls.Add(this.userPass_tbx);
            this.Controls.Add(this.girisBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonelGiris";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label girisLbl;
        private System.Windows.Forms.TextBox userName_tbx;
        private System.Windows.Forms.TextBox userPass_tbx;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.Button cikisBtn;
    }
}
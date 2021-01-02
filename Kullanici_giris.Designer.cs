
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanici_giris));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.uye_link = new System.Windows.Forms.LinkLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cikis_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.grs_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.userName_tbx = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.userPass_tbx = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.BackColor = System.Drawing.Color.Empty;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Cambria", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.AliceBlue;
            this.bunifuLabel1.Location = new System.Drawing.Point(51, 3);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(139, 40);
            this.bunifuLabel1.TabIndex = 7;
            this.bunifuLabel1.Text = "Giriş Yap";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // uye_link
            // 
            this.uye_link.ActiveLinkColor = System.Drawing.Color.Red;
            this.uye_link.AutoSize = true;
            this.uye_link.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uye_link.LinkColor = System.Drawing.SystemColors.MenuBar;
            this.uye_link.Location = new System.Drawing.Point(50, 152);
            this.uye_link.Name = "uye_link";
            this.uye_link.Size = new System.Drawing.Size(140, 14);
            this.uye_link.TabIndex = 2;
            this.uye_link.TabStop = true;
            this.uye_link.Text = "Üye olmak için tıklayınız.";
            this.uye_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uye_link_LinkClicked);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cikis_btn);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.grs_btn);
            this.panel1.Controls.Add(this.userName_tbx);
            this.panel1.Controls.Add(this.uye_link);
            this.panel1.Controls.Add(this.userPass_tbx);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 267);
            this.panel1.TabIndex = 11;
            // 
            // cikis_btn
            // 
            this.cikis_btn.ActiveBorderThickness = 1;
            this.cikis_btn.ActiveCornerRadius = 20;
            this.cikis_btn.ActiveFillColor = System.Drawing.Color.LightSlateGray;
            this.cikis_btn.ActiveForecolor = System.Drawing.Color.White;
            this.cikis_btn.ActiveLineColor = System.Drawing.Color.AliceBlue;
            this.cikis_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.cikis_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikis_btn.BackgroundImage")));
            this.cikis_btn.ButtonText = "Çıkış";
            this.cikis_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis_btn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis_btn.ForeColor = System.Drawing.Color.LightSlateGray;
            this.cikis_btn.IdleBorderThickness = 1;
            this.cikis_btn.IdleCornerRadius = 20;
            this.cikis_btn.IdleFillColor = System.Drawing.Color.White;
            this.cikis_btn.IdleForecolor = System.Drawing.Color.LightSlateGray;
            this.cikis_btn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.cikis_btn.Location = new System.Drawing.Point(39, 221);
            this.cikis_btn.Margin = new System.Windows.Forms.Padding(5);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(156, 43);
            this.cikis_btn.TabIndex = 4;
            this.cikis_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // grs_btn
            // 
            this.grs_btn.ActiveBorderThickness = 1;
            this.grs_btn.ActiveCornerRadius = 20;
            this.grs_btn.ActiveFillColor = System.Drawing.Color.LightSlateGray;
            this.grs_btn.ActiveForecolor = System.Drawing.Color.White;
            this.grs_btn.ActiveLineColor = System.Drawing.Color.AliceBlue;
            this.grs_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.grs_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grs_btn.BackgroundImage")));
            this.grs_btn.ButtonText = "Giriş";
            this.grs_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grs_btn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grs_btn.ForeColor = System.Drawing.Color.LightSlateGray;
            this.grs_btn.IdleBorderThickness = 1;
            this.grs_btn.IdleCornerRadius = 20;
            this.grs_btn.IdleFillColor = System.Drawing.Color.White;
            this.grs_btn.IdleForecolor = System.Drawing.Color.LightSlateGray;
            this.grs_btn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.grs_btn.Location = new System.Drawing.Point(39, 175);
            this.grs_btn.Margin = new System.Windows.Forms.Padding(5);
            this.grs_btn.Name = "grs_btn";
            this.grs_btn.Size = new System.Drawing.Size(156, 43);
            this.grs_btn.TabIndex = 3;
            this.grs_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.grs_btn.Click += new System.EventHandler(this.grs_btn_Click);
            // 
            // userName_tbx
            // 
            this.userName_tbx.AcceptsReturn = false;
            this.userName_tbx.AcceptsTab = false;
            this.userName_tbx.AnimationSpeed = 200;
            this.userName_tbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.userName_tbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.userName_tbx.BackColor = System.Drawing.Color.Transparent;
            this.userName_tbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userName_tbx.BackgroundImage")));
            this.userName_tbx.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.userName_tbx.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.userName_tbx.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.userName_tbx.BorderColorIdle = System.Drawing.Color.Silver;
            this.userName_tbx.BorderRadius = 5;
            this.userName_tbx.BorderThickness = 1;
            this.userName_tbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userName_tbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userName_tbx.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.userName_tbx.DefaultText = "";
            this.userName_tbx.FillColor = System.Drawing.Color.White;
            this.userName_tbx.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userName_tbx.HideSelection = true;
            this.userName_tbx.IconLeft = null;
            this.userName_tbx.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.userName_tbx.IconPadding = 10;
            this.userName_tbx.IconRight = ((System.Drawing.Image)(resources.GetObject("userName_tbx.IconRight")));
            this.userName_tbx.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.userName_tbx.Lines = new string[0];
            this.userName_tbx.Location = new System.Drawing.Point(17, 69);
            this.userName_tbx.MaxLength = 32767;
            this.userName_tbx.MinimumSize = new System.Drawing.Size(100, 35);
            this.userName_tbx.Modified = false;
            this.userName_tbx.Multiline = false;
            this.userName_tbx.Name = "userName_tbx";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.userName_tbx.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.userName_tbx.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.userName_tbx.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.userName_tbx.OnIdleState = stateProperties4;
            this.userName_tbx.PasswordChar = '\0';
            this.userName_tbx.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.userName_tbx.PlaceholderText = "Kullanıcı Adı";
            this.userName_tbx.ReadOnly = false;
            this.userName_tbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userName_tbx.SelectedText = "";
            this.userName_tbx.SelectionLength = 0;
            this.userName_tbx.SelectionStart = 0;
            this.userName_tbx.ShortcutsEnabled = true;
            this.userName_tbx.Size = new System.Drawing.Size(203, 35);
            this.userName_tbx.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.userName_tbx.TabIndex = 0;
            this.userName_tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userName_tbx.TextMarginBottom = 0;
            this.userName_tbx.TextMarginLeft = 5;
            this.userName_tbx.TextMarginTop = 0;
            this.userName_tbx.TextPlaceholder = "Kullanıcı Adı";
            this.userName_tbx.UseSystemPasswordChar = false;
            this.userName_tbx.WordWrap = true;
            // 
            // userPass_tbx
            // 
            this.userPass_tbx.AcceptsReturn = false;
            this.userPass_tbx.AcceptsTab = false;
            this.userPass_tbx.AnimationSpeed = 200;
            this.userPass_tbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.userPass_tbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.userPass_tbx.BackColor = System.Drawing.Color.Transparent;
            this.userPass_tbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userPass_tbx.BackgroundImage")));
            this.userPass_tbx.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.userPass_tbx.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.userPass_tbx.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.userPass_tbx.BorderColorIdle = System.Drawing.Color.Silver;
            this.userPass_tbx.BorderRadius = 5;
            this.userPass_tbx.BorderThickness = 1;
            this.userPass_tbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userPass_tbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userPass_tbx.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.userPass_tbx.DefaultText = "";
            this.userPass_tbx.FillColor = System.Drawing.Color.White;
            this.userPass_tbx.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userPass_tbx.HideSelection = true;
            this.userPass_tbx.IconLeft = null;
            this.userPass_tbx.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.userPass_tbx.IconPadding = 10;
            this.userPass_tbx.IconRight = ((System.Drawing.Image)(resources.GetObject("userPass_tbx.IconRight")));
            this.userPass_tbx.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.userPass_tbx.Lines = new string[0];
            this.userPass_tbx.Location = new System.Drawing.Point(17, 110);
            this.userPass_tbx.MaxLength = 32767;
            this.userPass_tbx.MinimumSize = new System.Drawing.Size(100, 35);
            this.userPass_tbx.Modified = false;
            this.userPass_tbx.Multiline = false;
            this.userPass_tbx.Name = "userPass_tbx";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.userPass_tbx.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.userPass_tbx.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.userPass_tbx.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.userPass_tbx.OnIdleState = stateProperties8;
            this.userPass_tbx.PasswordChar = '\0';
            this.userPass_tbx.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.userPass_tbx.PlaceholderText = "Şifre";
            this.userPass_tbx.ReadOnly = false;
            this.userPass_tbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userPass_tbx.SelectedText = "";
            this.userPass_tbx.SelectionLength = 0;
            this.userPass_tbx.SelectionStart = 0;
            this.userPass_tbx.ShortcutsEnabled = true;
            this.userPass_tbx.Size = new System.Drawing.Size(203, 35);
            this.userPass_tbx.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.userPass_tbx.TabIndex = 1;
            this.userPass_tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userPass_tbx.TextMarginBottom = 0;
            this.userPass_tbx.TextMarginLeft = 5;
            this.userPass_tbx.TextMarginTop = 0;
            this.userPass_tbx.TextPlaceholder = "Şifre";
            this.userPass_tbx.UseSystemPasswordChar = false;
            this.userPass_tbx.WordWrap = true;
            this.userPass_tbx.Enter += new System.EventHandler(this.userPass_tbx_Enter);
            this.userPass_tbx.Leave += new System.EventHandler(this.userPass_tbx_Leave);
            // 
            // Kullanici_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(264, 293);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kullanici_giris";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiServis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox userName_tbx;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox userPass_tbx;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.LinkLabel uye_link;
        private Bunifu.Framework.UI.BunifuThinButton2 grs_btn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 cikis_btn;
    }
}


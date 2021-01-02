
namespace BiServis
{
    partial class Rapor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rapor));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.randevuList_gbx = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.randevuSil_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cikis_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.randevuList_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // randevuList_gbx
            // 
            this.randevuList_gbx.Controls.Add(this.dataGridView1);
            this.randevuList_gbx.Controls.Add(this.randevuSil_btn);
            this.randevuList_gbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randevuList_gbx.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevuList_gbx.ForeColor = System.Drawing.Color.AliceBlue;
            this.randevuList_gbx.Location = new System.Drawing.Point(14, 25);
            this.randevuList_gbx.Name = "randevuList_gbx";
            this.randevuList_gbx.Size = new System.Drawing.Size(855, 318);
            this.randevuList_gbx.TabIndex = 23;
            this.randevuList_gbx.TabStop = false;
            this.randevuList_gbx.Text = "Randevu Detayı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(15, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(824, 195);
            this.dataGridView1.TabIndex = 1;
            // 
            // randevuSil_btn
            // 
            this.randevuSil_btn.ActiveBorderThickness = 1;
            this.randevuSil_btn.ActiveCornerRadius = 20;
            this.randevuSil_btn.ActiveFillColor = System.Drawing.Color.LightSlateGray;
            this.randevuSil_btn.ActiveForecolor = System.Drawing.Color.White;
            this.randevuSil_btn.ActiveLineColor = System.Drawing.Color.AliceBlue;
            this.randevuSil_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.randevuSil_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("randevuSil_btn.BackgroundImage")));
            this.randevuSil_btn.ButtonText = "Kapat";
            this.randevuSil_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randevuSil_btn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevuSil_btn.ForeColor = System.Drawing.Color.LightSlateGray;
            this.randevuSil_btn.IdleBorderThickness = 1;
            this.randevuSil_btn.IdleCornerRadius = 20;
            this.randevuSil_btn.IdleFillColor = System.Drawing.Color.White;
            this.randevuSil_btn.IdleForecolor = System.Drawing.Color.LightSlateGray;
            this.randevuSil_btn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.randevuSil_btn.Location = new System.Drawing.Point(719, 261);
            this.randevuSil_btn.Margin = new System.Windows.Forms.Padding(5);
            this.randevuSil_btn.Name = "randevuSil_btn";
            this.randevuSil_btn.Size = new System.Drawing.Size(120, 43);
            this.randevuSil_btn.TabIndex = 6;
            this.randevuSil_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.randevuSil_btn.Click += new System.EventHandler(this.randevuSil_btn_Click);
            // 
            // cikis_btn
            // 
            this.cikis_btn.ActiveBorderThickness = 1;
            this.cikis_btn.ActiveCornerRadius = 20;
            this.cikis_btn.ActiveFillColor = System.Drawing.Color.LightSlateGray;
            this.cikis_btn.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.cikis_btn.ActiveLineColor = System.Drawing.Color.AliceBlue;
            this.cikis_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.cikis_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikis_btn.BackgroundImage")));
            this.cikis_btn.ButtonText = " X";
            this.cikis_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis_btn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis_btn.ForeColor = System.Drawing.Color.LightSlateGray;
            this.cikis_btn.IdleBorderThickness = 1;
            this.cikis_btn.IdleCornerRadius = 20;
            this.cikis_btn.IdleFillColor = System.Drawing.Color.White;
            this.cikis_btn.IdleForecolor = System.Drawing.Color.LightSlateGray;
            this.cikis_btn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.cikis_btn.Location = new System.Drawing.Point(854, -4);
            this.cikis_btn.Margin = new System.Windows.Forms.Padding(5);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(24, 30);
            this.cikis_btn.TabIndex = 24;
            this.cikis_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(881, 367);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.randevuList_gbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rapor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.Rapor_Load);
            this.randevuList_gbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox randevuList_gbx;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 randevuSil_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 cikis_btn;
    }
}

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rapor));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.randevuList_gbx = new System.Windows.Forms.GroupBox();
            this.yillik_Rapor = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.kapat_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cikis_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
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
            this.randevuList_gbx.Controls.Add(this.yillik_Rapor);
            this.randevuList_gbx.Controls.Add(this.dataGridView1);
            this.randevuList_gbx.Controls.Add(this.kapat_btn);
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
            // yillik_Rapor
            // 
            this.yillik_Rapor.ActiveBorderThickness = 1;
            this.yillik_Rapor.ActiveCornerRadius = 20;
            this.yillik_Rapor.ActiveFillColor = System.Drawing.Color.LightSlateGray;
            this.yillik_Rapor.ActiveForecolor = System.Drawing.Color.White;
            this.yillik_Rapor.ActiveLineColor = System.Drawing.Color.AliceBlue;
            this.yillik_Rapor.BackColor = System.Drawing.Color.LightSlateGray;
            this.yillik_Rapor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yillik_Rapor.BackgroundImage")));
            this.yillik_Rapor.ButtonText = "Yazdır";
            this.yillik_Rapor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yillik_Rapor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yillik_Rapor.ForeColor = System.Drawing.Color.LightSlateGray;
            this.yillik_Rapor.IdleBorderThickness = 1;
            this.yillik_Rapor.IdleCornerRadius = 20;
            this.yillik_Rapor.IdleFillColor = System.Drawing.Color.White;
            this.yillik_Rapor.IdleForecolor = System.Drawing.Color.LightSlateGray;
            this.yillik_Rapor.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.yillik_Rapor.Location = new System.Drawing.Point(15, 261);
            this.yillik_Rapor.Margin = new System.Windows.Forms.Padding(5);
            this.yillik_Rapor.Name = "yillik_Rapor";
            this.yillik_Rapor.Size = new System.Drawing.Size(107, 43);
            this.yillik_Rapor.TabIndex = 25;
            this.yillik_Rapor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yillik_Rapor.Click += new System.EventHandler(this.yillik_Rapor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Cambria", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(15, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(824, 195);
            this.dataGridView1.TabIndex = 1;
            // 
            // kapat_btn
            // 
            this.kapat_btn.ActiveBorderThickness = 1;
            this.kapat_btn.ActiveCornerRadius = 20;
            this.kapat_btn.ActiveFillColor = System.Drawing.Color.LightSlateGray;
            this.kapat_btn.ActiveForecolor = System.Drawing.Color.White;
            this.kapat_btn.ActiveLineColor = System.Drawing.Color.AliceBlue;
            this.kapat_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.kapat_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kapat_btn.BackgroundImage")));
            this.kapat_btn.ButtonText = "Kapat";
            this.kapat_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kapat_btn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapat_btn.ForeColor = System.Drawing.Color.LightSlateGray;
            this.kapat_btn.IdleBorderThickness = 1;
            this.kapat_btn.IdleCornerRadius = 20;
            this.kapat_btn.IdleFillColor = System.Drawing.Color.White;
            this.kapat_btn.IdleForecolor = System.Drawing.Color.LightSlateGray;
            this.kapat_btn.IdleLineColor = System.Drawing.Color.LightSlateGray;
            this.kapat_btn.Location = new System.Drawing.Point(719, 261);
            this.kapat_btn.Margin = new System.Windows.Forms.Padding(5);
            this.kapat_btn.Name = "kapat_btn";
            this.kapat_btn.Size = new System.Drawing.Size(120, 43);
            this.kapat_btn.TabIndex = 6;
            this.kapat_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kapat_btn.Click += new System.EventHandler(this.cikis_btn_Click);
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
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
        private Bunifu.Framework.UI.BunifuThinButton2 kapat_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 cikis_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 yillik_Rapor;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
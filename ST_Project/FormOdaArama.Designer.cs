namespace ST_Project
{
    partial class FormOdaArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOdaArama));
            this.elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlOdaTanımlama = new System.Windows.Forms.Panel();
            this.comboOdaAdi = new System.Windows.Forms.ComboBox();
            this.btnPDF_CiktiAl = new System.Windows.Forms.Button();
            this.btnOdaBilgileriniListele = new System.Windows.Forms.Button();
            this.lblOdaDemirbasBilgileri = new System.Windows.Forms.Label();
            this.lblOdaAdi = new System.Windows.Forms.Label();
            this.dgvOdaDemirbaslari = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.SiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemirbasKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemirbasAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemirbasAdedi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFakulteDepartman = new System.Windows.Forms.Label();
            this.lblOdaIslemleri = new System.Windows.Forms.Label();
            this.picOdaIslemleri = new System.Windows.Forms.PictureBox();
            this.picAnaSayfa = new System.Windows.Forms.PictureBox();
            this.pnlOdaTanımlama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdaDemirbaslari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOdaIslemleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnaSayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse
            // 
            this.elipse.ElipseRadius = 5;
            this.elipse.TargetControl = this;
            // 
            // pnlOdaTanımlama
            // 
            this.pnlOdaTanımlama.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlOdaTanımlama.Controls.Add(this.comboOdaAdi);
            this.pnlOdaTanımlama.Controls.Add(this.btnPDF_CiktiAl);
            this.pnlOdaTanımlama.Controls.Add(this.btnOdaBilgileriniListele);
            this.pnlOdaTanımlama.Controls.Add(this.lblOdaDemirbasBilgileri);
            this.pnlOdaTanımlama.Controls.Add(this.lblOdaAdi);
            this.pnlOdaTanımlama.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOdaTanımlama.Location = new System.Drawing.Point(0, 0);
            this.pnlOdaTanımlama.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOdaTanımlama.Name = "pnlOdaTanımlama";
            this.pnlOdaTanımlama.Size = new System.Drawing.Size(375, 419);
            this.pnlOdaTanımlama.TabIndex = 0;
            // 
            // comboOdaAdi
            // 
            this.comboOdaAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboOdaAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboOdaAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboOdaAdi.FormattingEnabled = true;
            this.comboOdaAdi.Location = new System.Drawing.Point(103, 178);
            this.comboOdaAdi.Margin = new System.Windows.Forms.Padding(2);
            this.comboOdaAdi.Name = "comboOdaAdi";
            this.comboOdaAdi.Size = new System.Drawing.Size(160, 25);
            this.comboOdaAdi.TabIndex = 91;
            // 
            // btnPDF_CiktiAl
            // 
            this.btnPDF_CiktiAl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPDF_CiktiAl.ForeColor = System.Drawing.Color.Black;
            this.btnPDF_CiktiAl.Location = new System.Drawing.Point(140, 277);
            this.btnPDF_CiktiAl.Margin = new System.Windows.Forms.Padding(2);
            this.btnPDF_CiktiAl.Name = "btnPDF_CiktiAl";
            this.btnPDF_CiktiAl.Size = new System.Drawing.Size(82, 28);
            this.btnPDF_CiktiAl.TabIndex = 22;
            this.btnPDF_CiktiAl.Text = "PDF Çıktı Al";
            this.btnPDF_CiktiAl.UseVisualStyleBackColor = true;
            this.btnPDF_CiktiAl.Click += new System.EventHandler(this.btnPDF_CiktiAl_Click);
            // 
            // btnOdaBilgileriniListele
            // 
            this.btnOdaBilgileriniListele.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaBilgileriniListele.ForeColor = System.Drawing.Color.Black;
            this.btnOdaBilgileriniListele.Location = new System.Drawing.Point(140, 234);
            this.btnOdaBilgileriniListele.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdaBilgileriniListele.Name = "btnOdaBilgileriniListele";
            this.btnOdaBilgileriniListele.Size = new System.Drawing.Size(82, 28);
            this.btnOdaBilgileriniListele.TabIndex = 22;
            this.btnOdaBilgileriniListele.Text = "Listele";
            this.btnOdaBilgileriniListele.UseVisualStyleBackColor = true;
            this.btnOdaBilgileriniListele.Click += new System.EventHandler(this.btnOdaBilgileriniListele_Click);
            // 
            // lblOdaDemirbasBilgileri
            // 
            this.lblOdaDemirbasBilgileri.AutoSize = true;
            this.lblOdaDemirbasBilgileri.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaDemirbasBilgileri.ForeColor = System.Drawing.Color.White;
            this.lblOdaDemirbasBilgileri.Location = new System.Drawing.Point(121, 54);
            this.lblOdaDemirbasBilgileri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOdaDemirbasBilgileri.Name = "lblOdaDemirbasBilgileri";
            this.lblOdaDemirbasBilgileri.Size = new System.Drawing.Size(130, 30);
            this.lblOdaDemirbasBilgileri.TabIndex = 20;
            this.lblOdaDemirbasBilgileri.Text = "Oda Arama";
            // 
            // lblOdaAdi
            // 
            this.lblOdaAdi.AutoSize = true;
            this.lblOdaAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaAdi.ForeColor = System.Drawing.Color.White;
            this.lblOdaAdi.Location = new System.Drawing.Point(141, 136);
            this.lblOdaAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOdaAdi.Name = "lblOdaAdi";
            this.lblOdaAdi.Size = new System.Drawing.Size(81, 25);
            this.lblOdaAdi.TabIndex = 23;
            this.lblOdaAdi.Text = "Oda Adı";
            // 
            // dgvOdaDemirbaslari
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvOdaDemirbaslari.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOdaDemirbaslari.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvOdaDemirbaslari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOdaDemirbaslari.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOdaDemirbaslari.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOdaDemirbaslari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdaDemirbaslari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SiraNo,
            this.DemirbasKodu,
            this.DemirbasAdi,
            this.DemirbasAdedi});
            this.dgvOdaDemirbaslari.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOdaDemirbaslari.DoubleBuffered = true;
            this.dgvOdaDemirbaslari.EnableHeadersVisualStyles = false;
            this.dgvOdaDemirbaslari.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvOdaDemirbaslari.HeaderForeColor = System.Drawing.Color.White;
            this.dgvOdaDemirbaslari.Location = new System.Drawing.Point(375, 53);
            this.dgvOdaDemirbaslari.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOdaDemirbaslari.Name = "dgvOdaDemirbaslari";
            this.dgvOdaDemirbaslari.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOdaDemirbaslari.RowTemplate.Height = 24;
            this.dgvOdaDemirbaslari.Size = new System.Drawing.Size(535, 366);
            this.dgvOdaDemirbaslari.TabIndex = 1;
            // 
            // SiraNo
            // 
            this.SiraNo.HeaderText = "Sıra No";
            this.SiraNo.Name = "SiraNo";
            this.SiraNo.Width = 50;
            // 
            // DemirbasKodu
            // 
            this.DemirbasKodu.HeaderText = "Demirbaş Kodu";
            this.DemirbasKodu.Name = "DemirbasKodu";
            this.DemirbasKodu.Width = 200;
            // 
            // DemirbasAdi
            // 
            this.DemirbasAdi.HeaderText = "Demirbaş Adı";
            this.DemirbasAdi.Name = "DemirbasAdi";
            this.DemirbasAdi.Width = 321;
            // 
            // DemirbasAdedi
            // 
            this.DemirbasAdedi.HeaderText = "Demirbaş Adedi";
            this.DemirbasAdedi.Name = "DemirbasAdedi";
            // 
            // lblFakulteDepartman
            // 
            this.lblFakulteDepartman.AutoSize = true;
            this.lblFakulteDepartman.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFakulteDepartman.ForeColor = System.Drawing.Color.White;
            this.lblFakulteDepartman.Location = new System.Drawing.Point(380, 10);
            this.lblFakulteDepartman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFakulteDepartman.Name = "lblFakulteDepartman";
            this.lblFakulteDepartman.Size = new System.Drawing.Size(0, 13);
            this.lblFakulteDepartman.TabIndex = 30;
            // 
            // lblOdaIslemleri
            // 
            this.lblOdaIslemleri.AutoSize = true;
            this.lblOdaIslemleri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaIslemleri.ForeColor = System.Drawing.Color.White;
            this.lblOdaIslemleri.Location = new System.Drawing.Point(754, 13);
            this.lblOdaIslemleri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOdaIslemleri.Name = "lblOdaIslemleri";
            this.lblOdaIslemleri.Size = new System.Drawing.Size(111, 21);
            this.lblOdaIslemleri.TabIndex = 41;
            this.lblOdaIslemleri.Text = "Oda İşlemleri";
            this.lblOdaIslemleri.Click += new System.EventHandler(this.lblOdaAtama_Click);
            // 
            // picOdaIslemleri
            // 
            this.picOdaIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("picOdaIslemleri.Image")));
            this.picOdaIslemleri.Location = new System.Drawing.Point(717, 7);
            this.picOdaIslemleri.Margin = new System.Windows.Forms.Padding(2);
            this.picOdaIslemleri.Name = "picOdaIslemleri";
            this.picOdaIslemleri.Size = new System.Drawing.Size(34, 33);
            this.picOdaIslemleri.TabIndex = 40;
            this.picOdaIslemleri.TabStop = false;
            this.picOdaIslemleri.Click += new System.EventHandler(this.picOdaAtama_Click);
            // 
            // picAnaSayfa
            // 
            this.picAnaSayfa.Image = ((System.Drawing.Image)(resources.GetObject("picAnaSayfa.Image")));
            this.picAnaSayfa.Location = new System.Drawing.Point(869, 6);
            this.picAnaSayfa.Margin = new System.Windows.Forms.Padding(2);
            this.picAnaSayfa.Name = "picAnaSayfa";
            this.picAnaSayfa.Size = new System.Drawing.Size(32, 38);
            this.picAnaSayfa.TabIndex = 39;
            this.picAnaSayfa.TabStop = false;
            this.picAnaSayfa.Click += new System.EventHandler(this.picAnaSayfa_Click);
            // 
            // frmOdaArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(910, 419);
            this.Controls.Add(this.lblOdaIslemleri);
            this.Controls.Add(this.picOdaIslemleri);
            this.Controls.Add(this.picAnaSayfa);
            this.Controls.Add(this.lblFakulteDepartman);
            this.Controls.Add(this.dgvOdaDemirbaslari);
            this.Controls.Add(this.pnlOdaTanımlama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmOdaArama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flamingo | Oda Arama";
            this.Load += new System.EventHandler(this.frmOdaArama_Load);
            this.pnlOdaTanımlama.ResumeLayout(false);
            this.pnlOdaTanımlama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdaDemirbaslari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOdaIslemleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnaSayfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipse;
        private System.Windows.Forms.Panel pnlOdaTanımlama;
        private System.Windows.Forms.Label lblOdaAdi;
        private System.Windows.Forms.Label lblOdaDemirbasBilgileri;
        private System.Windows.Forms.Button btnOdaBilgileriniListele;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvOdaDemirbaslari;
        private System.Windows.Forms.Label lblFakulteDepartman;
        private System.Windows.Forms.Button btnPDF_CiktiAl;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemirbasKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemirbasAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemirbasAdedi;
        private System.Windows.Forms.Label lblOdaIslemleri;
        private System.Windows.Forms.PictureBox picOdaIslemleri;
        private System.Windows.Forms.PictureBox picAnaSayfa;
        private System.Windows.Forms.ComboBox comboOdaAdi;
    }
}
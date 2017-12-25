namespace ST_Project
{
    partial class FormDemirbasArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDemirbasArama));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlDemirbasArama = new System.Windows.Forms.Panel();
            this.dateAlimTarihi = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnDemirbasAra = new System.Windows.Forms.Button();
            this.lblDemirbasArama = new System.Windows.Forms.Label();
            this.txtAdedineGore = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.rbAdedineGore = new System.Windows.Forms.RadioButton();
            this.rbAlimTarihineGore = new System.Windows.Forms.RadioButton();
            this.txtFiyatinaGore = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.rbFiyatinaGore = new System.Windows.Forms.RadioButton();
            this.txtTuruneGore = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.rbTuruneGore = new System.Windows.Forms.RadioButton();
            this.txtAdinaGore = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.rbAdinaGore = new System.Windows.Forms.RadioButton();
            this.picAnaSayfa = new System.Windows.Forms.PictureBox();
            this.picDemirbasIslemleri = new System.Windows.Forms.PictureBox();
            this.lblDemirbasIslemleri = new System.Windows.Forms.Label();
            this.dgvDemirbasArama = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.SiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlimTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHepsiniAra = new System.Windows.Forms.Button();
            this.pnlDemirbasArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnaSayfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDemirbasIslemleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemirbasArama)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlDemirbasArama
            // 
            this.pnlDemirbasArama.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlDemirbasArama.Controls.Add(this.btnHepsiniAra);
            this.pnlDemirbasArama.Controls.Add(this.dateAlimTarihi);
            this.pnlDemirbasArama.Controls.Add(this.btnDemirbasAra);
            this.pnlDemirbasArama.Controls.Add(this.lblDemirbasArama);
            this.pnlDemirbasArama.Controls.Add(this.txtAdedineGore);
            this.pnlDemirbasArama.Controls.Add(this.rbAdedineGore);
            this.pnlDemirbasArama.Controls.Add(this.rbAlimTarihineGore);
            this.pnlDemirbasArama.Controls.Add(this.txtFiyatinaGore);
            this.pnlDemirbasArama.Controls.Add(this.rbFiyatinaGore);
            this.pnlDemirbasArama.Controls.Add(this.txtTuruneGore);
            this.pnlDemirbasArama.Controls.Add(this.rbTuruneGore);
            this.pnlDemirbasArama.Controls.Add(this.txtAdinaGore);
            this.pnlDemirbasArama.Controls.Add(this.rbAdinaGore);
            this.pnlDemirbasArama.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDemirbasArama.Location = new System.Drawing.Point(0, 0);
            this.pnlDemirbasArama.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDemirbasArama.Name = "pnlDemirbasArama";
            this.pnlDemirbasArama.Size = new System.Drawing.Size(375, 419);
            this.pnlDemirbasArama.TabIndex = 1;
            // 
            // dateAlimTarihi
            // 
            this.dateAlimTarihi.BackColor = System.Drawing.Color.SeaGreen;
            this.dateAlimTarihi.BorderRadius = 0;
            this.dateAlimTarihi.Enabled = false;
            this.dateAlimTarihi.ForeColor = System.Drawing.Color.White;
            this.dateAlimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateAlimTarihi.FormatCustom = null;
            this.dateAlimTarihi.Location = new System.Drawing.Point(151, 274);
            this.dateAlimTarihi.Name = "dateAlimTarihi";
            this.dateAlimTarihi.Size = new System.Drawing.Size(169, 19);
            this.dateAlimTarihi.TabIndex = 38;
            this.dateAlimTarihi.Value = new System.DateTime(2017, 12, 1, 0, 0, 0, 0);
            // 
            // btnDemirbasAra
            // 
            this.btnDemirbasAra.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDemirbasAra.ForeColor = System.Drawing.Color.Black;
            this.btnDemirbasAra.Location = new System.Drawing.Point(151, 323);
            this.btnDemirbasAra.Margin = new System.Windows.Forms.Padding(2);
            this.btnDemirbasAra.Name = "btnDemirbasAra";
            this.btnDemirbasAra.Size = new System.Drawing.Size(169, 28);
            this.btnDemirbasAra.TabIndex = 37;
            this.btnDemirbasAra.Text = "Ara";
            this.btnDemirbasAra.UseVisualStyleBackColor = true;
            this.btnDemirbasAra.Click += new System.EventHandler(this.btnDemirbasAra_Click);
            // 
            // lblDemirbasArama
            // 
            this.lblDemirbasArama.AutoSize = true;
            this.lblDemirbasArama.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDemirbasArama.ForeColor = System.Drawing.Color.White;
            this.lblDemirbasArama.Location = new System.Drawing.Point(103, 63);
            this.lblDemirbasArama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDemirbasArama.Name = "lblDemirbasArama";
            this.lblDemirbasArama.Size = new System.Drawing.Size(186, 30);
            this.lblDemirbasArama.TabIndex = 36;
            this.lblDemirbasArama.Text = "Demirbaş Arama";
            // 
            // txtAdedineGore
            // 
            this.txtAdedineGore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdedineGore.Enabled = false;
            this.txtAdedineGore.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtAdedineGore.ForeColor = System.Drawing.Color.White;
            this.txtAdedineGore.HintForeColor = System.Drawing.Color.White;
            this.txtAdedineGore.HintText = "";
            this.txtAdedineGore.isPassword = false;
            this.txtAdedineGore.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtAdedineGore.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAdedineGore.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtAdedineGore.LineThickness = 4;
            this.txtAdedineGore.Location = new System.Drawing.Point(151, 229);
            this.txtAdedineGore.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtAdedineGore.Name = "txtAdedineGore";
            this.txtAdedineGore.Size = new System.Drawing.Size(169, 30);
            this.txtAdedineGore.TabIndex = 34;
            this.txtAdedineGore.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rbAdedineGore
            // 
            this.rbAdedineGore.AutoSize = true;
            this.rbAdedineGore.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAdedineGore.ForeColor = System.Drawing.Color.White;
            this.rbAdedineGore.Location = new System.Drawing.Point(27, 237);
            this.rbAdedineGore.Margin = new System.Windows.Forms.Padding(2);
            this.rbAdedineGore.Name = "rbAdedineGore";
            this.rbAdedineGore.Size = new System.Drawing.Size(97, 19);
            this.rbAdedineGore.TabIndex = 35;
            this.rbAdedineGore.TabStop = true;
            this.rbAdedineGore.Text = "Adedine Göre";
            this.rbAdedineGore.UseVisualStyleBackColor = true;
            this.rbAdedineGore.CheckedChanged += new System.EventHandler(this.rbAdedineGore_CheckedChanged);
            // 
            // rbAlimTarihineGore
            // 
            this.rbAlimTarihineGore.AutoSize = true;
            this.rbAlimTarihineGore.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAlimTarihineGore.ForeColor = System.Drawing.Color.White;
            this.rbAlimTarihineGore.Location = new System.Drawing.Point(27, 274);
            this.rbAlimTarihineGore.Margin = new System.Windows.Forms.Padding(2);
            this.rbAlimTarihineGore.Name = "rbAlimTarihineGore";
            this.rbAlimTarihineGore.Size = new System.Drawing.Size(123, 19);
            this.rbAlimTarihineGore.TabIndex = 33;
            this.rbAlimTarihineGore.TabStop = true;
            this.rbAlimTarihineGore.Text = "Alım Tarihine Göre";
            this.rbAlimTarihineGore.UseVisualStyleBackColor = true;
            this.rbAlimTarihineGore.CheckedChanged += new System.EventHandler(this.rbAlimTarihineGore_CheckedChanged);
            // 
            // txtFiyatinaGore
            // 
            this.txtFiyatinaGore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiyatinaGore.Enabled = false;
            this.txtFiyatinaGore.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtFiyatinaGore.ForeColor = System.Drawing.Color.White;
            this.txtFiyatinaGore.HintForeColor = System.Drawing.Color.White;
            this.txtFiyatinaGore.HintText = "";
            this.txtFiyatinaGore.isPassword = false;
            this.txtFiyatinaGore.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtFiyatinaGore.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFiyatinaGore.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtFiyatinaGore.LineThickness = 4;
            this.txtFiyatinaGore.Location = new System.Drawing.Point(151, 193);
            this.txtFiyatinaGore.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtFiyatinaGore.Name = "txtFiyatinaGore";
            this.txtFiyatinaGore.Size = new System.Drawing.Size(169, 30);
            this.txtFiyatinaGore.TabIndex = 30;
            this.txtFiyatinaGore.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rbFiyatinaGore
            // 
            this.rbFiyatinaGore.AutoSize = true;
            this.rbFiyatinaGore.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbFiyatinaGore.ForeColor = System.Drawing.Color.White;
            this.rbFiyatinaGore.Location = new System.Drawing.Point(27, 201);
            this.rbFiyatinaGore.Margin = new System.Windows.Forms.Padding(2);
            this.rbFiyatinaGore.Name = "rbFiyatinaGore";
            this.rbFiyatinaGore.Size = new System.Drawing.Size(94, 19);
            this.rbFiyatinaGore.TabIndex = 31;
            this.rbFiyatinaGore.TabStop = true;
            this.rbFiyatinaGore.Text = "Fiyatına Göre";
            this.rbFiyatinaGore.UseVisualStyleBackColor = true;
            this.rbFiyatinaGore.CheckedChanged += new System.EventHandler(this.rbFiyatinaGore_CheckedChanged);
            // 
            // txtTuruneGore
            // 
            this.txtTuruneGore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTuruneGore.Enabled = false;
            this.txtTuruneGore.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtTuruneGore.ForeColor = System.Drawing.Color.White;
            this.txtTuruneGore.HintForeColor = System.Drawing.Color.White;
            this.txtTuruneGore.HintText = "";
            this.txtTuruneGore.isPassword = false;
            this.txtTuruneGore.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtTuruneGore.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTuruneGore.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtTuruneGore.LineThickness = 4;
            this.txtTuruneGore.Location = new System.Drawing.Point(151, 156);
            this.txtTuruneGore.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTuruneGore.Name = "txtTuruneGore";
            this.txtTuruneGore.Size = new System.Drawing.Size(169, 30);
            this.txtTuruneGore.TabIndex = 28;
            this.txtTuruneGore.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rbTuruneGore
            // 
            this.rbTuruneGore.AutoSize = true;
            this.rbTuruneGore.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTuruneGore.ForeColor = System.Drawing.Color.White;
            this.rbTuruneGore.Location = new System.Drawing.Point(27, 164);
            this.rbTuruneGore.Margin = new System.Windows.Forms.Padding(2);
            this.rbTuruneGore.Name = "rbTuruneGore";
            this.rbTuruneGore.Size = new System.Drawing.Size(90, 19);
            this.rbTuruneGore.TabIndex = 29;
            this.rbTuruneGore.TabStop = true;
            this.rbTuruneGore.Text = "Türüne Göre";
            this.rbTuruneGore.UseVisualStyleBackColor = true;
            this.rbTuruneGore.CheckedChanged += new System.EventHandler(this.rbTuruneGore_CheckedChanged);
            // 
            // txtAdinaGore
            // 
            this.txtAdinaGore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdinaGore.Enabled = false;
            this.txtAdinaGore.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtAdinaGore.ForeColor = System.Drawing.Color.White;
            this.txtAdinaGore.HintForeColor = System.Drawing.Color.White;
            this.txtAdinaGore.HintText = "";
            this.txtAdinaGore.isPassword = false;
            this.txtAdinaGore.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtAdinaGore.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAdinaGore.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtAdinaGore.LineThickness = 4;
            this.txtAdinaGore.Location = new System.Drawing.Point(151, 119);
            this.txtAdinaGore.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtAdinaGore.Name = "txtAdinaGore";
            this.txtAdinaGore.Size = new System.Drawing.Size(169, 30);
            this.txtAdinaGore.TabIndex = 26;
            this.txtAdinaGore.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rbAdinaGore
            // 
            this.rbAdinaGore.AutoSize = true;
            this.rbAdinaGore.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAdinaGore.ForeColor = System.Drawing.Color.White;
            this.rbAdinaGore.Location = new System.Drawing.Point(27, 128);
            this.rbAdinaGore.Margin = new System.Windows.Forms.Padding(2);
            this.rbAdinaGore.Name = "rbAdinaGore";
            this.rbAdinaGore.Size = new System.Drawing.Size(84, 19);
            this.rbAdinaGore.TabIndex = 27;
            this.rbAdinaGore.TabStop = true;
            this.rbAdinaGore.Text = "Adına Göre";
            this.rbAdinaGore.UseVisualStyleBackColor = true;
            this.rbAdinaGore.CheckedChanged += new System.EventHandler(this.rbAdinaGore_CheckedChanged);
            // 
            // picAnaSayfa
            // 
            this.picAnaSayfa.Image = ((System.Drawing.Image)(resources.GetObject("picAnaSayfa.Image")));
            this.picAnaSayfa.Location = new System.Drawing.Point(869, 6);
            this.picAnaSayfa.Margin = new System.Windows.Forms.Padding(2);
            this.picAnaSayfa.Name = "picAnaSayfa";
            this.picAnaSayfa.Size = new System.Drawing.Size(32, 38);
            this.picAnaSayfa.TabIndex = 27;
            this.picAnaSayfa.TabStop = false;
            this.picAnaSayfa.Click += new System.EventHandler(this.picAnaSayfa_Click);
            // 
            // picDemirbasIslemleri
            // 
            this.picDemirbasIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("picDemirbasIslemleri.Image")));
            this.picDemirbasIslemleri.Location = new System.Drawing.Point(675, 7);
            this.picDemirbasIslemleri.Margin = new System.Windows.Forms.Padding(2);
            this.picDemirbasIslemleri.Name = "picDemirbasIslemleri";
            this.picDemirbasIslemleri.Size = new System.Drawing.Size(34, 33);
            this.picDemirbasIslemleri.TabIndex = 30;
            this.picDemirbasIslemleri.TabStop = false;
            this.picDemirbasIslemleri.Click += new System.EventHandler(this.picDemirbasKaydi_Click);
            // 
            // lblDemirbasIslemleri
            // 
            this.lblDemirbasIslemleri.AutoSize = true;
            this.lblDemirbasIslemleri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDemirbasIslemleri.ForeColor = System.Drawing.Color.White;
            this.lblDemirbasIslemleri.Location = new System.Drawing.Point(712, 13);
            this.lblDemirbasIslemleri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDemirbasIslemleri.Name = "lblDemirbasIslemleri";
            this.lblDemirbasIslemleri.Size = new System.Drawing.Size(153, 21);
            this.lblDemirbasIslemleri.TabIndex = 38;
            this.lblDemirbasIslemleri.Text = "Demirbaş İşlemleri";
            this.lblDemirbasIslemleri.Click += new System.EventHandler(this.lblDemirbasKaydi_Click);
            // 
            // dgvDemirbasArama
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDemirbasArama.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDemirbasArama.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDemirbasArama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDemirbasArama.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDemirbasArama.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDemirbasArama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemirbasArama.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SiraNo,
            this.Ad,
            this.Tur,
            this.Fiyat,
            this.AlimTarihi,
            this.Adet});
            this.dgvDemirbasArama.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDemirbasArama.DoubleBuffered = true;
            this.dgvDemirbasArama.EnableHeadersVisualStyles = false;
            this.dgvDemirbasArama.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvDemirbasArama.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDemirbasArama.Location = new System.Drawing.Point(375, 53);
            this.dgvDemirbasArama.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDemirbasArama.Name = "dgvDemirbasArama";
            this.dgvDemirbasArama.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDemirbasArama.RowTemplate.Height = 24;
            this.dgvDemirbasArama.Size = new System.Drawing.Size(535, 366);
            this.dgvDemirbasArama.TabIndex = 39;
            // 
            // SiraNo
            // 
            this.SiraNo.HeaderText = "Sıra No";
            this.SiraNo.Name = "SiraNo";
            this.SiraNo.Width = 77;
            // 
            // Ad
            // 
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            this.Ad.Width = 245;
            // 
            // Tur
            // 
            this.Tur.HeaderText = "Tür";
            this.Tur.Name = "Tur";
            // 
            // Fiyat
            // 
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.Name = "Fiyat";
            // 
            // AlimTarihi
            // 
            this.AlimTarihi.HeaderText = "Alım Tarihi";
            this.AlimTarihi.Name = "AlimTarihi";
            // 
            // Adet
            // 
            this.Adet.HeaderText = "Adet";
            this.Adet.Name = "Adet";
            this.Adet.Width = 50;
            // 
            // btnHepsiniAra
            // 
            this.btnHepsiniAra.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsiniAra.ForeColor = System.Drawing.Color.Black;
            this.btnHepsiniAra.Location = new System.Drawing.Point(151, 355);
            this.btnHepsiniAra.Margin = new System.Windows.Forms.Padding(2);
            this.btnHepsiniAra.Name = "btnHepsiniAra";
            this.btnHepsiniAra.Size = new System.Drawing.Size(169, 28);
            this.btnHepsiniAra.TabIndex = 39;
            this.btnHepsiniAra.Text = "Hepsini Ara";
            this.btnHepsiniAra.UseVisualStyleBackColor = true;
            this.btnHepsiniAra.Click += new System.EventHandler(this.btnHepsiniAra_Click);
            // 
            // frmDemirbasArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(910, 419);
            this.Controls.Add(this.dgvDemirbasArama);
            this.Controls.Add(this.lblDemirbasIslemleri);
            this.Controls.Add(this.picDemirbasIslemleri);
            this.Controls.Add(this.picAnaSayfa);
            this.Controls.Add(this.pnlDemirbasArama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDemirbasArama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flamingo | Demirbaş Arama";
            this.Load += new System.EventHandler(this.frmDemirbasArama_Load);
            this.pnlDemirbasArama.ResumeLayout(false);
            this.pnlDemirbasArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnaSayfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDemirbasIslemleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemirbasArama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlDemirbasArama;
        private System.Windows.Forms.PictureBox picAnaSayfa;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAdedineGore;
        private System.Windows.Forms.RadioButton rbAdedineGore;
        private System.Windows.Forms.RadioButton rbAlimTarihineGore;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFiyatinaGore;
        private System.Windows.Forms.RadioButton rbFiyatinaGore;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTuruneGore;
        private System.Windows.Forms.RadioButton rbTuruneGore;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAdinaGore;
        private System.Windows.Forms.RadioButton rbAdinaGore;
        private System.Windows.Forms.Label lblDemirbasArama;
        private System.Windows.Forms.Button btnDemirbasAra;
        private System.Windows.Forms.Label lblDemirbasIslemleri;
        private System.Windows.Forms.PictureBox picDemirbasIslemleri;
        private Bunifu.Framework.UI.BunifuDatepicker dateAlimTarihi;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDemirbasArama;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlimTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.Button btnHepsiniAra;
    }
}
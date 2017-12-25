namespace ST_Project
{
    partial class FormPersonelIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonelIslemleri));
            this.elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlFlamingo = new System.Windows.Forms.Panel();
            this.lblFlamingo = new System.Windows.Forms.Label();
            this.picFlamingo = new System.Windows.Forms.PictureBox();
            this.tabPersonelIslemler = new System.Windows.Forms.TabControl();
            this.tabEkle = new System.Windows.Forms.TabPage();
            this.txtPersonelSoyadi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnPersoneleOdaAtama = new System.Windows.Forms.Button();
            this.comboEkleOda = new System.Windows.Forms.ComboBox();
            this.lblOda = new System.Windows.Forms.Label();
            this.comboEkleDepartman = new System.Windows.Forms.ComboBox();
            this.lblDepartman = new System.Windows.Forms.Label();
            this.comboEkleFakulte = new System.Windows.Forms.ComboBox();
            this.lblFakulte = new System.Windows.Forms.Label();
            this.lblPersonelAdi = new System.Windows.Forms.Label();
            this.txtPersonelAdi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tabGuncelle = new System.Windows.Forms.TabPage();
            this.txtGuncellenecekPersonelYeniSoyadi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtGuncellenecekPersonelYeniAdi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtGuncellenecekPersonelSoyadi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYeniSifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtYeniKullaniciAdi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtGuncellenecekPersonelAdi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tabSil = new System.Windows.Forms.TabPage();
            this.comboSilPersonel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblPersonelArama = new System.Windows.Forms.Label();
            this.picPersonelArama = new System.Windows.Forms.PictureBox();
            this.picAnaSayfa = new System.Windows.Forms.PictureBox();
            this.pnlFlamingo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlamingo)).BeginInit();
            this.tabPersonelIslemler.SuspendLayout();
            this.tabEkle.SuspendLayout();
            this.tabGuncelle.SuspendLayout();
            this.tabSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonelArama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnaSayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse
            // 
            this.elipse.ElipseRadius = 5;
            this.elipse.TargetControl = this;
            // 
            // pnlFlamingo
            // 
            this.pnlFlamingo.BackColor = System.Drawing.Color.Teal;
            this.pnlFlamingo.Controls.Add(this.lblFlamingo);
            this.pnlFlamingo.Controls.Add(this.picFlamingo);
            this.pnlFlamingo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFlamingo.Location = new System.Drawing.Point(0, 0);
            this.pnlFlamingo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFlamingo.Name = "pnlFlamingo";
            this.pnlFlamingo.Size = new System.Drawing.Size(450, 419);
            this.pnlFlamingo.TabIndex = 44;
            // 
            // lblFlamingo
            // 
            this.lblFlamingo.AutoSize = true;
            this.lblFlamingo.Font = new System.Drawing.Font("Segoe UI Semibold", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFlamingo.ForeColor = System.Drawing.Color.White;
            this.lblFlamingo.Location = new System.Drawing.Point(111, 311);
            this.lblFlamingo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFlamingo.Name = "lblFlamingo";
            this.lblFlamingo.Size = new System.Drawing.Size(228, 62);
            this.lblFlamingo.TabIndex = 10;
            this.lblFlamingo.Text = "FLAMİNGO\r\nSTOK TAKİP SİSTEMİ";
            this.lblFlamingo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picFlamingo
            // 
            this.picFlamingo.Image = ((System.Drawing.Image)(resources.GetObject("picFlamingo.Image")));
            this.picFlamingo.Location = new System.Drawing.Point(129, 45);
            this.picFlamingo.Margin = new System.Windows.Forms.Padding(2);
            this.picFlamingo.Name = "picFlamingo";
            this.picFlamingo.Size = new System.Drawing.Size(190, 252);
            this.picFlamingo.TabIndex = 9;
            this.picFlamingo.TabStop = false;
            // 
            // tabPersonelIslemler
            // 
            this.tabPersonelIslemler.Controls.Add(this.tabEkle);
            this.tabPersonelIslemler.Controls.Add(this.tabGuncelle);
            this.tabPersonelIslemler.Controls.Add(this.tabSil);
            this.tabPersonelIslemler.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPersonelIslemler.Location = new System.Drawing.Point(490, 58);
            this.tabPersonelIslemler.Margin = new System.Windows.Forms.Padding(2);
            this.tabPersonelIslemler.Multiline = true;
            this.tabPersonelIslemler.Name = "tabPersonelIslemler";
            this.tabPersonelIslemler.SelectedIndex = 0;
            this.tabPersonelIslemler.Size = new System.Drawing.Size(382, 306);
            this.tabPersonelIslemler.TabIndex = 59;
            this.tabPersonelIslemler.SelectedIndexChanged += new System.EventHandler(this.tabPersonelIslemler_SelectedIndexChanged);
            // 
            // tabEkle
            // 
            this.tabEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.tabEkle.Controls.Add(this.txtPersonelSoyadi);
            this.tabEkle.Controls.Add(this.btnPersoneleOdaAtama);
            this.tabEkle.Controls.Add(this.comboEkleOda);
            this.tabEkle.Controls.Add(this.lblOda);
            this.tabEkle.Controls.Add(this.comboEkleDepartman);
            this.tabEkle.Controls.Add(this.lblDepartman);
            this.tabEkle.Controls.Add(this.comboEkleFakulte);
            this.tabEkle.Controls.Add(this.lblFakulte);
            this.tabEkle.Controls.Add(this.lblPersonelAdi);
            this.tabEkle.Controls.Add(this.txtPersonelAdi);
            this.tabEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabEkle.Location = new System.Drawing.Point(4, 24);
            this.tabEkle.Margin = new System.Windows.Forms.Padding(2);
            this.tabEkle.Name = "tabEkle";
            this.tabEkle.Padding = new System.Windows.Forms.Padding(2);
            this.tabEkle.Size = new System.Drawing.Size(374, 278);
            this.tabEkle.TabIndex = 0;
            this.tabEkle.Text = "Odaya Ata";
            // 
            // txtPersonelSoyadi
            // 
            this.txtPersonelSoyadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonelSoyadi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtPersonelSoyadi.ForeColor = System.Drawing.Color.White;
            this.txtPersonelSoyadi.HintForeColor = System.Drawing.Color.White;
            this.txtPersonelSoyadi.HintText = "";
            this.txtPersonelSoyadi.isPassword = false;
            this.txtPersonelSoyadi.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtPersonelSoyadi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPersonelSoyadi.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtPersonelSoyadi.LineThickness = 4;
            this.txtPersonelSoyadi.Location = new System.Drawing.Point(245, 49);
            this.txtPersonelSoyadi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPersonelSoyadi.Name = "txtPersonelSoyadi";
            this.txtPersonelSoyadi.Size = new System.Drawing.Size(76, 29);
            this.txtPersonelSoyadi.TabIndex = 77;
            this.txtPersonelSoyadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnPersoneleOdaAtama
            // 
            this.btnPersoneleOdaAtama.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersoneleOdaAtama.ForeColor = System.Drawing.Color.Black;
            this.btnPersoneleOdaAtama.Location = new System.Drawing.Point(163, 202);
            this.btnPersoneleOdaAtama.Margin = new System.Windows.Forms.Padding(2);
            this.btnPersoneleOdaAtama.Name = "btnPersoneleOdaAtama";
            this.btnPersoneleOdaAtama.Size = new System.Drawing.Size(159, 28);
            this.btnPersoneleOdaAtama.TabIndex = 71;
            this.btnPersoneleOdaAtama.Text = "Ekle";
            this.btnPersoneleOdaAtama.UseVisualStyleBackColor = true;
            this.btnPersoneleOdaAtama.Click += new System.EventHandler(this.btnPersoneleOdaAtama_Click);
            // 
            // comboEkleOda
            // 
            this.comboEkleOda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboEkleOda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboEkleOda.FormattingEnabled = true;
            this.comboEkleOda.Location = new System.Drawing.Point(163, 168);
            this.comboEkleOda.Margin = new System.Windows.Forms.Padding(2);
            this.comboEkleOda.Name = "comboEkleOda";
            this.comboEkleOda.Size = new System.Drawing.Size(160, 27);
            this.comboEkleOda.TabIndex = 76;
            this.comboEkleOda.SelectedIndexChanged += new System.EventHandler(this.comboEkleOda_SelectedIndexChanged);
            // 
            // lblOda
            // 
            this.lblOda.AutoSize = true;
            this.lblOda.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOda.ForeColor = System.Drawing.Color.White;
            this.lblOda.Location = new System.Drawing.Point(59, 172);
            this.lblOda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOda.Name = "lblOda";
            this.lblOda.Size = new System.Drawing.Size(29, 15);
            this.lblOda.TabIndex = 75;
            this.lblOda.Text = "Oda";
            // 
            // comboEkleDepartman
            // 
            this.comboEkleDepartman.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboEkleDepartman.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboEkleDepartman.FormattingEnabled = true;
            this.comboEkleDepartman.Location = new System.Drawing.Point(163, 132);
            this.comboEkleDepartman.Margin = new System.Windows.Forms.Padding(2);
            this.comboEkleDepartman.Name = "comboEkleDepartman";
            this.comboEkleDepartman.Size = new System.Drawing.Size(160, 27);
            this.comboEkleDepartman.TabIndex = 74;
            this.comboEkleDepartman.SelectedIndexChanged += new System.EventHandler(this.comboEkleDepartman_SelectedIndexChanged);
            // 
            // lblDepartman
            // 
            this.lblDepartman.AutoSize = true;
            this.lblDepartman.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartman.ForeColor = System.Drawing.Color.White;
            this.lblDepartman.Location = new System.Drawing.Point(59, 136);
            this.lblDepartman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(67, 15);
            this.lblDepartman.TabIndex = 73;
            this.lblDepartman.Text = "Departman";
            // 
            // comboEkleFakulte
            // 
            this.comboEkleFakulte.AutoCompleteCustomSource.AddRange(new string[] {
            "fdsfdkslf",
            "dsfjdslkflkasj",
            "sadaskdaslkdas",
            "aslkdaslkdas"});
            this.comboEkleFakulte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboEkleFakulte.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboEkleFakulte.FormattingEnabled = true;
            this.comboEkleFakulte.Location = new System.Drawing.Point(163, 97);
            this.comboEkleFakulte.Margin = new System.Windows.Forms.Padding(2);
            this.comboEkleFakulte.Name = "comboEkleFakulte";
            this.comboEkleFakulte.Size = new System.Drawing.Size(160, 27);
            this.comboEkleFakulte.TabIndex = 72;
            this.comboEkleFakulte.SelectedIndexChanged += new System.EventHandler(this.comboEkleFakulte_SelectedIndexChanged);
            // 
            // lblFakulte
            // 
            this.lblFakulte.AutoSize = true;
            this.lblFakulte.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFakulte.ForeColor = System.Drawing.Color.White;
            this.lblFakulte.Location = new System.Drawing.Point(59, 101);
            this.lblFakulte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFakulte.Name = "lblFakulte";
            this.lblFakulte.Size = new System.Drawing.Size(45, 15);
            this.lblFakulte.TabIndex = 70;
            this.lblFakulte.Text = "Fakülte";
            // 
            // lblPersonelAdi
            // 
            this.lblPersonelAdi.AutoSize = true;
            this.lblPersonelAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelAdi.ForeColor = System.Drawing.Color.White;
            this.lblPersonelAdi.Location = new System.Drawing.Point(59, 62);
            this.lblPersonelAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonelAdi.Name = "lblPersonelAdi";
            this.lblPersonelAdi.Size = new System.Drawing.Size(79, 15);
            this.lblPersonelAdi.TabIndex = 69;
            this.lblPersonelAdi.Text = "Adı ve Soyadı";
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonelAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtPersonelAdi.ForeColor = System.Drawing.Color.White;
            this.txtPersonelAdi.HintForeColor = System.Drawing.Color.White;
            this.txtPersonelAdi.HintText = "";
            this.txtPersonelAdi.isPassword = false;
            this.txtPersonelAdi.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtPersonelAdi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPersonelAdi.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtPersonelAdi.LineThickness = 4;
            this.txtPersonelAdi.Location = new System.Drawing.Point(163, 49);
            this.txtPersonelAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.Size = new System.Drawing.Size(76, 29);
            this.txtPersonelAdi.TabIndex = 68;
            this.txtPersonelAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tabGuncelle
            // 
            this.tabGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.tabGuncelle.Controls.Add(this.txtGuncellenecekPersonelYeniSoyadi);
            this.tabGuncelle.Controls.Add(this.txtGuncellenecekPersonelYeniAdi);
            this.tabGuncelle.Controls.Add(this.txtGuncellenecekPersonelSoyadi);
            this.tabGuncelle.Controls.Add(this.btnGuncelle);
            this.tabGuncelle.Controls.Add(this.label4);
            this.tabGuncelle.Controls.Add(this.label3);
            this.tabGuncelle.Controls.Add(this.label2);
            this.tabGuncelle.Controls.Add(this.label1);
            this.tabGuncelle.Controls.Add(this.txtYeniSifre);
            this.tabGuncelle.Controls.Add(this.txtYeniKullaniciAdi);
            this.tabGuncelle.Controls.Add(this.txtGuncellenecekPersonelAdi);
            this.tabGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabGuncelle.Location = new System.Drawing.Point(4, 24);
            this.tabGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.tabGuncelle.Name = "tabGuncelle";
            this.tabGuncelle.Padding = new System.Windows.Forms.Padding(2);
            this.tabGuncelle.Size = new System.Drawing.Size(374, 278);
            this.tabGuncelle.TabIndex = 2;
            this.tabGuncelle.Text = "Güncelle";
            // 
            // txtGuncellenecekPersonelYeniSoyadi
            // 
            this.txtGuncellenecekPersonelYeniSoyadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGuncellenecekPersonelYeniSoyadi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtGuncellenecekPersonelYeniSoyadi.ForeColor = System.Drawing.Color.White;
            this.txtGuncellenecekPersonelYeniSoyadi.HintForeColor = System.Drawing.Color.White;
            this.txtGuncellenecekPersonelYeniSoyadi.HintText = "";
            this.txtGuncellenecekPersonelYeniSoyadi.isPassword = false;
            this.txtGuncellenecekPersonelYeniSoyadi.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtGuncellenecekPersonelYeniSoyadi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtGuncellenecekPersonelYeniSoyadi.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtGuncellenecekPersonelYeniSoyadi.LineThickness = 4;
            this.txtGuncellenecekPersonelYeniSoyadi.Location = new System.Drawing.Point(243, 79);
            this.txtGuncellenecekPersonelYeniSoyadi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGuncellenecekPersonelYeniSoyadi.Name = "txtGuncellenecekPersonelYeniSoyadi";
            this.txtGuncellenecekPersonelYeniSoyadi.Size = new System.Drawing.Size(72, 29);
            this.txtGuncellenecekPersonelYeniSoyadi.TabIndex = 77;
            this.txtGuncellenecekPersonelYeniSoyadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtGuncellenecekPersonelYeniAdi
            // 
            this.txtGuncellenecekPersonelYeniAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGuncellenecekPersonelYeniAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtGuncellenecekPersonelYeniAdi.ForeColor = System.Drawing.Color.White;
            this.txtGuncellenecekPersonelYeniAdi.HintForeColor = System.Drawing.Color.White;
            this.txtGuncellenecekPersonelYeniAdi.HintText = "";
            this.txtGuncellenecekPersonelYeniAdi.isPassword = false;
            this.txtGuncellenecekPersonelYeniAdi.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtGuncellenecekPersonelYeniAdi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtGuncellenecekPersonelYeniAdi.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtGuncellenecekPersonelYeniAdi.LineThickness = 4;
            this.txtGuncellenecekPersonelYeniAdi.Location = new System.Drawing.Point(156, 79);
            this.txtGuncellenecekPersonelYeniAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGuncellenecekPersonelYeniAdi.Name = "txtGuncellenecekPersonelYeniAdi";
            this.txtGuncellenecekPersonelYeniAdi.Size = new System.Drawing.Size(81, 29);
            this.txtGuncellenecekPersonelYeniAdi.TabIndex = 76;
            this.txtGuncellenecekPersonelYeniAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtGuncellenecekPersonelSoyadi
            // 
            this.txtGuncellenecekPersonelSoyadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGuncellenecekPersonelSoyadi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtGuncellenecekPersonelSoyadi.ForeColor = System.Drawing.Color.White;
            this.txtGuncellenecekPersonelSoyadi.HintForeColor = System.Drawing.Color.White;
            this.txtGuncellenecekPersonelSoyadi.HintText = "";
            this.txtGuncellenecekPersonelSoyadi.isPassword = false;
            this.txtGuncellenecekPersonelSoyadi.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtGuncellenecekPersonelSoyadi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtGuncellenecekPersonelSoyadi.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtGuncellenecekPersonelSoyadi.LineThickness = 4;
            this.txtGuncellenecekPersonelSoyadi.Location = new System.Drawing.Point(243, 43);
            this.txtGuncellenecekPersonelSoyadi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGuncellenecekPersonelSoyadi.Name = "txtGuncellenecekPersonelSoyadi";
            this.txtGuncellenecekPersonelSoyadi.Size = new System.Drawing.Size(72, 29);
            this.txtGuncellenecekPersonelSoyadi.TabIndex = 75;
            this.txtGuncellenecekPersonelSoyadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnGuncelle.Location = new System.Drawing.Point(156, 198);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(159, 28);
            this.btnGuncelle.TabIndex = 74;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 73;
            this.label4.Text = "Yeni Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 73;
            this.label3.Text = "Yeni K. Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 73;
            this.label2.Text = "Yeni Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 73;
            this.label1.Text = "Ad ve Soyad";
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYeniSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtYeniSifre.ForeColor = System.Drawing.Color.White;
            this.txtYeniSifre.HintForeColor = System.Drawing.Color.White;
            this.txtYeniSifre.HintText = "";
            this.txtYeniSifre.isPassword = true;
            this.txtYeniSifre.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtYeniSifre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtYeniSifre.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtYeniSifre.LineThickness = 4;
            this.txtYeniSifre.Location = new System.Drawing.Point(156, 150);
            this.txtYeniSifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(159, 35);
            this.txtYeniSifre.TabIndex = 72;
            this.txtYeniSifre.Text = "Parola";
            this.txtYeniSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtYeniKullaniciAdi
            // 
            this.txtYeniKullaniciAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYeniKullaniciAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtYeniKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.txtYeniKullaniciAdi.HintForeColor = System.Drawing.Color.White;
            this.txtYeniKullaniciAdi.HintText = "";
            this.txtYeniKullaniciAdi.isPassword = false;
            this.txtYeniKullaniciAdi.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtYeniKullaniciAdi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtYeniKullaniciAdi.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtYeniKullaniciAdi.LineThickness = 4;
            this.txtYeniKullaniciAdi.Location = new System.Drawing.Point(156, 116);
            this.txtYeniKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtYeniKullaniciAdi.Name = "txtYeniKullaniciAdi";
            this.txtYeniKullaniciAdi.Size = new System.Drawing.Size(159, 29);
            this.txtYeniKullaniciAdi.TabIndex = 72;
            this.txtYeniKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtGuncellenecekPersonelAdi
            // 
            this.txtGuncellenecekPersonelAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGuncellenecekPersonelAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtGuncellenecekPersonelAdi.ForeColor = System.Drawing.Color.White;
            this.txtGuncellenecekPersonelAdi.HintForeColor = System.Drawing.Color.White;
            this.txtGuncellenecekPersonelAdi.HintText = "";
            this.txtGuncellenecekPersonelAdi.isPassword = false;
            this.txtGuncellenecekPersonelAdi.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtGuncellenecekPersonelAdi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtGuncellenecekPersonelAdi.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtGuncellenecekPersonelAdi.LineThickness = 4;
            this.txtGuncellenecekPersonelAdi.Location = new System.Drawing.Point(156, 43);
            this.txtGuncellenecekPersonelAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGuncellenecekPersonelAdi.Name = "txtGuncellenecekPersonelAdi";
            this.txtGuncellenecekPersonelAdi.Size = new System.Drawing.Size(81, 29);
            this.txtGuncellenecekPersonelAdi.TabIndex = 72;
            this.txtGuncellenecekPersonelAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tabSil
            // 
            this.tabSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.tabSil.Controls.Add(this.comboSilPersonel);
            this.tabSil.Controls.Add(this.label6);
            this.tabSil.Controls.Add(this.btnSil);
            this.tabSil.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabSil.Location = new System.Drawing.Point(4, 24);
            this.tabSil.Margin = new System.Windows.Forms.Padding(2);
            this.tabSil.Name = "tabSil";
            this.tabSil.Padding = new System.Windows.Forms.Padding(2);
            this.tabSil.Size = new System.Drawing.Size(374, 278);
            this.tabSil.TabIndex = 1;
            this.tabSil.Text = "Sil";
            // 
            // comboSilPersonel
            // 
            this.comboSilPersonel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboSilPersonel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSilPersonel.FormattingEnabled = true;
            this.comboSilPersonel.Location = new System.Drawing.Point(146, 95);
            this.comboSilPersonel.Margin = new System.Windows.Forms.Padding(2);
            this.comboSilPersonel.Name = "comboSilPersonel";
            this.comboSilPersonel.Size = new System.Drawing.Size(160, 27);
            this.comboSilPersonel.TabIndex = 90;
            this.comboSilPersonel.SelectedIndexChanged += new System.EventHandler(this.comboSilOda_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(56, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 88;
            this.label6.Text = "Personel";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(146, 157);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(159, 28);
            this.btnSil.TabIndex = 84;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblPersonelArama
            // 
            this.lblPersonelArama.AutoSize = true;
            this.lblPersonelArama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelArama.ForeColor = System.Drawing.Color.White;
            this.lblPersonelArama.Location = new System.Drawing.Point(735, 13);
            this.lblPersonelArama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonelArama.Name = "lblPersonelArama";
            this.lblPersonelArama.Size = new System.Drawing.Size(130, 21);
            this.lblPersonelArama.TabIndex = 62;
            this.lblPersonelArama.Text = "Personel Arama";
            this.lblPersonelArama.Click += new System.EventHandler(this.lblPersonelAtama_Click);
            // 
            // picPersonelArama
            // 
            this.picPersonelArama.Image = ((System.Drawing.Image)(resources.GetObject("picPersonelArama.Image")));
            this.picPersonelArama.Location = new System.Drawing.Point(698, 7);
            this.picPersonelArama.Margin = new System.Windows.Forms.Padding(2);
            this.picPersonelArama.Name = "picPersonelArama";
            this.picPersonelArama.Size = new System.Drawing.Size(33, 34);
            this.picPersonelArama.TabIndex = 61;
            this.picPersonelArama.TabStop = false;
            this.picPersonelArama.Click += new System.EventHandler(this.picPersonelArama_Click);
            // 
            // picAnaSayfa
            // 
            this.picAnaSayfa.Image = ((System.Drawing.Image)(resources.GetObject("picAnaSayfa.Image")));
            this.picAnaSayfa.Location = new System.Drawing.Point(869, 6);
            this.picAnaSayfa.Margin = new System.Windows.Forms.Padding(2);
            this.picAnaSayfa.Name = "picAnaSayfa";
            this.picAnaSayfa.Size = new System.Drawing.Size(32, 38);
            this.picAnaSayfa.TabIndex = 60;
            this.picAnaSayfa.TabStop = false;
            this.picAnaSayfa.Click += new System.EventHandler(this.picAnaSayfa_Click);
            // 
            // FormPersonelIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(910, 419);
            this.Controls.Add(this.lblPersonelArama);
            this.Controls.Add(this.picPersonelArama);
            this.Controls.Add(this.picAnaSayfa);
            this.Controls.Add(this.tabPersonelIslemler);
            this.Controls.Add(this.pnlFlamingo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPersonelIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flamingo | Personel İşlemleri";
            this.Load += new System.EventHandler(this.frmPersonelAtama_Load);
            this.pnlFlamingo.ResumeLayout(false);
            this.pnlFlamingo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlamingo)).EndInit();
            this.tabPersonelIslemler.ResumeLayout(false);
            this.tabEkle.ResumeLayout(false);
            this.tabEkle.PerformLayout();
            this.tabGuncelle.ResumeLayout(false);
            this.tabGuncelle.PerformLayout();
            this.tabSil.ResumeLayout(false);
            this.tabSil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonelArama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnaSayfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipse;
        private System.Windows.Forms.Panel pnlFlamingo;
        private System.Windows.Forms.TabControl tabPersonelIslemler;
        private System.Windows.Forms.TabPage tabEkle;
        private System.Windows.Forms.TabPage tabGuncelle;
        private System.Windows.Forms.TabPage tabSil;
        private System.Windows.Forms.ComboBox comboSilPersonel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnPersoneleOdaAtama;
        private System.Windows.Forms.ComboBox comboEkleOda;
        private System.Windows.Forms.Label lblOda;
        private System.Windows.Forms.ComboBox comboEkleDepartman;
        private System.Windows.Forms.Label lblDepartman;
        private System.Windows.Forms.ComboBox comboEkleFakulte;
        private System.Windows.Forms.Label lblFakulte;
        private System.Windows.Forms.Label lblPersonelAdi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtYeniSifre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtYeniKullaniciAdi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtGuncellenecekPersonelAdi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtGuncellenecekPersonelYeniSoyadi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtGuncellenecekPersonelYeniAdi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtGuncellenecekPersonelSoyadi;
        private System.Windows.Forms.Label lblFlamingo;
        private System.Windows.Forms.PictureBox picFlamingo;
        private System.Windows.Forms.Label lblPersonelArama;
        private System.Windows.Forms.PictureBox picPersonelArama;
        private System.Windows.Forms.PictureBox picAnaSayfa;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPersonelSoyadi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPersonelAdi;
    }
}
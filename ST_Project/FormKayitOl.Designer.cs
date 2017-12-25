namespace ST_Project
{
    partial class FormKayitOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKayitOl));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlFlamingo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFlamingo = new System.Windows.Forms.Label();
            this.picFlamingo = new System.Windows.Forms.PictureBox();
            this.dragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtAd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnKayit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.chckKabul = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblHKS = new System.Windows.Forms.LinkLabel();
            this.lblUyeMisin = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.txtSoyad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblKabul = new System.Windows.Forms.Label();
            this.picKapat = new System.Windows.Forms.PictureBox();
            this.picAnaSayfa = new System.Windows.Forms.PictureBox();
            this.pnlFlamingo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlamingo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnaSayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlFlamingo
            // 
            this.pnlFlamingo.BackColor = System.Drawing.Color.Teal;
            this.pnlFlamingo.Controls.Add(this.panel1);
            this.pnlFlamingo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFlamingo.Location = new System.Drawing.Point(0, 0);
            this.pnlFlamingo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFlamingo.Name = "pnlFlamingo";
            this.pnlFlamingo.Size = new System.Drawing.Size(450, 419);
            this.pnlFlamingo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblFlamingo);
            this.panel1.Controls.Add(this.picFlamingo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 419);
            this.panel1.TabIndex = 46;
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
            // dragControl
            // 
            this.dragControl.Fixed = true;
            this.dragControl.Horizontal = true;
            this.dragControl.TargetControl = this.pnlFlamingo;
            this.dragControl.Vertical = true;
            // 
            // txtAd
            // 
            this.txtAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAd.ForeColor = System.Drawing.Color.White;
            this.txtAd.HintForeColor = System.Drawing.Color.White;
            this.txtAd.HintText = "";
            this.txtAd.isPassword = false;
            this.txtAd.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtAd.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAd.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtAd.LineThickness = 3;
            this.txtAd.Location = new System.Drawing.Point(536, 73);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(140, 29);
            this.txtAd.TabIndex = 2;
            this.txtAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAd.OnValueChanged += new System.EventHandler(this.txtAd_OnValueChanged);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.White;
            this.lblAdSoyad.Location = new System.Drawing.Point(533, 37);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(79, 15);
            this.lblAdSoyad.TabIndex = 6;
            this.lblAdSoyad.Text = "AD VE SOYAD";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifre.ForeColor = System.Drawing.Color.White;
            this.lblSifre.Location = new System.Drawing.Point(533, 219);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(35, 15);
            this.lblSifre.TabIndex = 8;
            this.lblSifre.Text = "ŞİFRE";
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSifre.ForeColor = System.Drawing.Color.White;
            this.txtSifre.HintForeColor = System.Drawing.Color.White;
            this.txtSifre.HintText = "";
            this.txtSifre.isPassword = true;
            this.txtSifre.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtSifre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSifre.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtSifre.LineThickness = 3;
            this.txtSifre.Location = new System.Drawing.Point(536, 250);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSifre.Size = new System.Drawing.Size(292, 29);
            this.txtSifre.TabIndex = 7;
            this.txtSifre.Text = "Şifre";
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(533, 122);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(87, 15);
            this.lblKullaniciAdi.TabIndex = 10;
            this.lblKullaniciAdi.Text = "KULLANICI ADI";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.HintForeColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.HintText = "";
            this.txtKullaniciAdi.isPassword = false;
            this.txtKullaniciAdi.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtKullaniciAdi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtKullaniciAdi.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtKullaniciAdi.LineThickness = 3;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(536, 157);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(292, 29);
            this.txtKullaniciAdi.TabIndex = 9;
            this.txtKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnKayit
            // 
            this.btnKayit.ActiveBorderThickness = 1;
            this.btnKayit.ActiveCornerRadius = 30;
            this.btnKayit.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnKayit.ActiveForecolor = System.Drawing.Color.White;
            this.btnKayit.ActiveLineColor = System.Drawing.Color.Turquoise;
            this.btnKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.btnKayit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKayit.BackgroundImage")));
            this.btnKayit.ButtonText = "Kayıt Ol";
            this.btnKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKayit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.ForeColor = System.Drawing.Color.White;
            this.btnKayit.IdleBorderThickness = 1;
            this.btnKayit.IdleCornerRadius = 30;
            this.btnKayit.IdleFillColor = System.Drawing.Color.Aqua;
            this.btnKayit.IdleForecolor = System.Drawing.Color.White;
            this.btnKayit.IdleLineColor = System.Drawing.Color.Aqua;
            this.btnKayit.Location = new System.Drawing.Point(536, 358);
            this.btnKayit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(112, 41);
            this.btnKayit.TabIndex = 11;
            this.btnKayit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // chckKabul
            // 
            this.chckKabul.BackColor = System.Drawing.Color.Aqua;
            this.chckKabul.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chckKabul.Checked = true;
            this.chckKabul.CheckedOnColor = System.Drawing.Color.Aqua;
            this.chckKabul.ForeColor = System.Drawing.Color.White;
            this.chckKabul.Location = new System.Drawing.Point(536, 317);
            this.chckKabul.Name = "chckKabul";
            this.chckKabul.Size = new System.Drawing.Size(20, 20);
            this.chckKabul.TabIndex = 12;
            // 
            // lblHKS
            // 
            this.lblHKS.AutoSize = true;
            this.lblHKS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHKS.LinkColor = System.Drawing.Color.Aqua;
            this.lblHKS.Location = new System.Drawing.Point(700, 317);
            this.lblHKS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHKS.Name = "lblHKS";
            this.lblHKS.Size = new System.Drawing.Size(134, 15);
            this.lblHKS.TabIndex = 13;
            this.lblHKS.TabStop = true;
            this.lblHKS.Text = "Hizmet Kullanım Şartları";
            // 
            // lblUyeMisin
            // 
            this.lblUyeMisin.AutoSize = true;
            this.lblUyeMisin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUyeMisin.LinkColor = System.Drawing.Color.DarkCyan;
            this.lblUyeMisin.Location = new System.Drawing.Point(653, 368);
            this.lblUyeMisin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUyeMisin.Name = "lblUyeMisin";
            this.lblUyeMisin.Size = new System.Drawing.Size(112, 15);
            this.lblUyeMisin.TabIndex = 14;
            this.lblUyeMisin.TabStop = true;
            this.lblUyeMisin.Text = "Üye misin? Giriş yap";
            this.lblUyeMisin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblUyeMisin_LinkClicked);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoyad.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSoyad.ForeColor = System.Drawing.Color.White;
            this.txtSoyad.HintForeColor = System.Drawing.Color.White;
            this.txtSoyad.HintText = "";
            this.txtSoyad.isPassword = false;
            this.txtSoyad.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtSoyad.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSoyad.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtSoyad.LineThickness = 3;
            this.txtSoyad.Location = new System.Drawing.Point(682, 73);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(146, 29);
            this.txtSoyad.TabIndex = 27;
            this.txtSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoyad.OnValueChanged += new System.EventHandler(this.txtSoyad_OnValueChanged);
            // 
            // lblKabul
            // 
            this.lblKabul.AutoSize = true;
            this.lblKabul.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKabul.ForeColor = System.Drawing.Color.White;
            this.lblKabul.Location = new System.Drawing.Point(556, 317);
            this.lblKabul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKabul.Name = "lblKabul";
            this.lblKabul.Size = new System.Drawing.Size(135, 15);
            this.lblKabul.TabIndex = 10;
            this.lblKabul.Text = "Her şeyi kabul ediyorum";
            // 
            // picKapat
            // 
            this.picKapat.Image = ((System.Drawing.Image)(resources.GetObject("picKapat.Image")));
            this.picKapat.Location = new System.Drawing.Point(869, 6);
            this.picKapat.Margin = new System.Windows.Forms.Padding(2);
            this.picKapat.Name = "picKapat";
            this.picKapat.Size = new System.Drawing.Size(32, 34);
            this.picKapat.TabIndex = 31;
            this.picKapat.TabStop = false;
            this.picKapat.Click += new System.EventHandler(this.picKapat_Click);
            // 
            // picAnaSayfa
            // 
            this.picAnaSayfa.Image = ((System.Drawing.Image)(resources.GetObject("picAnaSayfa.Image")));
            this.picAnaSayfa.Location = new System.Drawing.Point(833, 6);
            this.picAnaSayfa.Margin = new System.Windows.Forms.Padding(2);
            this.picAnaSayfa.Name = "picAnaSayfa";
            this.picAnaSayfa.Size = new System.Drawing.Size(32, 34);
            this.picAnaSayfa.TabIndex = 30;
            this.picAnaSayfa.TabStop = false;
            this.picAnaSayfa.Click += new System.EventHandler(this.picAnaSayfa_Click);
            // 
            // frmKayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(910, 419);
            this.Controls.Add(this.picKapat);
            this.Controls.Add(this.picAnaSayfa);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblUyeMisin);
            this.Controls.Add(this.lblHKS);
            this.Controls.Add(this.chckKabul);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.lblKabul);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.pnlFlamingo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKayitOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flamingo | Kayıt Ol";
            this.Load += new System.EventHandler(this.frmKayitOl_Load);
            this.pnlFlamingo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlamingo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnaSayfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlFlamingo;
        private Bunifu.Framework.UI.BunifuDragControl dragControl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAd;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSifre;
        private System.Windows.Forms.Label lblAdSoyad;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKayit;
        private Bunifu.Framework.UI.BunifuCheckbox chckKabul;
        private System.Windows.Forms.LinkLabel lblUyeMisin;
        private System.Windows.Forms.LinkLabel lblHKS;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSoyad;
        private System.Windows.Forms.Label lblKabul;
        private System.Windows.Forms.PictureBox picKapat;
        private System.Windows.Forms.PictureBox picAnaSayfa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFlamingo;
        private System.Windows.Forms.PictureBox picFlamingo;
    }
}


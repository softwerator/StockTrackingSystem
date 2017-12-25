namespace ST_Project
{
    partial class FormPersonelArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonelArama));
            this.elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlPersonel = new System.Windows.Forms.Panel();
            this.comboPersonel = new System.Windows.Forms.ComboBox();
            this.btnPersonelAra = new System.Windows.Forms.Button();
            this.txtOdaTanımlama = new System.Windows.Forms.Label();
            this.lblOdaAdi = new System.Windows.Forms.Label();
            this.dgvPersonelOdasi = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblPersonelOdasi = new System.Windows.Forms.Label();
            this.lblPersonelIslemleri = new System.Windows.Forms.Label();
            this.picPersonelIslemleri = new System.Windows.Forms.PictureBox();
            this.picAnaSayfa = new System.Windows.Forms.PictureBox();
            this.pnlPersonel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelOdasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonelIslemleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnaSayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse
            // 
            this.elipse.ElipseRadius = 5;
            this.elipse.TargetControl = this;
            // 
            // pnlPersonel
            // 
            this.pnlPersonel.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlPersonel.Controls.Add(this.comboPersonel);
            this.pnlPersonel.Controls.Add(this.btnPersonelAra);
            this.pnlPersonel.Controls.Add(this.txtOdaTanımlama);
            this.pnlPersonel.Controls.Add(this.lblOdaAdi);
            this.pnlPersonel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPersonel.Location = new System.Drawing.Point(0, 0);
            this.pnlPersonel.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPersonel.Name = "pnlPersonel";
            this.pnlPersonel.Size = new System.Drawing.Size(375, 419);
            this.pnlPersonel.TabIndex = 0;
            // 
            // comboPersonel
            // 
            this.comboPersonel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboPersonel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPersonel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPersonel.FormattingEnabled = true;
            this.comboPersonel.Location = new System.Drawing.Point(111, 213);
            this.comboPersonel.Margin = new System.Windows.Forms.Padding(2);
            this.comboPersonel.Name = "comboPersonel";
            this.comboPersonel.Size = new System.Drawing.Size(160, 25);
            this.comboPersonel.TabIndex = 92;
            // 
            // btnPersonelAra
            // 
            this.btnPersonelAra.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelAra.ForeColor = System.Drawing.Color.Black;
            this.btnPersonelAra.Location = new System.Drawing.Point(147, 254);
            this.btnPersonelAra.Margin = new System.Windows.Forms.Padding(2);
            this.btnPersonelAra.Name = "btnPersonelAra";
            this.btnPersonelAra.Size = new System.Drawing.Size(82, 28);
            this.btnPersonelAra.TabIndex = 24;
            this.btnPersonelAra.Text = "Ara";
            this.btnPersonelAra.UseVisualStyleBackColor = true;
            this.btnPersonelAra.Click += new System.EventHandler(this.btnPersonelAra_Click);
            // 
            // txtOdaTanımlama
            // 
            this.txtOdaTanımlama.AutoSize = true;
            this.txtOdaTanımlama.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdaTanımlama.ForeColor = System.Drawing.Color.White;
            this.txtOdaTanımlama.Location = new System.Drawing.Point(106, 76);
            this.txtOdaTanımlama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtOdaTanımlama.Name = "txtOdaTanımlama";
            this.txtOdaTanımlama.Size = new System.Drawing.Size(175, 30);
            this.txtOdaTanımlama.TabIndex = 18;
            this.txtOdaTanımlama.Text = "Personel Arama";
            // 
            // lblOdaAdi
            // 
            this.lblOdaAdi.AutoSize = true;
            this.lblOdaAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaAdi.ForeColor = System.Drawing.Color.White;
            this.lblOdaAdi.Location = new System.Drawing.Point(89, 171);
            this.lblOdaAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOdaAdi.Name = "lblOdaAdi";
            this.lblOdaAdi.Size = new System.Drawing.Size(205, 25);
            this.lblOdaAdi.TabIndex = 23;
            this.lblOdaAdi.Text = "Personel Adı ve Soyadı";
            // 
            // dgvPersonelOdasi
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPersonelOdasi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonelOdasi.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvPersonelOdasi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPersonelOdasi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonelOdasi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersonelOdasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonelOdasi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPersonelOdasi.DoubleBuffered = true;
            this.dgvPersonelOdasi.EnableHeadersVisualStyles = false;
            this.dgvPersonelOdasi.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvPersonelOdasi.HeaderForeColor = System.Drawing.Color.White;
            this.dgvPersonelOdasi.Location = new System.Drawing.Point(375, 53);
            this.dgvPersonelOdasi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPersonelOdasi.Name = "dgvPersonelOdasi";
            this.dgvPersonelOdasi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPersonelOdasi.RowTemplate.Height = 24;
            this.dgvPersonelOdasi.Size = new System.Drawing.Size(535, 366);
            this.dgvPersonelOdasi.TabIndex = 2;
            // 
            // lblPersonelOdasi
            // 
            this.lblPersonelOdasi.AutoSize = true;
            this.lblPersonelOdasi.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelOdasi.ForeColor = System.Drawing.Color.White;
            this.lblPersonelOdasi.Location = new System.Drawing.Point(380, 10);
            this.lblPersonelOdasi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonelOdasi.Name = "lblPersonelOdasi";
            this.lblPersonelOdasi.Size = new System.Drawing.Size(0, 13);
            this.lblPersonelOdasi.TabIndex = 33;
            // 
            // lblPersonelIslemleri
            // 
            this.lblPersonelIslemleri.AutoSize = true;
            this.lblPersonelIslemleri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelIslemleri.ForeColor = System.Drawing.Color.White;
            this.lblPersonelIslemleri.Location = new System.Drawing.Point(719, 13);
            this.lblPersonelIslemleri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonelIslemleri.Name = "lblPersonelIslemleri";
            this.lblPersonelIslemleri.Size = new System.Drawing.Size(146, 21);
            this.lblPersonelIslemleri.TabIndex = 41;
            this.lblPersonelIslemleri.Text = "Personel İşlemleri";
            this.lblPersonelIslemleri.Click += new System.EventHandler(this.lblPersonelAtama_Click);
            // 
            // picPersonelIslemleri
            // 
            this.picPersonelIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("picPersonelIslemleri.Image")));
            this.picPersonelIslemleri.Location = new System.Drawing.Point(682, 7);
            this.picPersonelIslemleri.Margin = new System.Windows.Forms.Padding(2);
            this.picPersonelIslemleri.Name = "picPersonelIslemleri";
            this.picPersonelIslemleri.Size = new System.Drawing.Size(34, 33);
            this.picPersonelIslemleri.TabIndex = 40;
            this.picPersonelIslemleri.TabStop = false;
            this.picPersonelIslemleri.Click += new System.EventHandler(this.picPersonelAtama_Click);
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
            // frmPersonelArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(910, 419);
            this.Controls.Add(this.lblPersonelIslemleri);
            this.Controls.Add(this.picPersonelIslemleri);
            this.Controls.Add(this.picAnaSayfa);
            this.Controls.Add(this.lblPersonelOdasi);
            this.Controls.Add(this.dgvPersonelOdasi);
            this.Controls.Add(this.pnlPersonel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPersonelArama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flamingo | Personel Arama";
            this.Load += new System.EventHandler(this.frmPersonelArama_Load);
            this.pnlPersonel.ResumeLayout(false);
            this.pnlPersonel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelOdasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonelIslemleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnaSayfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipse;
        private System.Windows.Forms.Panel pnlPersonel;
        private System.Windows.Forms.Label txtOdaTanımlama;
        private System.Windows.Forms.Button btnPersonelAra;
        private System.Windows.Forms.Label lblOdaAdi;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvPersonelOdasi;
        private System.Windows.Forms.Label lblPersonelOdasi;
        private System.Windows.Forms.Label lblPersonelIslemleri;
        private System.Windows.Forms.PictureBox picPersonelIslemleri;
        private System.Windows.Forms.PictureBox picAnaSayfa;
        private System.Windows.Forms.ComboBox comboPersonel;
    }
}
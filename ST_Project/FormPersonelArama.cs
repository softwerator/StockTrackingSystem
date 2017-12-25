using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST_Project
{
    public partial class FormPersonelArama : Form
    {
        YazilimSinamaEntities Entities = new YazilimSinamaEntities();
        frmAnaSayfa AnaSayfa;
        FormPersonelIslemleri PersonelAtama;

        public FormPersonelArama()
        {
            InitializeComponent();
        }

        private void frmPersonelArama_Load(object sender, EventArgs e)
        {
            foreach (var item in Entities.tblPersonel)
            {
                comboPersonel.Items.Add(item.PersonelAdi + " " + item.PersonelSoyadi);
            }
        }

        private void picAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa = new frmAnaSayfa();
            AnaSayfa.Show();
            this.Hide();
        }

        private void picPersonelAtama_Click(object sender, EventArgs e)
        {
            PersonelAtama = new FormPersonelIslemleri();
            PersonelAtama.Show();
            this.Hide();
        }

        private void lblPersonelAtama_Click(object sender, EventArgs e)
        {
            PersonelAtama = new FormPersonelIslemleri();
            PersonelAtama.Show();
            this.Hide();
        }

        private void btnPersonelAra_Click(object sender, EventArgs e)
        {
            dgvPersonelOdasi.Columns.Clear();
            dgvPersonelOdasi.Rows.Clear();
            bool isTrue = false;
            foreach (var item in Entities.tblOdaDemirbasAtama)
            {
                if (item.tblOda.tblPersonel != null)
                {
                    if (comboPersonel.SelectedItem.ToString().Equals(item.tblOda.tblPersonel.PersonelAdi + " " + item.tblOda.tblPersonel.PersonelSoyadi))
                    {
                        isTrue = true;
                        break;
                    }
                }
            }
            if (!isTrue)
            {
                MessageBox.Show("Aradığınız personelin sorumlu olduğu bir oda yoktur!", "Personel Arama");
            }
            else
            {
                dgvIslemleri();
                foreach (var item in Entities.tblOdaDemirbasAtama)
                {
                    if (item.tblOda.tblPersonel != null && item.tblOda.tblPersonel != null)
                    {
                        if (comboPersonel.SelectedItem.ToString().Equals(item.tblOda.tblPersonel.PersonelAdi + " " + item.tblOda.tblPersonel.PersonelSoyadi))
                        {
                            string[] satir = new string[] { item.tblDemirbas.DemirbasKodu, item.tblOda.OdaAdi, item.tblDemirbas.DemirbasAdi, Convert.ToString(item.Adet) };
                            dgvPersonelOdasi.Rows.Add(satir);
                        }
                    }
                }
            }
        }

        private void dgvIslemleri()
        {
            dgvPersonelOdasi.Rows.Clear();
            dgvPersonelOdasi.ColumnCount = 4;
            dgvPersonelOdasi.Columns[0].HeaderText = "Demirbaş Kodu";
            dgvPersonelOdasi.Columns[1].HeaderText = "Oda Adı";
            dgvPersonelOdasi.Columns[2].HeaderText = "Demirbaş Adı";
            dgvPersonelOdasi.Columns[3].HeaderText = "Demirbaş Adedi";
            DataGridViewColumn column1 = dgvPersonelOdasi.Columns[0];
            column1.Width = 120;
            DataGridViewColumn column2 = dgvPersonelOdasi.Columns[1];
            column2.Width = 73;
            DataGridViewColumn column3 = dgvPersonelOdasi.Columns[2];
            column3.Width = 180;
            DataGridViewColumn column4 = dgvPersonelOdasi.Columns[3];
            column4.Width = 120;
        }
    }
}

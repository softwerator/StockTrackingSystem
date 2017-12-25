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
    public partial class FormDemirbasArama : Form
    {
        YazilimSinamaEntities Entities = new YazilimSinamaEntities();
        frmAnaSayfa AnaSayfa;
        FormDemirbasIslemleri DemirbasEkle;

        public FormDemirbasArama()
        {
            InitializeComponent();
        }

        private void frmDemirbasArama_Load(object sender, EventArgs e)
        {
            dgvDemirbasArama.Rows.Clear();
            dgvDemirbasArama.Columns.Clear();
            if (!frmAnaSayfa.YetkiliD) { btnHepsiniAra.Visible = false; }
        }

        private void rbAdinaGore_CheckedChanged(object sender, EventArgs e)
        {
            txtAdinaGore.Enabled = true;
            txtAdedineGore.Enabled = false;
            txtFiyatinaGore.Enabled = false;
            txtTuruneGore.Enabled = false;
            dateAlimTarihi.Enabled = false;
        }

        private void rbTuruneGore_CheckedChanged(object sender, EventArgs e)
        {
            txtAdinaGore.Enabled = false;
            txtAdedineGore.Enabled = false;
            txtFiyatinaGore.Enabled = false;
            txtTuruneGore.Enabled = true;
            dateAlimTarihi.Enabled = false;
        }

        private void rbFiyatinaGore_CheckedChanged(object sender, EventArgs e)
        {
            txtAdinaGore.Enabled = false;
            txtAdedineGore.Enabled = false;
            txtFiyatinaGore.Enabled = true;
            txtTuruneGore.Enabled = false;
            dateAlimTarihi.Enabled = false;
        }

        private void rbAdedineGore_CheckedChanged(object sender, EventArgs e)
        {
            txtAdinaGore.Enabled = false;
            txtAdedineGore.Enabled = true;
            txtFiyatinaGore.Enabled = false;
            txtTuruneGore.Enabled = false;
            dateAlimTarihi.Enabled = false;
        }

        private void rbAlimTarihineGore_CheckedChanged(object sender, EventArgs e)
        {
            txtAdinaGore.Enabled = false;
            txtAdedineGore.Enabled = false;
            txtFiyatinaGore.Enabled = false;
            txtTuruneGore.Enabled = false;
            dateAlimTarihi.Enabled = true;
        }

        private void picAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa = new frmAnaSayfa();
            AnaSayfa.Show();
            this.Hide();
        }

        private void lblDemirbasKaydi_Click(object sender, EventArgs e)
        {
            if (frmAnaSayfa.YetkiliD) {
                DemirbasEkle = new FormDemirbasIslemleri();
                DemirbasEkle.Show();
                this.Hide();
            }
            else { MessageBox.Show("Bu sayfaya geçmek için yetkiniz bulunmamaktadır!", "Demirbaş Arama", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void picDemirbasKaydi_Click(object sender, EventArgs e)
        {
            if (frmAnaSayfa.YetkiliD)
            {
                DemirbasEkle = new FormDemirbasIslemleri();
                DemirbasEkle.Show();
                this.Hide();
            }
            else { MessageBox.Show("Bu sayfaya geçmek için yetkiniz bulunmamaktadır!", "Demirbaş Arama", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void btnDemirbasAra_Click(object sender, EventArgs e)
        {
            dgvDemirbasArama.Columns.Clear();
            dgvDemirbasArama.Rows.Clear();
            bool isTrue = false;
            foreach (var key in Entities.tblDemirbas)
            {
                if (txtAdinaGore.Text != "")
                {
                    if (key.DemirbasAdi.Equals(txtAdinaGore.Text))
                    {
                        isTrue = true;
                        break;
                    }
                }
                else if (txtTuruneGore.Text != "")
                {
                    if (key.tblDemirbasTuru.DemirbasTuruAdi.Equals(txtTuruneGore.Text))
                    {
                        isTrue = true;
                        break;
                    }
                }
                else if (txtFiyatinaGore.Text != "")
                {
                    if (key.Fiyat.Equals(Convert.ToInt32(txtFiyatinaGore.Text)))
                    {
                        isTrue = true;
                        break;
                    }
                }
                else if (txtAdedineGore.Text != "")
                {
                    if (key.Adet.Equals(Convert.ToInt32(txtAdedineGore.Text)))
                    {
                        isTrue = true;
                        break;
                    }
                }
                else if (Convert.ToString(dateAlimTarihi.Value) != "")
                {
                    if (key.AlimTarihi.Equals(Convert.ToDateTime(dateAlimTarihi.Value)))
                    {
                        isTrue = true;
                        break;
                    }
                }
            }
            if (!isTrue)
            {
                MessageBox.Show("Aradığınız kriterle ilgili herhangi bir demirbaş yoktur!", "Demirbaş Arama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string[] satir = null;
                dgvIslemleri();
                foreach (var item in Entities.tblDemirbas)
                {
                    if (rbAdinaGore.Checked)
                    {
                        if (item.DemirbasAdi.Contains(txtAdinaGore.Text))
                        {
                            satir = new string[] { item.DemirbasAdi, item.tblDemirbasTuru.DemirbasTuruAdi, item.Fiyat.ToString("0,##") + " TL", item.AlimTarihi.Date.ToString("d"), item.Adet.ToString() };
                            dgvDemirbasArama.Rows.Add(satir);
                        }
                    }
                    else if (rbTuruneGore.Checked)
                    {
                        if (item.tblDemirbasTuru.DemirbasTuruAdi.Equals(txtTuruneGore.Text))
                        {
                            satir = new string[] { item.DemirbasAdi, item.tblDemirbasTuru.DemirbasTuruAdi, item.Fiyat.ToString("0,##") + " TL", item.AlimTarihi.Date.ToString("d"), item.Adet.ToString() };
                            dgvDemirbasArama.Rows.Add(satir);
                        }
                    }
                    else if (rbFiyatinaGore.Checked)
                    {
                        if (item.Fiyat.Equals(Convert.ToInt32(txtFiyatinaGore.Text)))
                        {
                            satir = new string[] { item.DemirbasAdi, item.tblDemirbasTuru.DemirbasTuruAdi, item.Fiyat.ToString("0,##") + " TL", item.AlimTarihi.Date.ToString("d"), item.Adet.ToString() };
                            dgvDemirbasArama.Rows.Add(satir);
                        }
                    }
                    else if (rbAdedineGore.Checked)
                    {
                        if (item.Adet.Equals(Convert.ToInt32(txtAdedineGore.Text)))
                        {
                            satir = new string[] { item.DemirbasAdi, item.tblDemirbasTuru.DemirbasTuruAdi, item.Fiyat.ToString("0,##") + " TL", item.AlimTarihi.Date.ToString("d"), item.Adet.ToString() };
                            dgvDemirbasArama.Rows.Add(satir);
                        }
                    }
                    else if (rbAlimTarihineGore.Checked)
                    {
                        if (item.AlimTarihi.Equals(dateAlimTarihi.Value))
                        {
                            satir = new string[] { item.DemirbasAdi, item.tblDemirbasTuru.DemirbasTuruAdi, item.Fiyat.ToString("0,##") + " TL", item.AlimTarihi.Date.ToString("d"), item.Adet.ToString() };
                            dgvDemirbasArama.Rows.Add(satir);
                        }
                    }
                }
            }
        }

        private void dgvIslemleri()
        {
            dgvDemirbasArama.Rows.Clear();
            dgvDemirbasArama.ColumnCount = 5;
            dgvDemirbasArama.Columns[0].HeaderText = "Ad";
            dgvDemirbasArama.Columns[1].HeaderText = "Tür";
            dgvDemirbasArama.Columns[2].HeaderText = "Fiyat";
            dgvDemirbasArama.Columns[3].HeaderText = "Alım Tarihi";
            dgvDemirbasArama.Columns[4].HeaderText = "Adet";
            DataGridViewColumn column1 = dgvDemirbasArama.Columns[0];
            column1.Width = 152;
            DataGridViewColumn column2 = dgvDemirbasArama.Columns[1];
            column2.Width = 120;
            DataGridViewColumn column3 = dgvDemirbasArama.Columns[2];
            column3.Width = 75;
            DataGridViewColumn column4 = dgvDemirbasArama.Columns[3];
            column4.Width = 100;
            DataGridViewColumn column5 = dgvDemirbasArama.Columns[4];
            column5.Width = 50;
        }

        private void btnHepsiniAra_Click(object sender, EventArgs e)
        {
            dgvIslemleri();
            foreach (var item in Entities.tblDemirbas)
            {
                String[] satir = new string[] { item.DemirbasAdi, item.tblDemirbasTuru.DemirbasTuruAdi, item.Fiyat.ToString("0,##") + " TL", item.AlimTarihi.Date.ToString("d"), item.Adet.ToString() };
                dgvDemirbasArama.Rows.Add(satir);
            }
        }
    }
}

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
    public partial class FormDemirbasIslemleri : Form
    {
        YazilimSinamaEntities Entities = new YazilimSinamaEntities();
        frmAnaSayfa AnaSayfa;
        FormDemirbasArama DemirbasArama;
        int fakulteID, departmanID, demirbasID, demirbasTuruID;

        public FormDemirbasIslemleri()
        {
            InitializeComponent();
        }

        private void picAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa = new frmAnaSayfa();
            AnaSayfa.Show();
            this.Hide();
        }

        private void lblDemirbasArama_Click(object sender, EventArgs e)
        {
            DemirbasArama = new FormDemirbasArama();
            DemirbasArama.Show();
            this.Hide();
        }

        private void picDemirbasArama_Click(object sender, EventArgs e)
        {
            DemirbasArama = new FormDemirbasArama();
            DemirbasArama.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool farkliDemirbas = false;

            foreach (var kontrol in Entities.tblDemirbas)
            {
                if ((kontrol.DemirbasAdi.Equals(txtEkleAdi.Text)) && (kontrol.DepartmanID.Equals(departmanID)) && (kontrol.FakulteID.Equals(fakulteID)))
                {
                    farkliDemirbas = true;
                    break;
                }
            }

            if (!farkliDemirbas)
            {
                string kod = "";
                tblDemirbas key = new tblDemirbas();
                key.DemirbasAdi = txtEkleAdi.Text;
                key.DemirbasTuruID = demirbasTuruID;
                key.Fiyat = Convert.ToInt32(txtEkleFiyati.Text);
                key.Adet = Convert.ToInt32(txtEkleAdet.Text);
                key.AlimTarihi = Convert.ToDateTime(dateAlimTarihi.Value.ToString());
                key.FakulteID = fakulteID;
                key.DepartmanID = departmanID;
                if (fakulteID < 10) { kod += "0" + fakulteID; } else { kod += fakulteID; }
                if (departmanID < 10) { kod += "0" + departmanID; } else { kod += departmanID; }
                if (demirbasTuruID < 10) { kod += "0" + demirbasTuruID; } else { kod += demirbasTuruID; }
                if ((Entities.tblDemirbas.Count() + 1) < 10) { kod += "0" + (Entities.tblDemirbas.Count()+1); }
                key.DemirbasKodu = kod;
                Entities.tblDemirbas.Add(key);
                Entities.SaveChanges();
                MessageBox.Show("Girdiğiniz demirbaş başarıyla eklenmiştir!", "Demirbaş İşlemleri");
            }
            else
            {
                MessageBox.Show("Girdiğiniz demirbaş bulunmaktadır!\nLütfen yeni bir demirbaş ismi giriniz!", "Demirbaş İşlemleri");
            }
            
        }

        private void frmDemirbasIslemleri_Load(object sender, EventArgs e)
        {
            if (!frmAnaSayfa.YetkiliD)
            {
                comboGuncelleDemirbas.Items.Clear();
                tabDemirbasIslemler.TabPages.Remove(tabEkle);
                tabDemirbasIslemler.TabPages.Remove(tabSil);
                comboGuncelleDepartman.Visible = false;
                comboGuncelleFakulte.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
            }
            comboEkleFakulte.Items.Clear();
            foreach (var fakulte in Entities.tblFakulte)
            {
                comboEkleFakulte.Items.Add(fakulte.FakulteAdi);
            }
            comboEkleTuru.Items.Clear();
            foreach (var tur in Entities.tblDemirbasTuru)
            {
                comboEkleTuru.Items.Add(tur.DemirbasTuruAdi);
            }
        }

        private void tabDemirbasIslemler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabDemirbasIslemler.SelectedTab == tabDemirbasIslemler.TabPages["tabEkle"])
            {
                comboEkleFakulte.Items.Clear();
                foreach (var fakulte in Entities.tblFakulte)
                {
                    comboEkleFakulte.Items.Add(fakulte.FakulteAdi);
                }
                comboEkleTuru.Items.Clear();
                foreach (var tur in Entities.tblDemirbasTuru)
                {
                    comboEkleTuru.Items.Add(tur.DemirbasTuruAdi);
                }
            }
            else if (tabDemirbasIslemler.SelectedTab == tabDemirbasIslemler.TabPages["tabGuncelle"])
            {
                comboGuncelleFakulte.Items.Clear();
                foreach (var fakulte in Entities.tblFakulte)
                {
                    comboGuncelleFakulte.Items.Add(fakulte.FakulteAdi);
                }
                comboGuncelleDemirbas.Items.Clear();
                foreach (var item in Entities.tblOdaDemirbasAtama)
                {
                    if (item.tblOda.tblPersonel != null)
                    {
                        if (frmAnaSayfa.adSoyad.Equals(item.tblOda.tblPersonel.PersonelAdi + " " + item.tblOda.tblPersonel.PersonelSoyadi))
                        {
                            comboGuncelleDemirbas.Items.Add(item.tblDemirbas.DemirbasAdi);
                        }
                    }
                }
            }
            else if (tabDemirbasIslemler.SelectedTab == tabDemirbasIslemler.TabPages["tabSil"])
            {
                comboSilFakulte.Items.Clear();
                foreach (var fakulte in Entities.tblFakulte)
                {
                    comboSilFakulte.Items.Add(fakulte.FakulteAdi);
                }
            }
        }

        private void comboGuncelleFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboGuncelleDepartman.Text = "";
            comboGuncelleDemirbas.Text = "";
            comboGuncelleDepartman.Items.Clear();
            foreach (var fakulte in Entities.tblFakulte)
            {
                if (comboGuncelleFakulte.SelectedItem.ToString().Equals(fakulte.FakulteAdi))
                    fakulteID = fakulte.FakulteID;
            }
            foreach (var departman in Entities.tblDepartman)
            {
                if (departman.FakulteID.Equals(fakulteID))
                    comboGuncelleDepartman.Items.Add(departman.DepartmanAdi);
            }
        }

        private void comboGuncelleDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboGuncelleDemirbas.Text = "";
            comboGuncelleDemirbas.Items.Clear();
            foreach (var departman in Entities.tblDepartman)
            {
                if (comboGuncelleDepartman.SelectedItem.ToString().Equals(departman.DepartmanAdi))
                    departmanID = departman.DepartmanID;
            }
            foreach (var demirbas in Entities.tblDemirbas)
            {
                if (demirbas.DepartmanID.Equals(departmanID))
                    comboGuncelleDemirbas.Items.Add(demirbas.DemirbasAdi);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            foreach (var demirbas in Entities.tblDemirbas)
            {
                if (demirbas.DemirbasID.Equals(demirbasID))
                {
                    if (txtGuncelleAdet.Text != "" && txtGuncelleFiyat.Text != "")
                    {
                        demirbas.Fiyat = Convert.ToInt32(txtGuncelleFiyat.Text);
                        demirbas.Adet = Convert.ToInt32(txtGuncelleAdet.Text);
                    }
                    else if (txtGuncelleAdet.Text != "")
                    {
                        demirbas.Adet = Convert.ToInt32(txtGuncelleAdet.Text);
                    }
                    else if (txtGuncelleFiyat.Text != "")
                    {
                        demirbas.Fiyat = Convert.ToInt32(txtGuncelleFiyat.Text);
                    }
                    MessageBox.Show("Geçerli demirbaş güncellenmiştir!", "Demirbaş İşlemleri");
                    break;
                }
            }
            Entities.SaveChanges();
        }

        private void comboSilFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSilDepartman.Text = "";
            comboSilDemirbas.Text = "";
            comboSilDepartman.Items.Clear();
            foreach (var fakulte in Entities.tblFakulte)
            {
                if (comboSilFakulte.SelectedItem.ToString().Equals(fakulte.FakulteAdi))
                    fakulteID = fakulte.FakulteID;
            }
            foreach (var departman in Entities.tblDepartman)
            {
                if (departman.FakulteID.Equals(fakulteID))
                    comboSilDepartman.Items.Add(departman.DepartmanAdi);
            }
        }

        private void comboSilDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSilDemirbas.Text = "";
            comboSilDemirbas.Items.Clear();
            foreach (var departman in Entities.tblDepartman)
            {
                if (comboSilDepartman.SelectedItem.ToString().Equals(departman.DepartmanAdi))
                    departmanID = departman.DepartmanID;
            }
            foreach (var demirbas in Entities.tblDemirbas)
            {
                if (demirbas.DepartmanID.Equals(departmanID))
                    comboSilDemirbas.Items.Add(demirbas.DemirbasAdi);
            }
        }

        private void comboSilDemirbas_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var demirbas in Entities.tblDemirbas)
            {
                if (comboSilDemirbas.SelectedItem.ToString().Equals(demirbas.DemirbasAdi))
                    demirbasID = demirbas.DemirbasID;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach (var item in Entities.tblDemirbas)
            {
                if (item.DemirbasID.Equals(demirbasID))
                {
                    Entities.tblDemirbas.Remove(item);
                    MessageBox.Show("Geçerli demirbaş silinmiştir!", "Demirbaş İşlemleri");
                    break;
                }
            }
            Entities.SaveChanges();
        }

        private void txtEkleFiyati_OnValueChanged(object sender, EventArgs e)
        {
            int sonuc;
            if (txtEkleFiyati.Text != "")
            {
                if ((int.TryParse(txtEkleFiyati.Text, out sonuc)) == false)
                {
                    MessageBox.Show("Bu alan sadece rakamlardan oluşabilir!", "Demirbaş İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtEkleAdet_OnValueChanged(object sender, EventArgs e)
        {
            int sonuc;
            if (txtEkleAdet.Text != "")
            {
                if ((int.TryParse(txtEkleAdet.Text, out sonuc)) == false)
                {
                    MessageBox.Show("Bu alan sadece rakamlardan oluşabilir!", "Demirbaş İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtGuncelleFiyat_OnValueChanged(object sender, EventArgs e)
        {
            int sonuc;
            if (txtGuncelleFiyat.Text != "")
            {
                if ((int.TryParse(txtGuncelleFiyat.Text, out sonuc)) == false)
                {
                    MessageBox.Show("Bu alan sadece rakamlardan oluşabilir!", "Demirbaş İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtGuncelleAdet_OnValueChanged(object sender, EventArgs e)
        {
            int sonuc;
            if (txtGuncelleAdet.Text != "")
            {
                if ((int.TryParse(txtGuncelleAdet.Text, out sonuc)) == false)
                {
                    MessageBox.Show("Bu alan sadece rakamlardan oluşabilir!", "Demirbaş İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void comboEkleTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var tur in Entities.tblDemirbasTuru)
            {
                if (comboEkleTuru.SelectedItem.ToString().Equals(tur.DemirbasTuruAdi))
                    demirbasTuruID = tur.DemirbasTuruID;
            }
        }

        private void comboGuncelleDemirbas_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var demirbas in Entities.tblDemirbas)
            {
                if (comboGuncelleDemirbas.SelectedItem.ToString().Equals(demirbas.DemirbasAdi))
                    demirbasID = demirbas.DemirbasID;
            }
        }

        private void comboEkleFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboEkleDepartman.Text = "";
            comboEkleDepartman.Items.Clear();
            foreach (var fakulte in Entities.tblFakulte)
            {
                if (comboEkleFakulte.SelectedItem.ToString().Equals(fakulte.FakulteAdi))
                    fakulteID = fakulte.FakulteID;
            }

            foreach (var departman in Entities.tblDepartman)
            {
                if (departman.FakulteID.Equals(fakulteID))
                    comboEkleDepartman.Items.Add(departman.DepartmanAdi);
            }
        }

        private void comboEkleDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var departman in Entities.tblDepartman)
            {
                if (comboEkleDepartman.SelectedItem.ToString().Equals(departman.DepartmanAdi))
                    departmanID = departman.DepartmanID;
            }
        }
    }
}

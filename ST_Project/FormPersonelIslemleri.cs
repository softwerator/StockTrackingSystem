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
    public partial class FormPersonelIslemleri : Form
    {
        YazilimSinamaEntities Entities = new YazilimSinamaEntities();
        frmAnaSayfa AnaSayfa;
        FormPersonelArama PersonelArama;
        int fakulteID, departmanID, odaID, personelID;

        public FormPersonelIslemleri()
        {
            InitializeComponent();
        }

        private void frmPersonelAtama_Load(object sender, EventArgs e)
        {
            if (!frmAnaSayfa.YetkiliD)
            {
                label1.Visible = false;
                txtGuncellenecekPersonelAdi.Visible = false;
                txtGuncellenecekPersonelSoyadi.Visible = false;
                tabPersonelIslemler.TabPages.Remove(tabSil);
            }
            foreach (var fakulte in Entities.tblFakulte)
            {
                comboEkleFakulte.Items.Add(fakulte.FakulteAdi);
            }
        }

        private void tabPersonelIslemler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPersonelIslemler.SelectedTab == tabPersonelIslemler.TabPages["tabEkle"])
            {
                foreach (var fakulte in Entities.tblFakulte)
                {
                    comboEkleFakulte.Items.Add(fakulte.FakulteAdi);
                }
            }
            else if (tabPersonelIslemler.SelectedTab == tabPersonelIslemler.TabPages["tabSil"])
            {
                foreach (var personel in Entities.tblPersonel)
                {
                    comboSilPersonel.Items.Add(personel.PersonelAdi + " " + personel.PersonelSoyadi);
                }
            }
        }

        private void lblPersonelAtama_Click(object sender, EventArgs e)
        {
            PersonelArama = new FormPersonelArama();
            PersonelArama.Show();
            this.Hide();
        }

        private void picAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa = new frmAnaSayfa();
            AnaSayfa.Show();
            this.Hide();
        }

        private void comboFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboEkleDepartman.Items.Clear();
            foreach (var fakulte in Entities.tblFakulte)
            {
                if (comboEkleFakulte.SelectedItem.ToString().Equals(fakulte.FakulteAdi))
                    fakulteID = fakulte.FakulteID;
            }
            foreach (var departman in Entities.tblDepartman)
            {
                if (departman.FakulteID.Equals(fakulteID))
                {
                    comboEkleDepartman.Items.Add(departman.DepartmanAdi);
                }
            }
        }

        private void comboDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboEkleOda.Items.Clear();
            foreach (var departman in Entities.tblDepartman)
            {
                if (comboEkleDepartman.SelectedItem.ToString().Equals(departman.DepartmanAdi))
                    departmanID = departman.DepartmanID;
            }
            foreach (var oda in Entities.tblOda)
            {
                if (oda.DepartmanID.Equals(departmanID)) {
                    comboEkleOda.Items.Add(oda.OdaAdi);
                }
            }
        }

        private void comboEkleFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboEkleDepartman.Text = "";
            comboEkleOda.Text = "";
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

        private void comboSilFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboEkleOda_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var oda in Entities.tblOda)
            {
                if (comboEkleOda.SelectedItem.ToString().Equals(oda.OdaAdi))
                    odaID = oda.OdaID;
            }
        }

        private void comboEkleDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboEkleOda.Items.Clear();
            foreach (var departman in Entities.tblDepartman)
            {
                if (comboEkleDepartman.SelectedItem.ToString().Equals(departman.DepartmanAdi))
                    departmanID = departman.DepartmanID;
            }
            foreach (var oda in Entities.tblOda)
            {
                if (oda.DepartmanID.Equals(departmanID))
                    comboEkleOda.Items.Add(oda.OdaAdi);
            }
        }

        private void comboSilDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboSilOda_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var oda in Entities.tblOda)
            {
                if (comboSilPersonel.SelectedItem.ToString().Equals(oda.OdaAdi))
                    odaID = oda.OdaID;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bool isSorumlu = false;

            foreach (var item in Entities.tblOda)
            {
                if (item.tblPersonel != null)
                {
                    if (comboSilPersonel.SelectedItem.ToString() == item.tblPersonel.PersonelAdi + " " + item.tblPersonel.PersonelSoyadi)
                    {
                        isSorumlu = false;
                        tblPersonel p = Entities.tblPersonel.First(f => f.PersonelAdi == item.tblPersonel.PersonelAdi && f.PersonelSoyadi == item.tblPersonel.PersonelSoyadi);
                        tblKullanici k = Entities.tblKullanici.First(ku => ku.tblPersonel.PersonelAdi == item.tblPersonel.PersonelAdi && ku.tblPersonel.PersonelSoyadi == item.tblPersonel.PersonelSoyadi);
                        item.PersonelID = null;
                        Entities.tblPersonel.Remove(p);
                        Entities.tblKullanici.Remove(k);
                        MessageBox.Show("Personel sistemden silinmiştir!", "Personel İşlemleri");
                        break;
                    }
                    else
                    {
                        isSorumlu = true;
                    }
                }
            }
            if (isSorumlu)
            {
                foreach (var item in Entities.tblPersonel)
                {
                    if (comboSilPersonel.SelectedItem.ToString().Equals(item.PersonelAdi + " " + item.PersonelSoyadi))
                    {
                        Entities.tblPersonel.Remove(item);
                        tblKullanici k = Entities.tblKullanici.First(ku => ku.tblPersonel.PersonelAdi == item.PersonelAdi && ku.tblPersonel.PersonelSoyadi == item.PersonelSoyadi);
                        Entities.tblKullanici.Remove(k);
                        MessageBox.Show("Personel sistemden silinmiştir!", "Personel İşlemleri");
                        break;
                    }
                }
            }
            Entities.SaveChanges();
            comboSilPersonel.Items.Clear();
            foreach (var personel in Entities.tblPersonel)
            {
                comboSilPersonel.Items.Add(personel.PersonelAdi + " " + personel.PersonelSoyadi);
            }
        }

        private void picPersonelArama_Click(object sender, EventArgs e)
        {
            PersonelArama = new FormPersonelArama();
            PersonelArama.Show();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bool isTrue = false;
            if (frmAnaSayfa.YetkiliD)
            {
                foreach (var k in Entities.tblKullanici)
                {
                    foreach (var key in Entities.tblPersonel)
                    {
                        if ((txtGuncellenecekPersonelAdi.Text).Equals(key.PersonelAdi) && (txtGuncellenecekPersonelSoyadi.Text).Equals(key.PersonelSoyadi) && k.PersonelID.Equals(key.PersonelID))
                        {
                            isTrue = false;
                            if (txtGuncellenecekPersonelYeniAdi.Text != "" && txtGuncellenecekPersonelYeniSoyadi.Text != "")
                            {
                                key.PersonelAdi = txtGuncellenecekPersonelYeniAdi.Text;
                                key.PersonelSoyadi = txtGuncellenecekPersonelYeniSoyadi.Text;
                            }
                            if (txtYeniKullaniciAdi.Text != "")
                            {
                                k.KullaniciAdi = txtYeniKullaniciAdi.Text;
                            }
                            if (txtYeniSifre.Text != "")
                            {
                                k.Sifre = txtYeniSifre.Text;
                            }
                            MessageBox.Show("Personel bilgileri başarıyla güncellenmiştir!", "Personel İşlemleri");
                            break;
                        }
                        else
                        {
                            isTrue = true;
                        }
                    }
                    if (!isTrue) break;
                }
                if (isTrue) MessageBox.Show("Aradığınız personel sistemde bulunmamaktadır!", "Personel İşlemleri");
            }
            else
            {
                foreach (var k in Entities.tblKullanici)
                {
                    foreach (var key in Entities.tblPersonel)
                    {
                        if (frmAnaSayfa.kulllaniciAdi.Equals(k.KullaniciAdi))
                        {
                            if (txtGuncellenecekPersonelYeniAdi.Text != "" && txtGuncellenecekPersonelYeniSoyadi.Text != "")
                            {
                                key.PersonelAdi = txtGuncellenecekPersonelYeniAdi.Text;
                                key.PersonelSoyadi = txtGuncellenecekPersonelYeniSoyadi.Text;
                            }
                            if (txtYeniKullaniciAdi.Text != "")
                            {
                                k.KullaniciAdi = txtYeniKullaniciAdi.Text;
                            }
                            if (txtYeniSifre.Text != "")
                            {
                                k.Sifre = txtYeniSifre.Text;
                            }
                            MessageBox.Show("Personel bilgileri başarıyla güncellenmiştir!", "Personel İşlemleri");
                            break;
                        }
                    }
                    if (!isTrue) break;
                }
            }
            Entities.SaveChanges();
        }

        private void btnPersoneleOdaAtama_Click(object sender, EventArgs e)
        {
            bool isTrue = false;
            
            if (!frmAnaSayfa.YetkiliD)
            {
                foreach (var item in Entities.tblPersonel)
                {
                    if (item.PersonelAdi.Equals(txtPersonelAdi.Text) && item.PersonelSoyadi.Equals(txtPersonelSoyadi.Text) && item.PersonelID > 3)
                    {
                        personelID = item.PersonelID;
                        isTrue = false;
                        break;
                    }
                    else
                    {
                        isTrue = true;
                    }
                }
            }
            else
            {
                foreach (var item in Entities.tblPersonel)
                {
                    if (item.PersonelAdi.Equals(txtPersonelAdi.Text) && item.PersonelSoyadi.Equals(txtPersonelSoyadi.Text))
                    {
                        personelID = item.PersonelID;
                        isTrue = false;
                        break;
                    }
                    else
                    {
                        isTrue = true;
                    }
                }
            }
            
            if(isTrue) MessageBox.Show("Lütfen geçerli bir personel adı yazınız!");
            else
            {
                foreach (var item in Entities.tblOda)
                {
                    if (item.OdaID.Equals(odaID))
                    {
                        item.PersonelID = personelID;
                        break;
                    }
                }
            }
            Entities.SaveChanges();
        }
    }
}

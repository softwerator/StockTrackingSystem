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
    public partial class FormOdaIslemleri : Form
    {
        YazilimSinamaEntities Entities = new YazilimSinamaEntities();
        frmAnaSayfa AnaSayfa;
        FormOdaArama OdaArama;
        int fakulteID, departmanID, odaID, demirbasID;

        public FormOdaIslemleri()
        {
            InitializeComponent();
        }

        private void frmOdaEkleme_Load(object sender, EventArgs e)
        {
            if (!frmAnaSayfa.YetkiliD)
            {
                tabOdaIslemler.TabPages.Remove(tabEkle);
                tabOdaIslemler.TabPages.Remove(tabSil);
                comboGuncelleFakulte.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                comboDemirbasDepartman.Visible = false;
                comboDemirbasFakulte.Visible = false;
                comboGuncelleDepartman.Visible = false;
            }
            comboEkleFakulte.Items.Clear();
            foreach (var fakulte in Entities.tblFakulte)
            {
                comboEkleFakulte.Items.Add(fakulte.FakulteAdi);
            }
        }

        private void tabOdaIslemler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabOdaIslemler.SelectedTab == tabOdaIslemler.TabPages["tabEkle"])
            {
                comboEkleFakulte.Items.Clear();
                foreach (var fakulte in Entities.tblFakulte)
                {
                    comboEkleFakulte.Items.Add(fakulte.FakulteAdi);
                }
            }
            else if (tabOdaIslemler.SelectedTab == tabOdaIslemler.TabPages["tabGuncelle"])
            {
                comboGuncelleFakulte.Items.Clear();
                foreach (var fakulte in Entities.tblFakulte)
                {
                    comboGuncelleFakulte.Items.Add(fakulte.FakulteAdi);
                }
                foreach (var item in Entities.tblOda)
                {
                    if (item.tblPersonel != null)
                    {
                        if (frmAnaSayfa.adSoyad.Equals(item.tblPersonel.PersonelAdi + " " + item.tblPersonel.PersonelSoyadi))
                        {
                            comboGuncelleOda.Items.Add(item.OdaAdi);
                        }
                    }
                }
            }
            else if (tabOdaIslemler.SelectedTab == tabOdaIslemler.TabPages["tabSil"])
            {
                comboSilFakulte.Items.Clear();
                foreach (var fakulte in Entities.tblFakulte)
                {
                    comboSilFakulte.Items.Add(fakulte.FakulteAdi);
                }
            }
            else if (tabOdaIslemler.SelectedTab == tabOdaIslemler.TabPages["tabDemirbasKaydi"])
            {
                comboDemirbasFakulte.Items.Clear();
                foreach (var fakulte in Entities.tblFakulte)
                {
                    comboDemirbasFakulte.Items.Add(fakulte.FakulteAdi);
                }
                foreach (var item in Entities.tblOda)
                {
                    if (item.tblPersonel != null)
                    {
                        if (frmAnaSayfa.adSoyad.Equals(item.tblPersonel.PersonelAdi + " " + item.tblPersonel.PersonelSoyadi))
                        {
                            comboDemirbasOda.Items.Add(item.OdaAdi);
                        }
                    }
                }
            }
        }

        private void lblOdaArama_Click(object sender, EventArgs e)
        {
            OdaArama = new FormOdaArama();
            OdaArama.Show();
            this.Hide();
        }

        private void picOdaArama_Click(object sender, EventArgs e)
        {
            OdaArama = new FormOdaArama();
            OdaArama.Show();
            this.Hide();
        }

        private void picAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa = new frmAnaSayfa();
            AnaSayfa.Show();
            this.Hide();
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

        private void comboGuncelleFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboGuncelleDepartman.Text = "";
            comboGuncelleOda.Text = "";
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

        private void comboSilFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSilDepartman.Text = "";
            comboSilOda.Text = "";
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

        private void comboGuncelleDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboGuncelleOda.Items.Clear();
            foreach (var departman in Entities.tblDepartman)
            {
                if (comboGuncelleDepartman.SelectedItem.ToString().Equals(departman.DepartmanAdi))
                    departmanID = departman.DepartmanID;
            }
            foreach (var oda in Entities.tblOda)
            {
                if (oda.DepartmanID.Equals(departmanID))
                    comboGuncelleOda.Items.Add(oda.OdaAdi);
            }
        }

        private void comboSilDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSilOda.Items.Clear();
            foreach (var departman in Entities.tblDepartman)
            {
                if (comboSilDepartman.SelectedItem.ToString().Equals(departman.DepartmanAdi))
                    departmanID = departman.DepartmanID;
            }
            foreach (var oda in Entities.tblOda)
            {
                if (oda.DepartmanID.Equals(departmanID))
                    comboSilOda.Items.Add(oda.OdaAdi);
            }
        }

        private void comboGuncelleOda_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var oda in Entities.tblOda)
            {
                if (comboGuncelleOda.SelectedItem.ToString().Equals(oda.OdaAdi))
                    odaID = oda.OdaID;
            }
        }

        private void comboSilOda_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var oda in Entities.tblOda)
            {
                if (comboSilOda.SelectedItem.ToString().Equals(oda.OdaAdi))
                    odaID = oda.OdaID;
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

        private void btnOdaEkle_Click(object sender, EventArgs e)
        {
            bool farklıOda = false;

            foreach (var key in Entities.tblOda)
            {
               if (key.OdaAdi.Equals(txtOda.Text)) {
                    farklıOda = true;
                    break;
                }
            }

            if (!farklıOda)
            {
                tblOda o = new tblOda() { OdaAdi = txtOda.Text, DepartmanID = departmanID };
                Entities.tblOda.Add(o);
                Entities.SaveChanges();
                MessageBox.Show("Girdiğiniz oda başarıyla eklenmiştir!", "Oda İşlemleri");
            }
            else {
                MessageBox.Show("Girdiğiniz oda bulunmaktadır!\nLütfen yeni bir oda ismi giriniz!", "Oda İşlemleri");
            }
        }

        private void comboDemirbasFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboDemirbasDepartman.Text = "";
            comboDemirbasOda.Text = "";
            comboDemirbasAdi.Text = "";
            comboDemirbasAdeti.Text = "";
            comboDemirbasDepartman.Items.Clear();
            foreach (var fakulte in Entities.tblFakulte)
            {
                if (comboDemirbasFakulte.SelectedItem.ToString().Equals(fakulte.FakulteAdi))
                    fakulteID = fakulte.FakulteID;
            }
            foreach (var departman in Entities.tblDepartman)
            {
                if (departman.FakulteID.Equals(fakulteID))
                    comboDemirbasDepartman.Items.Add(departman.DepartmanAdi);
            }
        }

        private void comboDemirbasDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboDemirbasAdi.Text = "";
            comboDemirbasAdeti.Text = "";
            comboDemirbasOda.Text = "";
            comboDemirbasOda.Items.Clear();
            foreach (var departman in Entities.tblDepartman)
            {
                if (comboDemirbasDepartman.SelectedItem.ToString().Equals(departman.DepartmanAdi))
                    departmanID = departman.DepartmanID;
            }
            foreach (var oda in Entities.tblOda)
            {
                if (oda.DepartmanID.Equals(departmanID))
                    comboDemirbasOda.Items.Add(oda.OdaAdi);
            }
            comboDemirbasAdi.Items.Clear();
            foreach (var departman in Entities.tblDepartman)
            {
                if (comboDemirbasDepartman.SelectedItem.ToString().Equals(departman.DepartmanAdi))
                    departmanID = departman.DepartmanID;
            }
            foreach (var adi in Entities.tblDemirbas)
            {
                if (adi.DepartmanID.Equals(departmanID))
                    comboDemirbasAdi.Items.Add(adi.DemirbasAdi);
            }
        }

        private void btnOdayaDemirbasEkle_Click(object sender, EventArgs e)
        {
            bool isVarMiydi = false;

            foreach (var item in Entities.tblOdaDemirbasAtama)
            {
                if (item.DemirbasID.Equals(demirbasID))
                {
                    isVarMiydi = true;
                    item.Adet = Convert.ToInt32(comboDemirbasAdeti.SelectedItem.ToString());
                    tblDemirbas d = Entities.tblDemirbas.First(de => de.DemirbasID == demirbasID);
                    d.Adet -= Convert.ToInt32(comboDemirbasAdeti.SelectedItem.ToString());
                    break;
                }
                else
                {
                    isVarMiydi = false;
                }
            }
            if (!isVarMiydi)
            {
                tblOdaDemirbasAtama oDA = new tblOdaDemirbasAtama();
                tblDemirbas d = Entities.tblDemirbas.First(de => de.DemirbasID == demirbasID);
                oDA.DemirbasID = demirbasID;
                oDA.Adet = Convert.ToInt32(comboDemirbasAdeti.SelectedItem.ToString());
                oDA.OdaID = odaID;
                d.Adet -= Convert.ToInt32(comboDemirbasAdeti.SelectedItem.ToString());
                Entities.tblOdaDemirbasAtama.Add(oDA);
            }
            Entities.SaveChanges();
        }

        private void comboDemirbasOda_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departmanAdi = "";
            comboDemirbasAdeti.Text = "";
            foreach (var oda in Entities.tblOda)
            {
                if (comboDemirbasOda.SelectedItem.ToString().Equals(oda.OdaAdi))
                {
                    odaID = oda.OdaID;
                    departmanAdi = oda.tblDepartman.DepartmanAdi;
                }
            }
            if (!frmAnaSayfa.YetkiliD)
            {
                comboDemirbasAdi.Items.Clear();
                foreach (var adi in Entities.tblDemirbas)
                {
                    if (adi.tblDepartman.DepartmanAdi.Equals(departmanAdi))
                    {
                        comboDemirbasAdi.Items.Add(adi.DemirbasAdi);
                    }
                }
            }
        }

        private void comboDemirbasAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Adet = 0;
            comboDemirbasAdeti.Text = "";
            comboDemirbasAdeti.Items.Clear();
            foreach (var item in Entities.tblDemirbas)
            {
                if (comboDemirbasAdi.SelectedItem.ToString().Equals(item.DemirbasAdi))
                {
                    demirbasID = item.DemirbasID;
                    Adet = item.Adet;
                }
            }
            for (int i = 0; i < Adet; i++)
            {
                comboDemirbasAdeti.Items.Add(i+1);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach (var item in Entities.tblOda)
            {
                if (item.OdaID.Equals(odaID))
                {
                    Entities.tblOda.Remove(item);
                    MessageBox.Show("Geçerli oda silinmiştir", "Oda İşlemleri");
                    break;
                }
            }
            Entities.SaveChanges();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            foreach (var key in Entities.tblOda) 
            {
                if (key.OdaID.Equals(odaID))
                {
                    key.OdaAdi = txtYeniAd.Text;
                    MessageBox.Show("Geçerli oda yeni isimle güncellenmiştir!", "Oda İşlemleri");
                    break;
                }
            }
            Entities.SaveChanges();            
        }
    }
}

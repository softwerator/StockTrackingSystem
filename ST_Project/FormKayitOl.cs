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
    public partial class FormKayitOl : Form
    {
        YazilimSinamaEntities Entities = new YazilimSinamaEntities();
        frmAnaSayfa AnaSayfa;
        FormGirisYap GirisYap;
        
        public FormKayitOl()
        {
            InitializeComponent();
        }

        private void picKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtParola_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_OnValueChanged(object sender, EventArgs e)
        {
    
        }

        private void picGirisYapaGit_Click(object sender, EventArgs e)
        {

        }

        private void picAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa = new frmAnaSayfa();
            AnaSayfa.Show();
            this.Hide();
        }

        private void lblUyeMisin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GirisYap = new FormGirisYap();
            GirisYap.Show();
            this.Hide();
        }

        private void frmKayitOl_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtKullaniciAdi.Text == "" || txtSifre.Text == "" 
                || txtSoyad.Text == "" || chckKabul.Checked == false)
            {
                if (txtAd.Text == "" || txtSoyad.Text == "")
                    lblAdSoyad.ForeColor = Color.Red;
                else lblAdSoyad.ForeColor = Color.White;
                if (txtKullaniciAdi.Text == "")
                    lblKullaniciAdi.ForeColor = Color.Red;
                else lblKullaniciAdi.ForeColor = Color.White;
                if (txtSifre.Text == "")
                    lblSifre.ForeColor = Color.Red;
                else lblSifre.ForeColor = Color.White;
                if (chckKabul.Checked == false)
                    lblKabul.ForeColor = Color.Red;
                else lblKabul.ForeColor = Color.White;
            }
            else
            {
                bool isTrue = false;
                foreach (var item in Entities.tblKullanici)
                {
                    if (item.KullaniciAdi.Equals(txtKullaniciAdi.Text)) { isTrue = false; break; }
                    else { isTrue = true; }
                }
                if (!isTrue) { MessageBox.Show("Bu kullanıcı adı ile üye olan kullanıcı mevcuttur!", "Kayıt Ol", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
                else
                {
                    tblKullanici Kullanici = new tblKullanici()
                    {
                        KullaniciAdi = txtKullaniciAdi.Text,
                        Sifre = txtSifre.Text,
                        YetkiliID = false
                    };
                    tblPersonel Personel = new tblPersonel()
                    {
                        PersonelAdi = txtAd.Text,
                        PersonelSoyadi = txtSoyad.Text
                    };
                    
                    Entities.tblPersonel.Add(Personel);
                    Entities.tblKullanici.Add(Kullanici);

                    Entities.SaveChanges();

                    GirisYap = new FormGirisYap();
                    GirisYap.Show();
                    this.Hide();
                }
            }
        }

        private void txtAd_OnValueChanged(object sender, EventArgs e)
        {
            int sonuc;
            if (txtAd.Text != "")
            {
                if ((int.TryParse(txtAd.Text, out sonuc)) == true)
                {
                    MessageBox.Show("Bu alan rakamlardan oluşamaz!", "Kayıt Ol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtSoyad_OnValueChanged(object sender, EventArgs e)
        {
            int sonuc;
            if (txtSoyad.Text != "")
            {
                if ((int.TryParse(txtSoyad.Text, out sonuc)) == true)
                {
                    MessageBox.Show("Bu alan rakamlardan oluşamaz!", "Kayıt Ol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

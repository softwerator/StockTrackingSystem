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
    public partial class FormGirisYap : Form
    {
        YazilimSinamaEntities Entities = new YazilimSinamaEntities();
        frmAnaSayfa AnaSayfa;
        FormKayitOl KayitOl;
        public static string kullaniciAdi = "";
        public static string adSoyad = "";
        public static int kullaniciID;
        public static bool isAdmin = false;
        private bool isTrue = false;
        public FormGirisYap()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            foreach (var key in Entities.tblKullanici)
            {
                if (key.KullaniciAdi.Equals(txtKullaniciAdi.Text) && key.Sifre.Equals(txtSifre.Text))
                {
                    if (key.YetkiliID) isAdmin = true;
                    else isAdmin = false;
                    isTrue = true;
                    kullaniciAdi = key.KullaniciAdi;
                    adSoyad = key.tblPersonel.PersonelAdi + " " + key.tblPersonel.PersonelSoyadi;
                    isAdmin = key.YetkiliID;
                    kullaniciID = key.KullaniciID;
                    AnaSayfa = new frmAnaSayfa();
                    AnaSayfa.Show();
                    this.Hide();
                    break;
                } else {
                    isTrue = false;
                    kullaniciAdi = "";
                }
            }
            if (!isTrue)
            {
                MessageBox.Show("Hatalı giriş yaptınız, lütfen tekrar deneyiniz!", "Giriş Yap", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }

        }

        private void picKayitOlaGit_Click(object sender, EventArgs e)
        {

        }

        private void picKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa = new frmAnaSayfa();
            AnaSayfa.Show();
            this.Hide();
        }

        private void lblUyeMisin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl = new FormKayitOl();
            KayitOl.Show();
            this.Hide();
        }

        private void AlanlarDoluMu()
        {

        }

        private void frmGirisYap_Load(object sender, EventArgs e)
        {

        }
    }
}

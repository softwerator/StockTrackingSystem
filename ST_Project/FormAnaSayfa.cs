using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST_Project
{
    public partial class frmAnaSayfa : Form
    {
        YazilimSinamaEntities Entities = new YazilimSinamaEntities();
        FormGirisYap GirisYap;
        FormOdaArama Odalar;
        FormDemirbasArama Demirbaslar;
        FormPersonelArama Personeller;
        public static string kulllaniciAdi = "";
        public static string adSoyad = "";
        public static int kullaniciID;
        public static bool YetkiliD = false; 

        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            kulllaniciAdi = FormGirisYap.kullaniciAdi;
            adSoyad = FormGirisYap.adSoyad;
            YetkiliD = false;
            if (kulllaniciAdi != "")
            {
                picCikisYap.Visible = true;
                lblCikisYap.Visible = true;
                lblKullaniciAdi.Visible = true;

                if (FormGirisYap.isAdmin)
                {
                    YetkiliD = true;
                    lblKullaniciAdi.Text = "Hoşgeldiniz Admin " + FormGirisYap.kullaniciAdi + "!";
                }
                else
                {
                    YetkiliD = false;
                    lblKullaniciAdi.Text = "Hoşgeldiniz " + FormGirisYap.kullaniciAdi + "!";
                }
            }
            lblPDFKapat.Visible = false;
            axAcroPDF1.Visible = false;
        }
       
        private void lblGirisYapKayitOl_Click(object sender, EventArgs e)
        {
            if (kulllaniciAdi == "")
            {
                GirisYap = new FormGirisYap();
                GirisYap.Show();
                this.Hide();
            }
        }

        private void lblAnaSayfa_Click(object sender, EventArgs e)
        {
            pnlBelgeler.Visible = false;
            pnlFlamingoNedir.Visible = false;
            if (kulllaniciAdi != "")
            {
                picCikisYap.Visible = true;
                lblCikisYap.Visible = true;
                lblKullaniciAdi.Visible = true;
            }
        }

        private void lblOdalar_Click(object sender, EventArgs e)
        {
            if (kulllaniciAdi != "")
            {
                Odalar = new FormOdaArama();
                Odalar.Show();
                this.Hide();
            }
        }

        private void lblPersoneller_Click(object sender, EventArgs e)
        {
            if (kulllaniciAdi != "")
            {
                Personeller = new FormPersonelArama();
                Personeller.Show();
                this.Hide();
            }
        }

        private void lblDemirbaslar_Click(object sender, EventArgs e)
        {
            if (kulllaniciAdi != "")
            {
                Demirbaslar = new FormDemirbasArama();
                Demirbaslar.Show();
                this.Hide();
            }
        }

        private void lblBelgeler_Click(object sender, EventArgs e)
        {
            bool isTrue = false;
            foreach (var item in Entities.tblBelgeler)
            {
                if (item.KullaniciID.Equals(FormGirisYap.kullaniciID))
                {
                    isTrue = true;
                    break;
                }
            }
            if (!isTrue)
            {
                MessageBox.Show("Daha önce oluşturduğunuz herhangi bir belge bulunmamaktadır!", "Belgeler");
            }
            else
            {
                picCikisYap.Visible = false;
                lblCikisYap.Visible = false;
                lblKullaniciAdi.Visible = false;
                if (kulllaniciAdi != "")
                {
                    pnlFlamingoNedir.Visible = false;
                    pnlBelgeler.Visible = true;
                    dgvBelgeler.SendToBack();
                }
                dgvBelgeler.Columns.Clear();
                dgvBelgeler.Rows.Clear();
                int count = 0;
                dgvIslemleri();
                foreach (var item in Entities.tblBelgeler)
                {
                    if (item.KullaniciID.Equals(FormGirisYap.kullaniciID))
                    {
                        count++;
                        string[] satir = new string[] { count.ToString(), item.BelgeAdi, item.BelgeOlusturulmaTarihi.Date.ToString("d"), item.BelgeYolu };
                        dgvBelgeler.Rows.Add(satir);
                    }
                }
            }
        }
        private void dgvBelgeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                lblPDFKapat.Visible = true;
                axAcroPDF1.Visible = true;
                axAcroPDF1.src = dgvBelgeler[e.ColumnIndex, e.RowIndex].Value.ToString();
            }
        }

        private void dgvIslemleri()
        {
            dgvBelgeler.Rows.Clear();
            dgvBelgeler.ColumnCount = 4;
            dgvBelgeler.Columns[0].HeaderText = "Sıra No";
            dgvBelgeler.Columns[1].HeaderText = "Belge Adı";
            dgvBelgeler.Columns[2].HeaderText = "Belge Tarihi";
            dgvBelgeler.Columns[3].HeaderText = "Belge Aç";
            DataGridViewColumn column1 = dgvBelgeler.Columns[0];
            column1.Width = 75;
            DataGridViewColumn column2 = dgvBelgeler.Columns[1];
            column2.Width = 150;
            DataGridViewColumn column3 = dgvBelgeler.Columns[2];
            column3.Width = 120;
            DataGridViewColumn column4 = dgvBelgeler.Columns[3];
            column4.Width = 293;
        }

        private void lblFlamingoNedir_Click(object sender, EventArgs e)
        {
            pnlBelgeler.Visible = false;
            pnlFlamingoNedir.Visible = true;
            imgFlamingoNedir.SendToBack();
            imgFlamingoNedir.Parent = lblHakkımızda;
            float opacityvalue = float.Parse("33,3") / 100;
            imgFlamingoNedir.Image = ST_Project.frmAnaSayfa.Opaklik(
            Image.FromFile("C://Users//Burakcan//Documents//Visual Studio 2017//Projects//ST_Project//ST_Project//Properties//Flamingo.png"), opacityvalue);
        }

        public static Image Opaklik(Image imgPic, float imgOpac)
        {
            Bitmap bmpPic = new Bitmap(imgPic.Width, imgPic.Height);
            Graphics gfxPic = Graphics.FromImage(bmpPic);
            ColorMatrix cmxPic = new ColorMatrix();
            cmxPic.Matrix33 = imgOpac;
            ImageAttributes iaPic = new ImageAttributes();
            iaPic.SetColorMatrix(cmxPic, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            gfxPic.DrawImage(imgPic, new Rectangle(0, 0, bmpPic.Width, bmpPic.Height), 0, 0, imgPic.Width, imgPic.Height, GraphicsUnit.Pixel, iaPic);
            gfxPic.Dispose();
            return bmpPic;
        }

        private void picAnaSayfaKapat_Click(object sender, EventArgs e)
        {
            if (kulllaniciAdi == "")
                Application.Exit();
            else
                MessageBox.Show("Sayın " + kulllaniciAdi + ", çıkış yapmadan önce oturumu kapatınız!", "Ana Sayfa");
        }

        private void picBelgelerKapat_Click(object sender, EventArgs e)
        {
            if (kulllaniciAdi == "")
                Application.Exit();
            else
                MessageBox.Show("Sayın " + kulllaniciAdi + ", çıkış yapmadan önce oturumu kapatınız!", "Ana Sayfa");
        }

        private void lblCikisYap_Click(object sender, EventArgs e)
        {
            picCikisYap.Visible = false;
            lblCikisYap.Visible = false;
            lblKullaniciAdi.Visible = false;
            lblKullaniciAdi.Text = "";
            if (kulllaniciAdi != "") {
                kulllaniciAdi = "";
                FormGirisYap.kullaniciAdi = "";
            }
        }

        private void picCikisYap_Click(object sender, EventArgs e)
        {
            picCikisYap.Visible = false;
            lblCikisYap.Visible = false;
            lblKullaniciAdi.Visible = false;
            lblKullaniciAdi.Text = "";
        }

        private void lblPDFKapat_Click(object sender, EventArgs e)
        {
            lblPDFKapat.Visible = false;
            axAcroPDF1.Visible = false;
        }

        private void pnlFlamingoNedir_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

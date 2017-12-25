using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST_Project
{
    public partial class FormOdaArama : Form
    {
        YazilimSinamaEntities Entities = new YazilimSinamaEntities();
        frmAnaSayfa AnaSayfa;
        FormOdaIslemleri OdaAtama;
        string pdfBilgiGoster = "";
        string AranmisOda = "";
                       
        public FormOdaArama()
        {
            InitializeComponent();
        }

        private void frmOdaArama_Load(object sender, EventArgs e)
        {
            dgvOdaDemirbaslari.Columns.Clear();
            dgvOdaDemirbaslari.Rows.Clear();
            foreach (var item in Entities.tblOda)
            {
                comboOdaAdi.Items.Add(item.OdaAdi);
            }
        }

        private void picAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa = new frmAnaSayfa();
            AnaSayfa.Show();
            this.Hide();
        }

        private void lblOdaAtama_Click(object sender, EventArgs e)
        {
            OdaAtama = new FormOdaIslemleri();
            OdaAtama.Show();
            this.Hide();
        }

        private void picOdaAtama_Click(object sender, EventArgs e)
        {
            OdaAtama = new FormOdaIslemleri();
            OdaAtama.Show();
            this.Hide();
        }

        private void btnOdaBilgileriniListele_Click(object sender, EventArgs e)
        {
            dgvOdaDemirbaslari.Columns.Clear();
            dgvOdaDemirbaslari.Rows.Clear();
            bool isTrue = false;
            string fakulteAdi = "", departmanAdi = "";
            foreach (var key in Entities.tblOdaDemirbasAtama)
            {
                if (key.tblOda.OdaAdi.Equals(comboOdaAdi.SelectedItem.ToString()))
                {
                    fakulteAdi = key.tblOda.tblDepartman.tblFakulte.FakulteAdi;
                    departmanAdi = key.tblOda.tblDepartman.DepartmanAdi;
                    isTrue = true;
                    break;
                }
            }
            if (!isTrue)
            {
                lblFakulteDepartman.Text = "";
                MessageBox.Show("Aradığınız odanın herhangi bir demirbaşı yoktur!", "Oda Arama");
            }
            else
            {
                int count = 0;
                DgvIslemleri();
                foreach (var item in Entities.tblOdaDemirbasAtama)
                {
                    if (comboOdaAdi.SelectedItem.ToString().Equals(item.tblOda.OdaAdi))
                    {
                        if (count == 0) AranmisOda = item.tblOda.OdaAdi;
                        count++;
                        string[] satir = new string[] { count.ToString(), item.tblDemirbas.DemirbasAdi, item.tblDemirbas.DemirbasKodu, Convert.ToString(item.Adet) };
                        dgvOdaDemirbaslari.Rows.Add(satir);
                    }
                }
                lblFakulteDepartman.Text = "Bu oda " + fakulteAdi + "\n" + departmanAdi + " departmanında bulunmaktadır.";
                pdfBilgiGoster = AranmisOda + " odası " + fakulteAdi + " ve " + departmanAdi + " departmanında bulunmaktadır.";
            }
        }

        private void DgvIslemleri()
        {
            dgvOdaDemirbaslari.Rows.Clear();
            dgvOdaDemirbaslari.ColumnCount = 4;
            dgvOdaDemirbaslari.Columns[0].HeaderText = "Sıra No";
            dgvOdaDemirbaslari.Columns[1].HeaderText = "Demirbaş Adı";
            dgvOdaDemirbaslari.Columns[2].HeaderText = "Demirbaş Kodu";
            dgvOdaDemirbaslari.Columns[3].HeaderText = "Demirbaş Adedi";
            DataGridViewColumn column1 = dgvOdaDemirbaslari.Columns[0];
            column1.Width = 73;
            DataGridViewColumn column2 = dgvOdaDemirbaslari.Columns[1];
            column2.Width = 120;
            DataGridViewColumn column3 = dgvOdaDemirbaslari.Columns[2];
            column3.Width = 180;
            DataGridViewColumn column4 = dgvOdaDemirbaslari.Columns[3];
            column4.Width = 120;
        }

        private void btnPDF_CiktiAl_Click(object sender, EventArgs e)
        {
            if(dgvOdaDemirbaslari.RowCount > 0)
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4);
                        try
                        {
                            System.IO.MemoryStream ms = new System.IO.MemoryStream();
                            PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                            iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, ms);
                            doc.Open();

                            BaseFont text = BaseFont.CreateFont("Helvetica", "Cp1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);
                            iTextSharp.text.Font f = new iTextSharp.text.Font(text, 16f, 1, BaseColor.RED);
                            Chunk c = new Chunk();
                            c.Font = f;
                            doc.Add(c);

                            Paragraph heading = new Paragraph("FLAMİNGO STOK TAKİP SİSTEMİ \n\n\n", f);
                            heading.Alignment = Element.ALIGN_CENTER;
                            doc.Add(heading);

                            BaseFont text1 = BaseFont.CreateFont("Helvetica", "Cp1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);
                            iTextSharp.text.Font f1 = new iTextSharp.text.Font(text1, 12f, 0, BaseColor.BLACK);
                            Chunk c1 = new Chunk();
                            c1.Font = f1;
                            doc.Add(c1);

                            Paragraph p1 = new Paragraph(pdfBilgiGoster, f1);
                            doc.Add(p1);

                            Paragraph p2 = new Paragraph(" ");
                            doc.Add(p2);

                            BaseFont text2 = BaseFont.CreateFont("Helvetica", "Cp1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);
                            iTextSharp.text.Font f2 = new iTextSharp.text.Font(text2, 10f, 1, BaseColor.BLACK);
                            Chunk c2 = new Chunk();
                            c2.Font = f2;
                            doc.Add(c2);

                            PdfPTable table = new PdfPTable(dgvOdaDemirbaslari.Columns.Count);

                            for (int j = 0; j < dgvOdaDemirbaslari.Columns.Count; j++)
                            {
                                table.AddCell(new Phrase(dgvOdaDemirbaslari.Columns[j].HeaderText, f2));
                            }

                            table.HeaderRows = 1;

                            BaseFont text3 = BaseFont.CreateFont("Helvetica", "Cp1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);
                            iTextSharp.text.Font f3 = new iTextSharp.text.Font(text3, 10f, 0, BaseColor.BLACK);
                            Chunk c3 = new Chunk();
                            c3.Font = f3;
                            doc.Add(c3);

                            for (int i = 0; i < dgvOdaDemirbaslari.Rows.Count; i++)
                            {
                                for (int k = 0; k < dgvOdaDemirbaslari.Columns.Count; k++)
                                {
                                    if (dgvOdaDemirbaslari[k, i].Value != null)
                                    {
                                        table.AddCell(new Phrase(dgvOdaDemirbaslari[k, i].Value.ToString(), f3));
                                    }
                                }
                            }

                            doc.Add(table);

                            byte[] belge = ms.ToArray();
                            string[] belgeAdi = sfd.FileName.Split('\\');
                            string gercekBelgeAdi = belgeAdi[belgeAdi.Length - 1];
                            belgeAdi = gercekBelgeAdi.Split('.');
                            gercekBelgeAdi = belgeAdi[0];

                            tblBelgeler Belge = new tblBelgeler();
                            Belge.BelgeAdi = gercekBelgeAdi;
                            Belge.BelgeOlusturulmaTarihi = DateTime.Now.Date;
                            Belge.KullaniciID = FormGirisYap.kullaniciID;
                            Belge.BelgeYolu = sfd.FileName;
                            Entities.tblBelgeler.Add(Belge);
                            Entities.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            doc.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("PDF dökümanı oluşturmak için listeleme yapınız!", "Oda Arama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

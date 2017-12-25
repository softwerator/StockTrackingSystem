using System;

namespace ST_Project
{
    public class Testing
    {
        bool durum = false;
        public bool AdeteBak(string Adet)
        {
            if (SayiMi(Adet))
            {
                durum = true;
                return durum;
            }
            else if (Adet.Equals(""))
            {
                durum = false;
                return durum;
            }
            else if (Adet.Contains(" "))
            {
                durum = false;
                return durum;
            }
            throw new InvalidOperationException();
        }

        public bool GiriseBak(string KullaniciAdi, string Sifre)
        {
            if (GirisAlanlariBosMu(KullaniciAdi, Sifre))
            {
                durum = false;
                return durum;
            }
            else
            {
                durum = true;
                return durum;
            }
            throw new InvalidOperationException();
        }

        public bool OdayaBak(string Oda)
        {
            if (Oda.StartsWith("YZM_"))
            {
                durum = true;
                return durum;
            }
            else
            {
                durum = false;
                return durum;
            }
            throw new InvalidOperationException();
        }

        private bool SayiMi(string Deger)
        {
            foreach (char c in Deger)
            {
                if (!Char.IsDigit(c)) return false;
            }
            return true;
        }

        private bool GirisAlanlariBosMu(string KullaniciAdi, string Sifre)
        {
            if (KullaniciAdi.Equals("") && Sifre.Equals(""))
            {
                return true;
            }
            return false;
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ST_Project;

namespace ST_ProjectTests
{
    [TestClass]
    public class UnitTest1
    {
        Testing t = new Testing();

        [TestMethod]
        public void AdetAlaniDoluMu()
        {
            bool sonuc = t.AdeteBak("5");
            Assert.AreEqual(true, sonuc);
        }

        [TestMethod]
        public void AdetAlaniHataliMi()
        {
            bool sonuc = t.AdeteBak("12 34");
            Assert.AreEqual(false, sonuc);
        }

        [TestMethod]
        public void AdetAlaniBosMu()
        {
            bool sonuc = t.AdeteBak(" ");
            Assert.AreEqual(false, sonuc);
        }

        [TestMethod]
        public void GirisAlanlariDoluMu()
        {
            bool sonuc = t.GiriseBak("btimucin", "123456");
            Assert.AreEqual(true, sonuc);
        }

        [TestMethod]
        public void GirisAlanlariBosMu()
        {
            bool sonuc = t.GiriseBak("", "");
            Assert.AreEqual(false, sonuc);
        }

        [TestMethod]
        public void YZM_OdaAramaBasariliMi()
        {
            bool sonuc = t.OdayaBak("YZM_1");
            Assert.AreEqual(true, sonuc);
        }

        [TestMethod]
        public void YZM_OdaAramaBasarisizMi()
        {
            bool sonuc = t.OdayaBak("1YZM");
            Assert.AreEqual(false, sonuc);
        }
    }
}

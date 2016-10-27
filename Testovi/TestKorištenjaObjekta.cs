using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestKorištenjaObjekta : ConsoleTest
    {
        [TestMethod]
        public void KorištenjeObjekta_IspišiTrenutniDatumVrijemeIspisujeTrenutnuVrijednost()
        {
            DateTime trenutnoVrijeme = DateTime.Now;
            KorištenjeObjekata.IspišiTrenutniDatumVrijeme();
            object obj = cw.GetObject();
            string ispisano = obj as string;
            DateTime ispisanoVrijeme = ispisano != null ? DateTime.Parse(ispisano) : (DateTime)obj;
            Assert.IsTrue((trenutnoVrijeme - ispisanoVrijeme).Seconds <= 1);
        }

        [TestMethod]
        public void KorištenjeObjekta_IspišiDanašnjiDatumIspisujeDanašnjiDatum()
        {
            KorištenjeObjekata.IspišiDanašnjiDatum();
            Assert.AreEqual(DateTime.Now.ToShortDateString(), cw.GetString());
        }

        [TestMethod]
        public void KorištenjeObjekta_IspišiTrenutnoVrijemeIspisujeVrijednost()
        {
            DateTime trenutnoVrijeme = DateTime.Now;
            KorištenjeObjekata.IspišiTrenutnoVrijeme();
            DateTime ispisanoVrijeme = DateTime.Parse(cw.GetString());
            Assert.IsTrue((trenutnoVrijeme - ispisanoVrijeme).Seconds <= 1);
        }

        [TestMethod]
        public void KorištenjeObjekta_IzračunajBrojDanaIzmeđuDvaDatumaVraća365ZaNeprestupnuGodinu()
        {
            Assert.AreEqual(365, KorištenjeObjekata.IzračunajBrojDanaIzmeđuDvaDatuma(2001, 1, 1, 2002, 1, 1));
        }

        [TestMethod]
        public void KorištenjeObjekta_IzračunajBrojDanaIzmeđuDvaDatumaVraća366ZaPrestupnuGodinu()
        {
            Assert.AreEqual(366, KorištenjeObjekata.IzračunajBrojDanaIzmeđuDvaDatuma(2004, 1, 1, 2005, 1, 1));
        }
    }
}

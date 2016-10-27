using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestStatičkogKonstruktora : ConsoleTest
    {
        [TestMethod]
        public void StatičkiKonstruktor_PrijePozivaStatičkeMetodeIzvodiSeStatičkiKonstruktor()
        {
            StatičkiKonstruktor.PozoviSamoStatičkuMetodu();
            Assert.AreEqual("SaStatičkimKonstruktorom1.StatičkiKonstruktor", cw.GetString());
            Assert.AreEqual("SaStatičkimKonstruktorom1.Metoda1", cw.GetString());
            Assert.IsTrue(cw.IsEmpty);
        }

        [TestMethod]
        public void StatičkiKonstruktor_PrijeStvaranjaObjektaIzvodiSeStatičkiKonstruktor()
        {
            StatičkiKonstruktor.PozoviNestatičkuMetodu();
            Assert.AreEqual("SaStatičkimKonstruktorom2.StatičkiKonstruktor", cw.GetString());
            Assert.AreEqual("SaStatičkimKonstruktorom1.StatičkiKonstruktor", cw.GetString());
            Assert.AreEqual("SaStatičkimKonstruktorom1.KonstruktorKlase", cw.GetString());
            Assert.AreEqual("SaStatičkimKonstruktorom2.KonstruktorKlase", cw.GetString());
            Assert.AreEqual("SaStatičkimKonstruktorom2.Metoda2", cw.GetString());
            Assert.IsTrue(cw.IsEmpty);
        }
    }
}

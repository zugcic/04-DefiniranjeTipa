using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp.KonstruktorKlase;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestKonstruktorKlase
    {
        [TestMethod]
        public void KonstruktorKlase_KonstruktorSArgumentimaInicijaliziraOsobu()
        {
            Osoba o = new Osoba("Nikola", "Tesla", new DateTime(1856, 7, 10), Spol.Muški);
            Assert.AreEqual("Nikola", o.Ime);
            Assert.AreEqual("Tesla", o.Prezime);
            Assert.AreEqual(new DateTime(1856, 7, 10), o.DatumRođenja);
            Assert.AreEqual(Spol.Muški, o.Spol);
        }
    }
}

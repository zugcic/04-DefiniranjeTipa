using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestKonstruktorKlase : ConsoleTest
    {
        [TestMethod]
        public void KonstruktorKlase_KonstruktorSArgumentimaInicijaliziraOsobu()
        {
            KonstruktorKlase.StvoriObjektZadanimKonstruktorom("Nikola", "Tesla", new DateTime(1856, 7, 10));
            Assert.AreEqual("Nikola", cw.GetString());
            Assert.AreEqual("Tesla", cw.GetString());
            Assert.AreEqual(new DateTime(1856, 7, 10), (DateTime)cw.GetObject());
        }
    }
}

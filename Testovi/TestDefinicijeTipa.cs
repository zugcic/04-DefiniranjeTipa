using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestDefinicijeTipa : ConsoleTest
    {
        [TestMethod]
        public void DefinicijaTipa_MojaKlasaIspišiČlanIspisuje5()
        {
            DefinicijaTipa.IspišiČlanKlase();
            Assert.AreEqual(5, cw.GetInt());
        }

        [TestMethod]
        public void DefinicijaTipa_MojaStrukturaIspišiČlanIspisujeMojaStruktura()
        {
            DefinicijaTipa.IspišiČlanStrukture();
            Assert.AreEqual("MojaStruktura", cw.GetString());
        }
    }
}

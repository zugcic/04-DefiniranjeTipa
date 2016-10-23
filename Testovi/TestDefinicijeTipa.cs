using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp.DefinicijaTipa;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestDefinicijeTipa : ConsoleTest
    {
        [TestMethod]
        public void DefinicijaTipa_MojaKlasaIspišiČlanIspisuje5()
        {
            MojaKlasa mk = new MojaKlasa();
            Assert.AreEqual(5, mk.IspišiČlan());
        }

        [TestMethod]
        public void DefinicijaTipa_MojaStrukturaIspišiČlanIspisuje5()
        {
            MojaStruktura ms = new MojaStruktura();
            Assert.AreEqual("MojaStruktura", ms.IspišiČlan());
        }
    }
}

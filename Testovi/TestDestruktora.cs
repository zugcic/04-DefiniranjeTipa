using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestDestruktora : ConsoleTest
    {
        [TestMethod]
        public void Destruktor_PrilikomUništenjaObjektaIspisujeSePoruka()
        {
            KlasaSDestruktorom ksd = new KlasaSDestruktorom();
            Assert.AreEqual("Konstruktor objekta br. 1", cw.GetString());
            ksd = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            Assert.AreEqual("Destruktor objekta br. 1", cw.GetString());
        }
    }
}

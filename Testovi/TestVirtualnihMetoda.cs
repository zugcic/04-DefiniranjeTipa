using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestVirtualnihMetoda : ConsoleTest
    {
        [TestMethod]
        public void VirtualneMetode_ZasebniPoziviNevirtualnihMetodaPozivajuPripadajućeČlanove()
        {
            VirtualneMetode.ZasebniPoziviNevirtualnihMetoda();
            Assert.AreEqual("Bazna Obično", cw.GetString());
            Assert.AreEqual("Izvedena1 Obično", cw.GetString());
            Assert.AreEqual("Izvedena2 Obično", cw.GetString());
        }

        [TestMethod]
        public void VirtualneMetode_PoziviNevirtualnihMetodaNaKolekcijiBaznogTipaPozivajuBazneČlanove()
        {
            VirtualneMetode.PoziviNevirtualnihMetodaNaKolekcijiBaznogTipa();
            Assert.AreEqual("Bazna Obično", cw.GetString());
            Assert.AreEqual("Bazna Obično", cw.GetString());
            Assert.AreEqual("Bazna Obično", cw.GetString());
        }

        [TestMethod]
        public void VirtualneMetode_ZasebniPoziviVirtualnihMetodaPozivajuPripadajućeČlanove()
        {
            VirtualneMetode.ZasebniPoziviVirtualnihMetoda();
            Assert.AreEqual("Bazna Virtualno", cw.GetString());
            Assert.AreEqual("Izvedena1 Virtualno", cw.GetString());
            Assert.AreEqual("Izvedena2 Virtualno", cw.GetString());
        }

        [TestMethod]
        public void VirtualneMetode_PoziviVirtualnihMetodaNaKolekcijiBaznogTipaPozivajuPripadajućeČlanove()
        {
            VirtualneMetode.PoziviVirtualnihMetodaNaKolekcijiBaznogTipa();
            Assert.AreEqual("Bazna Virtualno", cw.GetString());
            Assert.AreEqual("Izvedena1 Virtualno", cw.GetString());
            Assert.AreEqual("Izvedena2 Virtualno", cw.GetString());
        }
    }
}

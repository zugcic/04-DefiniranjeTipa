using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestDelegiranjaKonstruktora : ConsoleTest
    {

        [TestMethod]
        public void DelegiranjeKonstruktora_PozivPraznogKonstruktoraIzvedeneKlase()
        {
            DelegiranjeKonstruktora.StvoriInstancuIzvedeneKlasePraznimKonstruktorom();
            Assert.IsTrue(cw.GetString().StartsWith("Bazna.Bazna("));
            Assert.IsTrue(cw.GetString().StartsWith("Izvedena.Izvedena("));
        }

        [TestMethod]
        public void DelegiranjeKonstruktora_PozivKonstruktoraSDvaArgumenta()
        {
            DelegiranjeKonstruktora.StvoriInstancuIzvedeneKlaseKonstruktoromSDvaArgumenta(5, 7);
            Assert.AreEqual("Bazna.Bazna(5)", cw.GetString());
            Assert.AreEqual("Izvedena.Izvedena(7)", cw.GetString());
            Assert.AreEqual("Izvedena.Izvedena(5, 7)", cw.GetString());
            Assert.AreEqual(5, cw.GetInt());
            Assert.AreEqual(7, cw.GetInt());
        }
    }
}

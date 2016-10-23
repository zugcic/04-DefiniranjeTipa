using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp.StatičkiČlanovi;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestStatičkihČlanova : ConsoleTest
    {
        [TestMethod]
        public void StatičkiČlanovi_IspišiBrojStvorenihObjekataIspisujeNaPočetku0()
        {
            BrojačInstanci.IspišiBrojStvorenihObjekata();
            Assert.AreEqual(0, cw.GetInt());
        }

        [TestMethod]
        public void StatičkiČlanovi_IspišiBrojStvorenihObjekataIspisujeBrojStvorenihObjekata()
        {
            BrojačInstanci bi = new BrojačInstanci();
            BrojačInstanci.IspišiBrojStvorenihObjekata();
            Assert.AreEqual(1, cw.GetInt());

            bi = new BrojačInstanci();
            BrojačInstanci.IspišiBrojStvorenihObjekata();
            Assert.AreEqual(2, cw.GetInt());
        }

        [TestMethod]
        public void StatičkiČlanovi_IspišiRedniBrojObjektaIspisujeRedniBroj()
        {
            BrojačInstanci bi = new BrojačInstanci();
            bi.IspišiRedniBrojObjekta();
            Assert.AreEqual(1, cw.GetInt());

            bi = new BrojačInstanci();
            bi.IspišiRedniBrojObjekta();
            Assert.AreEqual(2, cw.GetInt());
        }
    }
}

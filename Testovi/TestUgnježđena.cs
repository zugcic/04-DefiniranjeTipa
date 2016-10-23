using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestUgnježđena : ConsoleTest
    {
        [TestMethod]
        public void UgnježđenaKlasa_Gnijezdo_IspišiSeIspisujeZadaniTekst()
        {
            Gnijezdo g = new Gnijezdo();
            g.IspišiMe();
            Assert.AreEqual("Ugnježđena", cw.GetString());
            
        }

        [TestMethod]
        public void UgnježđenaKlasa_IzvedenoGnijezdo_PredstaviSeIspisujeZadaniTekst()
        {
            IzvedenoGnijezdo ig = new IzvedenoGnijezdo();
            ig.PredstaviSe();
            Assert.AreEqual("Ja sam klasa Ugnježđena", cw.GetString());
        }

        [TestMethod]
        public void UgnježđenaKlasa_IzravnoKorištenjeUgnježđeneKlase()
        {
            UgnježđenaKlasa.IzravnoKorištenjeUgnježđeneKlase();
            Assert.AreEqual("Ja sam klasa Ugnježđena, neposredno", cw.GetString());
        }
    }
}

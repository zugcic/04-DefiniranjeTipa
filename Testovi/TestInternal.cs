using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestInternal : ConsoleTest
    {
        [TestMethod]
        public void Internal_IzvedenaIzJavneBazne_IspišiMePozivaMetoduUBaznojKlasi()
        {
            Internal.IspišiIzvedenuIzJavne();
            Assert.AreEqual("JavnaBazna", cw.GetString());
        }

        [TestMethod]
        public void Internal_IzvedenaIzBazne_IspišiMePozivaMetoduUBaznojKlasi()
        {
            Internal.IspišiIzvedenuIzBazne();
            Assert.AreEqual("???Bazna", cw.GetString());
        }

        [TestMethod]
        public void Internal_IzvedenaIzInterneBazneLokalneIspišiMePozivaMetoduUBaznojKlasi()
        {
            IzvedenaIzInterneBazne izvedanaIzInterneBazne = new IzvedenaIzInterneBazne();
            izvedanaIzInterneBazne.IspišiMe();
            Assert.AreEqual("InternaBazna", cw.GetString());
        }
    }
}

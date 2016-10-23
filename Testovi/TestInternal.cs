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
            IzvedenaIzJavneBazne izvedanaIzJavne = new IzvedenaIzJavneBazne();
            izvedanaIzJavne.IspišiMe();
            Assert.AreEqual("JavnaBazna", cw.GetString());
        }

        [TestMethod]
        public void Internal_IzvedenaIzBazne_IspišiMePozivaMetoduUBaznojKlasi()
        {
            IzvedenaIzBazne izvedanaIzBazne = new IzvedenaIzBazne();
            izvedanaIzBazne.IspišiMe();
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

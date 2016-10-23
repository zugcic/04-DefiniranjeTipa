using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestKonstruktoraStrukture : ConsoleTest
    {
        [TestMethod]
        public void KonstruktorStrukture_TestPozivaPraznogKonstruktora()
        {
            KonstruktorStrukture.PozivPodrazumijevanogKonstruktora();
            Assert.AreEqual(0.0, cw.GetDouble());
            Assert.AreEqual(JedinicaDuljine.Milimetar, (JedinicaDuljine)cw.GetObject());
        }

        [TestMethod]
        public void KonstruktorStrukture_TestPozivaKonstruktoraSDvaArgumenta()
        {
            KonstruktorStrukture.PozivKonstruktoraSDvaArgumenta(3, JedinicaDuljine.Metar);
            Assert.AreEqual(3.0, cw.GetDouble());
            Assert.AreEqual(JedinicaDuljine.Kilometar, (JedinicaDuljine)cw.GetObject());
        }

        [TestMethod]
        public void KonstruktorStrukture_TestPozivaKonstruktoraSJednimArgumentom()
        {
            KonstruktorStrukture.PozivKonstruktoraSJednimArgumentom(3);
            Assert.AreEqual(3.0, cw.GetDouble());
            Assert.AreEqual(JedinicaDuljine.Metar, (JedinicaDuljine)cw.GetObject());
        }
    }
}

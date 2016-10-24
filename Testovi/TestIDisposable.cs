using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;
using System.IO;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestIDisposable
    {
        [TestMethod]
        public void IDisposable_DatotekaJeUspješnoObrisana()
        {
            string ime = "privremena.txt";
            Disposable.StvaranjeIPisanjeUDatoteku(ime);
            Assert.IsTrue(File.Exists(ime));
            Disposable.BrisanjeDatoteke(ime);
            Assert.IsFalse(File.Exists(ime));
        }
    }
}

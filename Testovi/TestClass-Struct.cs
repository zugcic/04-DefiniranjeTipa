using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestClass_Struct : ConsoleTest
    {
        [TestMethod]
        public void ClassStruct_IspišiKlase()
        {
            ClassStruct.IspišiKlase();
            Assert.AreEqual(5, cw.GetInt());
            Assert.AreEqual(5, cw.GetInt());

            Assert.AreEqual(2, cw.GetInt());
            Assert.AreEqual(2, cw.GetInt());
        }

        [TestMethod]
        public void ClassStruct_IspišiStrukture()
        {
            ClassStruct.IspišiStrukture();
            Assert.AreEqual("MojaStruktura", cw.GetString());
            Assert.AreEqual("MojaStruktura", cw.GetString());

            Assert.AreEqual("MojaStruktura", cw.GetString());
            Assert.AreEqual("MyStruct", cw.GetString());
        }
    }
}

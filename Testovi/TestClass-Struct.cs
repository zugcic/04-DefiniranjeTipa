using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp.ClassStruct;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestClass_Struct : ConsoleTest
    {
        [TestMethod]
        public void Test_ClassStruct()
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            mk1.IspišiČlan();
            mk2.IspišiČlan();
            Assert.AreEqual(5, cw.GetInt());
            Assert.AreEqual(5, cw.GetInt());

            mk2.broj = 2;
            mk1.IspišiČlan();
            mk2.IspišiČlan();
            Assert.AreEqual(2, cw.GetInt());
            Assert.AreEqual(2, cw.GetInt());


            MojaStruktura ms1 = new MojaStruktura();
            MojaStruktura ms2 = ms1;
            ms1.IspišiČlan();
            ms2.IspišiČlan();
            Assert.AreEqual("MojaStruktura", cw.GetString());
            Assert.AreEqual("MojaStruktura", cw.GetString());

            ms2.tekst = "MyStruct";
            ms1.IspišiČlan();
            ms2.IspišiČlan();
            Assert.AreEqual("MojaStruktura", cw.GetString());
            Assert.AreEqual("MyStruct", cw.GetString());
        }
    }
}

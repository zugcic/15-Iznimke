using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestBacanjaIznimke
    {
        [TestMethod]
        public void BacanjeIznimke_FaktorijelVraćaPravuVrijednostZaPozitivneArgumente()
        {
            Assert.AreEqual(1, Math.Faktorjel(1));
            Assert.AreEqual(2, Math.Faktorjel(2));
            Assert.AreEqual(6, Math.Faktorjel(3));
            Assert.AreEqual(24, Math.Faktorjel(4));
        }

        [TestMethod]
        public void BacanjeIznimke_FaktorijelVraća1ZaArgument0()
        {
            Assert.AreEqual(1, Math.Faktorjel(0));
        }

        [TestMethod]
        public void BacanjeIznimke_FaktorijelBacaIznimkuTipaArgumentOutOfRangeExceptionZaNegativneArgumente()
        {
            try
            {
                Math.Faktorjel(-1);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(ArgumentOutOfRangeException));
            }
        }
    }
}

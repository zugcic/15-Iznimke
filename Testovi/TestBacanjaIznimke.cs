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
            Assert.AreEqual(1, BacanjeIznimke.Faktorjel(1));
            Assert.AreEqual(2, BacanjeIznimke.Faktorjel(2));
            Assert.AreEqual(6, BacanjeIznimke.Faktorjel(3));
            Assert.AreEqual(24, BacanjeIznimke.Faktorjel(4));
        }

        [TestMethod]
        public void BacanjeIznimke_FaktorijelVraća1ZaArgument0()
        {
            Assert.AreEqual(1, BacanjeIznimke.Faktorjel(0));
        }

        [TestMethod]
        public void BacanjeIznimke_FaktorijelBacaIznimkuTipaArgumentOutOfRangeExceptionZaNegativneArgumente()
        {
            try
            {
                BacanjeIznimke.Faktorjel(-1);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(ArgumentOutOfRangeException));
            }
        }
    }
}

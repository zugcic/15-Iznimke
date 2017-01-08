using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestOdvajanjaGlavneLogike : ConsoleTest
    {
        [TestMethod]
        public void OdvajanjeGlavneLogike_PetljaSePrekidaZabrojeveVećeOd12()
        {
            try
            {
                OdvajanjeGlavneLogike.IspisPovrh(12, 20);

                for (int i = 1; i <= 12; ++i)
                    Assert.IsTrue(cw.GetString().StartsWith(string.Format("12 povrh {0} = ", i)));

            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}

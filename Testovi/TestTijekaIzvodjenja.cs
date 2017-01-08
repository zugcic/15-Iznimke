using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestTijekaIzvodjenja : ConsoleTest
    {
        [TestMethod]
        public void TijekIzvodjenja_AkoNijeBačenaIznimkaIzvodiSeCijeliBlokTryIBlokFinally()
        {
            int djeljitelj = 1;
            TijekIzvodjenja.IspisTryCatchFinally(3, djeljitelj);
            Assert.AreEqual(6, cw.Count);
            Assert.AreEqual(TijekIzvodjenja.ZapočinjeBlokTry, cw.GetString());
            Assert.AreEqual(string.Format("Dijelim s {0}", djeljitelj), cw.GetString());
            Assert.AreEqual(3, cw.GetInt());
            Assert.AreEqual(string.Format("Podijelio sam s {0}", djeljitelj), cw.GetString());
            Assert.AreEqual(TijekIzvodjenja.ZavršavaBlokTry, cw.GetString());
            Assert.AreEqual(TijekIzvodjenja.BlokFinally, cw.GetString());
        }

        [TestMethod]
        public void TijekIzvodjenja_AkoJeBačenaIznimkaPrekidaSeTryBlokTeSeIzvodeBlokoviCatchIFinally()
        {
            int djeljitelj = 0;
            TijekIzvodjenja.IspisTryCatchFinally(3, djeljitelj);
            Assert.AreEqual(4, cw.Count);
            Assert.AreEqual(TijekIzvodjenja.ZapočinjeBlokTry, cw.GetString());
            Assert.AreEqual(string.Format("Dijelim s {0}", djeljitelj), cw.GetString());
            Assert.AreEqual(TijekIzvodjenja.BlokCatch, cw.GetString());
            Assert.AreEqual(TijekIzvodjenja.BlokFinally, cw.GetString());
        }
    }
}

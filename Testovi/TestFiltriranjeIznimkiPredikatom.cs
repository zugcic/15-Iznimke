using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestFiltriranjeIznimkiPredikatom : ConsoleTest
    {
        [TestMethod]
        public void FiltriranjeIznimkiPredikatom_IspišiLogaritamZaIspravneArgumenteIspisujeRezultat()
        {
            FiltriranjeIznimkiPredikatom.IspišiLogaritamBroja(1000, 10);
            Assert.AreEqual(string.Format(FiltriranjeIznimkiPredikatom.FormatIspisa, 1000, 10, 3), cw.GetString());
        }

        [TestMethod]
        public void FiltriranjeIznimkiPredikatom_IspišiLogaritamZaNegativniBrojIspisujePogrešku()
        {
            FiltriranjeIznimkiPredikatom.IspišiLogaritamBroja(-1000, 10);
            Assert.AreEqual(FiltriranjeIznimkiPredikatom.NedozvoljeniBroj, cw.GetString());
        }

        [TestMethod]
        public void FiltriranjeIznimkiPredikatom_IspišiLogaritamZaNegativnuBazuIspisujePogrešku()
        {
            FiltriranjeIznimkiPredikatom.IspišiLogaritamBroja(1000, -10);
            Assert.AreEqual(FiltriranjeIznimkiPredikatom.NedozvoljenaBaza, cw.GetString());
        }
    }
}

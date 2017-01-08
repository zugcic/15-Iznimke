using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestFiltaIznimki : ConsoleTest
    {
        [TestMethod]
        public void FiltarIznimki_FileNotFoundExceptionĆeBitiUhvaćenKaoException()
        {
            Exception e = new System.IO.FileNotFoundException();
            FiltarIznimki.FiltriranjeIznimkePremaTipu(e);
            Assert.AreEqual(string.Format(FiltarIznimki.FormatFiltraException, e.GetType().Name), cw.GetString());
        }

        [TestMethod]
        public void FiltarIznimki_ArgumentOutOfRangeExceptionĆeBitiUhvaćenKaoArgumentOutOfRangeException()
        {
            Exception e = new ArgumentOutOfRangeException();
            FiltarIznimki.FiltriranjeIznimkePremaTipu(e);
            Assert.AreEqual(string.Format(FiltarIznimki.FormatFiltraArgumentOutOfRangeException, e.GetType().Name), cw.GetString());
        }

        [TestMethod]
        public void FiltarIznimki_ArgumentExceptionĆeBitiUhvaćenKaoArgumentException()
        {
            Exception e = new ArgumentException();
            FiltarIznimki.FiltriranjeIznimkePremaTipu(e);
            Assert.AreEqual(string.Format(FiltarIznimki.FormatFiltraArgumentException, e.GetType().Name), cw.GetString());
        }

        [TestMethod]
        public void FiltarIznimki_ArgumentNullExceptionĆeBitiUhvaćenKaoArgumentException()
        {
            Exception e = new ArgumentNullException();
            FiltarIznimki.FiltriranjeIznimkePremaTipu(e);
            Assert.AreEqual(string.Format(FiltarIznimki.FormatFiltraArgumentException, e.GetType().Name), cw.GetString());
        }
    }
}

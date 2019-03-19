using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asztali_alkalmazás_Záródolgozat.Validáció;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Validáció.Tests
{
    [TestClass()]
    public class NévValidációTests
    {
        [TestMethod()]
        public void nemNagyBetűNévTeszt()
        {
            try
            {
                NévValidáció Nv = new NévValidáció("jános");
                Nv.validácíó();
            }
            catch(Exception e)
            {
                Assert.Fail("Kisbetűre névben rossz kivételt dobott");
            }
            Assert.Fail("Kisbetűre névben nem dobott kivételt");
        }

        [TestMethod()]
        public void üresNévTeszt()
        {
            try
            {
                NévValidáció Nv = new NévValidáció("");
                Nv.validácíó();
            }
            catch (Exception e)
            {
                Assert.Fail("Üres névre rossz kivételt dobott");
            }
            Assert.Fail("Üres névre nem dobott kivételt");
        }
    }
}
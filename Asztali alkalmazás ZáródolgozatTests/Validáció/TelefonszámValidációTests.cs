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
    public class TelefonszámValidációTests
    {
        [TestMethod()]
        public void értékNullaTelefonszámTeszt()
        {
            try
            {
                TelefonszámValidáció Tv = new TelefonszámValidáció(0);
                Tv.validácíó();

            }
            catch(Exception e)
            {
                Assert.Fail("0 Telefonszám eredményre rossz kivételt dobott");
            }
            Assert.Fail("0 Telefonszám eredményre nem dobott kivételt");
        }

       
    }
}
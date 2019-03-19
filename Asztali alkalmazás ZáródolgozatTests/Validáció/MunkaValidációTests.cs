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
    public class MunkaValidációTests
    {
        [TestMethod()]
        public void üresMunkaTeszt()
        {
            try
            {
                MunkaValidáció Mv = new MunkaValidáció("");
                Mv.validácíó();
            }
            catch(Exception e)
            {
                Assert.Fail("Üres munka szöveg nem megfelelő kivételt dobott");
            }
            Assert.Fail("Üres munka szöveg nem dobott kivételt");
        }

       
    }
}
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
    public class VárosValidációTests
    {
        [TestMethod()]
        public void üresVárosTeszt()
        {
           try
            {
                VárosValidáció Vv = new VárosValidáció("");
                Vv.validácíó();
            }
            catch(Exception e)
            {
                Assert.Fail("Üres város szövegre rossz kivételt dobott");
            }
            Assert.Fail(" Üres város szövegre nem dobott kivételt");
        }

     
    }
}
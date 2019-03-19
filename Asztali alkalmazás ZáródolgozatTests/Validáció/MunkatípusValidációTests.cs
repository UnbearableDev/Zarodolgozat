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
    public class MunkatípusValidációTests
    {
        [TestMethod()]
        public void üresMunkatípusTeszt()
        {
            try
            {
                MunkatípusValidáció Mt = new MunkatípusValidáció("");
                Mt.validácíó();
                }
            catch(Exception e)
            {
                Assert.Fail("Üres Munkatípus szövegre rossz kivételt dobott");

            }
            Assert.Fail("Üres Munkatípus szövegre nem dobott kivételt");
        }

       
    }
}
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
    public class EmailValidációTests
    {
        [TestMethod()]
        public void nincsKukacAzEmailbanTeszt()
        {
            try
            {
                EmailValidáció Ev = new EmailValidáció("asdasd");
                Ev.validáció();
            }
            catch(Exception e)
            {
                Assert.Fail("Kukac nélküli szövegre rossz kivételt dobott");
            }
            Assert.Fail("Kukac nélküli szövegre nem dob kivételt");
        }

        [TestMethod()]
        public void üresEmailKivétel()
        {
            try
            {
                EmailValidáció Ev = new EmailValidáció("");
                Ev.validáció();
            }
            catch(Exception e)
            {
                Assert.Fail("Üres Emailre rossz kivételt dob");
            }
            Assert.Fail("Üres Emailre nem dob kivételt");
        }
    }
}
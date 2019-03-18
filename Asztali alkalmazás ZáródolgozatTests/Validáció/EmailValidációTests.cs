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
            Assert.Fail();
        }

        [TestMethod()]
        public void üresEmailKivétel()
        {
            Assert.Fail();
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asztali_alkalmazás_Záródolgozat.Validáció;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asztali_alkalmazás_Záródolgozat.Validáció;


namespace Asztali_alkalmazás_Záródolgozat.Validáció.Tests
{
    [TestClass()]
    public class AzonosítóValidációTests
    {
       
        [TestMethod()]
        public void értékNullaAzonosítóTeszt()
        {
            try
            {

               
                AzonosítóValidáció Av = new AzonosítóValidáció(0);
                Av.validácíó();
                    
                
            }
            catch(Exception e)
            {
                Assert.Fail("Nulla értékre rossz kivételt dob");
            }
            Assert.Fail("Nulla értékre nem dob kivételt");
        }

        [TestMethod()]
        public void nemSzámAzonosítóTeszt()
        {
            try
            {
                AzonosítóValidáció Av = new AzonosítóValidáció("a");
                Av.validácíó();
            }
            catch(Exception e)
            {

            }
        }
    }
}
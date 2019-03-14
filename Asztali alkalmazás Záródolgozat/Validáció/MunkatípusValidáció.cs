using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Validáció
{
    class MunkatípusValidáció
    {
        private string munkatípus;

        public MunkatípusValidáció(string munkatípus)
        {
            this.munkatípus = munkatípus;
        }
        public void validácíó()
        {
            if(uresMunkatípus())
            {

            }
            if(nemSzövegMunkatípus())
            {

            }
        }

        private bool nemSzövegMunkatípus()
        {
            throw new NotImplementedException();
        }

        private bool uresMunkatípus()
        {
            throw new NotImplementedException();
        }
    }
}

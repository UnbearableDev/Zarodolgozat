using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asztali_alkalmazás_Záródolgozat.Kivétel.MunkatípusKivétel;

namespace Asztali_alkalmazás_Záródolgozat.Validáció
{
   public class MunkatípusValidáció
    {
        private string munkatípus;

        public MunkatípusValidáció(string munkatípus)
        {
            this.munkatípus = munkatípus;
        }
        public void validácíó()
        {
            if(üresMunkatípus())
            {
                throw new üresMunkatípusKivétel("A Munkatípus nem lehet üres");
            }
    
        }

 
        private bool üresMunkatípus()
        {
            if (string.IsNullOrEmpty(munkatípus) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asztali_alkalmazás_Záródolgozat.Kivétel.MunkaKivétel;

namespace Asztali_alkalmazás_Záródolgozat.Validáció
{
   public class MunkaValidáció
    {
        private string munka;
        public MunkaValidáció(string munka)
        {
            this.munka = munka;

        }
        public void validácíó()
        {
            if(üresMunka())
            {
                throw new üresMunkaKivétel("a Munka nem lehet üres");
            }
        
        }

    
        private bool üresMunka()
        {
            if (string.IsNullOrEmpty(munka) == true)
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

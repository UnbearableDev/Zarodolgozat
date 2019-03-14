using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Validáció
{
    class MunkaValidáció
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

            }
            if(nemSzövegMunka())
            {

            }
        }

        private bool nemSzövegMunka()
        {
            throw new NotImplementedException();
        }

        private bool üresMunka()
        {
            throw new NotImplementedException();
        }
    }
}

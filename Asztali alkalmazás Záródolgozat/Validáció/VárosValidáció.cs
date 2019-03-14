using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Validáció
{
    class VárosValidáció
    {
        private string város;
        public VárosValidáció(string város)
        {
            this.város = város;

        }
        public void validácíó()
        {
            if (üresVáros())
            {

            }
            if (nemSzövegVáros())
            {

            }
        }

        private bool nemSzövegVáros()
        {
            throw new NotImplementedException();
        }

        private bool üresVáros()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Validáció
{
    class AzonosítóValidáció
    {
        private int azonosító;
        public AzonosítóValidáció(int azonosító)
        {
            this.azonosító = azonosító;
        }
        public void validácíó()
        {
            if(üresAzonosító())
            {

            }
            if(nemSzámAzonosító())
            {

            }
        }

        private bool üresAzonosító()
        {
            throw new NotImplementedException();
        }

        private bool nemSzámAzonosító()
        {
            throw new NotImplementedException();
        }
    }
}

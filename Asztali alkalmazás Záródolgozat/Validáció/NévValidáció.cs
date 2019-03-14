using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Validáció
{
    class NévValidáció
    {
        private string név;
        public NévValidáció(string név)
        {
            this.név = név;

        }
        public void validácíó()
        {
            if (üresNév())
            {

            }
            if (nemSzövegNév())
            {

            }
            if(nemNagyBetűNév())
            {

            }
        }

        private bool nemNagyBetűNév()
        {
            throw new NotImplementedException();
        }

        private bool nemSzövegNév()
        {
            throw new NotImplementedException();
        }

        private bool üresNév()
        {
            throw new NotImplementedException();
        }
    }
}

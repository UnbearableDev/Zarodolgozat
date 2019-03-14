using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Validáció
{
    class TelefonszámValidáció
    {
        private int telefonszám;
        public TelefonszámValidáció(int telefonszám)
        {
            this.telefonszám = telefonszám;
        }
        public void validácíó()
        {
            if (üresTelefonszám())
            {

            }
            if (nemSzámTelefonszám())
            {

            }
        }

        private bool üresTelefonszám()
        {
            throw new NotImplementedException();
        }

        private bool nemSzámTelefonszám()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Validáció
{
   public class TelefonszámValidáció
    {
        private int telefonszám;
        public TelefonszámValidáció(int telefonszám)
        {
            this.telefonszám = telefonszám;
        }
        public void validácíó()
        {
            if (értékNullaTelefonszám())
            {

            }
           
        }

        private bool értékNullaTelefonszám()
        {
            if (telefonszám == 0)
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

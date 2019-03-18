using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asztali_alkalmazás_Záródolgozat.Kivétel.TelefonszámKivétel;

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
                throw new Exception("Telefonszám nem lehet nulla");
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

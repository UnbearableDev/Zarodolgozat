using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Validáció
{
   public class NévValidáció
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
            if(nemNagyBetűNév())
            {

            }
        }

        private bool nemNagyBetűNév()
        {
           if(Char.IsUpper(név[0]) == true)
            {
                return false;
            }
           else
            {
                return true;
            }
        }

       

        private bool üresNév()
        {
            if (string.IsNullOrEmpty(név) == true)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Validáció
{
   public class VárosValidáció
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
        
        }

      

        private bool üresVáros()
        {
            if (string.IsNullOrEmpty(város) == true)
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

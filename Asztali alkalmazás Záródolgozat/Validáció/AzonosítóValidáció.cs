using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Validáció
{
    public class AzonosítóValidáció
    {
        private int azonosító;
        public AzonosítóValidáció(int azonosító)
        {
            this.azonosító = azonosító;
        }
        public void validácíó()
        {
            if(értékNullaAzonosító())
            {

            }
            if(nemSzámAzonosító())
            {

            }
        }

        private bool értékNullaAzonosító()
        {
            if(azonosító == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool nemSzámAzonosító()
        {
            if(azonosító.GetType() == typeof(int))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

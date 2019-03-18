using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asztali_alkalmazás_Záródolgozat.Kivétel.AzonosítóKivétel;


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
                throw new értékNullaAzonosítóKivétel("Az azonosító értéke nem lehet nulla");
            }
            if(nemSzámAzonosító())
            {
                throw new nemSzámAzonosítóKivétel("Az azonosító értéke csak szám lehet");
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

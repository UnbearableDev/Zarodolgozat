using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asztali_alkalmazás_Záródolgozat.Tár;

namespace Asztali_alkalmazás_Záródolgozat.Vezérlő
{
    class MegrendelőVezérlő
    {
        private MegrendelőkKezelMegrendelőtF megrendelőketKezelőMetódusok;
        
       public void hozzáadniMegrendelőtMegrendelőkhöz( string email, string munka, string munkatípus, string név, int telefonszám, string város)
        {

            try
            {
                int MegrendelőAzonosító = megrendelőketKezelőMetódusok.visszaadKövetkezőMegrendelőAzonosítót();
                Megrendelő újMegrendelő = new Megrendelő(MegrendelőAzonosító, név, város, email, munka, munkatípus, telefonszám);
                megrendelőketKezelőMetódusok.hozzáadMegrendelőt(újMegrendelő);
            }
            catch()
        }
        public void törölniMegrendelőtMegrendelőkböl(int azonosító)
        {
            try
            {
                megrendelőketKezelőMetódusok.törölMegrendelőt(azonosító);
            }
        }
        public void módosítaniMegrendelőtMegrendelőkhöz()
        {
            try
            {

            }
        }
        public void betölteniMegrendelőket()
        {

        }
     
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Tár
{
   interface IMegrendelőkKezelMegrendelőtF
    {
        void hozzáadMegrendelőt(Megrendelő megrendelő);
        void törölMegrendelőt(int azonosító);
        void módosítMegrendelőt(int azonosító, Megrendelő Újmegrendelő);
        int számolMegrendelőt();
        Megrendelő keresMegrendelőtNévről(string név);
        bool létezikeMegrendelőNévről(string név);
        int visszaadKövetkezőMegrendelőAzonosítót();
    }
}

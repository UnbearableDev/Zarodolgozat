using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Kivétel.AzonosítóKivétel
{
    class értékNullaAzonosítóKivétel : Exception
    {
        public értékNullaAzonosítóKivétel(string üzenet)
        :base(üzenet)
        {}
    }
}

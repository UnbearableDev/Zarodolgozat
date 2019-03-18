using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Kivétel.EmailKivétel
{
    class nincsKukacAzEmailbanKivétel : Exception
    {
        public nincsKukacAzEmailbanKivétel(string üzenet)
        :base(üzenet)
        { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Kivétel.VezérlőKivétel
{
    class VezérlőKivételek : Exception
    {
        public VezérlőKivételek(string üzenet)
        :base(üzenet)
        { }
    }
}

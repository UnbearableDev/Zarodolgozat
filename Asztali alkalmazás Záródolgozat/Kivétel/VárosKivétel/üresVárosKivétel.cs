using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Kivétel.VárosKivétel
{
    class üresVárosKivétel : Exception
    {
        public üresVárosKivétel(string üzenet)
        :base(üzenet)
        { }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Kivétel.NévKivétel
{
    class nemNagyBetűNévKivétel : Exception
    {
        public nemNagyBetűNévKivétel(string üzenet)
        :base(üzenet)
        {}
    }
}

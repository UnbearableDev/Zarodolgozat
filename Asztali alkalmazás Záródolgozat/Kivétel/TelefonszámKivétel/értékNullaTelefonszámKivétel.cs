﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Kivétel.TelefonszámKivétel
{
    class értékNullaTelefonszámKivétel : Exception
    {
        public értékNullaTelefonszámKivétel(string üzenet)
        :base(üzenet)
        { }
    }
}

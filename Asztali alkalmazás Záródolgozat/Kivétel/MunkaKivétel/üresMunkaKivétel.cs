﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Kivétel.MunkaKivétel
{
    class üresMunkaKivétel : Exception
    {
        public üresMunkaKivétel(string üzenet)
        :base(üzenet)
        { }
    }
}

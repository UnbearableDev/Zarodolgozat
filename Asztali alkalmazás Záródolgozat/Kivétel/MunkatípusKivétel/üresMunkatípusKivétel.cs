﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Kivétel.MunkatípusKivétel
{
    class üresMunkatípusKivétel : Exception
    {
        public üresMunkatípusKivétel(string üzenet)
        :base(üzenet)
        {}
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazás_Záródolgozat.Tár
{
 interface IMegrendelőkF
    {
        List<Megrendelő> getMegrendelők();
        int getMaximumAzonosító();
    }
}

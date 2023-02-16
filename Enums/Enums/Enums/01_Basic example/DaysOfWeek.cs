﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums._01_Basic_example
{
    enum DaysOfWeek
    {
        None        = 0b_0000_0000,  // 0
        Monday      = 0b_0000_0001,  // 1
        Tuesday     = 0b_0000_0010,  // 2
        Wednesday   = 0b_0000_0100,  // 4
        Thursday    = 0b_0000_1000,  // 8
        Friday      = 0b_0001_0000,  // 16
        Saturday    = 0b_0010_0000,  // 32
        Sunday      = 0b_0100_0000,  // 64
        Weekend     = Saturday | Sunday
    }
}

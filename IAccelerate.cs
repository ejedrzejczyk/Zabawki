﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    interface IAccelerate
    {
        int SpeedIncrease();
        int SpeedDecrease();
        int GetCurrentSpeed();
    }
}

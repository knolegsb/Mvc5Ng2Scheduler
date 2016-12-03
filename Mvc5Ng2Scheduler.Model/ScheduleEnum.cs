﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc5Ng2Scheduler.Model
{
    public enum ScheduleType
    {
        Work = 1,
        Coffee = 2,
        Doctor = 3,
        Shopping = 4,
        Other = 5
    }
    public enum ScheduleStatus
    {
        Valid = 1,
        Cencelled = 2
    }
}
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeekEndTask5
{
    interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string ShowInfo();
    }
}

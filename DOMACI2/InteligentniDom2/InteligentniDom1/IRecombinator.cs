﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteligentniDom1
{
    interface IRecombinator
    {
        List<RouteAndQuality> Recombine(List<RouteAndQuality> selected);
    }
}

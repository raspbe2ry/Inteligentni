using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteligentniDom1
{
    class RouteAndQuality
    {
        public int[] Route { get; set; }
        public int Quality { get; set; }

        public RouteAndQuality()
        {

        }

        public RouteAndQuality(int[] route)
        {
            Route = new int[25];
            for (int i = 0; i < 25; i++)
                Route[i] = route[i];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteligentniDom1
{
    class R_SingleCrossing : IRecombinator
    {
        public List<RouteAndQuality> Recombine(List<RouteAndQuality> selected)
        {
            int maskCount = new Random().Next()%24+1;
            RouteAndQuality r1 = new RouteAndQuality(selected[0].Route);
            RouteAndQuality r2 = new RouteAndQuality(selected[1].Route);

            RouteAndQuality helper = new RouteAndQuality(selected[0].Route);

            for (int i=maskCount; i<=25; i++)
            {
                for(int j=0; j<25; j++)
                {
                    if (!r1.Route.Take(i).Contains(selected[1].Route[j]))
                    {
                        r1.Route[i] = selected[1].Route[j];
                        break;
                    }
                }
                for (int j = 0; j < 25; j++)
                {
                    if (!r2.Route.Take(i).Contains(helper.Route[j]))
                    {
                        r2.Route[i] = helper.Route[j];
                        break;
                    }
                }
            }
            selected.Add(r1);
            selected.Add(r2);

            return selected;
        }
    }
}

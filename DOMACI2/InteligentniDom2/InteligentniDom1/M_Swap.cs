using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteligentniDom1
{
    class M_Swap : IMutator
    {
        public Generation Mutate(List<RouteAndQuality> recombined)
        {
            Random r = new Random();

            int p1 = r.Next() % 25;
            int p2 = r.Next() % 25;

            int s = recombined[6].Route[p1];
            recombined[6].Route[p1] = recombined[6].Route[p2];
            recombined[6].Route[p2] = s;

            s = recombined[7].Route[p1];
            recombined[7].Route[p1] = recombined[7].Route[p2];
            recombined[7].Route[p2] = s;

            return new Generation(recombined);
        }
    }
}

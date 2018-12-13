using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteligentniDom1
{
    class S_StabileStateMethod : ISelector
    {
        public List<RouteAndQuality> Select(Generation generation)  //select
        {
            return generation.Routes8.OrderBy(x => x.Quality).Take(6).ToList();
        }
    }
}

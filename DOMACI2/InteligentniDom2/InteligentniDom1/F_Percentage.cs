using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteligentniDom1
{
    class F_Percentage : IFinalizer
    {
        public int StartGenerationQuality { get; set; }
        public int CuurentGenerationQuality { get; set; }

        public bool GoalAchieved(Generation generation)
        {
            CuurentGenerationQuality = CountQuality(generation);
            if (CuurentGenerationQuality < StartGenerationQuality / 10)
                return true;
            else
                return false;
        }

        public void SetStartGeneration(Generation g)
        {
            StartGenerationQuality = CountQuality(g);
        }

        private int CountQuality(Generation generation)
        {
            return generation.Routes8.Sum(x => x.Quality);
        }
    }
}

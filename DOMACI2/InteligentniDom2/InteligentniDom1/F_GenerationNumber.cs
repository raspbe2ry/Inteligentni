using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteligentniDom1
{
    class F_GenerationNumber : IFinalizer
    {
        private static long CycleNumber=0;
        private static long GoalCycle;

        public F_GenerationNumber(long goalCycle)
        {
            GoalCycle = goalCycle;
        }

        public bool GoalAchieved(Generation generation)
        {
            if (CycleNumber == GoalCycle)
            {
                ResetCounter();
                return true;
            }
            else
            {
                CycleNumber++;
                return false;
            }
        }

        public void ResetCounter()
        {
            CycleNumber = 0;
        }

        public void SetStartGeneration(Generation g)
        {
        }
    }
}

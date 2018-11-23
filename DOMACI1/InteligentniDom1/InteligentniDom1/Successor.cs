using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteligentniDom1
{
    class Successor : ISuccesor
    {
        public State FindNext(State current)
        {
            int[] randoms=new int[current.truckNumber];
            Random randomizer = new Random();
            int numberOfTowns = current.townsPerTruck;

            State newState = new State(current);

            for(int i=0; i<current.truckNumber; i++)
            {
                randoms[i] = randomizer.Next() % numberOfTowns;
            }

            int p = current.truckTowns[0][randoms[0]];
            for (int i = 0; i < current.truckNumber; i++)
            {
                if (i != current.truckNumber - 1)
                    newState.truckTowns[i][randoms[i]] = current.truckTowns[i + 1][randoms[i + 1]];
                else
                    newState.truckTowns[i][randoms[i]] = p;
            }

            return newState;
        }
    }
}

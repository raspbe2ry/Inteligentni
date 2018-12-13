using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteligentniDom1
{
    class Generation
    {
        public List<RouteAndQuality> Routes8 { get; set; }
        Random randomizer = new Random();

        public Generation()
        {
            Routes8 = new List<RouteAndQuality>();

            for(int i=0; i<8; i++)
            {
                int p = randomizer.Next() % 25;
                Routes8.Add(new RouteAndQuality(new int[25]));
                for(int j=0; j<25; j++)
                {
                    Routes8[i].Route[j] = (p+j)%25;
                }
                Routes8[i].Route = Shufle(Routes8[i].Route);
            }
        }

        public Generation(List<RouteAndQuality> routes8)
        {
            this.Routes8 = new List<RouteAndQuality>();

            for (int i = 0; i < 8; i++)
            {
                Routes8.Add(new RouteAndQuality(new int[25]));
                for (int j = 0; j < 25; j++)
                {
                    Routes8[i].Route[j] = routes8[i].Route[j];
                }
            }
        }

        public void FindFitness(int[][] matrix)
        {
            for (int i = 0; i < 8; i++)
                Routes8[i].Quality = EvaluateRoute(Routes8[i].Route, matrix);
        }

        private int EvaluateRoute(int[] routes, int[][] matrix)  //int[25]
        {
            int retValue = 0;
            int[] distances = new int[5];

            for (int i = 0; i < 5; i++)
            {
                distances[i] = 0;
                for (int j = i*5; j < (i+1)*5 - 1; j++)
                {
                    distances[i] += matrix[routes[j]][routes[j+1]];
                }
            }

            for (int i = 0; i < distances.Length; i++)
                for (int j = i + 1; j < distances.Length; j++)
                    retValue += Math.Abs(distances[i] - distances[j]);

            return retValue;
        }

        public Generation CreateNextGeneration(ISelector selector, IRecombinator recombinator, IMutator mutator)
        {
            return mutator.Mutate(recombinator.Recombine(selector.Select(this)));
        }

        private int[] Shufle(int[] route)
        {
            int a, b;
            int p;
            Random r = new Random();

            for(int i=0; i<12; i++)
            {
                a = r.Next() % 25;
                b = r.Next() % 25;
                p = route[a];
                route[a] = route[b];
                route[b] = p;
            }

            return route;
        }
    }
}

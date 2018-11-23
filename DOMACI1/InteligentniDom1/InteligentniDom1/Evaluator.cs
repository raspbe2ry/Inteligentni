using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteligentniDom1
{
    class Evaluator: IEvaluate
    {
        public int[][] matrix { get; set; }
        int dimA;
        public double average { get; set; }

        public Evaluator(int[][] stateMatrix)
        {
            average = 0;
            dimA = stateMatrix.Length;
            matrix = new int[dimA][];
            for (int i = 0; i < dimA; i++)
                matrix[i] = new int[dimA];
            for (int i = 0; i < dimA; i++)
                for (int j = 0; j < dimA; j++)
                {
                    this.matrix[i][j] = stateMatrix[i][j];
                    average += matrix[i][j];
                }
            average /= (dimA * (dimA-1));
        }

        public double Evaluate(State state)
        {
            double retValue = 0;
            double[] distances = new double[state.truckNumber];

            for (int i = 0; i < state.truckNumber; i++)
            {
                distances[i] = 0;
                for (int j = 0; j < state.townsPerTruck-1; j++)
                {
                    distances[i] += matrix[state.truckTowns[i][j]][state.truckTowns[i][j+1]];
                }
            }

            for (int i = 0; i < distances.Length; i++)
                for (int j = i + 1; j < distances.Length; j++)
                    retValue += Math.Abs(distances[i] - distances[j]);

            return retValue;
        }
    }
}

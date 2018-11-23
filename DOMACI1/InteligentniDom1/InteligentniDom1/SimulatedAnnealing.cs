using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteligentniDom1
{
    class SimulatedAnnealing
    {
        public static IEvaluate Evaluator { get; set; }
        public static ISuccesor SuccesorFinder { get; set; }
        public static Random random = new Random();
        public double TempMax { get; set; }
        public double TempMin { get; set; }
        public double TempStep { get; set; }
        public double TempFactor { get; set; }
        public int MaxIteration { get; set; }
        public int Model { get; set; }
        private ListBox lbx;

        public SimulatedAnnealing(IEvaluate evaluator, ISuccesor succesor, ListBox lbx)
        {
            Evaluator = evaluator;
            SuccesorFinder = succesor;
            this.lbx = lbx;
        }

        public State PerformAnnealing(State initialState, int[][] matrix)
        {
            State retState;
            initialState.Print(matrix, lbx);

            if (Model == 0)
            {
                retState= FactoredAnnealing(initialState);
            }
            else
            {
                retState= FixedAnnealing(initialState);
            }

            retState.Print(matrix, lbx);
            return retState;
        }

        private State FactoredAnnealing(State initialState)
        {
            for (double temp = TempMax; temp >= TempMin; temp = temp* TempFactor)
            {
                for (int i = 0; i < MaxIteration; i++)
                {
                    State nextState = SuccesorFinder.FindNext(initialState);
                    double costOfNew = Evaluator.Evaluate(nextState);
                    double costOfOld = Evaluator.Evaluate(initialState);
                    double delta = costOfNew - costOfOld;
                    if (delta < 0)
                    {
                        initialState = nextState;
                    }
                    else
                    {
                        if (random.NextDouble() < Math.Exp(-delta / temp))
                            initialState = nextState;
                    }
                }
            }

            return initialState;
        }

        private State FixedAnnealing(State initialState)
        {
            for (double temp = TempMax; temp >= TempMin; temp = temp - TempStep)
            {
                for (int i = 0; i < MaxIteration; i++)
                {
                    State nextState = SuccesorFinder.FindNext(initialState);
                    double costOfNew = Evaluator.Evaluate(nextState);
                    double costOfOld = Evaluator.Evaluate(initialState);
                    double delta = costOfNew - costOfOld;
                    if (delta < 0)
                    {
                        initialState = nextState;
                    }
                    else
                    {
                        if (random.NextDouble() < Math.Exp(-delta / temp))
                            initialState = nextState;
                    }
                }
            }

            return initialState;
        }

    }
}

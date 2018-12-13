using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteligentniDom1
{
    class GeneticAlgorithm
    {
        public Generation InitialGeneration { get; set; }
        public Generation Solution { get; set; }
        public double[] LastTreeFitnesses;
        int[][] Matrix { get; set; }

        public IFinalizer finalizer;
        public ISelector selector;
        public IRecombinator recombinator;
        public IMutator mutator;
        public ListBox listBox;

        public GeneticAlgorithm(int[][] matrix, IFinalizer finalizer, ISelector selector, IRecombinator recombinator, IMutator mutator, ListBox lbx)
        {
            Matrix = matrix;
            this.finalizer = finalizer;
            this.selector = selector;
            this.recombinator = recombinator;
            this.mutator = mutator;
            this.listBox=lbx;
        }

        private void CreateFirstGeneration()
        {
            InitialGeneration = new Generation();
        }

        private bool CheckLastThreeGeneration(int startFitness)
        {
            double startFitness10 = startFitness / 10.0;
            if (LastTreeFitnesses[0] < startFitness10 && LastTreeFitnesses[1] < startFitness10 && LastTreeFitnesses[2] < startFitness10)
                return true;
            else
                return false;
        }

        public Generation FindSolution()
        {
            int queueHead = 0;
            int numOfGeneration = 0;
            //int startFitness = InitialGeneration.FindFitness();

            CreateFirstGeneration();
            //LastTreeFitnesses[queueHead++] = startFitness;
            Solution = InitialGeneration;

            listBox.Items.Add("INITIAL GENERATION");
            for (int i=0; i<8; i++)
            {
                listBox.Items.Add("H" + i.ToString() + ": ");
                Print(Solution.Routes8[i].Route, Matrix, listBox);
            }

            Solution.FindFitness(Matrix);
            finalizer.SetStartGeneration(Solution);

            while (!finalizer.GoalAchieved(Solution))
            {
                Solution = Solution.CreateNextGeneration(selector, recombinator, mutator);
                Solution.FindFitness(Matrix);
                numOfGeneration++;
            }
            Solution.FindFitness(Matrix);

            listBox.ForeColor = System.Drawing.Color.Green;
            listBox.Items.Add("");
            listBox.Items.Add("");
            listBox.Items.Add("");
            listBox.Items.Add("FINAL GENERATION");
            for (int i = 0; i < 8; i++)
            {
                listBox.Items.Add("H"+i.ToString()+": ");
                Print(Solution.Routes8[i].Route, Matrix, listBox);
            }

            return Solution;
        }

        public string Print(int[] routes, int[][] matrix, ListBox lbx)
        {
            string forPrint = "";

            double[] distances = new double[5];

            for (int i = 0; i < 5; i++)
            {
                distances[i] = 0;
                for (int j = 0; j < 4; j++)
                {
                    distances[i] += matrix[routes[i * 5 + j]][routes[i * 5 + j + 1]];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                var truckPrint = "";
                for (int j = 0; j < 5; j++)
                {
                    forPrint += routes[i * 5 + j].ToString() + " ";
                    truckPrint += routes[i * 5 + j].ToString() + " ";
                    forPrint += ": Distance " + distances[i].ToString() + " \n";
                }
                lbx.Items.Add(truckPrint + ": Distance " + distances[i].ToString());
            }
            lbx.Items.Add("-----------------------");

            return forPrint;
        }
    }
}

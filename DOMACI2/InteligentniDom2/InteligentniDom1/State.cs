using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteligentniDom1
{
    class State
    {
        public int truckNumber { get; set; }
        public int towns { get; set; }
        public int[][] truckTowns { get; set; }
        //public int[][] distances { get; set; }
        public int townsPerTruck { get; set; }

        public State(int truckNumber, int towns, int[][] matrix)
        {
            this.truckNumber = truckNumber;
            this.towns = towns;
            if (towns % truckNumber != 0)
                throw new Exception("Broj gradova mora da bude deljiv brojem kamiona");
            townsPerTruck = towns / truckNumber;
            truckTowns = new int[truckNumber][];
            for (int i = 0; i < truckNumber; i++)
                truckTowns[i] = new int[townsPerTruck];

            //for (int i = 0; i < truckNumber; i++)
            //    for (int j = 0; j < townsPerTruck; j++)
            //        distances[i][j] = matrix[i][j];
        }

        public State(State old)
        {
            this.truckNumber = old.truckNumber;
            this.towns = old.towns;
            if (towns % truckNumber != 0)
                throw new Exception("Broj gradova mora da bude deljiv brojem kamiona");
            townsPerTruck = towns / truckNumber;
            truckTowns = new int[truckNumber][];
            for (int i = 0; i < truckNumber; i++)
                truckTowns[i] = new int[townsPerTruck];

            for (int i = 0; i < truckNumber; i++)
                for (int j = 0; j < townsPerTruck; j++)
                    truckTowns[i][j] = old.truckTowns[i][j];
        }

        public State InitiateStart()
        {
            int town = 0;
            for(int i=0; i<truckNumber; i++)
                for(int j=0; j< townsPerTruck; j++)
                {
                    truckTowns[i][j] = town;
                    town++;
                }

            return this;
        }

        public string Print(int[][] matrix, ListBox lbx)
        {
            string forPrint = "";

            double[] distances = new double[truckNumber];

            for (int i = 0; i < truckNumber; i++)
            {
                distances[i] = 0;
                for (int j = 0; j < townsPerTruck - 1; j++)
                {
                    distances[i] += matrix[truckTowns[i][j]][truckTowns[i][j + 1]];
                }
            }

            for (int i=0; i<truckNumber; i++)
            {
                var truckPrint = "";
                for (int j = 0; j < townsPerTruck; j++)
                {
                    forPrint += truckTowns[i][j].ToString() + " ";
                    truckPrint+= truckTowns[i][j].ToString() + " ";
                    forPrint += ": Distance " + distances[i].ToString() + " \n";
                }
                lbx.Items.Add(truckPrint + ": Distance " + distances[i].ToString());
            }
            lbx.Items.Add("-----------------------");

            return forPrint;
        }

    }
}

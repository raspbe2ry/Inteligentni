﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteligentniDom1
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        Random r = new Random();
        int[][] matrixOfDistance=new int[25][];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv.DataSource = dt;
            rbn1.Checked = true;
            rbn2.Checked = false;
            tbx1.Enabled = true;
            tbx2.Enabled = false;

            for (int i = 0; i < 25; i++)
            {
                dt.Columns.Add("Town " + i.ToString());
                //matrixOfDistance[i][i] = 0;
                matrixOfDistance[i] = new int[25];
            }

            for(int i=0; i<25; i++)
                for(int j=i+1; j<25; j++)
                {
                    matrixOfDistance[i][j] = r.Next(100, 500);
                    matrixOfDistance[j][i] = matrixOfDistance[i][j];
                }

            for (int i = 0; i < 25; i++)
            {
                DataRow dr = dt.NewRow();
                for(int j=0; j<25; j++)
                {
                    dr[j] = matrixOfDistance[i][j];
                }
                dt.Rows.Add(dr);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            State initial = new State(5, 25, matrixOfDistance);
            initial= initial.InitiateStart();
            IEvaluate evaluator = new Evaluator(matrixOfDistance);
            ISuccesor succesor = new Successor();
            SimulatedAnnealing sa = new SimulatedAnnealing(evaluator, succesor, lbx);
            sa.TempMin = Double.Parse(tbx3.Text);
            sa.TempMax = Double.Parse(tbx4.Text);
            if (rbn1.Checked)
            {
                sa.Model = 1;
                sa.TempStep = Double.Parse(tbx1.Text);
            }
            if (rbn2.Checked)
            {
                sa.Model = 0;
                sa.TempFactor = Double.Parse(tbx2.Text);
            }
            sa.MaxIteration = Int32.Parse(tbx6.Text);

            State finalState = null;
            Thread thread = new Thread(() => { finalState = sa.PerformAnnealing(initial, matrixOfDistance); });
            thread.Start();
        }

        private void rbn1_CheckedChanged(object sender, EventArgs e)
        {
            if(rbn1.Checked==true)
            {
                tbx1.Enabled = true;
                tbx2.Enabled = false;
            }
        }

        private void rbn2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn2.Checked == true)
            {
                tbx2.Enabled = true;
                tbx1.Enabled = false;
            }
        }

        #region 
        private void lbl4_Click(object sender, EventArgs e)
        {

        }

        private void tbx4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void tbx3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void tbx4_TextChanged_1(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

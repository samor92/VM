using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task1_1
{
    public partial class Form1 : Form
    {
        int[] size = { 10, 100, 1000 };
        int[,] diap = { { -10, 10 }, { -100, 100 }, { -1000, 1000 } };
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int t = 0;
            double y = 1.0;
            while (y - y + 1 == 1)
            {
                y = y * 10;
                t++;
            }*/

            double[] a = { 1, 1, 1, 4, 8 };
            double[] b = { 2, 4, 2, 4, 8, 2 };
            double[] c = { 4, 8, 2, 1, 1 };
            double[] p = { 2, 4, 1, 4, 1, 2 };
            double[] q = { 8, 1, 2, 2, 4, 4 };
            double[] f;            
            
            int test = 1;
           

            for (int i = 0; i < 9; i++)            
            {                                              
                double s = 0;
                double acc = 0;
                int k = 3;//size[i / 3] / 2;
                for (int t = 0; t < test; t++)
                {                    
                    Ghauss.makeMatrix(size[i / 3], k, out a, out b, out c, out p, out q, diap[i % 3, 1]);
                    double[] x = Ghauss.makeX(size[i / 3], diap[i % 3, 1]);          
                    f = Ghauss.makeF(size[i / 3], k, a, b, c, p, q, x);
                    double accur;
                    double[] _x = Ghauss.Solve(size[i / 3], k, a, b, c, p, q, f, out accur, x);
                    acc = acc + accur;
                    double max = 0;
                    double g;
                    for (int j = 0; j < size[i / 3]; j++)
                    {
                        g = Math.Abs((_x[j] - x[j]) / x[j]);
                        if (g > max)
                            max = g;
                    }
                    s = s + max;
                }
                s = s / test;
                acc = acc / test;
                Grid1[2, i].Value = s;
                Grid1[3, i].Value = acc;
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                Grid1.Rows.Add();                
            }
            
            for (int i = 0; i < 9; i++)
            {
                int a = size[i / 3];
                Grid1[0, i].Value = a;
                Grid1[1, i].Value = "[" + diap[i % 3, 0] + ", " + diap[i % 3, 1] + "]";
            }

            int n = 10;
            int k = 5;

            for (int i = 0; i < n; i++)
            {
                if (i == k) dtGrdVwMatrix.Columns.Add("Col" + i, "k");
                else if (i == k + 1) dtGrdVwMatrix.Columns.Add("Col" + i, "");
                else dtGrdVwMatrix.Columns.Add("Col" + i, "");
                dtGrdVwMatrix.Columns[i].Width = 20;
                dtGrdVwMatrix.Rows.Add();
                dtGrdVwMatrix.Rows[i].Height = 20;
            }

            for (int i = 0; i < n; i++)
            {
                dtGrdVwMatrix[k, i].Value = "X";
                dtGrdVwMatrix[k + 1, i].Value = "X";
                dtGrdVwMatrix[n - 1 - i, i].Value = "X";
                if (i < n - 1) dtGrdVwMatrix[i, n - 2 - i].Value = "X";
                if (i > 0) dtGrdVwMatrix[i, n - i].Value = "X";
            }
        }
    }
}
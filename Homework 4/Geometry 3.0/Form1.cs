using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_3._0
{
    public partial class Form1 : Form
    {
        private void Reset()
        {
            tbSideA.Text = "0";
            tbSideB.Text = "0";
            tbAngleAB.Text = "0";

            ResetResults();
        }

        private void ResetResults()
        {
            lbPerim.Text = "Perimeter is ";
            lbArea.Text = "Area is ";
        }

        private void ShowResults(Triangle triangle)
        {
            lbPerim.Text += $"{Math.Round(triangle.GetPerimeter(), 2)} cm";
            lbArea.Text += $"{Math.Round(triangle.GetArea(), 2)} cm²";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ResetResults();
            try
            {
                float sideA = float.Parse(tbSideA.Text);
                float sideB = float.Parse(tbSideB.Text);
                float angleAB = float.Parse(tbAngleAB.Text);

                if(sideA <= 0 || sideB <= 0 || angleAB <= 0)
                    throw new ArgumentException("The wrong sides or the wrong angle");

                Triangle triangle;

                if (angleAB == 90)
                {
                    triangle = new RightTriangle(sideA, sideB, angleAB);
                    ShowResults(triangle);
                }
                else
                {
                    triangle = new IsoscelesTriangle(sideA, sideB, angleAB);
                    ShowResults(triangle);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "ERROR MESSAGE");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
    public partial class Form1 : Form
    {
        Triangle triangle;
        public Form1()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            tbSideA.Text = "0";
            tbSideB.Text = "0";
            tbSideC.Text = "0";

            ResetResults();
        }

        private void ResetResults()
        {
            lbAngles.Text = "Angles is ";
            lbPerim.Text = "Perimeter is";
            lbArea.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {       
            try
            {
                ResetResults();

                float A = float.Parse(tbSideA.Text);
                float B = float.Parse(tbSideB.Text);
                float C = float.Parse(tbSideC.Text);
            
                if (A == B && B == C && C == A)
                {
                    triangle = new EqualTriangle(A, B, C);
                }
                else
                {
                    triangle = new Triangle(A, B, C);
                }

                double[] angles = triangle.GetAngles();
                double angleAB = angles[0];
                double angleBC = angles[1];
                double angleCA = angles[2];

                lbAngles.Text = $"Angles between\n A and B is {angleAB}°,\n B and C is {angleBC}°,\n C and A is {angleCA}°";
                lbPerim.Text = $"Perimeter is {triangle.GetPerimeter()} cm";

                if (triangle is EqualTriangle)
                {
                    lbArea.Text = $"Area is {triangle.GetArea()} cm²";
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString(), "ERROR MESSAGE");
                Reset();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}

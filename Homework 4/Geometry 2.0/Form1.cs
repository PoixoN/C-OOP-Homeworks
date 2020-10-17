using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_2._0
{
    public partial class Form1 : Form
    {
        private void Reset()
        {
            lbParam1.Visible = false;
            tbParam1.Visible = false;

            lbParam2.Visible = false;
            tbParam2.Visible = false;

            lbParam3.Visible = false;
            tbParam3.Visible = false;

            ResetResults();
        }

        private void ResetResults()
        {
            lbPerim.Text = "Perimeter is ";
            lbArea.Text = "Area is ";
        }

        private void ShowResults(Shape shape)
        {
            lbPerim.Text += $"{Math.Round(shape.GetPerimeter(), 2)} cm";
            lbArea.Text += $"{Math.Round(shape.GetArea(), 2)} cm²";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void cbShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset();
            btnCalculate.Enabled = true;
            switch (cbShapes.Text)
            { 
                case "Circle":
                    lbParam1.Text = "Radius";
                    lbParam1.Visible = true;               
                    tbParam1.Visible = true;
                    break;
                case "Triangle":
                    lbParam1.Text = "SideA";
                    lbParam1.Visible = true;
                    tbParam1.Visible = true;

                    lbParam2.Text = "SideB";
                    lbParam2.Visible = true;
                    tbParam2.Visible = true;

                    lbParam3.Text = "SideC";
                    lbParam3.Visible = true;
                    tbParam3.Visible = true;
                    break;
                case "Square":
                    lbParam1.Text = "Side";
                    lbParam1.Visible = true;
                    tbParam1.Visible = true;
                    break;
                case "Diamond":
                    lbParam1.Text = "Side";
                    lbParam1.Visible = true;
                    tbParam1.Visible = true;
                    break;
                case "Rectangle":
                    lbParam1.Text = "SideA";
                    lbParam1.Visible = true;
                    tbParam1.Visible = true;

                    lbParam2.Text = "SideB";
                    lbParam2.Visible = true;
                    tbParam2.Visible = true;
                    break;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ResetResults();
            Shape shape;
            try
            {
                switch (cbShapes.Text)
                {
                    case "Circle":
                        float Radius = float.Parse(tbParam1.Text);
                        if(Radius > 0)
                        {
                            shape = new Circle(Radius);
                            ShowResults(shape);
                            break;
                        }
                        else
                            throw new ArgumentException("The wrong radius");
                    case "Triangle":
                        float triangleSideA = float.Parse(tbParam1.Text);
                        float triangleSideB = float.Parse(tbParam2.Text);
                        float triangleSideC = float.Parse(tbParam3.Text);
                        if(triangleSideA > 0 && triangleSideB > 0 && triangleSideC > 0)
                        {
                            shape = new Triangle(triangleSideA, triangleSideB, triangleSideC);
                            ShowResults(shape);
                            break;
                        }
                        else
                            throw new ArgumentException("The wrong sides");
                    case "Square":
                        float squareSide = float.Parse(tbParam1.Text);
                        if(squareSide > 0)
                        {
                            shape = new Square(squareSide);
                            ShowResults(shape);
                            break;
                        }
                        else
                            throw new ArgumentException("The wrong square side");
                    case "Diamond":
                        float diamondSide = float.Parse(tbParam1.Text);
                        if(diamondSide > 0)
                            {
                            shape = new Diamond(diamondSide);
                            ShowResults(shape);
                            break;
                        }
                        else
                            throw new ArgumentException("The wrong diamond side");
                    case "Rectangle":
                        float rectangleSideA = float.Parse(tbParam1.Text);
                        float rectangleSideB = float.Parse(tbParam2.Text);
                        if (rectangleSideA > 0 && rectangleSideB > 0)
                        {
                            shape = new Rectangle(rectangleSideA, rectangleSideB);
                            ShowResults(shape);
                            break;
                        }
                        else
                            throw new ArgumentException("The wrong rectangle sides");
                }
            }
            catch (Exception exp)
            { 
                MessageBox.Show(exp.ToString(), "ERROR MESSAGE");
            }
        }
    }
}

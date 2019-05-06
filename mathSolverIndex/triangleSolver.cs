using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathSolverIndex
{
    public partial class triangleSolver : Form
    {   
        public triangleSolver()
        {
            InitializeComponent();
            label1.Text = "Input three values and then press the solve button.";
            label3.Text = "Key: \n Red = Error \n SAS = Orange \n AAS = Blue \n ASS = Green";
        }

        public void solveButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightCyan; //Changing color upon button click.
            int valueCount = 0; 
            double sideOne = -1;
            double sideTwo = -1;
            double sideThree = -1;
            double angleOne = -1;
            double angleTwo = -1;
            double angleThree = -1;

            string tempS1 = textBox1.Text;
            if (!string.IsNullOrEmpty(tempS1))
            {
                sideOne = double.Parse(tempS1);
                valueCount++;
            }
            string tempS2 = textBox2.Text;
            if (!string.IsNullOrEmpty(tempS2))
            {
                sideTwo = double.Parse(tempS2);
                valueCount++;
            }
            string tempS3 = textBox3.Text;
            if (!string.IsNullOrEmpty(tempS3))
            {
                sideThree = double.Parse(tempS3);
                valueCount++;
            }
            string tempA1 = textBox4.Text;
            if (!string.IsNullOrEmpty(tempA1))
            {
                angleOne = double.Parse(tempA1);
                valueCount++;
            }
            string tempA2 = textBox5.Text;
            if (!string.IsNullOrEmpty(tempA2))
            {
                angleTwo = double.Parse(tempA2);
                valueCount++;
            }
            string tempA3 = textBox6.Text;
            if (!string.IsNullOrEmpty(tempA3))
            {
                angleThree = double.Parse(tempA3);
                valueCount++;
            }

            // If the user does not give 3 values there will be an error message.
            if (valueCount < 3) 
                MessageBox.Show("Pleas enter atleast three values", "Value Count Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            int triangleType = findTriangleType(tempS1, tempS2, tempS3, tempA1, tempA2, tempA3);
            // The triangleType function returns a number which represents a triangle type, these if statements then run the correct solution function. 
            if (triangleType == 1)
            {
                solveSAS(sideOne, sideTwo, angleThree);
            }
            else if (triangleType == 2)
            {
                solveSSS();
            }
            else if (triangleType == 3)
            {
                solveASS(sideOne, sideTwo, angleOne);
            }
            else if (triangleType == 4)
            {
                solveAAS(sideOne, angleOne, angleTwo);
            }
            else { this.BackColor = Color.Red; }
        }

        private int findTriangleType(string tempS1, string tempS2, string tempS3, string tempA1, string tempA2, string tempA3)
        {
            if (!string.IsNullOrEmpty(tempS1) && !string.IsNullOrEmpty(tempS2) && !string.IsNullOrEmpty(tempA3))//if sideA, sideB, angleC are present then the triangle is SAS
            {
                return 1;
            }
            
            if (!string.IsNullOrEmpty(tempS1) && !string.IsNullOrEmpty(tempS2) && !string.IsNullOrEmpty(tempS3))//if sideA, sideB, sideC are present then the triangle is SSS
            {
                return 2;
            }
            if ((!string.IsNullOrEmpty(tempS1) && !string.IsNullOrEmpty(tempS2) && !string.IsNullOrEmpty(tempA1)) || (!string.IsNullOrEmpty(tempS1) && !string.IsNullOrEmpty(tempS2) && !string.IsNullOrEmpty(tempA2)))//if sideA, sideB, angleA are present then the triangle is AAS
            {
                return 3;
            }
            else if (!string.IsNullOrEmpty(tempS1) && !string.IsNullOrEmpty(tempA1) && !string.IsNullOrEmpty(tempA2))//if  sideA, angleA, angleB  are present then the triangle is AAS
            {
                return 4;
            }
            else { return 0; }
        }

        private void solveSAS(double sideA, double sideB, double angleC)
        {
            this.BackColor = Color.Orange;
            // Using the law of cosines to find sideC, rounding it and putting it in its textbox.
            double sidecTemp = cosLaw(sideA, sideB, 0, 0, 0, angleC);
            sidecTemp = Math.Round(sidecTemp);
            textBox3.Text = sidecTemp.ToString();

            // using the law of sines to find angleB, rounding it and putting it in its textbox.
            double anglebTemp = sinLaw(sidecTemp, sideB, angleC, 0);
            anglebTemp = Math.Round(anglebTemp);
            textBox5.Text = anglebTemp.ToString();

            // 180 minus the sum of the two known angles to find the missing angle, rounding it and putting it in its textbox.
            double angleaTemp = getSupplementary(angleC, anglebTemp);
            angleaTemp = Math.Round(angleaTemp);
            textBox4.Text = angleaTemp.ToString();
        }
        private void solveSSS()
        {
            this.BackColor = Color.Red;
        }

        //Takes the known values for AAS and puts the missing values in their correct textbox.
        private void solveAAS(double sideA, double angleA, double angleB)
        {
            this.BackColor = Color.Blue;
            // Using the law of sines to find sideB, rounding it and putting it in its textbox.
            double sidebTemp = sinLaw(sideA, 0, angleA, angleB);
            sidebTemp = Math.Round(sidebTemp);
            textBox2.Text = sidebTemp.ToString();

            // 180 minus the sum of the two known angles to find the missing angle, rounding it and putting it in its textbox.
            double anglecTemp = getSupplementary(angleA, angleB);
            anglecTemp = Math.Round(anglecTemp);
            textBox6.Text = anglecTemp.ToString();

            // Using the law of sines to find sideC, rounding it and putting it in its textbox.
            double sidecTemp = sinLaw(sideA, 0, angleA, anglecTemp);
            sidecTemp = Math.Round(sidecTemp);
            textBox3.Text = sidecTemp.ToString();
            
        }

        //Takes the known values for ASS and puts the missing values in their correct textbox.
        private void solveASS(double sideA, double sideB, double angleA)
        {
            this.BackColor = Color.DarkGreen;
            // Using the law of sines to find angleB, rounding it and putting it in its textbox.
            double anglebTemp = sinLaw(sideA, sideB, angleA, 0);
            anglebTemp = Math.Round(anglebTemp);
            textBox5.Text = anglebTemp.ToString();

            // 180 minus the sum of the two known angles to find the missing angle, rounding it and putting it in its textbox.
            double anglecTemp = getSupplementary(angleA, anglebTemp);
            anglecTemp = Math.Round(anglecTemp);
            textBox6.Text = anglecTemp.ToString();

            // Using the law of sines to find sideB, rounding it and putting it in its textbox.
            double sidecTemp = sinLaw(sideA, 0, angleA, anglecTemp);
            sidecTemp = Math.Round(sidecTemp);
            textBox3.Text = sidecTemp.ToString();
        }

        private double sinLaw(double side1, double side2, double angle1, double angle2)
        {
            // each of these if statements checks which piece of information is missing and does the proper sine law calculations to find it.
            if (angle2 == 0) 
            {
                return degAsin(side2 / (side1 / degSin(angle1)));
                //return degAsin((degSin(angle1) / side1) * side2);
            }
            else if (angle1 == 0)
            {
                return degAsin(side1 / (side2 / degSin(angle2)));
            }
            else if (side1 == 0)
            {
                return (side2 / degSin(angle2)) * degSin(angle1);
            }
            else if (side2 == 0)
            {
                return (side1 / degSin(angle1)) * degSin(angle2);
            }
            else { return 0; }
        }

        private double cosLaw(double side1, double side2, double side3, double angle1, double angle2, double angle3)
        {
            // each of these if statements checks which piece of information is missing and does the proper cosine law calculations to find it.
            if (side1 == 0) // SAS case
            {
                return Math.Sqrt((Math.Pow(side3, 2) + Math.Pow(side2, 2)) - (2 * side3 * side2 * degCos(angle1)));
            }
            else if (side2 == 0) // SAS case
            {
                return Math.Sqrt((Math.Pow(side1, 2) + Math.Pow(side3, 2)) - (2 * side1 * side3 * degCos(angle2)));
            }
            else if (side3 == 0) // SAS case
            {
                return Math.Sqrt((Math.Pow(side1, 2) + Math.Pow(side2, 2)) - (2 * side1 * side2 * degCos(angle3)));
            }
            else
            {
                // SSS case, solve for angle
                return 0;
            }
        }

        // if we know two angles, the third angle is the 180 minus the sum of those two angles.
        private double getSupplementary(double angle1, double angle2)
        {
            return 180 - (angle1 + angle2);
        }

        //Takes an angle, converts it to radians, and returns the sine of the converted angle.
        double degSin(double angle)
        {
            return Math.Sin((Math.PI / 180) * angle);
        }

        //Takes an angle, converts it to radians, and returns the inverse sine of the converted angle.
        double degAsin(double angle)
        {
            return (180 / Math.PI) * (Math.Asin(angle));
        }

        //Takes an angle, converts it to radians, and returns the cosine of the converted angle.
        double degCos(double angle)
        {
            return Math.Cos((Math.PI / 180) * angle);
        }

        //Takes an angle, converts it to radians, and returns the inverse cosine of the converted angle.
        double degAcos(double angle)
        {
            return (180 / Math.PI) * (Math.Acos(angle));
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
        }
    }
}

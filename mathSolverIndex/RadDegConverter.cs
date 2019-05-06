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
    public partial class RadDegConverter : Form
    {
        const double halfC = Math.PI / 180;
        int radOrDeg;
        public RadDegConverter()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double input = double.Parse(textBox1.Text);
            if (radOrDeg == 1)
            {
                ResultTextbox.Text = Convert.ToString(Math.Round(input * halfC, 2));
                resultType.Text = "radians";
            }

            if (radOrDeg == 0)
            {
                ResultTextbox.Text = Convert.ToString(Math.Round(input / halfC));
                resultType.Text = "degrees";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            solvingLabel.Text = "which value are you solving for?";
            this.BackColor = Color.White;
            textBox1.Text = null;
            ResultTextbox.Text = null;
            radOrDeg = 2;
        }

        private void radianButton_Click(object sender, EventArgs e)
        {
            solvingLabel.Text = "Solving for Radians, Please enter a value in Degrees.";
            radOrDeg = 1;
        }

        private void degreeButton_Click(object sender, EventArgs e)
        {
            solvingLabel.Text = "Solving for Degrees, Please enter a value in Radians.";
            radOrDeg = 0;
        }
    }
}

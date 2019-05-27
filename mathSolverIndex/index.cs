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
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            triangleSolver triSolve = new triangleSolver();
            triSolve.ShowDialog();
            
        }

        private void rad_conversion_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            RadDegConverter radConverter = new RadDegConverter();
            radConverter.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CompoundInterest compInterest = new CompoundInterest();
            compInterest.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_Lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double p = 0.55;


        double ran;
        Random r = new Random();

        private void btAnswer_Click(object sender, EventArgs e)
        {
            tbAnswer.Clear();
            if (tbAsk.Text != String.Empty)
            {
                ran = r.NextDouble();
                if (ran < p) tbAnswer.Text = "Да";
                else tbAnswer.Text = "Нет";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

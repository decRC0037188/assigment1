using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double r1 = double.Parse(textBox2.Text);
            double r2 = double.Parse(textBox1.Text);

            double RT = 1.0 / (1.0 / r1 + 1.0 / r2);
            label1.Text = "RT = " + RT;
            //comment
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}

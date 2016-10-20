using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Average : Form
    {
        public Average()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /**
                       *
                       * Name: ZiChao Liu
                       * 
                       * Teacher: Mr. Hardman
                       * 
                       * Assignment #2, Program #2
                       * 
                       * Date Last Modified: 10/19/2016
                       * 
                       */

            // using user input number
            double Firstnumber = Convert.ToDouble(txtFirstnumber.Text);
            double Secondnumber = Convert.ToDouble(txtSecondnumber.Text);
            double Thirdnumber = Convert.ToDouble(txtThirdnumber.Text);
            double Fourthnumber = Convert.ToDouble(txtFourthnumber.Text);
            double Fifthnumber = Convert.ToDouble(txtFifthnumber.Text);
            //using arithmic operator for caculation
            double Average = (Firstnumber + Secondnumber + Thirdnumber + Fourthnumber + Fifthnumber) / 5;

            //Display all caculation to the user
            lblResult.Text = string.Format("{0,10}{1,28}\n{2,10}{3,25}\n{4,10}{5,25}\n{6,10}{7,23}\n{8,10}{9,26}\n{10,10}{11,23}","Grade 1:", Firstnumber, "Grade 2:", Secondnumber, "Grade 3:", Thirdnumber, "Grade 4:", Fourthnumber, "Grade 5:", Fifthnumber, "Average:", Average);
        }

        private void txtThirdnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Secondnumber_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void Firstnumber_Click(object sender, EventArgs e)
        {

        }
    }
}

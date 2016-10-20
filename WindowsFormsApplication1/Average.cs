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
                       * Date Last Modified: 
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

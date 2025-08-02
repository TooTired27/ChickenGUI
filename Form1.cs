using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIPrac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const int DOZEN = 12;
            int numChickens=int.Parse(txtChicken1.Text);
            int numChickens2=int.Parse(txtChicken2.Text);
            int  numChickens3 = int.Parse(txtChicken3.Text);
            int numChickens4=int.Parse(txtChicken4.Text);
            int numChickens5=int.Parse(txtChicken5.Text);
            int eggSum = numChickens + numChickens2 + numChickens3 + numChickens4 + numChickens5;
            int total=eggSum/DOZEN;
            int rem = eggSum%DOZEN;
            lblOutput.Text = " A total of " + eggSum.ToString() + " eggs is " + total.ToString() + " dozen and " + rem.ToString() + " eggs.";
        }
    }
}

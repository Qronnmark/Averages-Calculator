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
    public partial class Assignment2 : Form
    {
        public Assignment2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblgr4_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            double firstMark = Convert.ToDouble(txtfirstMark.Text);
            double secondMark = Convert.ToDouble(txtsecondMark.Text);
            double thirdMark = Convert.ToDouble(txtthirdMark.Text);
            double fourthMark = Convert.ToDouble(txtfourthMark.Text);
            double fifthMark = Convert.ToDouble(txtfifthMark.Text);

            double average = (firstMark + secondMark + thirdMark + fourthMark + fifthMark) / 5;

            lblResult.Text = string.Format("{0, 15}{1, 15}\n{2, 15}{3, 15}\n{4, 15}{5, 15}\n{6, 15}{7,15}\n{8,15}{9,15}\n{10, 15}{11, 15}","Grade one: ",firstMark,"Grade two: ",secondMark,"Grade three: ",thirdMark,"Grade four: ",fourthMark,"Grade five: ",fifthMark,"Average: ",average);
        }

        private void lblgr1_Click(object sender, EventArgs e)
        {
            
        }

        private void firstMark_TextChanged(object sender, EventArgs e)
        {

        }

        private void fourthMark_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

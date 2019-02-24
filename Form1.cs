using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inclass5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCalc.Clear();

            Refresh();

            double pi_over_4 = 0;
            int num_terms = int.Parse(txtNumterms.Text);
            double sign = 1;
            for(int term = 0; term < num_terms; term++)
            {
                pi_over_4 += sign / (term * 2 + 1);
                sign *= -1;
            }
            double pi = 4 * pi_over_4;
            txtCalc.Text = pi.ToString();
                }
            }
        }
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cisla;
            int n = Convert.ToInt32(textBox1.Text);
            double[] pole = new double[n];
            Random rn = new Random();
            listBox1.Items.Clear();

            for (int i = 0; i < n; i++)
            {
                cisla = rn.NextDouble() * 2000 - 1000;
                pole[i] = cisla;
            }

            double prum = pole.Average();
            label1.Visible = true;
            label1.Text = "Prumer zadanych prvku je: " + prum.ToString();
            double maxi = double.MinValue;

            foreach (double x in pole)
            {
                listBox1.Items.Add(x.ToString());
                if (x <= prum && x > maxi)
                {
                    maxi = x;
                }
            }
            label2.Visible = true;
            label2.Text = "Maximum je: mensi nebo rovno prumeru " + maxi.ToString();
        }
    }
}

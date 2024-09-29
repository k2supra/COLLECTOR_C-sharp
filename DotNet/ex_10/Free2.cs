using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_10
{
    public partial class Free2 : Form
    {
        public Free2()
        {
            InitializeComponent();
        }

        private void textBox1_to_3_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double p = (a + b + c) / 2;
            double ri = Math.Round(Math.Sqrt((p-a)*(p-b)*(p-c)/2), 2);
            double ro = Math.Round(a*b*c/(4*Math.Sqrt(p*(p-a)*(p-b)*(p-c))), 2);
            textBox4.Text = $"{ri}";
            textBox5.Text = $"{ro}";
        }
    }
}

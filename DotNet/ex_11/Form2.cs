using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_11
{
    public partial class Form2 : Form
    {
        public Form2(string text1, string text2, string text3, string text4)
        {
            InitializeComponent();
            label1.Text = text1;
            label2.Text = text2;
            label3.Text = text3;
            label4.Text = text4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3($"{label1.Text + " " + label2.Text + " " + label3.Text + " " + label4.Text}", listBox1);
            form3.Show();
            this.Hide();
            form3.FormClosed += (s, args) => this.Show();
        }
    }
}

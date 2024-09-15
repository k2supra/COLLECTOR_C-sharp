using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace ex_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            string text = textBox1.Text;
            int n = text.IndexOf(",");
            if (!Char.IsDigit(ch) && !Char.IsControl(ch) && !(ch == ',' && n == -1)) e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.SelectedItem != null) button1.Enabled = true;
        }
        protected List<double> _gasPrice = new List<double>() { 60.0, 62.0, 56.0, 59.0};
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = (Convert.ToInt32(double.Parse(textBox1.Text) / _gasPrice[comboBox1.SelectedIndex])).ToString();
            textBox3.Text = (double.Parse(textBox1.Text) - double.Parse(textBox2.Text) * _gasPrice[comboBox1.SelectedIndex]).ToString();
        }

    }
}

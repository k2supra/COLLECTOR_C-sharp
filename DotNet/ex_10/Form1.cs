namespace ex_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = $"{Convert.ToDouble(textBox1.Text) * 3}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = $"{Math.Round(Math.Pow(Convert.ToDouble(textBox1.Text), 2) * Math.Sqrt(3) / 4, 2)}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = $"{Math.Round(Convert.ToDouble(textBox1.Text) / Math.Sqrt(3), 2)}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Text = $"{Math.Round(Convert.ToDouble(textBox1.Text) / (Math.Sqrt(3) * 2), 2)}";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox9.Text = $"{Math.Round(Math.Sqrt(Math.Pow(double.Parse(textBox10.Text), 2) + Math.Pow(double.Parse(textBox11.Text), 2)), 2)}";
        }

        private void textBox10_11_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text.Length > 0 && textBox11.Text.Length > 0)
            {
                button8.Enabled = true;
            }
            else button8.Enabled = false;
        }

        private void textBox14_15_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text.Length > 0 && textBox14.Text.Length > 0)
            {
                button7.Enabled = true;
            }
            else button7.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox8.Text = $"{Math.Round(Math.Sqrt(Math.Pow(double.Parse(textBox15.Text), 2) - Math.Pow(double.Parse(textBox14.Text), 2)), 2)}";
        }

        private void textBox17_18_TextChanged(object sender, EventArgs e)
        {
            if (textBox17.Text.Length > 0 && textBox18.Text.Length > 0)
            {
                button6.Enabled = true;
            }
            else button6.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox7.Text = $"{double.Parse(textBox17.Text) * double.Parse(textBox18.Text) / 2}";
        }

        private void textBox6_and_12_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Length > 0 && textBox12.Text.Length > 0)
            {
                button5.Enabled = true;
            }
            else button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox13.Text = $"{0.5 * double.Parse(textBox12.Text) * double.Parse(textBox6.Text)}";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Free1 free1 = new Free1();
            free1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Free2 free2 = new Free2();
            free2.Show();
        }
    }
}

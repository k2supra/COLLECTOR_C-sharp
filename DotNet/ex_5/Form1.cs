namespace ex_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //"95", "95 Pulls", "Diesel", "Diesel Pulls"
        protected double[] gas_price = { 59.99, 61.99, 55.99, 58.99 };
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = (gas_price[comboBox1.SelectedIndex]).ToString();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label6.Text = "0";
            }
            else
            {
                label6.Text = (double.Parse(textBox2.Text) * double.Parse(textBox1.Text)).ToString();
            }
        }

        private void radioButton_1_2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { textBox2.Enabled = true; textBox3.Enabled = false; }
            else { textBox2.Enabled = false; textBox3.Enabled = true; }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == ',' && textBox2.Text.IndexOf(",") == -1 || e.KeyChar == '.' && textBox2.Text.IndexOf(".") == -1)) e.Handled = true;
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == ',' && textBox3.Text.IndexOf(",") == -1 || e.KeyChar == '.' && textBox3.Text.IndexOf(".") == -1)) e.Handled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label6.Text = "0";
            }
            else
            {
                label6.Text = (double.Parse(textBox2.Text) * double.Parse(textBox1.Text)).ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                label6.Text = "0";
            }
            else
            {
                label6.Text = textBox3.Text;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox8.Enabled = checkBox1.Checked;
            if (!checkBox1.Checked)
            {
                food_price_1 = 0;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox9.Enabled = checkBox2.Checked;
            if (!checkBox2.Checked)
            {
                food_price_2 = 0;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox11.Enabled = checkBox3.Checked;
            if (!checkBox3.Checked)
            {
                food_price_3 = 0;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox10.Enabled = checkBox4.Checked;
            if (!checkBox4.Checked)
            {
                food_price_4 = 0;
            }
        }

        private void textBox_8_to_11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        protected double food_price_1 = 0;
        protected double food_price_2 = 0;
        protected double food_price_3 = 0;
        protected double food_price_4 = 0;
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            food_price_1 = double.Parse(textBox8.Text) * double.Parse(textBox4.Text);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            food_price_2 = double.Parse(textBox9.Text) * double.Parse(textBox5.Text);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            food_price_3 = double.Parse(textBox11.Text) * double.Parse(textBox6.Text);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            food_price_4 = double.Parse(textBox10.Text) * double.Parse(textBox7.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = (food_price_1 + food_price_2 + food_price_3 + food_price_4).ToString();
            label13.Text = (double.Parse(label6.Text) + double.Parse(label9.Text)).ToString();
        }
    }
}

namespace ex_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_to_4_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 &&
                textBox2.Text.Length > 0 &&
                textBox3.Text.Length > 0 &&
                textBox4.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            form2.Show();
            this.Hide();
            form2.FormClosed += (s, args) => this.Show();
        }
    }
}

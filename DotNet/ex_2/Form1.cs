using System.Runtime.CompilerServices;

namespace ex_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] result1 = new double[int.Parse(textBox1.Text), int.Parse(textBox2.Text)];
            double[,] result2 = new double[int.Parse(textBox1.Text), int.Parse(textBox2.Text)];
            string data1 = "";
            double sum1 = 0;
            double mult1 = 1;
            int sum2 = 0;
            int sum22 = 0;
            string data2 = "";
            for (int i = 0; i < result1.GetLength(0); i++)
            {
                for (int j = 0; j < result1.GetLength(1); j++)
                {
                    result1[i, j] = ((i * i) - result1.GetLength(1)) / (i + j + result1.GetLength(0));
                    if (result1[i, j] > 0)
                    {
                        sum1 += result1[i, j];
                    }
                    else if (result1[i, j] < 0)
                    {
                        mult1 *= result1[i, j];
                    }
                    result2[i, j] = Math.Round((3 * j * j - 35) / (i + 1.2 * j + 2), 1);
                    if (result2[i, j] > 0)
                    {
                        sum2 += 1;
                    }
                    else if (result2[i, j] < 0)
                    {
                        sum22 += 1;
                    }
                    data1 += result1[i, j].ToString() + " ";
                    data2 += result2[i, j].ToString() + " ";
                }
                Array1.Items.Add(data1);
                Array2.Items.Add(data2);
                data1 = "";
                data2 = "";
            }
            label4.Text = sum1.ToString();
            label5.Text = mult1.ToString();
            label7.Text = sum22.ToString();
            label9.Text = sum2.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

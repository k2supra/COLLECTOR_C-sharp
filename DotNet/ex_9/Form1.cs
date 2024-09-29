namespace ex_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = int.Parse(textBox1.Text);
            int c = int.Parse(textBox2.Text);
            Random random = new Random();
            dataGridView1.RowCount = r;
            dataGridView1.ColumnCount = c;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = random.Next(-20, 20);
                    dataGridView1.Columns[j].Width = 35;
                }
            }
            rows_mult_less_40();
        }
        private void rows_mult_less_40()
        {
            int number = 0;
            int temp = 1;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    temp *= Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                }
                if (temp > 40)
                {
                    number++;
                }
                temp = 1;
            }
            label3.Text = $"Amount of rows that number`s multiplication < 40 : {number}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.RowCount;
            int c = dataGridView1.ColumnCount;
            int[] arr = new int[r * c];
            int t = 0;

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value) >= 0)
                    {
                        arr[t] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                        t++;
                    }
                }
            }
            Array.Resize(ref arr, t);
            listBox1.Items.Clear();
            foreach (int i in arr) listBox1.Items.Add(i * i);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            rows_mult_less_40();
        }
    }
}

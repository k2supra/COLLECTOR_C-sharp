using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_14
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Graphics graphics = Graphics.FromImage(bitmap);

            Pen pen = new Pen(Color.DarkOrange, 2);

            graphics.DrawRectangle(pen, 10, 10, 20, 10);
            graphics.DrawPie( pen, 100, 100, 50, 50, 45, 90);
            graphics.DrawLine(pen, 150, 10, 10, 50);
            graphics.DrawRectangle(pen, 100, 200, 40, 40);
            graphics.DrawEllipse(pen, 150, 200, 40, 40);

            pictureBox1.Image = bitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.Filter = "png image|*.png | jpg imagge|*.jpg ";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = new Bitmap(this.pictureBox1.Image);
                    bitmap.Save(saveFileDialog1.FileName);
                }
            }
        }
    }
}

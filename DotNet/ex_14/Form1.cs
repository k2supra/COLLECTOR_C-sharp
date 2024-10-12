using System;
using System.Drawing;
using System.Windows.Forms;

namespace ex_14
{
    public partial class Form1 : Form
    {
        private Timer animationTimer;
        private int currentP;
        private int min;
        private int max;
        private double scale = 10;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();  // Ініціалізуємо таймер
        }

        private void InitializeTimer()
        {
            animationTimer = new Timer();
            animationTimer.Interval = 100;
            animationTimer.Tick += new EventHandler(OnAnimationTick);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            min = Convert.ToInt32(textBox2.Text);
            max = Convert.ToInt32(textBox3.Text);
            CreateGraphic(max);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            min = Convert.ToInt32(textBox2.Text);
            max = Convert.ToInt32(textBox3.Text);
            currentP = min;
            animationTimer.Start();
        }

        private void OnAnimationTick(object sender, EventArgs e)
        {
            if (currentP > max)
            {
                animationTimer.Stop();
            }
            else
            {
                CreateGraphicStep(currentP);
                currentP++;
            }
        }

        private void CreateGraphicStep(int pLimit)
        {
            CreateGraphic(pLimit);
        }


        private void CreateGraphic(int pLimit)
        {
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            Bitmap bitmap = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);

            Pen axisPen = new Pen(Color.Black, 1);
            Pen graphPen = new Pen(Color.Red, 2);
            Pen graphPen2 = new Pen(Color.Yellow, 2);
            Pen graphPen3 = new Pen(Color.Green, 2);

            graphics.DrawLine(axisPen, 0, height / 2, width, height / 2);
            graphics.DrawLine(axisPen, width / 2, 0, width / 2, height);

            for (double h = 0; h <= width; h += width / scale)
            {
                graphics.DrawLine(axisPen, (float)h, (height / 2) - 5, (float)h, (height / 2) + 5);
            }
            for (double v = 0; v <= height; v += height / scale)
            {
                graphics.DrawLine(axisPen, (width / 2) - 5, (float)v, (width / 2) + 5, (float)v);
            }

            PointF? previousPointF = null;
            PointF? previousPointF2 = null;
            PointF? previousPointF3 = null;

            for (int p = min; p <= pLimit; p++)
            {
                PointF currentPointF = new PointF((float)((width / 2) + ((width / scale) * p)), (float)((height / 2) - (height / scale * CountSquare(p))));
                PointF currentPointF2 = new PointF((float)((width / 2) + ((width / scale) * p)), (float)((height / 2) - (height / scale * CountSin(p))));
                PointF currentPointF3 = new PointF((float)((width / 2) + ((width / scale) * p)), (float)((height / 2) - (height / scale * CountCos(p))));

                if (previousPointF != null)
                {
                    graphics.DrawLine(graphPen, previousPointF.Value, currentPointF);
                }
                if (previousPointF2 != null)
                {
                    graphics.DrawLine(graphPen2, previousPointF2.Value, currentPointF2);
                }
                if (previousPointF3 != null)
                {
                    graphics.DrawLine(graphPen3, previousPointF3.Value, currentPointF3);
                }

                previousPointF = currentPointF;
                previousPointF2 = currentPointF2;
                previousPointF3 = currentPointF3;
            }

            pictureBox1.Image = bitmap;
        }

        private double CountSquare(double number)
        {
            return number * number; 
        }

        private double CountSin(double number)
        {
            return Math.Sin(number);
        }

        private double CountCos(double number)
        {
            return Math.Cos(number);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}

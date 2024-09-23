namespace ex_6
{
    public partial class Form1 : Form
    {

        private DateTime newYear;
        public Form1()
        {
            InitializeComponent();
            newYear = new DateTime(DateTime.Now.Year + 1, 1, 1, 0, 0, 0);
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(UpdateCountdown);
            timer1.Start();
            timer2.Start();
        }
        private void UpdateCountdown(object sender, EventArgs e)
        {
            TimeSpan timeRemaining = newYear - DateTime.Now;

            if (timeRemaining.TotalSeconds > 0)
            {
                label1.Text = string.Format("{0}d:{1}h:{2}m:{3}s",
                    timeRemaining.Days, timeRemaining.Hours, timeRemaining.Minutes, timeRemaining.Seconds);
            }
            else
            {
                label1.Text = "З Новим Роком!";
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (pictureBox1.Left < 600) pictureBox1.Left += 10;
            else
            {
                pictureBox1.Left = 10;
            }
        }
    }
}

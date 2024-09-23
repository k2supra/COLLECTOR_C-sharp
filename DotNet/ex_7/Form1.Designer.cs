namespace ex_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            textBox2 = new TextBox();
            trackBar1 = new TrackBar();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(328, 316);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(226, 27);
            textBox1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(357, 176);
            numericUpDown1.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(55, 27);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += trackBar1_Scroll;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(418, 176);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(136, 27);
            textBox2.TabIndex = 2;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(247, 89);
            trackBar1.Maximum = 400;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(381, 56);
            trackBar1.TabIndex = 3;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar1.Value = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(673, 89);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(textBox2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private TrackBar trackBar1;
        private Label label1;
    }
}

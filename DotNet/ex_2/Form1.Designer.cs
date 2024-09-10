namespace ex_2
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
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            Array1 = new ListBox();
            Array2 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 41);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "A size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 41);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "B size";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(419, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(241, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(342, 121);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Array1
            // 
            Array1.FormattingEnabled = true;
            Array1.Location = new Point(216, 208);
            Array1.Name = "Array1";
            Array1.Size = new Size(150, 104);
            Array1.TabIndex = 5;
            // 
            // Array2
            // 
            Array2.FormattingEnabled = true;
            Array2.Location = new Point(419, 208);
            Array2.Name = "Array2";
            Array2.Size = new Size(150, 104);
            Array2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 326);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 7;
            label3.Text = "Sum of numbers > 0: ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(342, 326);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(342, 356);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(180, 356);
            label6.Name = "label6";
            label6.Size = new Size(151, 20);
            label6.TabIndex = 9;
            label6.Text = "Mult of numbers < 0: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(581, 356);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(419, 356);
            label8.Name = "label8";
            label8.Size = new Size(174, 20);
            label8.TabIndex = 13;
            label8.Text = "Amount of numbers < 0: ";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(581, 326);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(419, 326);
            label10.Name = "label10";
            label10.Size = new Size(174, 20);
            label10.TabIndex = 11;
            label10.Text = "Amount of numbers > 0: ";
            label10.Click += label10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Array2);
            Controls.Add(Array1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private ListBox Array1;
        private ListBox Array2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}

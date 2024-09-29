namespace ex_10
{
    partial class Free2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(63, 321);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(94, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(139, 172);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "C side";
            textBox3.Size = new Size(94, 27);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox1_to_3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 116);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "B side";
            textBox2.Size = new Size(94, 27);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox1_to_3_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 61);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "A side";
            textBox1.Size = new Size(94, 27);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_to_3_TextChanged;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(139, 250);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(217, 321);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(94, 27);
            textBox5.TabIndex = 10;
            // 
            // Free2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Free2";
            Text = "Free2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox5;
    }
}
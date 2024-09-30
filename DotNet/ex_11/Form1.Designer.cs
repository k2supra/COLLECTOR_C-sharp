namespace ex_11
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_to_4_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox1_to_4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(205, 191);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox1_to_4_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(205, 256);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox1_to_4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 63);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 4;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 125);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 5;
            label2.Text = "Author:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 194);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 6;
            label3.Text = "Company:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 259);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 7;
            label4.Text = "Year:";
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(139, 368);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}

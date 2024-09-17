namespace ex_5
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
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            groupBox3 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            groupBox5 = new GroupBox();
            label8 = new Label();
            label9 = new Label();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox6 = new GroupBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label12 = new Label();
            label13 = new Label();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 299);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gas station";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(6, 230);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(309, 63);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "To pay";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(253, 35);
            label7.Name = "label7";
            label7.Size = new Size(31, 20);
            label7.TabIndex = 1;
            label7.Text = "grn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(157, 18);
            label6.Name = "label6";
            label6.Size = new Size(32, 37);
            label6.TabIndex = 0;
            label6.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(257, 192);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 9;
            label5.Text = "grn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 160);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 8;
            label4.Text = "liters";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(175, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(76, 27);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(175, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(76, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Location = new Point(6, 132);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(141, 92);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Money";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton_1_2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(83, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Amount";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton_1_2_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 88);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 4;
            label3.Text = "grn";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 81);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(76, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 88);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 2;
            label2.Text = "Price";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "95", "95 Pulls", "Diesel", "Diesel Pulls" });
            comboBox1.Location = new Point(175, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(113, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 36);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 0;
            label1.Text = "Gas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(textBox11);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Location = new Point(381, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(323, 299);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mini-cafe";
            // 
            // textBox10
            // 
            textBox10.Enabled = false;
            textBox10.Location = new Point(251, 184);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(58, 27);
            textBox10.TabIndex = 19;
            textBox10.TextChanged += textBox10_TextChanged;
            textBox10.KeyPress += textBox_8_to_11_KeyPress;
            // 
            // textBox11
            // 
            textBox11.Enabled = false;
            textBox11.Location = new Point(251, 129);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(58, 27);
            textBox11.TabIndex = 18;
            textBox11.TextChanged += textBox11_TextChanged;
            textBox11.KeyPress += textBox_8_to_11_KeyPress;
            // 
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.Location = new Point(251, 78);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(58, 27);
            textBox9.TabIndex = 17;
            textBox9.TextChanged += textBox9_TextChanged;
            textBox9.KeyPress += textBox_8_to_11_KeyPress;
            // 
            // textBox8
            // 
            textBox8.Enabled = false;
            textBox8.Location = new Point(251, 35);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(58, 27);
            textBox8.TabIndex = 16;
            textBox8.TextChanged += textBox8_TextChanged;
            textBox8.KeyPress += textBox_8_to_11_KeyPress;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(163, 184);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(58, 27);
            textBox7.TabIndex = 15;
            textBox7.Text = "25,0";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(163, 129);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(58, 27);
            textBox6.TabIndex = 14;
            textBox6.Text = "70,0";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(163, 78);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(58, 27);
            textBox5.TabIndex = 13;
            textBox5.Text = "36,0";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(163, 36);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(58, 27);
            textBox4.TabIndex = 11;
            textBox4.Text = "56,0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(251, 12);
            label11.Name = "label11";
            label11.Size = new Size(62, 20);
            label11.TabIndex = 12;
            label11.Text = "Amount";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(163, 12);
            label10.Name = "label10";
            label10.Size = new Size(41, 20);
            label10.TabIndex = 11;
            label10.Text = "Price";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(label9);
            groupBox5.Location = new Point(6, 230);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(309, 63);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            groupBox5.Text = "To pay";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(253, 35);
            label8.Name = "label8";
            label8.Size = new Size(31, 20);
            label8.TabIndex = 1;
            label8.Text = "grn";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F);
            label9.Location = new Point(157, 18);
            label9.Name = "label9";
            label9.Size = new Size(32, 37);
            label9.TabIndex = 0;
            label9.Text = "0";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(40, 187);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(98, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Coca-cola";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(40, 132);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(106, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "French fries";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(40, 81);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(107, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Hamburger";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(40, 36);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Hot-dog";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(pictureBox1);
            groupBox6.Controls.Add(button1);
            groupBox6.Controls.Add(label12);
            groupBox6.Controls.Add(label13);
            groupBox6.Location = new Point(12, 317);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(692, 121);
            groupBox6.TabIndex = 11;
            groupBox6.TabStop = false;
            groupBox6.Text = "To pay";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Okko_logo;
            pictureBox1.Location = new Point(33, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(127, 42);
            button1.Name = "button1";
            button1.Size = new Size(126, 56);
            button1.TabIndex = 2;
            button1.Text = "Count";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(582, 68);
            label12.Name = "label12";
            label12.Size = new Size(31, 20);
            label12.TabIndex = 1;
            label12.Text = "grn";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 20F);
            label13.Location = new Point(449, 42);
            label13.Name = "label13";
            label13.Size = new Size(38, 46);
            label13.TabIndex = 0;
            label13.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 450);
            Controls.Add(groupBox6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private GroupBox groupBox3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private GroupBox groupBox4;
        private Label label7;
        private Label label6;
        private TextBox textBox4;
        private Label label11;
        private Label label10;
        private GroupBox groupBox5;
        private Label label8;
        private Label label9;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private GroupBox groupBox6;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label12;
        private Label label13;
    }
}

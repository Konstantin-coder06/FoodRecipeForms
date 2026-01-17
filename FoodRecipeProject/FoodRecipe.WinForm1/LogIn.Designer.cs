namespace FoodRecipe.WinForm1
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button3 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1586, 351);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1577, 272);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1577, 305);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(1577, 115);
            label1.Name = "label1";
            label1.Size = new Size(108, 46);
            label1.TabIndex = 4;
            label1.Text = "LogIn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1586, 410);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // button2
            // 
            button2.Location = new Point(1586, 448);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(606, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 552);
            panel1.TabIndex = 7;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            button4.ForeColor = Color.LimeGreen;
            button4.Location = new Point(-11, 488);
            button4.Name = "button4";
            button4.Size = new Size(241, 37);
            button4.TabIndex = 13;
            button4.Text = "Влезте с него от тук\r\n";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(6, 460);
            label8.Name = "label8";
            label8.Size = new Size(156, 23);
            label8.TabIndex = 12;
            label8.Text = "Имате акаунт?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDark;
            label7.Location = new Point(6, 330);
            label7.Name = "label7";
            label7.Size = new Size(78, 23);
            label7.TabIndex = 11;
            label7.Text = "Парола";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(6, 251);
            label6.Name = "label6";
            label6.Size = new Size(123, 23);
            label6.TabIndex = 10;
            label6.Text = "Имейл адрес";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(6, 156);
            label5.Name = "label5";
            label5.Size = new Size(47, 23);
            label5.TabIndex = 9;
            label5.Text = "Име";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(6, 117);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 8;
            label4.Text = "Въведете:";
            // 
            // button3
            // 
            button3.BackColor = Color.LimeGreen;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(6, 405);
            button3.Name = "button3";
            button3.Size = new Size(211, 39);
            button3.TabIndex = 7;
            button3.Text = "Регистрирай се";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox5.Location = new Point(3, 356);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(290, 31);
            textBox5.TabIndex = 5;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox4.Location = new Point(6, 277);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(290, 31);
            textBox4.TabIndex = 4;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox3.Location = new Point(6, 193);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(290, 31);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.LimeGreen;
            label3.Location = new Point(6, 9);
            label3.Name = "label3";
            label3.Size = new Size(318, 93);
            label3.TabIndex = 1;
            label3.Text = "Добре дошли! Тук ще се \r\nнаучите как да станете\r\nпрофисионален готвач\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-167, -186);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(966, 903);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(928, 537);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "LogIn";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button2;
        private Panel panel1;
        private Label label3;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button4;
    }
}
namespace FoodRecipe.WinForm1
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-85, -125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(979, 692);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.LightGreen;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 448);
            panel1.TabIndex = 1;
          
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(12, 369);
            label5.Name = "label5";
            label5.Size = new Size(158, 23);
            label5.TabIndex = 7;
            label5.Text = "Нямаш акаунт?";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            button2.ForeColor = Color.LimeGreen;
            button2.Location = new Point(0, 395);
            button2.Name = "button2";
            button2.Size = new Size(216, 37);
            button2.TabIndex = 8;
            button2.Text = "Регистрирай се тук";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 296);
            button1.Name = "button1";
            button1.Size = new Size(161, 39);
            button1.TabIndex = 6;
            button1.Text = "Sign in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(12, 244);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(290, 31);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(12, 209);
            label4.Name = "label4";
            label4.Size = new Size(78, 23);
            label4.TabIndex = 4;
            label4.Text = "Парола";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(123, 23);
            label3.TabIndex = 3;
            label3.Text = "Имейл адрес";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(6, 72);
            label2.Name = "label2";
            label2.Size = new Size(318, 23);
            label2.TabIndex = 1;
            label2.Text = "Влез с твоя имейл адрес и парала\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(280, 31);
            label1.TabIndex = 0;
            label1.Text = "Добре дошъл отново!";
            label1.Click += label1_Click;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "SignIn";
            Text = "SignIn";
            Load += SignIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private Button button2;
        private Label label5;
    }
}
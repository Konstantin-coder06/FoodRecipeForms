using FoodRecipe.Core;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.RegularExpressions;

namespace FoodRecipe.WinForm1
{
    public partial class LogIn : Form
    {
        public int LoggedInUserId { get; private set; }
        public LogIn()
        {
            InitializeComponent();
            InitializeTextBox5();
            InitializeTextBox4();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        ControllerCustomer controllerCustomer;
        private void Form1_Load(object sender, EventArgs e)
        {
            controllerCustomer = new ControllerCustomer();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Close();
        }
        public string output = "";
        private void button3_Click(object sender, EventArgs e)
        {
            string errors = "";
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                errors += "Въведи име!\n";
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                errors += "Въведи имейл адрес!\n";
            }
            else if (!Regex.IsMatch(textBox4.Text, @"^[^@]+@[^@]+\.[^@]+$"))
            {
                errors += "Имейлът трябва да съдържа @ символ и точка след него!\n";
            }

            if (string.IsNullOrEmpty(textBox5.Text))
            {
                errors += "Въведи парола!\n";
            }
            else if (textBox5.Text.Length < 8)
            {
                errors += "Паролата трябва да съдържа поне 8 символа!\n";
            }
            else if (!Regex.IsMatch(textBox5.Text, @"\d"))
            {
                errors += "Паролата трябва да съдържа поне едно число!\n";
            }
            if (!string.IsNullOrEmpty(errors))
            {
                MessageBox.Show(errors, "Грешка!!!!");
            }
            else
            {
                output = controllerCustomer.SignUp(textBox3.Text, textBox4.Text, textBox5.Text);
                if (output == "Зает е този имайл адрес!")
                {
                    MessageBox.Show("Зает е този имайл адрес!");
                }
                else
                {
                   
                    MessageBox.Show(output);
                    MainForm mainForm = new MainForm();
                    mainForm.button3.Visible = false;
                    mainForm.LoggedInUserId = controllerCustomer.GetIdReg(textBox3.Text, textBox4.Text, textBox5.Text);
                    mainForm.button8.Visible = true;
                    this.Close();
                    mainForm.Show();

                }

            }
        }
        private void InitializeTextBox5()
        {
            textBox5.Text = "Password";
            textBox5.ForeColor = Color.Gray;

            textBox5.Enter += new EventHandler(RemoveText5);
            textBox5.Leave += new EventHandler(AddText5);
        }

        public void RemoveText5(object sender, EventArgs e)
        {
            if (textBox5.Text == "Password")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
                textBox5.PasswordChar = '*';
            }
        }

        public void AddText5(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                textBox5.Text = "Password";
                textBox5.ForeColor = Color.Gray;
            }
        }
        private void InitializeTextBox4()
        {
            textBox4.Text = "Email";
            textBox4.ForeColor = Color.Gray;

            textBox4.Enter += new EventHandler(RemoveText4);
            textBox4.Leave += new EventHandler(AddText4);
        }

        public void RemoveText4(object sender, EventArgs e)
        {
            if (textBox4.Text == "Email")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
             
            }
        }

        public void AddText4(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                textBox4.Text = "Email";
                textBox4.ForeColor = Color.Gray;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
using FoodRecipe.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodRecipe.WinForm1
{
    public partial class SignIn : Form
    {
        public int LoggedInUserId { get; private set; }
        public SignIn()
        {
            InitializeComponent();
            InitializeTextBox1();
            InitializeTextBox2();
          
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        ControllerCustomer customer;
        private void SignIn_Load(object sender, EventArgs e)
        {
            customer = new ControllerCustomer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }
        private void InitializeTextBox1()
        {
            textBox1.Text = "Username";
            textBox1.ForeColor = Color.Gray;

            textBox1.Enter += new EventHandler(RemoveText1);
            textBox1.Leave += new EventHandler(AddText1);
        }

        public void RemoveText1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

            }
        }

        public void AddText1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Gray;
            }
        }
        private void InitializeTextBox2()
        {
            textBox2.Text = "Password";
            textBox2.ForeColor = Color.Gray;

            textBox2.Enter += new EventHandler(RemoveText2);
            textBox2.Leave += new EventHandler(AddText2);
        }

        public void RemoveText2(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }
        }

        public void AddText2(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Gray;
            }
        }
       
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("ПОПЪЛНИ ПОЛЕТАТА");
            }
            else
            {
                string output = customer.SignIn(textBox1.Text, textBox2.Text);


                var user = customer.GetUserByEmail(textBox1.Text);

           
                if (output == "Успешно влязохте")
                {
                    LoggedInUserId = user.Id;
                    this.Close();
                    MainForm mainForm = new MainForm();                      
                    mainForm.LoggedInUserId = LoggedInUserId; 
                    mainForm.button8.Visible = true;
                    mainForm.Show();
                }
                else if (output == "Успешно влязохте Admin")
                {
                    LoggedInUserId = user.Id;
                    this.Close();
                    AdminForm adminForm = new AdminForm();
                    adminForm.LoggedInUserId = LoggedInUserId; 
                    adminForm.Show();
                }               
                else
                {
                    MessageBox.Show("Няма намерен такъв потребител");

                }

            }
        }
     
        private void label1_Click(object sender, EventArgs e)
        {

        }

     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

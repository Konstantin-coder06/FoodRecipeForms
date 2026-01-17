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
    public partial class AdminForm : Form
    {
        public int LoggedInUserId { get; set; }
        ControllerCustomer customer;
        ControllerRecipe recipe;
        ControllerCategory category;
        ControllerSubCategory subCategory;
        ControllerIngredient ingredient;
        ControllerContact contact;
        public AdminForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            customer = new ControllerCustomer();
            recipe = new ControllerRecipe();
            category = new ControllerCategory();
            subCategory = new ControllerSubCategory();
            ingredient = new ControllerIngredient();
            contact = new ControllerContact();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            radioButton17.Visible = true;
            radioButton18.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            radioButton19.Visible = true;
            radioButton20.Visible = true;
            radioButton21.Visible = true;
            radioButton22.Visible = true;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = customer.ShowAllCustomers();
            richTextBox1.Visible = true;
            label3.Visible = true;
            label3.Text = "За да махнете потребител:";
            textBox1.Visible = true;
            button11.Visible = true;
            textBox2.Visible = false;
            label4.Text = "Въведи имейлът му";
            label4.Visible = true;
            label5.Visible = false;
            button11.Text = "Търси";
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = recipe.ShowAllRecipes();
            label3.Text = "За да махнете рецепта:";
            label3.Visible = true;
            label4.Text = "Напишете номера пред рецептата";
            label4.Visible = true;
            button11.Text = "Изтрий";
            label5.Visible = false;
            button11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = false;
            richTextBox1.Visible = true;
            panel1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string selectedRadioText = "";


            foreach (Control control in panel1.Controls)
            {

                if (control is RadioButton radioButton && radioButton.Checked)
                {

                    selectedRadioText = radioButton.Text;
                    break;
                }
            }
            string recipesByCategory = recipe.SearchByCategoryWithId(selectedRadioText);
            richTextBox1.Text = recipesByCategory;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.Text == "Търси")
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    string output = customer.DeleteUser(textBox1.Text);
                    if (output == "You delete this user")
                    {
                        MessageBox.Show(output);
                        richTextBox1.Clear();
                        richTextBox1.Text = customer.ShowAllCustomers();
                    }
                    else
                    {
                        MessageBox.Show("There is no user with this email. Be more careful!!!!!");
                    }
                }
                else
                {
                    MessageBox.Show("First enter email in the textbox");
                }
            }
            if (button11.Text == "Добави")
            {
                if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
                {
                    string output = subCategory.AddSubCategory(textBox2.Text, textBox1.Text);
                    MessageBox.Show(output);
                }
            }
            if (button11.Text == "Добави   с")
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    string output = category.AddCategory(textBox1.Text);
                    MessageBox.Show(output);
                }
            }
            if (button11.Text == "Промени")
            {
                if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
                {
                    string output = recipe.ChangeNameOfRecipe(int.Parse(textBox1.Text), textBox2.Text);

                    MessageBox.Show(output);
                    richTextBox1.Text = recipe.ShowAllRecipes();
                }

            }
            if (button11.Text == "Промени с")
            {
                if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
                {
                    string output = ingredient.ChangeIngName(textBox1.Text, textBox2.Text);
                    MessageBox.Show(output);
                    richTextBox1.Text = ingredient.ShowAllIng();
                }
            }
            if (button11.Text == "Изтрий")
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    string outputDel = recipe.DeleteRecipe(int.Parse(textBox1.Text));
                    MessageBox.Show(outputDel);
                    richTextBox1.Text = recipe.ShowAllRecipes();
                }
            }
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox1.Text = category.ShowAllCategory();
            label3.Text = "Добавете имe на категорията";
            button11.Text = "Добави";
            label3.Visible = true;
            textBox1.Visible = true;
            button11.Visible = true;
            label4.Text = "Добавете имe на събкатегорията";
            label4.Visible = true;
            label5.Text = "Добавете имe на категорията";
            label5.Visible = true;
            label5.Visible = true;
            textBox2.Visible = true;


        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox1.Text = category.ShowAllCategory();
            label4.Text = "Добавете има на категорията";
            button11.Text = "Добави   с";
            label3.Visible = true;
            textBox1.Visible = true;
            button11.Visible = true;
            label3.Text = "Добавете имe на категорията";
            label4.Visible = true;
            label5.Visible = false;
            textBox2.Visible = false;


        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox1.Text = recipe.ShowAllRecipes();
            label3.Text = "За да промениш името на рецептата трябва да:";
            label3.Visible = true;
            label4.Text = "Добавиш номера на рецептата";
            label4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label5.Text = "Новото име на рецептата";
            label5.Visible = true;
            button11.Text = "Промени";
            button11.Visible = true;
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = ingredient.ShowAllIng();
            richTextBox1.Visible = true;
            label3.Text = "За да промениш името на съставката трябва да:";
            label3.Visible = true;
            label4.Text = "Напиши старото име на съставката";
            label4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label5.Text = "Напиши новото име на съставката";
            label5.Visible = true;
            button11.Text = "Промени с";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            string output = contact.ShowAllAdvices();
            richTextBox1.Text = output;
        }
    }
}

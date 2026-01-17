using FoodRecipe.Core;
using FoodRecipe.Data.Entities;
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
    public partial class AddRecipe : Form
    {
        public int LoggedInUserId { get; set; }
        public AddRecipe()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        ControllerRecipe controllerRecipe;
        ControllerCustomer customer;
        ControllerIngredient ingredient;
        ControllerRecipe_Ingredient ingredientRecipe;
        ControllerRecipe_Category recipeCategory;
        ControllerInstruction instruction;
        private void AddRecipe_Load(object sender, EventArgs e)
        {
            controllerRecipe = new ControllerRecipe();
            customer = new ControllerCustomer();
            ingredient = new ControllerIngredient();
            ingredientRecipe = new ControllerRecipe_Ingredient();
            recipeCategory = new ControllerRecipe_Category();
            instruction = new ControllerInstruction();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox8.Text) == 1)
            {
                label11.Visible = true;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;

                textBox9.Visible = true;
                textBox10.Visible = false;
                textBox11.Visible = false;
                textBox12.Visible = false;
                textBox13.Visible = false;
                textBox14.Visible = false;
                textBox15.Visible = false;
                textBox16.Visible = false;
                textBox17.Visible = false;
                textBox18.Visible = false;

            }
            if (int.Parse(textBox8.Text) == 2)
            {
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;

                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = false;
                textBox12.Visible = false;
                textBox13.Visible = false;
                textBox14.Visible = false;
                textBox15.Visible = false;
                textBox16.Visible = false;
                textBox17.Visible = false;
                textBox18.Visible = false;

            }
            if (int.Parse(textBox8.Text) == 3)
            {
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;

                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = false;
                textBox13.Visible = false;
                textBox14.Visible = false;
                textBox15.Visible = false;
                textBox16.Visible = false;
                textBox17.Visible = false;
                textBox18.Visible = false;

            }
            if (int.Parse(textBox8.Text) == 4)
            {
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;

                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = false;
                textBox14.Visible = false;
                textBox15.Visible = false;
                textBox16.Visible = false;
                textBox17.Visible = false;
                textBox18.Visible = false;

            }
            if (int.Parse(textBox8.Text) == 5)
            {
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;

                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = false;
                textBox15.Visible = false;
                textBox16.Visible = false;
                textBox17.Visible = false;
                textBox18.Visible = false;

            }
            if (int.Parse(textBox8.Text) == 6)
            {
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;

                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                textBox15.Visible = false;
                textBox16.Visible = false;
                textBox17.Visible = false;
                textBox18.Visible = false;

            }
            if (int.Parse(textBox8.Text) == 7)
            {
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;

                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                textBox15.Visible = true;
                textBox16.Visible = false;
                textBox17.Visible = false;
                textBox18.Visible = false;

            }
            if (int.Parse(textBox8.Text) == 8)
            {
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = false;
                label20.Visible = false;

                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                textBox15.Visible = true;
                textBox16.Visible = true;
                textBox17.Visible = false;
                textBox18.Visible = false;

            }
            if (int.Parse(textBox8.Text) == 9)
            {
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                label20.Visible = false;

                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                textBox15.Visible = true;
                textBox16.Visible = true;
                textBox17.Visible = true;
                textBox18.Visible = false;

            }
            if (int.Parse(textBox8.Text) == 10)
            {
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                label20.Visible = true;

                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                textBox15.Visible = true;
                textBox16.Visible = true;
                textBox17.Visible = true;
                textBox18.Visible = true;

            }
            if (int.Parse(textBox8.Text) <= 0 || int.Parse(textBox8.Text) >= 11)
            {
                MessageBox.Show("Грешно въведено число или стринг!", "Грешка!!!!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bool isChecked = false;
            foreach (Control control in panel1.Controls)
            {

                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    isChecked = true;

                }
            }
            string errors = "";
            //1,2,3,4,5
            foreach (Control controls in this.Controls)
            {
                if (controls is TextBox textBo && textBo.Visible)
                {
                    if (string.IsNullOrWhiteSpace(textBo.Text))
                    {
                        errors="Моля, въведете всички полета!!!! ВНИМАНИЕ";
                    }
                    else if (isChecked == false)
                    {
                       errors="Моля, въведете категория към рецептата!!!!ВНИМАНИЕ";
                    }



                }
            }
            if (string.IsNullOrWhiteSpace(errors))
            {


                string output = controllerRecipe.AddRecipe(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text), LoggedInUserId);
                if (output == "Успешно е добавена рецептата")
                {
                    MessageBox.Show("Успешно е добавена рецептата");
                    List<string> ingredients = textBox7.Text.Split(',').Select(i => i.Trim()).ToList();

                    string outputIng = ingredient.AddIfNess(ingredients);
                    if (outputIng == "Добавихте успешно продуктите")
                    {
                        MessageBox.Show("Добавихте успешно продуктите");
                        List<string> quantity = textBox6.Text.Split(',').Select(i => i.Trim()).ToList();
                        string outputAddIngRec = ingredientRecipe.AddRecIng(ingredients, quantity);
                        if (outputAddIngRec == "Успешно добавихте продуктите към рецептата")
                        {
                            MessageBox.Show("Успешно добавихте продуктите към рецептата");
                            string selectedRadioText = "";


                            foreach (Control control in panel1.Controls)
                            {

                                if (control is RadioButton radioButton && radioButton.Checked)
                                {

                                    selectedRadioText = radioButton.Text;
                                    break;
                                }
                            }
                            string outputCat = recipeCategory.AddRecipeToCategory(selectedRadioText);

                            MessageBox.Show(outputCat);
                            int n = int.Parse(textBox8.Text);
                            List<string> instructions = new List<string>();
                            for (int i = 9; i <= 8 + n; i++)
                            {
                                TextBox textBox = this.Controls["textBox" + i.ToString()] as TextBox;

                                if (textBox != null)
                                {
                                    instructions.Add(textBox.Text);
                                }
                            }
                            string outputInstr = instruction.AddInstructionOfRecipe(instructions);
                            if (outputInstr == "Добави инструкции успешно")
                            {
                                MessageBox.Show("Добави инструкции успешно");
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(errors);
            }
        }
            
        
    

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

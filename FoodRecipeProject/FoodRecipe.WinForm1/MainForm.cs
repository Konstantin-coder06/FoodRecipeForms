using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodRecipe.Core;
using FoodRecipe.Data.Entities;

namespace FoodRecipe.WinForm1
{
    public partial class MainForm : Form
    {
        public int LoggedInUserId { get; set; }
        public MainForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            button3.Visible = true;
            richTextBox1.ReadOnly = true;

        }
        ControllerRecipe recipe;
        private void MainForm_Load(object sender, EventArgs e)
        {
            recipe = new ControllerRecipe();
         

        }


        private void button3_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddRecipe addRecipe = new AddRecipe();
            addRecipe.LoggedInUserId = LoggedInUserId;
            addRecipe.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {


                string output = recipe.SearchByName(textBox1.Text);
                richTextBox1.Text = output;
                richTextBox1.Visible = true;
            }
            else
            {
                richTextBox1.Visible = true;
                richTextBox1.Text = "Празна е текстовата кутия";
            }
        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = recipe.Drinks();
            richTextBox1.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = recipe.Salads();
            richTextBox1.Visible = true;
            button12.Visible = true;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = recipe.Salads();
            richTextBox1.Visible = true;
            button12.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
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
          
            string recipesByCategory = recipe.SearchByCategoryWithoutIdWithInstructions(selectedRadioText);
            richTextBox1.Visible = true;
            richTextBox1.Text = recipesByCategory;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            button12.Visible = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = recipe.ShowAllRecipe();
            richTextBox1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Чакаме финансиране от Правителството, за да може да направим блога ни :(", "Съжаляваме");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact(this);
            this.Hide();
            contact.Show();
        }
    }
}

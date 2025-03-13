using System;
using System.Windows.Forms;
using YourNamespace;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Add initialization logic here
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the SetupAccountForm when "Join Now" is clicked
            SetupAccountForm setupAccountForm = new SetupAccountForm();
            setupAccountForm.ShowDialog();
        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the SignInForm when "Sign In" is clicked
            SignInForm signInForm = new SignInForm();
            signInForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculatorForm calculatorForm = new CalculatorForm();
            calculatorForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Open the SetupAccountForm when "Join Now" is clicked
            SetupAccountForm setupAccountForm = new SetupAccountForm();
            setupAccountForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open the SignInForm when "Sign In" is clicked
            SignInForm signInForm = new SignInForm();
            signInForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FoodTableForm foodTableForm = new FoodTableForm();
            foodTableForm.ShowDialog();

        }
    }
}

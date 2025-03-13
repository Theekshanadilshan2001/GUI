using System;
using System.Windows.Forms;

namespace YourNamespace
{
    public partial class ProfileForm : Form
    {
        private string username;
        private double previousWeight;
        private string userGoal;
        private int userTDEE;

        public ProfileForm(string username, string name, int tdee, string goal, double weight)
        {
            InitializeComponent();
            this.username = username;
            this.userTDEE = tdee;
            this.userGoal = goal;
            this.previousWeight = weight;

            lblName.Text = "Name: " + name;
            lblTDEE.Text = "TDEE: " + tdee.ToString();
            lblGoal.Text = "Goal: " + goal;
            lblWeight.Text = "Weight: " + weight.ToString() + " kg";

            GenerateAdvice(goal, weight);
        }

        private void GenerateAdvice(string goal, double weight)
        {
            lblAdvice.Text = "Eat according to your plan.";
        }

        private void btnUpdateWeight_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtWeight.Text, out double newWeight))
            {
                double weightDifference = newWeight - previousWeight;
                string advice = GetAdvice(weightDifference);

                if (DatabaseHelper.UpdateUserWeight(username, newWeight))
                {
                    lblWeight.Text = "Weight: " + newWeight.ToString() + " kg";
                    lblAdvice.Text = advice;

                    MessageBox.Show("Weight updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    previousWeight = newWeight;
                }
                else
                {
                    MessageBox.Show("Failed to update weight.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid weight value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetAdvice(double weightDifference)
        {
            if (userGoal == "Fat Loss")
            {
                if (weightDifference < 0.3) return "Eat the same amount of calories per day.";
                return "Please reduce 200kcal more.";
            }
            else if (userGoal == "Muscle Gain")
            {
                if (weightDifference < 0.2) return "Please eat 100 more calories per day.";
                return "Eat the same amount of calories per day.";
            }
            else if (userGoal == "Strength Training")
            {
                if (weightDifference < 0.5) return "Please eat 300 more calories per day.";
                return "Eat the same amount of calories per day.";
            }
            return "No advice available.";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
            this.Close();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }
    }
}

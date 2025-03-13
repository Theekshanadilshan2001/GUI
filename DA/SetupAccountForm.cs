using System;
using System.Windows.Forms;

namespace YourNamespace
{
    public partial class SetupAccountForm : Form
    {

        public SetupAccountForm()
        {
            InitializeComponent();
            LoadGoals();
        }

        private void LoadGoals()
        {
            cmbGoal.Items.Clear();
            cmbGoal.Items.Add("Muscle Build");
            cmbGoal.Items.Add("Fat Loss");
            cmbGoal.Items.Add("Strength Training");
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string name = txtName.Text.Trim();
            int tdee = int.Parse(txtTDEE.Text);
            string goal = cmbGoal.SelectedItem?.ToString().Trim();
            double weight = double.Parse(txtWeight.Text);

            if (DatabaseHelper.RegisterUser(username, password, name, tdee, goal, weight))
            {
                MessageBox.Show("Account created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to create account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbGoal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SetupAccountForm_Load(object sender, EventArgs e)
        {

        }
    }
}

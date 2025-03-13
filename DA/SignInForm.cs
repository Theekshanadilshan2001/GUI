using System;
using System.Windows.Forms;

namespace YourNamespace
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            try
            {
                using (var reader = DatabaseHelper.GetUserByUsername(username))
                {
                    if (reader.Read())
                    {
                        string storedPassword = reader["Password"].ToString();
                        if (storedPassword == password)
                        {
                            MessageBox.Show("Sign-in successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string name = reader["Name"].ToString();
                            int tdee = int.Parse(reader["TDEE"].ToString());
                            string goal = reader["Goal"].ToString();
                            double weight = double.Parse(reader["Weight"].ToString());

                            ProfileForm profileForm = new ProfileForm(username, name, tdee, goal, weight);
                            profileForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid password.", "Sign-In Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username not found.", "Sign-In Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

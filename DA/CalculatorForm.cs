using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            try
            {
                double height = Convert.ToDouble(txtHeight.Text) / 100; // Convert cm to meters
                double weight = Convert.ToDouble(txtWeight.Text);
                double bmi = weight / (height * height);
                lblBMIResult.Text = $"Your BMI: {bmi:F2}";
            }
            catch
            {
                MessageBox.Show("Please enter valid numeric values.");
            }
        }

        private void btnCalculateTDEE_Click(object sender, EventArgs e)
        {
            try
            {
                double weight = Convert.ToDouble(txtTDEEWeight.Text);
                double height = Convert.ToDouble(txtTDEEHeight.Text);
                int age = Convert.ToInt32(txtAge.Text);
                string activityLevel = cmbActivityLevel.SelectedItem.ToString();

                double bmr = (10 * weight) + (6.25 * height) - (5 * age) + 5;
                double tdeeMultiplier = activityLevel switch
                {
                    "Sedentary" => 1.2,
                    "Lightly Active" => 1.375,
                    "Moderately Active" => 1.55,
                    "Very Active" => 1.725,
                    "Super Active" => 1.9,
                    _ => 1.2
                };

                double tdee = bmr * tdeeMultiplier;
                lblTDEEResult.Text = $"Your TDEE: {tdee:F2} kcal";
            }
            catch
            {
                MessageBox.Show("Please enter valid numeric values.");
            }
        }

        private void btnCalculateBodyFat_Click(object sender, EventArgs e)
        {
            try
            {
                double neck = Convert.ToDouble(txtNeck.Text);
                double waist = Convert.ToDouble(txtWaist.Text);
                double hip = Convert.ToDouble(txtHip.Text);
                double bodyFatPercentage = ((waist + hip - neck) * 0.74) - 9; // Simplified calculation
                lblBodyFatResult.Text = $"Your Body Fat: {bodyFatPercentage:F2} %";
            }
            catch
            {
                MessageBox.Show("Please enter valid numeric values.");
            }
        }
    }
}

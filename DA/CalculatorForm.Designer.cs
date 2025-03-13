using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class CalculatorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Text = "Fitness Calculators";
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            AddControls();
        }

        private void AddControls()
        {
            // BMI Calculator Components
            Label lblBMI = new Label { Text = "BMI Calculator", Left = 20, Top = 20, Width = 200, ForeColor = Color.White };
            txtHeight = new TextBox { Left = 20, Top = 50, Width = 100, ForeColor = Color.Black, BackColor = Color.White, PlaceholderText = "Height (cm)" };
            txtWeight = new TextBox { Left = 20, Top = 80, Width = 100, ForeColor = Color.Black, BackColor = Color.White, PlaceholderText = "Weight (kg)" };
            btnCalculateBMI = new Button { Text = "Calculate BMI", Left = 20, Top = 110, Width = 120, BackColor = Color.White, ForeColor = Color.Black };
            lblBMIResult = new Label { Text = "Your BMI: -", Left = 20, Top = 140, Width = 200, ForeColor = Color.White };

            btnCalculateBMI.Click += new EventHandler(btnCalculateBMI_Click);

            // TDEE Calculator Components
            Label lblTDEE = new Label { Text = "TDEE Calculator", Left = 220, Top = 20, Width = 200, ForeColor = Color.White };
            txtTDEEWeight = new TextBox { Left = 220, Top = 50, Width = 100, ForeColor = Color.Black, BackColor = Color.White, PlaceholderText = "Weight (kg)" };
            txtTDEEHeight = new TextBox { Left = 220, Top = 80, Width = 100, ForeColor = Color.Black, BackColor = Color.White, PlaceholderText = "Height (cm)" };
            txtAge = new TextBox { Left = 220, Top = 110, Width = 100, ForeColor = Color.Black, BackColor = Color.White, PlaceholderText = "Age" };
            cmbActivityLevel = new ComboBox { Left = 220, Top = 140, Width = 120, ForeColor = Color.Black, BackColor = Color.White };
            cmbActivityLevel.Items.AddRange(new string[] { "Sedentary", "Lightly Active", "Moderately Active", "Very Active", "Super Active" });

            btnCalculateTDEE = new Button { Text = "Calculate TDEE", Left = 220, Top = 170, Width = 120, BackColor = Color.White, ForeColor = Color.Black };
            lblTDEEResult = new Label { Text = "Your TDEE: - kcal", Left = 220, Top = 200, Width = 200, ForeColor = Color.White };

            btnCalculateTDEE.Click += new EventHandler(btnCalculateTDEE_Click);

            // Body Fat Calculator Components
            Label lblBodyFat = new Label { Text = "Body Fat Percentage", Left = 420, Top = 20, Width = 200, ForeColor = Color.White };
            txtNeck = new TextBox { Left = 420, Top = 50, Width = 100, ForeColor = Color.Black, BackColor = Color.White, PlaceholderText = "Neck (cm)" };
            txtWaist = new TextBox { Left = 420, Top = 80, Width = 100, ForeColor = Color.Black, BackColor = Color.White, PlaceholderText = "Waist (cm)" };
            txtHip = new TextBox { Left = 420, Top = 110, Width = 100, ForeColor = Color.Black, BackColor = Color.White, PlaceholderText = "Hip (cm)" };
            btnCalculateBodyFat = new Button { Text = "Calculate Body Fat", Left = 420, Top = 140, Width = 140, BackColor = Color.White, ForeColor = Color.Black };
            lblBodyFatResult = new Label { Text = "Your Body Fat: - %", Left = 420, Top = 170, Width = 200, ForeColor = Color.White };

            btnCalculateBodyFat.Click += new EventHandler(btnCalculateBodyFat_Click);

            // Add Components to Form
            this.Controls.Add(lblBMI);
            this.Controls.Add(txtHeight);
            this.Controls.Add(txtWeight);
            this.Controls.Add(btnCalculateBMI);
            this.Controls.Add(lblBMIResult);

            this.Controls.Add(lblTDEE);
            this.Controls.Add(txtTDEEWeight);
            this.Controls.Add(txtTDEEHeight);
            this.Controls.Add(txtAge);
            this.Controls.Add(cmbActivityLevel);
            this.Controls.Add(btnCalculateTDEE);
            this.Controls.Add(lblTDEEResult);

            this.Controls.Add(lblBodyFat);
            this.Controls.Add(txtNeck);
            this.Controls.Add(txtWaist);
            this.Controls.Add(txtHip);
            this.Controls.Add(btnCalculateBodyFat);
            this.Controls.Add(lblBodyFatResult);
        }

        // Declare UI Elements
        private TextBox txtHeight, txtWeight, txtTDEEWeight, txtTDEEHeight, txtAge, txtNeck, txtWaist, txtHip;
        private Label lblBMIResult, lblTDEEResult, lblBodyFatResult;
        private Button btnCalculateBMI, btnCalculateTDEE, btnCalculateBodyFat;
        private ComboBox cmbActivityLevel;
    }
}

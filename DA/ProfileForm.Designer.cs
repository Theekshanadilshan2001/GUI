namespace YourNamespace
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            lblName = new Label();
            lblTDEE = new Label();
            lblGoal = new Label();
            lblWeight = new Label();
            txtWeight = new TextBox();
            btnUpdateWeight = new Button();
            lblAdvice = new Label();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(18, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 16);
            lblName.TabIndex = 0;
            lblName.Text = "Name: ";
            // 
            // lblTDEE
            // 
            lblTDEE.AutoSize = true;
            lblTDEE.BackColor = Color.Transparent;
            lblTDEE.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblTDEE.ForeColor = Color.White;
            lblTDEE.Location = new Point(17, 47);
            lblTDEE.Name = "lblTDEE";
            lblTDEE.Size = new Size(51, 16);
            lblTDEE.TabIndex = 1;
            lblTDEE.Text = "TDEE: ";
            // 
            // lblGoal
            // 
            lblGoal.AutoSize = true;
            lblGoal.BackColor = Color.Transparent;
            lblGoal.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblGoal.ForeColor = Color.White;
            lblGoal.Location = new Point(18, 75);
            lblGoal.Name = "lblGoal";
            lblGoal.Size = new Size(47, 16);
            lblGoal.TabIndex = 2;
            lblGoal.Text = "Goal: ";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.BackColor = Color.Transparent;
            lblWeight.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblWeight.ForeColor = Color.White;
            lblWeight.Location = new Point(18, 103);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(64, 16);
            lblWeight.TabIndex = 3;
            lblWeight.Text = "Weight: ";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(131, 103);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(88, 23);
            txtWeight.TabIndex = 4;
            // 
            // btnUpdateWeight
            // 
            btnUpdateWeight.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnUpdateWeight.Location = new Point(236, 101);
            btnUpdateWeight.Name = "btnUpdateWeight";
            btnUpdateWeight.Size = new Size(88, 28);
            btnUpdateWeight.TabIndex = 5;
            btnUpdateWeight.Text = "Update";
            btnUpdateWeight.UseVisualStyleBackColor = true;
            btnUpdateWeight.Click += btnUpdateWeight_Click;
            // 
            // lblAdvice
            // 
            lblAdvice.AutoSize = true;
            lblAdvice.BackColor = Color.Transparent;
            lblAdvice.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblAdvice.ForeColor = Color.White;
            lblAdvice.Location = new Point(18, 141);
            lblAdvice.Name = "lblAdvice";
            lblAdvice.Size = new Size(63, 16);
            lblAdvice.TabIndex = 6;
            lblAdvice.Text = "Advice: ";
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnLogout.Location = new Point(18, 188);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(88, 28);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(391, 334);
            Controls.Add(lblName);
            Controls.Add(lblTDEE);
            Controls.Add(lblGoal);
            Controls.Add(lblWeight);
            Controls.Add(txtWeight);
            Controls.Add(btnUpdateWeight);
            Controls.Add(lblAdvice);
            Controls.Add(btnLogout);
            Name = "ProfileForm";
            Text = "Profile";
            Load += ProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTDEE;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnUpdateWeight;
        private System.Windows.Forms.Label lblAdvice;
        private System.Windows.Forms.Button btnLogout;
    }
}

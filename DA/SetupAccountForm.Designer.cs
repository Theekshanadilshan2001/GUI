namespace YourNamespace
{
    partial class SetupAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupAccountForm));
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblTDEE = new Label();
            txtTDEE = new TextBox();
            lblGoal = new Label();
            cmbGoal = new ComboBox();
            lblWeight = new Label();
            txtWeight = new TextBox();
            btnCreateAccount = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = SystemColors.ActiveCaptionText;
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(18, 19);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(131, 19);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(176, 23);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = SystemColors.ActiveCaptionText;
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(18, 56);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(131, 56);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(176, 23);
            txtPassword.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.ActiveCaptionText;
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(18, 94);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 15);
            lblName.TabIndex = 4;
            lblName.Text = "Full Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 94);
            txtName.Name = "txtName";
            txtName.Size = new Size(176, 23);
            txtName.TabIndex = 5;
            // 
            // lblTDEE
            // 
            lblTDEE.AutoSize = true;
            lblTDEE.BackColor = SystemColors.ActiveCaptionText;
            lblTDEE.ForeColor = Color.White;
            lblTDEE.Location = new Point(18, 131);
            lblTDEE.Name = "lblTDEE";
            lblTDEE.Size = new Size(37, 15);
            lblTDEE.TabIndex = 6;
            lblTDEE.Text = "TDEE:";
            // 
            // txtTDEE
            // 
            txtTDEE.Location = new Point(131, 131);
            txtTDEE.Name = "txtTDEE";
            txtTDEE.Size = new Size(88, 23);
            txtTDEE.TabIndex = 7;
            // 
            // lblGoal
            // 
            lblGoal.AutoSize = true;
            lblGoal.BackColor = SystemColors.ActiveCaptionText;
            lblGoal.ForeColor = Color.White;
            lblGoal.Location = new Point(18, 169);
            lblGoal.Name = "lblGoal";
            lblGoal.Size = new Size(68, 15);
            lblGoal.TabIndex = 8;
            lblGoal.Text = "Select Goal:";
            // 
            // cmbGoal
            // 
            cmbGoal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGoal.Location = new Point(131, 169);
            cmbGoal.Name = "cmbGoal";
            cmbGoal.Size = new Size(176, 23);
            cmbGoal.TabIndex = 9;
            cmbGoal.SelectedIndexChanged += cmbGoal_SelectedIndexChanged;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.BackColor = SystemColors.ActiveCaptionText;
            lblWeight.ForeColor = Color.White;
            lblWeight.Location = new Point(18, 206);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(72, 15);
            lblWeight.TabIndex = 10;
            lblWeight.Text = "Weight (kg):";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(131, 206);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(88, 23);
            txtWeight.TabIndex = 11;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(88, 244);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(131, 28);
            btnCreateAccount.TabIndex = 12;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // SetupAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(350, 300);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblTDEE);
            Controls.Add(txtTDEE);
            Controls.Add(lblGoal);
            Controls.Add(cmbGoal);
            Controls.Add(lblWeight);
            Controls.Add(txtWeight);
            Controls.Add(btnCreateAccount);
            ForeColor = Color.White;
            Name = "SetupAccountForm";
            Text = "Setup Account";
            Load += SetupAccountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTDEE;
        private System.Windows.Forms.TextBox txtTDEE;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.ComboBox cmbGoal;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnCreateAccount;
    }
}

namespace WinFormsApp1
{
    partial class FoodTableForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvFoodTable;
        private System.Windows.Forms.Button btnBack;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodTableForm));
            dgvFoodTable = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFoodTable).BeginInit();
            SuspendLayout();
            // 
            // dgvFoodTable
            // 
            dgvFoodTable.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvFoodTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoodTable.Location = new Point(20, 20);
            dgvFoodTable.Name = "dgvFoodTable";
            dgvFoodTable.Size = new Size(361, 400);
            dgvFoodTable.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(163, 438);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 30);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // FoodTableForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(407, 480);
            Controls.Add(dgvFoodTable);
            Controls.Add(btnBack);
            Name = "FoodTableForm";
            Text = "Food Table";
            ((System.ComponentModel.ISupportInitialize)dgvFoodTable).EndInit();
            ResumeLayout(false);
        }
    }
}

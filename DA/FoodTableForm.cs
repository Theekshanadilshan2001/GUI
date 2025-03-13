using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FoodTableForm : Form
    {
        public FoodTableForm()
        {
            InitializeComponent();
            LoadFoodData();
        }

        private void LoadFoodData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Food Item", typeof(string));
            table.Columns.Add("Calories", typeof(int));
            table.Columns.Add("Protein (g)", typeof(double));

            List<(string food, int calories, double protein)> foodList = new List<(string, int, double)>
            {
                ("Chicken Breast", 165, 31),
                ("Salmon", 206, 22),
                ("Eggs", 155, 13),
                ("Tofu", 76, 8),
                ("Lentils", 116, 9),
                ("Greek Yogurt", 100, 10),
                ("Almonds", 579, 21),
                ("Brown Rice", 111, 2.6),
                ("Oats", 389, 17),
                ("Cottage Cheese", 98, 11),
                ("Quinoa", 120, 4),
                ("Milk", 42, 3.4),
                ("Beef", 250, 26),
                ("Tuna", 132, 29),
                ("Turkey", 135, 30),
                ("Peanuts", 567, 25),
                ("Chickpeas", 164, 9),
                ("Shrimp", 99, 24),
                ("Whey Protein", 120, 24),
                ("Soybeans", 172, 18),
                ("Spinach", 23, 2.9),
                ("Broccoli", 55, 4),
                ("Pork", 242, 27),
                ("Cheese", 402, 25),
                ("Pumpkin Seeds", 446, 19),
                ("Chia Seeds", 486, 16),
                ("Sunflower Seeds", 584, 21),
                ("Cashews", 553, 18),
                ("Walnuts", 654, 15),
                ("Pistachios", 562, 20),
                ("Hazelnuts", 628, 15),
                ("Flaxseeds", 534, 18),
                ("Mushrooms", 22, 3),
                ("Cucumber", 16, 0.6),
                ("Carrots", 41, 0.9),
                ("Sweet Potatoes", 86, 2),
                ("Avocado", 160, 2),
                ("Peas", 81, 5),
                ("Brussels Sprouts", 43, 3.4),
                ("Kale", 49, 4.3),
                ("Zucchini", 17, 1.2),
                ("Asparagus", 20, 2.2),
                ("Cabbage", 25, 1.3),
                ("Lettuce", 15, 1.4),
                ("Tomatoes", 18, 0.9),
                ("Coconut", 354, 3.3),
                ("Blueberries", 57, 0.7),
                ("Strawberries", 32, 0.7),
                ("Oranges", 47, 0.9),
                ("Apples", 52, 0.3)
            };

            foreach (var (food, calories, protein) in foodList)
            {
                table.Rows.Add(food, calories, protein);
            }

            dgvFoodTable.DataSource = table;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

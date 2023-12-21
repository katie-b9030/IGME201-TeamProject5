using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wrkFloMealPlanner
{
    public partial class Form1 : Form
    {
        public DataTable recipesTable;
        public Dictionary<string, string> recipes = new Dictionary<string, string>();
        private Dictionary<DateTime, MealPlan> mealsDictionary = new Dictionary<DateTime, MealPlan>();


        public Form1()
        {
            InitializeComponent();
            

            recipes.Add("Honey Garlic Chicken", "https://www.recipetineats.com/honey-garlic-chicken/");
            recipes.Add("Mini Chocolate Cakes", "https://www.recipetineats.com/mini-chocolate-cakes/");
            recipes.Add("Lamb Souvlaki", "https://www.recipetineats.com/lamb-souvlaki/");

            InitializeRecipesTable();

            mealsDictionary.Add(new DateTime(2000, 1, 1), new MealPlan(new DateTime(2000, 1, 1)));
          
            recipeDataGridView.DataSource = recipesTable;
            recipeDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            newItemButton.Click += new EventHandler(NewItemButton__Click);
            recipeDataGridView.CellClick += new DataGridViewCellEventHandler(RecipeDataGridView_CellClick);

            enterDateButton.Click += new EventHandler(EnterDateButton__Click);

            breakfastButton.Click += new EventHandler(BreakfastButton__Click);
            lunchButton.Click += new EventHandler(LunchButton__Click);
            dinnerButton.Click += new EventHandler(DinnerButton__Click);

            breakfastLabel.Click += new EventHandler(BreakfastLabel__Click);
            lunchLabel.Click += new EventHandler(LunchLabel__Click);
            dinnerLabel.Click += new EventHandler(DinnerLabel__Click);
        }

        private void InitializeRecipesTable()
        {
            recipesTable = new DataTable();
            recipesTable.Columns.Add("RecipeName", typeof(string));
            
            foreach (string recipe in recipes.Keys)
            {
                recipesTable.Rows.Add(recipe);
            }
            
        }

        private void NewItemButton__Click(object sender, EventArgs e)
        {
            Form2 newItemForm = new Form2(ref shoppingListCheckedListBox);
            newItemForm.ShowDialog();
        }

        private void RecipeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is clicked
            if (e.RowIndex >= 0 && e.RowIndex < recipesTable.Rows.Count)
            {
                //Get cell
                DataGridViewCell cell = (DataGridViewCell) recipeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                
                // Open the URL in the WebBrowser control
                Form3 recipeWebsite = new Form3((string)cell.Value, recipes[(string)cell.Value]);
                recipeWebsite.ShowDialog();
            }
        }

        

        private void EnterDateButton__Click(object sender, EventArgs e)
        {
            
            DateTime date = dateTimePicker.Value;

            dateLabel.Text = date.ToShortDateString();

            if (mealsDictionary.ContainsKey(date))
            {
                Update_Meals(mealsDictionary[date]);
            }
            else
            {
                MealPlan plan = new MealPlan(date);
                mealsDictionary.Add(date, plan);
                Update_Meals(plan);
            }

            
        }

        private void BreakfastButton__Click(object sender, EventArgs e)
        {
            Form4 newMealForm = new Form4(mealsDictionary[dateTimePicker.Value], ref breakfastLabel, MealType.Breakfast);
            newMealForm.ShowDialog();
        }

        private void LunchButton__Click(object sender, EventArgs e)
        {
            Form4 newMealForm = new Form4(mealsDictionary[dateTimePicker.Value], ref lunchLabel, MealType.Lunch);
            newMealForm.ShowDialog();
        }

        private void DinnerButton__Click(object sender, EventArgs e)
        {
            Form4 newMealForm = new Form4(mealsDictionary[dateTimePicker.Value], ref dinnerLabel, MealType.Dinner);
            newMealForm.ShowDialog();
        }

        public void Update_Meals(MealPlan plan)
        {
            breakfastLabel.Text = plan.GetMeal(MealType.Breakfast);
            lunchLabel.Text = plan.GetMeal(MealType.Lunch);
            dinnerLabel.Text = plan.GetMeal(MealType.Dinner);
            
        }

       /*
        private void BreakfastLabel__TextChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            MealPlan plan = mealsDictionary[date];

            if (plan.GetMealURL(MealType.Breakfast) != null)
            {
                breakfastLabel.Click += new EventHandler(BreakfastLabel__Click);
            }
            else
            {
                breakfastLabel.Click -= new EventHandler(BreakfastLabel__Click);
            }
        }

        private void LunchLabel__TextChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            MealPlan plan = mealsDictionary[date];

            if (plan.GetMealURL(MealType.Lunch) != null)
            {
                lunchLabel.Click += new EventHandler(LunchLabel__TextChanged);
            }
            else
            {
                lunchLabel.Click -= new EventHandler(LunchLabel__TextChanged);
            }
        }

        private void DinnerLabel__TextChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            MealPlan plan = mealsDictionary[date];

            if (plan.GetMealURL(MealType.Dinner) != null)
            {
                dinnerLabel.Click += new EventHandler(DinnerLabel__TextChanged);
            }
            else
            {
                dinnerLabel.Click -= new EventHandler(DinnerLabel__TextChanged);
            }
        }
       */

        private void BreakfastLabel__Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            MealPlan plan = mealsDictionary[date];

            if (plan.GetMealURL(MealType.Breakfast) != null)
            {
                try
                {
                    Form3 recipeWebsite = new Form3(breakfastLabel.Text, mealsDictionary[date].GetMealURL(MealType.Breakfast));
                    recipeWebsite.ShowDialog();
                }
                catch { }

            }
        }

        private void LunchLabel__Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            MealPlan plan = mealsDictionary[date];

            if (plan.GetMealURL(MealType.Lunch) != null)
            {
                try
                {
                    Form3 recipeWebsite = new Form3(lunchLabel.Text, mealsDictionary[date].GetMealURL(MealType.Lunch));
                    recipeWebsite.ShowDialog();
                }
                catch { }

            }
        }

        private void DinnerLabel__Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            MealPlan plan = mealsDictionary[date];

            if (plan.GetMealURL(MealType.Dinner) != null)
            {
                try
                {
                    Form3 recipeWebsite = new Form3(dinnerLabel.Text, mealsDictionary[date].GetMealURL(MealType.Dinner));
                    recipeWebsite.ShowDialog();
                } catch { }
                
            }
            
        }
    }
}

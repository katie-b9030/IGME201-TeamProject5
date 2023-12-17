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


        public Form1()
        {
            InitializeComponent();
            

            recipes.Add("Honey Garlic Chicken", "https://www.recipetineats.com/honey-garlic-chicken/");
            recipes.Add("Mini Chocolate Cakes", "https://www.recipetineats.com/mini-chocolate-cakes/");
            recipes.Add("Lamb Souvlaki", "https://www.recipetineats.com/lamb-souvlaki/");

            InitializeRecipesTable();

            recipeDataGridView.DataSource = recipesTable;
            recipeDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            newItemButton.Click += new EventHandler(NewItemButton__Click);
            recipeDataGridView.CellClick += new DataGridViewCellEventHandler(RecipeDataGridView_CellClick);
        }

        private void InitializeRecipesTable()
        {
            // Create a DataTable with columns for your recipes
            recipesTable = new DataTable();
            recipesTable.Columns.Add("RecipeName", typeof(string));
            

            // Add some sample data (replace this with your actual data)
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
                // Get the URL from the selected row
                //string url = recipesTable.Rows[e.RowIndex]["URL"].ToString();

                DataGridViewCell cell = (DataGridViewCell) recipeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                
                // Open the URL in the WebBrowser control
                Form3 recipeWebsite = new Form3((string)cell.Value, recipes[(string)cell.Value]);
                recipeWebsite.ShowDialog();
            }
        }


    }
}

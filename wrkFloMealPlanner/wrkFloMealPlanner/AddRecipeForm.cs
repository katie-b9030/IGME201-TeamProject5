using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wrkFloMealPlanner
{
    public partial class AddRecipeForm : Form
    {
        private Dictionary<string, string> recipes;
        private DataGridView recipeDataGridView;
        private DataTable recipesTable; 
        //This form is created to take information to add a new recipe to the recipe list
        public AddRecipeForm(ref Dictionary<string, string> recipes, ref DataGridView recipeDataGridView, ref DataTable recipesTable)
        {
            InitializeComponent();
            
            this.recipes = recipes;
            this.recipeDataGridView = recipeDataGridView;
            this.recipesTable = recipesTable;

            enterButton.Click += new EventHandler(EnterButton__Click);
            cancelButton.Click += new EventHandler(CancelButton__Click);

        }

        //Closes the form and adds recipe to the list
        private void EnterButton__Click(object sender, EventArgs e)
        {
            recipes.Add(nameTextBox.Text, urlTextBox.Text);
            recipesTable.Rows.Add(nameTextBox.Text);

            recipeDataGridView.Update();
            recipeDataGridView.Refresh();

            this.enterButton.DialogResult = DialogResult.OK;
            this.Close();

        }

        //Closes the form
        private void CancelButton__Click(object sender, EventArgs e)
        {
            this.cancelButton.DialogResult = DialogResult.Cancel;
        }

    }
}

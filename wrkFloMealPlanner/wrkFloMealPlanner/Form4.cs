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
	public partial class Form4 : Form
	{
		private MealPlan mealPlan;
		private Label label;
		private MealType mealType;
        private Button button;
		//This form is created to take information to add a meal to the meal planner.
        public Form4(MealPlan mealPlan, ref Label label, MealType mealType)
		{
			InitializeComponent();

			this.mealPlan = mealPlan;
			this.label = label;
			this.mealType = mealType;
			this.button = button;

			enterButton.Click += new EventHandler(EnterButton__Click);
			cancelButton.Click += new EventHandler(CancelButton__Click);

		}
        //Closes the form and updates the meal and url into the planner
        private void EnterButton__Click(object sender, EventArgs e)
		{
			
			mealPlan.AddMeal(mealType, nameTextBox.Text, urlTextBox.Text);
			label.Text = nameTextBox.Text;
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

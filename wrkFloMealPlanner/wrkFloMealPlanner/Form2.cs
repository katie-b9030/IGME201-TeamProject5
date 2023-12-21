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
    //This form is made to add an item to the shopping list
    public partial class Form2 : Form
    {
        private CheckedListBox shoppingList;
        //Constructor, takes a reference to a CheckedListBox (the shopping list)
        public Form2(ref CheckedListBox shoppingList)
        {
            InitializeComponent();

            this.shoppingList = shoppingList;

            enterButton.Click += new EventHandler(EnterButton__Click);
            cancelButton.Click += new EventHandler(CancelButton__Click);

        }
        //Closes the form and adds the new item to the shopping list on main form
        private void EnterButton__Click(object sender, EventArgs e)
        {
            shoppingList.Items.Add(newItemTextBox.Text);
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

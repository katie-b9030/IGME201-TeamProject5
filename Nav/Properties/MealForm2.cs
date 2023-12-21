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
    public partial class Form2 : Form
    {
        private CheckedListBox shoppingList;
        public Form2(ref CheckedListBox shoppingList)
        {
            InitializeComponent();

            this.shoppingList = shoppingList;

            enterButton.Click += new EventHandler(EnterButton__Click);
            cancelButton.Click += new EventHandler(CancelButton__Click);

        }

        private void EnterButton__Click(object sender, EventArgs e)
        {
            shoppingList.Items.Add(newItemTextBox.Text);
            this.enterButton.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void CancelButton__Click(object sender, EventArgs e)
        {
            this.cancelButton.DialogResult = DialogResult.Cancel;
        }
    }
}

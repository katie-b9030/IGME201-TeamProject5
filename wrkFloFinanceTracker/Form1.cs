using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Katiya
//Katie
//Brevin
//Laila
// Ethan 
namespace wrkFloFinanceTracker
{
    public partial class FinanceTracker : Form
    {
        Options child;

        int savingGoal;
        int spendingLimit;
        string transactionTitle;
        double transactionAmount;
        DateTime transactionDate;
        string transactionTags;
        bool transactionIsSaving;

        public FinanceTracker()
        {
            InitializeComponent();

            addButton.Enabled = true;
            addButton.Click += new EventHandler(AddButton__Click);
        }

        private void AddButton__Click(object sender, EventArgs e)
        {
            child = new Options(this);
            child.ShowDialog();

            if (child.savingGoal != 0)
            {
                this.savingGoal = child.savingGoal;
                savingsProgressBar.Maximum = savingGoal;
            }
            else if (child.spendingLimit != 0)
            {
                this.spendingLimit = child.spendingLimit;
                spendingProgressBar.Maximum = spendingLimit;
            }
            else if (child.transactionTitle != null)
            {
                this.transactionTitle = child.transactionTitle;
                this.transactionAmount = child.transactionAmount;
                this.transactionDate = child.transactionDate;
                this.transactionTags = child.transactionTags;
                this.transactionIsSaving = child.transactionIsSaving;

                KeyValuePair<string, string> keyValuePairs = new KeyValuePair<string, string>();
                PaintListView(keyValuePairs);

                if (this.transactionIsSaving )
                {
                    savingsProgressBar.Value += (int)transactionAmount;
                }
                else
                {
                    spendingProgressBar.Value += (int)transactionAmount;
                }
            }

            spentLabel.Text = "$" + spendingProgressBar.Value + " /" + " $" + spendingProgressBar.Maximum;
            savedLabel.Text = "$" + savingsProgressBar.Value + " /" + " $" + savingsProgressBar.Maximum;
        }

        private void PaintListView(KeyValuePair<string, string> keyValuePairs)
        {

        }
    }
}

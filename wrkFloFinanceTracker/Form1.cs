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
    /* Class: FinanceTracker
     * Author: Katie Bogart
     * Purpose: creates the main finance tracker form
     * Restrictions: None
     */
    public partial class FinanceTracker : Form
    {
        Options child;

        int savingGoal;
        int amtSaved;
        int netWorth = 0;
        int spendingLimit;
        int amtSpent;
        string transactionTitle;
        double transactionAmount;
        DateTime transactionDate;
        string transactionTags;
        bool transactionIsSaving;
        ListViewItem firstLVI;
        int lviCntr = 0;

        /* Method: FinanceTracker
         * Purpose: enable add button
         *          disable remove button
         *          add event handlers
         * Restrictions: None
         */
        public FinanceTracker()
        {
            InitializeComponent();

            addButton.Enabled = true;
            removeButton.Enabled = false;
            addButton.Click += new EventHandler(AddButton__Click);
            removeButton.Click += new EventHandler(RemoveButton__Click);
        }

        /* Method: AddButton__Click
         * Purpose: opens an instance of Options
         *          checks to see which value was inputted
         *          sets variable data accordingly
         *          populates form with relevant data
         * Restrictions: None
         */
        private void AddButton__Click(object sender, EventArgs e)
        {
            // create child
            child = new Options(this);
            child.ShowDialog();

            // check if saving goal was inputted
            if (child.savingGoal != 0)
            {
                this.savingGoal = child.savingGoal;
                savingsProgressBar.Maximum = savingGoal;
                // update progress bar
                if (this.amtSaved < this.savingGoal)
                {
                    savingsProgressBar.Value += amtSaved;
                }
                else
                {
                    savingsProgressBar.Value = savingGoal;
                }
            }
            // check if spending limit was inputted
            else if (child.spendingLimit != 0)
            {
                this.spendingLimit = child.spendingLimit;
                spendingProgressBar.Maximum = spendingLimit;
                // update progress bar
                if (this.amtSpent < this.spendingLimit)
                {
                    spendingProgressBar.Value += amtSpent;
                }
                else
                {
                    spendingProgressBar.Value = spendingLimit;
                }
            }
            // check if transaction was inputted
            else if (child.transactionTitle != null)
            {
                // pull values
                this.transactionTitle = child.transactionTitle;
                this.transactionAmount = child.transactionAmount;
                this.transactionDate = child.transactionDate;
                this.transactionTags = child.transactionTags;
                this.transactionIsSaving = child.transactionIsSaving;

                // create list to populate ListView
                SortedList<string, object> transactionKVP = new SortedList<string, object>();
                KeyValuePair<string, object> keyValuePair = new KeyValuePair<string, object>("Title", transactionTitle);
                transactionKVP.Add(keyValuePair.Key, keyValuePair.Value);
                keyValuePair = new KeyValuePair<string, object>("Amount", transactionAmount);
                transactionKVP.Add(keyValuePair.Key, keyValuePair.Value);
                keyValuePair = new KeyValuePair<string, object>("Date", transactionDate);
                transactionKVP.Add(keyValuePair.Key, keyValuePair.Value);
                keyValuePair = new KeyValuePair<string, object>("Tags", transactionTags);
                transactionKVP.Add(keyValuePair.Key, keyValuePair.Value);
                PaintListView(transactionKVP);

                // update relevant progress bar
                if (this.transactionIsSaving)
                {
                    amtSaved += (int)transactionAmount;
                    if (this.amtSaved < this.savingGoal)
                    {
                        savingsProgressBar.Value = amtSaved;
                    }
                    else
                    {
                        savingsProgressBar.Value = savingGoal;
                    }
                }
                else
                {
                    amtSpent += (int)transactionAmount;
                    if (this.amtSpent < this.spendingLimit)
                    {
                        spendingProgressBar.Value = amtSpent;
                    }
                    else
                    {
                        spendingProgressBar.Value = spendingLimit;
                    }
                }
                // update net worth
                netWorth = amtSaved - amtSpent;
                // allow transaction to be removed
                removeButton.Enabled = true;
            }
            // update labels
            spentLabel.Text = "$" + amtSpent + " /" + " $" + spendingLimit;
            savedLabel.Text = "$" + amtSaved + " /" + " $" + savingGoal;
            netWorthLabel.Text = "$" + netWorth;
        }

        /* Method: RemoveButton__Click
         * Purpose: remove most recent entry in listview
         *          update labels
         * Restrictions: None
         */
        private void RemoveButton__Click(object sender, EventArgs e)
        {
            // get index amount and type
            int toRemove = financesListView.Items.Count - 1;
            int amount = (int)Double.Parse(financesListView.Items[toRemove].SubItems[1].Text);
            string type = financesListView.Items[toRemove].SubItems[3].Text;
            // update labels based on type
            if (type.Contains("spent"))
            {
                amtSpent -= amount;
                spentLabel.Text = "$" + amtSpent + " /" + " $" + spendingLimit;
                // update progress bar
                if (this.amtSpent < this.spendingLimit)
                {
                    spendingProgressBar.Value = amtSpent;
                }
                else
                {
                    spendingProgressBar.Value = spendingLimit;
                }
                // add to net worth if spent
                netWorth += amount;
            }
            else if (type.Contains("saved"))
            {
                amtSaved -= amount;
                savedLabel.Text = "$" + amtSaved + " /" + " $" + savingGoal;
                // update progress bar
                if (this.amtSaved < this.savingGoal)
                {
                    savingsProgressBar.Value = amtSaved;
                }
                else
                {
                    savingsProgressBar.Value = savingGoal;
                }
                // remove from net worth if saved
                netWorth -= amount;
            }
            // update net worth label
            netWorthLabel.Text = "$" + netWorth;
            // remove item
            financesListView.Items.RemoveAt(toRemove);
            // disable button if there is nothing in listview to remove
            if (financesListView.Items.Count == 0 )
            {
                removeButton.Enabled = false;
            
            }
        }

        /* Method: PaintListView
         * Purpose: use list to add values to listview
         * Restrictions: None
         */
        private void PaintListView(SortedList<string, object> keyValuePairs)
        {
            ListViewItem lvi = null;
            ListViewItem.ListViewSubItem lvsi = null;

            // check if list has values
            if (keyValuePairs != null)
            {
                // set item (and first column
                lvi = new ListViewItem();
                lvi.Text = keyValuePairs["Title"].ToString();
                lvi.Tag = keyValuePairs["Title"].ToString();

                // color code
                if (lviCntr % 2 == 0)
                {
                    lvi.BackColor = ColorTranslator.FromHtml("#cff5ff");
                }
                else
                {
                    lvi.BackColor = Color.White;
                }

                // add subitems
                foreach (KeyValuePair<string, object> keyValuePair in keyValuePairs)
                {
                    string key = keyValuePair.Key;
                    object value = keyValuePair.Value;

                    if (key == "Title")
                    {
                        continue;
                    }
                    else
                    {
                        lvsi = new ListViewItem.ListViewSubItem();
                        lvsi.Text = value.ToString();
                        if (key == "Tags")
                        {
                            if (transactionIsSaving)
                            {
                                lvsi.Text += ", saved";
                            }
                            else
                            {
                                lvsi.Text += ", spent";
                            }
                        }
                        lvi.SubItems.Add(lvsi);
                    }
                    // select first
                    if (lviCntr == 0)
                    {
                        lvi.Selected = true;
                        lvi.Focused = true;
                        firstLVI = lvi;
                    }
                }
                // add item
                financesListView.Items.Add(lvi);
                lviCntr++;
                this.financesListView.EndUpdate();
                financesListView.TopItem = firstLVI;
                financesListView.Refresh();
            }
        }
    }
}

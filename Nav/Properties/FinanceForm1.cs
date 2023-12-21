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
        int amtSaved;
        int spendingLimit;
        int amtSpent;
        string transactionTitle;
        double transactionAmount;
        DateTime transactionDate;
        string transactionTags;
        bool transactionIsSaving;
        ListViewItem firstLVI;
        int lviCntr = 0;

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

                if (this.transactionIsSaving)
                {
                    amtSaved += (int)transactionAmount;
                }
                else
                {
                    amtSpent += (int)transactionAmount;
                }
            }
            if (this.amtSaved < this.savingGoal)
            {
                savingsProgressBar.Value += amtSaved;
            }
            else
            {
                savingsProgressBar.Value = savingGoal;
            }
            if (this.amtSpent < this.spendingLimit)
            {
                spendingProgressBar.Value += amtSpent;
            }
            else
            {
                spendingProgressBar.Value = spendingLimit;
            }

            spentLabel.Text = "$" + amtSpent + " /" + " $" + spendingLimit;
            savedLabel.Text = "$" + amtSaved + " /" + " $" + savingGoal;
        }

        private void PaintListView(SortedList<string, object> keyValuePairs)
        {
            ListViewItem lvi = null;
            ListViewItem.ListViewSubItem lvsi = null;

            if (keyValuePairs != null)
            {
                lvi = new ListViewItem();
                lvi.Text = keyValuePairs["Title"].ToString();
                lvi.Tag = keyValuePairs["Title"].ToString();

                if (lviCntr % 2 == 0)
                {
                    lvi.BackColor = ColorTranslator.FromHtml("#cff5ff");
                }
                else
                {
                    lvi.BackColor = Color.White;
                }
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
                    if (lviCntr == 0)
                    {
                        lvi.Selected = true;
                        lvi.Focused = true;
                        firstLVI = lvi;
                    }
                }
                financesListView.Items.Add(lvi);
                lviCntr++;
                this.financesListView.EndUpdate();
                financesListView.TopItem = firstLVI;
                financesListView.Refresh();
            }
        }
    }
}

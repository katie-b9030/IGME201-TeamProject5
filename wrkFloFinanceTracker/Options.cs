using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wrkFloFinanceTracker
{
    public partial class Options : Form
    {
        Form parent;

        public int savingGoal = 0;
        public int spendingLimit = 0;
        public string transactionTitle;
        public double transactionAmount;
        public DateTime transactionDate;
        public string transactionTags;
        public bool transactionIsSaving;

        RadioButton transactionType;

        public Options(Form parent)
        {
            InitializeComponent();

            this.parent = parent;
            parent.Enabled = false;

            savingPanel.Visible = false;
            spendingPanel.Visible = false;
            transactionPanel.Visible = false;
            addButton.Enabled = false;
            dateTextBox.Text = DateTime.Now.ToShortDateString();

            savingRadioButton.Click += new EventHandler(RadioButton__Click);
            spendingRadioButton.Click += new EventHandler(RadioButton__Click);
            transactionRadioButton.Click += new EventHandler(RadioButton__Click);

            savingGoalTextBox.KeyPress += new KeyPressEventHandler(SavingGoalTextBox__KeyPress);

            spendingLimitTextBox.KeyPress += new KeyPressEventHandler(SpendingLimitTextBox__KeyPress);

            titleTextBox.KeyPress += new KeyPressEventHandler(TitleTextBox__KeyPress);
            amountTextBox.KeyPress += new KeyPressEventHandler(AmountTextBox__KeyPress);
            dateTextBox.KeyPress += new KeyPressEventHandler(DateTextBox__KeyPress);
            tagsTextBox.KeyPress += new KeyPressEventHandler(TagsTextBox__KeyPress);
            savTransRadioButton.Click += new EventHandler(TransRadioButton__Click);
            spdTransRadioButton.Click += new EventHandler(TransRadioButton__Click);

            addButton.Click += new EventHandler(AddButton__Click);
            cancelButton.Click += new EventHandler(CancelButton__Click);
        }

        private void RadioButton__Click(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb == savingRadioButton)
            {
                savingPanel.Visible = true;
                spendingPanel.Visible = false;
                transactionPanel.Visible = false;
            }
            else if (rb == spendingRadioButton)
            {
                spendingPanel.Visible = true;
                transactionPanel.Visible = false;
                savingPanel.Visible = false;
            }
            else
            {
                transactionPanel.Visible = true;
                spendingPanel.Visible = false;
                savingPanel.Visible = false;
            }
        }

        private void SavingGoalTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            if (!string.IsNullOrEmpty(savingGoalTextBox.Text))
            {
                addButton.Enabled = true;
            }
        }

        private void SpendingLimitTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            if (!string.IsNullOrEmpty(spendingLimitTextBox.Text))
            {
                addButton.Enabled = true;
            }
        }

        private void TitleTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(titleTextBox.Text) && !string.IsNullOrWhiteSpace(amountTextBox.Text) && !string.IsNullOrWhiteSpace(dateTextBox.Text) && !string.IsNullOrWhiteSpace(tagsTextBox.Text) && (savTransRadioButton.Checked || spdTransRadioButton.Checked))
            {
                addButton.Enabled = true;
            }
        }

        private void AmountTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            if (!string.IsNullOrWhiteSpace(titleTextBox.Text) && !string.IsNullOrWhiteSpace(amountTextBox.Text) && !string.IsNullOrWhiteSpace(dateTextBox.Text) && !string.IsNullOrWhiteSpace(tagsTextBox.Text) && (savTransRadioButton.Checked || spdTransRadioButton.Checked))
            {
                addButton.Enabled = true;
            }
        }

        private void DateTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) || e.KeyChar != '/' || e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            if (!string.IsNullOrWhiteSpace(titleTextBox.Text) && !string.IsNullOrWhiteSpace(amountTextBox.Text) && !string.IsNullOrWhiteSpace(dateTextBox.Text) && !string.IsNullOrWhiteSpace(tagsTextBox.Text) && (savTransRadioButton.Checked || spdTransRadioButton.Checked))
            {
                addButton.Enabled = true;
            }
        }

        private void TagsTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(titleTextBox.Text) && !string.IsNullOrWhiteSpace(amountTextBox.Text) && !string.IsNullOrWhiteSpace(dateTextBox.Text) && !string.IsNullOrWhiteSpace(tagsTextBox.Text) && (savTransRadioButton.Checked || spdTransRadioButton.Checked))
            {
                addButton.Enabled = true;
            }
        }

        private void TransRadioButton__Click(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            transactionType = rb;

            if (!string.IsNullOrWhiteSpace(titleTextBox.Text) && !string.IsNullOrWhiteSpace(amountTextBox.Text) && !string.IsNullOrWhiteSpace(dateTextBox.Text) && !string.IsNullOrWhiteSpace(tagsTextBox.Text) && (savTransRadioButton.Checked || spdTransRadioButton.Checked))
            {
                addButton.Enabled = true;
            }
        }

        private void AddButton__Click(object sender, EventArgs e)
        {
            parent.Enabled = true;
            if (savingPanel.Visible)
            {
                this.savingGoal = Int32.Parse(savingGoalTextBox.Text);
            }
            else if (spendingPanel.Visible)
            {
                this.spendingLimit = Int32.Parse(spendingLimitTextBox.Text);
            }
            else if (transactionPanel.Visible)
            {
                this.transactionTitle = titleTextBox.Text;
                this.transactionAmount = Int32.Parse(amountTextBox.Text);
                this.transactionDate = DateTime.Parse(dateTextBox.Text).Date;
                this.transactionTags = tagsTextBox.Text;
                if (transactionType == savingRadioButton)
                {
                    this.transactionIsSaving = true;
                }
                else
                {
                    this.transactionIsSaving = false;
                }
            }
            this.Close();
        }

        private void CancelButton__Click(object sender, EventArgs e)
        {
            parent.Enabled = true;
            this.Close();
        }
    }
}

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
    /* Class: Options
     * Author: Katie Bogart
     * Purpose: creates the options form
     * Restrictions: None
     */
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

        /* Method: Options
         * Purpose: constructs the options form
         *          sets values for variables
         *          sets up event handlers
         * Restrictions: None
         */
        public Options(Form parent)
        {
            InitializeComponent();

            this.parent = parent;
            parent.Enabled = false;

            savingPanel.Visible = false;
            spendingPanel.Visible = false;
            transactionPanel.Visible = false;
            addButton.Enabled = false;
            dateTimePicker.Value = DateTime.Now;

            savingRadioButton.Click += new EventHandler(RadioButton__Click);
            spendingRadioButton.Click += new EventHandler(RadioButton__Click);
            transactionRadioButton.Click += new EventHandler(RadioButton__Click);

            savingGoalTextBox.KeyPress += new KeyPressEventHandler(SavingGoalTextBox__KeyPress);

            spendingLimitTextBox.KeyPress += new KeyPressEventHandler(SpendingLimitTextBox__KeyPress);

            titleTextBox.KeyPress += new KeyPressEventHandler(TitleTextBox__KeyPress);
            amountTextBox.KeyPress += new KeyPressEventHandler(AmountTextBox__KeyPress);
            tagsTextBox.KeyPress += new KeyPressEventHandler(TagsTextBox__KeyPress);
            savTransRadioButton.Click += new EventHandler(TransRadioButton__Click);
            spdTransRadioButton.Click += new EventHandler(TransRadioButton__Click);

            addButton.Click += new EventHandler(AddButton__Click);
            cancelButton.Click += new EventHandler(CancelButton__Click);
        }

        /* Method: RadioButton__Click
         * Purpose: checks which radio button is clicked
         *          makes the right panel visible based on rb
         * Restrictions: None
         */
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

        /* Method: SavingGoalTextBox__KeyPress
         * Purpose: checks if input is backspace or digit
         * Restrictions: None
         */
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

        /* Method: SpendingLimitTextBox__KeyPress
         * Purpose: checks if input is backspace or digit
         * Restrictions: None
         */
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

        /* Method: TitleTextBox__KeyPress
         * Purpose: checks if all inputs are filled
         * Restrictions: None
         */
        private void TitleTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(titleTextBox.Text) && !string.IsNullOrWhiteSpace(amountTextBox.Text) && !string.IsNullOrWhiteSpace(tagsTextBox.Text) && (savTransRadioButton.Checked || spdTransRadioButton.Checked))
            {
                addButton.Enabled = true;
            }
        }

        /* Method: AmountBox__KeyPress
         * Purpose: checks if input is backspace or digit or .
         *          checks if all inputs are filled
         * Restrictions: None
         */
        private void AmountTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (!string.IsNullOrWhiteSpace(titleTextBox.Text) && !string.IsNullOrWhiteSpace(amountTextBox.Text) && !string.IsNullOrWhiteSpace(tagsTextBox.Text) && (savTransRadioButton.Checked || spdTransRadioButton.Checked))
            {
                addButton.Enabled = true;
            }
        }

        /* Method: TagsTextBox__KeyPress
         * Purpose: checks if all inputs are filled
         * Restrictions: None
         */
        private void TagsTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(titleTextBox.Text) && !string.IsNullOrWhiteSpace(amountTextBox.Text) && !string.IsNullOrWhiteSpace(tagsTextBox.Text) && (savTransRadioButton.Checked || spdTransRadioButton.Checked))
            {
                addButton.Enabled = true;
            }
        }

        /* Method: TransRadioButton__Click
         * Purpose: sets whether transaction is saving or spending
         *          checks if all inputs are filled
         * Restrictions: None
         */
        private void TransRadioButton__Click(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Text == "saving")
            {
                transactionIsSaving = true;
            }
            else if (rb.Text == "saving")
            {
                transactionIsSaving = false;
            }

            if (!string.IsNullOrWhiteSpace(titleTextBox.Text) && !string.IsNullOrWhiteSpace(amountTextBox.Text) && !string.IsNullOrWhiteSpace(tagsTextBox.Text) && (savTransRadioButton.Checked || spdTransRadioButton.Checked))
            {
                addButton.Enabled = true;
            }

        }

        /* Method: AddButton__Click
         * Purpose: checks which panel is visible
         *          sets variable data accordingly
         *          closes form
         * Restrictions: None
         */
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
                this.transactionAmount = Double.Parse(amountTextBox.Text);
                this.transactionDate = dateTimePicker.Value;
                this.transactionTags = tagsTextBox.Text;
            }
            this.Close();
        }

        /* Method: TitleTextBox__KeyPress
         * Purpose: closes form
         * Restrictions: None
         */
        private void CancelButton__Click(object sender, EventArgs e)
        {
            parent.Enabled = true;
            this.Close();
        }
    }
}

namespace wrkFloMealPlanner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plannerLabel = new System.Windows.Forms.Label();
            this.mealLabel = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dateLabel = new System.Windows.Forms.Label();
            this.enterDateButton = new System.Windows.Forms.Button();
            this.dinnerButton = new System.Windows.Forms.Button();
            this.lunchButton = new System.Windows.Forms.Button();
            this.breakfastButton = new System.Windows.Forms.Button();
            this.dinnerGroupBox = new System.Windows.Forms.GroupBox();
            this.dinnerLabel = new System.Windows.Forms.Label();
            this.lunchGroupBox = new System.Windows.Forms.GroupBox();
            this.lunchLabel = new System.Windows.Forms.Label();
            this.breakfastGroupBox = new System.Windows.Forms.GroupBox();
            this.breakfastLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.recipesPanel = new System.Windows.Forms.Panel();
            this.recipeDataGridView = new System.Windows.Forms.DataGridView();
            this.newRecipeButton = new System.Windows.Forms.Button();
            this.recipesLabel = new System.Windows.Forms.Label();
            this.shoppingListPanel = new System.Windows.Forms.Panel();
            this.newItemButton = new System.Windows.Forms.Button();
            this.shoppingListLabel = new System.Windows.Forms.Label();
            this.shoppingListCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.dinnerGroupBox.SuspendLayout();
            this.lunchGroupBox.SuspendLayout();
            this.breakfastGroupBox.SuspendLayout();
            this.recipesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataGridView)).BeginInit();
            this.shoppingListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // plannerLabel
            // 
            this.plannerLabel.AutoSize = true;
            this.plannerLabel.BackColor = System.Drawing.Color.Transparent;
            this.plannerLabel.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plannerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.plannerLabel.Location = new System.Drawing.Point(642, 0);
            this.plannerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plannerLabel.Name = "plannerLabel";
            this.plannerLabel.Size = new System.Drawing.Size(179, 67);
            this.plannerLabel.TabIndex = 17;
            this.plannerLabel.Text = "planner";
            // 
            // mealLabel
            // 
            this.mealLabel.AutoSize = true;
            this.mealLabel.BackColor = System.Drawing.Color.Transparent;
            this.mealLabel.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.mealLabel.Location = new System.Drawing.Point(520, 1);
            this.mealLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(131, 65);
            this.mealLabel.TabIndex = 15;
            this.mealLabel.Text = "meal";
            this.mealLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Location = new System.Drawing.Point(-1, 1);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Panel1Collapsed = true;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panel1);
            this.splitContainer.Panel2.Controls.Add(this.dateLabel);
            this.splitContainer.Panel2.Controls.Add(this.enterDateButton);
            this.splitContainer.Panel2.Controls.Add(this.dinnerButton);
            this.splitContainer.Panel2.Controls.Add(this.lunchButton);
            this.splitContainer.Panel2.Controls.Add(this.breakfastButton);
            this.splitContainer.Panel2.Controls.Add(this.dinnerGroupBox);
            this.splitContainer.Panel2.Controls.Add(this.lunchGroupBox);
            this.splitContainer.Panel2.Controls.Add(this.breakfastGroupBox);
            this.splitContainer.Panel2.Controls.Add(this.dateTimePicker);
            this.splitContainer.Panel2.Controls.Add(this.recipesPanel);
            this.splitContainer.Panel2.Controls.Add(this.shoppingListPanel);
            this.splitContainer.Panel2.Controls.Add(this.mealLabel);
            this.splitContainer.Panel2.Controls.Add(this.plannerLabel);
            this.splitContainer.Size = new System.Drawing.Size(831, 562);
            this.splitContainer.SplitterDistance = 244;
            this.splitContainer.TabIndex = 30;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dateLabel.Location = new System.Drawing.Point(329, 127);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(143, 39);
            this.dateLabel.TabIndex = 32;
            this.dateLabel.Text = "1/1/2000";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enterDateButton
            // 
            this.enterDateButton.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Bold);
            this.enterDateButton.Location = new System.Drawing.Point(672, 96);
            this.enterDateButton.Name = "enterDateButton";
            this.enterDateButton.Size = new System.Drawing.Size(132, 24);
            this.enterDateButton.TabIndex = 31;
            this.enterDateButton.Text = "View Meal Plan";
            this.enterDateButton.UseVisualStyleBackColor = true;
            // 
            // dinnerButton
            // 
            this.dinnerButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F);
            this.dinnerButton.Location = new System.Drawing.Point(754, 434);
            this.dinnerButton.Name = "dinnerButton";
            this.dinnerButton.Size = new System.Drawing.Size(50, 99);
            this.dinnerButton.TabIndex = 30;
            this.dinnerButton.Text = "+";
            this.dinnerButton.UseVisualStyleBackColor = true;
            // 
            // lunchButton
            // 
            this.lunchButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F);
            this.lunchButton.Location = new System.Drawing.Point(754, 303);
            this.lunchButton.Name = "lunchButton";
            this.lunchButton.Size = new System.Drawing.Size(50, 99);
            this.lunchButton.TabIndex = 29;
            this.lunchButton.Text = "+";
            this.lunchButton.UseVisualStyleBackColor = true;
            // 
            // breakfastButton
            // 
            this.breakfastButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F);
            this.breakfastButton.Location = new System.Drawing.Point(754, 175);
            this.breakfastButton.Name = "breakfastButton";
            this.breakfastButton.Size = new System.Drawing.Size(50, 99);
            this.breakfastButton.TabIndex = 28;
            this.breakfastButton.Text = "+";
            this.breakfastButton.UseVisualStyleBackColor = true;
            // 
            // dinnerGroupBox
            // 
            this.dinnerGroupBox.Controls.Add(this.dinnerLabel);
            this.dinnerGroupBox.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.dinnerGroupBox.Location = new System.Drawing.Point(326, 422);
            this.dinnerGroupBox.Name = "dinnerGroupBox";
            this.dinnerGroupBox.Size = new System.Drawing.Size(421, 109);
            this.dinnerGroupBox.TabIndex = 27;
            this.dinnerGroupBox.TabStop = false;
            this.dinnerGroupBox.Text = "Dinner";
            // 
            // dinnerLabel
            // 
            this.dinnerLabel.AutoSize = true;
            this.dinnerLabel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinnerLabel.Location = new System.Drawing.Point(16, 37);
            this.dinnerLabel.Name = "dinnerLabel";
            this.dinnerLabel.Size = new System.Drawing.Size(63, 28);
            this.dinnerLabel.TabIndex = 1;
            this.dinnerLabel.Text = "None";
            // 
            // lunchGroupBox
            // 
            this.lunchGroupBox.Controls.Add(this.lunchLabel);
            this.lunchGroupBox.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.lunchGroupBox.Location = new System.Drawing.Point(326, 291);
            this.lunchGroupBox.Name = "lunchGroupBox";
            this.lunchGroupBox.Size = new System.Drawing.Size(421, 109);
            this.lunchGroupBox.TabIndex = 27;
            this.lunchGroupBox.TabStop = false;
            this.lunchGroupBox.Text = "Lunch";
            // 
            // lunchLabel
            // 
            this.lunchLabel.AutoSize = true;
            this.lunchLabel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunchLabel.Location = new System.Drawing.Point(16, 37);
            this.lunchLabel.Name = "lunchLabel";
            this.lunchLabel.Size = new System.Drawing.Size(63, 28);
            this.lunchLabel.TabIndex = 1;
            this.lunchLabel.Text = "None";
            // 
            // breakfastGroupBox
            // 
            this.breakfastGroupBox.Controls.Add(this.breakfastLabel);
            this.breakfastGroupBox.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.breakfastGroupBox.Location = new System.Drawing.Point(326, 163);
            this.breakfastGroupBox.Name = "breakfastGroupBox";
            this.breakfastGroupBox.Size = new System.Drawing.Size(421, 109);
            this.breakfastGroupBox.TabIndex = 26;
            this.breakfastGroupBox.TabStop = false;
            this.breakfastGroupBox.Text = "Breakfast";
            // 
            // breakfastLabel
            // 
            this.breakfastLabel.AutoSize = true;
            this.breakfastLabel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakfastLabel.Location = new System.Drawing.Point(16, 37);
            this.breakfastLabel.Name = "breakfastLabel";
            this.breakfastLabel.Size = new System.Drawing.Size(63, 28);
            this.breakfastLabel.TabIndex = 0;
            this.breakfastLabel.Text = "None";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Tw Cen MT", 8.25F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(326, 96);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(321, 25);
            this.dateTimePicker.TabIndex = 25;
            this.dateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // recipesPanel
            // 
            this.recipesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recipesPanel.Controls.Add(this.recipeDataGridView);
            this.recipesPanel.Controls.Add(this.newRecipeButton);
            this.recipesPanel.Controls.Add(this.recipesLabel);
            this.recipesPanel.Location = new System.Drawing.Point(15, 297);
            this.recipesPanel.Name = "recipesPanel";
            this.recipesPanel.Size = new System.Drawing.Size(282, 244);
            this.recipesPanel.TabIndex = 19;
            // 
            // recipeDataGridView
            // 
            this.recipeDataGridView.AllowUserToAddRows = false;
            this.recipeDataGridView.AllowUserToDeleteRows = false;
            this.recipeDataGridView.AllowUserToResizeColumns = false;
            this.recipeDataGridView.AllowUserToResizeRows = false;
            this.recipeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recipeDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.recipeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.recipeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipeDataGridView.ColumnHeadersVisible = false;
            this.recipeDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.recipeDataGridView.Location = new System.Drawing.Point(0, 43);
            this.recipeDataGridView.Name = "recipeDataGridView";
            this.recipeDataGridView.RowHeadersVisible = false;
            this.recipeDataGridView.RowHeadersWidth = 51;
            this.recipeDataGridView.RowTemplate.Height = 24;
            this.recipeDataGridView.Size = new System.Drawing.Size(280, 199);
            this.recipeDataGridView.TabIndex = 25;
            // 
            // newRecipeButton
            // 
            this.newRecipeButton.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Bold);
            this.newRecipeButton.Location = new System.Drawing.Point(154, 4);
            this.newRecipeButton.Name = "newRecipeButton";
            this.newRecipeButton.Size = new System.Drawing.Size(123, 34);
            this.newRecipeButton.TabIndex = 24;
            this.newRecipeButton.Text = "Add Recipe";
            this.newRecipeButton.UseVisualStyleBackColor = true;
            // 
            // recipesLabel
            // 
            this.recipesLabel.BackColor = System.Drawing.Color.Transparent;
            this.recipesLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.recipesLabel.Location = new System.Drawing.Point(4, 4);
            this.recipesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recipesLabel.Name = "recipesLabel";
            this.recipesLabel.Size = new System.Drawing.Size(171, 41);
            this.recipesLabel.TabIndex = 22;
            this.recipesLabel.Text = "recipes";
            // 
            // shoppingListPanel
            // 
            this.shoppingListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shoppingListPanel.Controls.Add(this.newItemButton);
            this.shoppingListPanel.Controls.Add(this.shoppingListLabel);
            this.shoppingListPanel.Controls.Add(this.shoppingListCheckedListBox);
            this.shoppingListPanel.Location = new System.Drawing.Point(15, 94);
            this.shoppingListPanel.Name = "shoppingListPanel";
            this.shoppingListPanel.Size = new System.Drawing.Size(282, 186);
            this.shoppingListPanel.TabIndex = 18;
            // 
            // newItemButton
            // 
            this.newItemButton.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newItemButton.Location = new System.Drawing.Point(182, 5);
            this.newItemButton.Name = "newItemButton";
            this.newItemButton.Size = new System.Drawing.Size(95, 34);
            this.newItemButton.TabIndex = 25;
            this.newItemButton.Text = "Add Item";
            this.newItemButton.UseVisualStyleBackColor = true;
            // 
            // shoppingListLabel
            // 
            this.shoppingListLabel.BackColor = System.Drawing.Color.Transparent;
            this.shoppingListLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.shoppingListLabel.Location = new System.Drawing.Point(4, 5);
            this.shoppingListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shoppingListLabel.Name = "shoppingListLabel";
            this.shoppingListLabel.Size = new System.Drawing.Size(171, 36);
            this.shoppingListLabel.TabIndex = 21;
            this.shoppingListLabel.Text = "shopping list";
            // 
            // shoppingListCheckedListBox
            // 
            this.shoppingListCheckedListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.shoppingListCheckedListBox.Font = new System.Drawing.Font("Tw Cen MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingListCheckedListBox.FormattingEnabled = true;
            this.shoppingListCheckedListBox.Items.AddRange(new object[] {
            "Milk",
            "Eggs",
            "Sour Cream",
            "Flour"});
            this.shoppingListCheckedListBox.Location = new System.Drawing.Point(0, 54);
            this.shoppingListCheckedListBox.Name = "shoppingListCheckedListBox";
            this.shoppingListCheckedListBox.Size = new System.Drawing.Size(280, 130);
            this.shoppingListCheckedListBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.panel1.Location = new System.Drawing.Point(-1, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 10);
            this.panel1.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 559);
            this.Controls.Add(this.splitContainer);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.dinnerGroupBox.ResumeLayout(false);
            this.dinnerGroupBox.PerformLayout();
            this.lunchGroupBox.ResumeLayout(false);
            this.lunchGroupBox.PerformLayout();
            this.breakfastGroupBox.ResumeLayout(false);
            this.breakfastGroupBox.PerformLayout();
            this.recipesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataGridView)).EndInit();
            this.shoppingListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label plannerLabel;
        private System.Windows.Forms.Label mealLabel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel recipesPanel;
        private System.Windows.Forms.Panel shoppingListPanel;
        private System.Windows.Forms.Label shoppingListLabel;
        private System.Windows.Forms.Label recipesLabel;
        private System.Windows.Forms.Button newRecipeButton;
        private System.Windows.Forms.Button newItemButton;
        protected internal System.Windows.Forms.CheckedListBox shoppingListCheckedListBox;
        private System.Windows.Forms.DataGridView recipeDataGridView;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox breakfastGroupBox;
        private System.Windows.Forms.Button dinnerButton;
        private System.Windows.Forms.Button lunchButton;
        private System.Windows.Forms.Button breakfastButton;
        private System.Windows.Forms.GroupBox dinnerGroupBox;
        private System.Windows.Forms.GroupBox lunchGroupBox;
        private System.Windows.Forms.Label dinnerLabel;
        private System.Windows.Forms.Label lunchLabel;
        private System.Windows.Forms.Label breakfastLabel;
        private System.Windows.Forms.Button enterDateButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Panel panel1;
    }
}


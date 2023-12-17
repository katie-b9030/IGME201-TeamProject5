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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.recipeDataGridView = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newItemButton = new System.Windows.Forms.Button();
            this.shoppingListLabel = new System.Windows.Forms.Label();
            this.shoppingListCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.breakfastGroupBox = new System.Windows.Forms.GroupBox();
            this.lunchGroupBox = new System.Windows.Forms.GroupBox();
            this.dinnerGroupBox = new System.Windows.Forms.GroupBox();
            this.breakfastButton = new System.Windows.Forms.Button();
            this.lunchButton = new System.Windows.Forms.Button();
            this.dinnerButton = new System.Windows.Forms.Button();
            this.breakfastLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.breakfastGroupBox.SuspendLayout();
            this.lunchGroupBox.SuspendLayout();
            this.dinnerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.label4.Location = new System.Drawing.Point(642, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 56);
            this.label4.TabIndex = 17;
            this.label4.Text = "planner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(536, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 55);
            this.label3.TabIndex = 15;
            this.label3.Text = "meal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Location = new System.Drawing.Point(-1, 1);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dinnerButton);
            this.splitContainer.Panel2.Controls.Add(this.lunchButton);
            this.splitContainer.Panel2.Controls.Add(this.breakfastButton);
            this.splitContainer.Panel2.Controls.Add(this.dinnerGroupBox);
            this.splitContainer.Panel2.Controls.Add(this.lunchGroupBox);
            this.splitContainer.Panel2.Controls.Add(this.breakfastGroupBox);
            this.splitContainer.Panel2.Controls.Add(this.dateTimePicker);
            this.splitContainer.Panel2.Controls.Add(this.dateLabel);
            this.splitContainer.Panel2.Controls.Add(this.panel2);
            this.splitContainer.Panel2.Controls.Add(this.panel1);
            this.splitContainer.Panel2.Controls.Add(this.label3);
            this.splitContainer.Panel2.Controls.Add(this.label4);
            this.splitContainer.Size = new System.Drawing.Size(1066, 564);
            this.splitContainer.SplitterDistance = 244;
            this.splitContainer.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.recipeDataGridView);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(15, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 244);
            this.panel2.TabIndex = 19;
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
            this.recipeDataGridView.Location = new System.Drawing.Point(0, 38);
            this.recipeDataGridView.Name = "recipeDataGridView";
            this.recipeDataGridView.RowHeadersVisible = false;
            this.recipeDataGridView.RowHeadersWidth = 51;
            this.recipeDataGridView.RowTemplate.Height = 24;
            this.recipeDataGridView.Size = new System.Drawing.Size(280, 204);
            this.recipeDataGridView.TabIndex = 25;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(158, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 34);
            this.button3.TabIndex = 24;
            this.button3.Text = "Add Recipe";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 41);
            this.label2.TabIndex = 22;
            this.label2.Text = "recipes";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.newItemButton);
            this.panel1.Controls.Add(this.shoppingListLabel);
            this.panel1.Controls.Add(this.shoppingListCheckedListBox);
            this.panel1.Location = new System.Drawing.Point(15, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 186);
            this.panel1.TabIndex = 18;
            // 
            // newItemButton
            // 
            this.newItemButton.Location = new System.Drawing.Point(184, 3);
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
            this.shoppingListLabel.Size = new System.Drawing.Size(171, 29);
            this.shoppingListLabel.TabIndex = 21;
            this.shoppingListLabel.Text = "shopping list";
            // 
            // shoppingListCheckedListBox
            // 
            this.shoppingListCheckedListBox.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingListCheckedListBox.FormattingEnabled = true;
            this.shoppingListCheckedListBox.Items.AddRange(new object[] {
            "Milk",
            "Eggs",
            "Sour Cream",
            "Flour"});
            this.shoppingListCheckedListBox.Location = new System.Drawing.Point(3, 37);
            this.shoppingListCheckedListBox.Name = "shoppingListCheckedListBox";
            this.shoppingListCheckedListBox.Size = new System.Drawing.Size(276, 140);
            this.shoppingListCheckedListBox.TabIndex = 0;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dateLabel.Location = new System.Drawing.Point(614, 92);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateLabel.Size = new System.Drawing.Size(185, 40);
            this.dateLabel.TabIndex = 24;
            this.dateLabel.Text = "01/01/2001";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Tw Cen MT", 8.25F);
            this.dateTimePicker.Location = new System.Drawing.Point(326, 105);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(272, 22);
            this.dateTimePicker.TabIndex = 25;
            this.dateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // breakfastGroupBox
            // 
            this.breakfastGroupBox.Controls.Add(this.breakfastLabel);
            this.breakfastGroupBox.Location = new System.Drawing.Point(326, 147);
            this.breakfastGroupBox.Name = "breakfastGroupBox";
            this.breakfastGroupBox.Size = new System.Drawing.Size(421, 109);
            this.breakfastGroupBox.TabIndex = 26;
            this.breakfastGroupBox.TabStop = false;
            this.breakfastGroupBox.Text = "Breakfast";
            // 
            // lunchGroupBox
            // 
            this.lunchGroupBox.Controls.Add(this.label1);
            this.lunchGroupBox.Location = new System.Drawing.Point(326, 275);
            this.lunchGroupBox.Name = "lunchGroupBox";
            this.lunchGroupBox.Size = new System.Drawing.Size(421, 109);
            this.lunchGroupBox.TabIndex = 27;
            this.lunchGroupBox.TabStop = false;
            this.lunchGroupBox.Text = "Lunch";
            // 
            // dinnerGroupBox
            // 
            this.dinnerGroupBox.Controls.Add(this.label5);
            this.dinnerGroupBox.Location = new System.Drawing.Point(326, 406);
            this.dinnerGroupBox.Name = "dinnerGroupBox";
            this.dinnerGroupBox.Size = new System.Drawing.Size(421, 109);
            this.dinnerGroupBox.TabIndex = 27;
            this.dinnerGroupBox.TabStop = false;
            this.dinnerGroupBox.Text = "Dinner";
            // 
            // breakfastButton
            // 
            this.breakfastButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F);
            this.breakfastButton.Location = new System.Drawing.Point(754, 154);
            this.breakfastButton.Name = "breakfastButton";
            this.breakfastButton.Size = new System.Drawing.Size(50, 99);
            this.breakfastButton.TabIndex = 28;
            this.breakfastButton.Text = "+";
            this.breakfastButton.UseVisualStyleBackColor = true;
            // 
            // lunchButton
            // 
            this.lunchButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F);
            this.lunchButton.Location = new System.Drawing.Point(754, 282);
            this.lunchButton.Name = "lunchButton";
            this.lunchButton.Size = new System.Drawing.Size(50, 99);
            this.lunchButton.TabIndex = 29;
            this.lunchButton.Text = "+";
            this.lunchButton.UseVisualStyleBackColor = true;
            // 
            // dinnerButton
            // 
            this.dinnerButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F);
            this.dinnerButton.Location = new System.Drawing.Point(754, 413);
            this.dinnerButton.Name = "dinnerButton";
            this.dinnerButton.Size = new System.Drawing.Size(50, 99);
            this.dinnerButton.TabIndex = 30;
            this.dinnerButton.Text = "+";
            this.dinnerButton.UseVisualStyleBackColor = true;
            // 
            // breakfastLabel
            // 
            this.breakfastLabel.AutoSize = true;
            this.breakfastLabel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakfastLabel.Location = new System.Drawing.Point(16, 18);
            this.breakfastLabel.Name = "breakfastLabel";
            this.breakfastLabel.Size = new System.Drawing.Size(52, 23);
            this.breakfastLabel.TabIndex = 0;
            this.breakfastLabel.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "None";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 559);
            this.Controls.Add(this.splitContainer);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.breakfastGroupBox.ResumeLayout(false);
            this.breakfastGroupBox.PerformLayout();
            this.lunchGroupBox.ResumeLayout(false);
            this.lunchGroupBox.PerformLayout();
            this.dinnerGroupBox.ResumeLayout(false);
            this.dinnerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label shoppingListLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button newItemButton;
        protected internal System.Windows.Forms.CheckedListBox shoppingListCheckedListBox;
        private System.Windows.Forms.DataGridView recipeDataGridView;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox breakfastGroupBox;
        private System.Windows.Forms.Button dinnerButton;
        private System.Windows.Forms.Button lunchButton;
        private System.Windows.Forms.Button breakfastButton;
        private System.Windows.Forms.GroupBox dinnerGroupBox;
        private System.Windows.Forms.GroupBox lunchGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label breakfastLabel;
    }
}


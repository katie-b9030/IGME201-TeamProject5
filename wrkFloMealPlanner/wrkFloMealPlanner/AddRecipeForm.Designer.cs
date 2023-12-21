namespace wrkFloMealPlanner
{
    partial class AddRecipeForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.recipeNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::wrkFloMealPlanner.Properties.Resources.wrkflo_logo_scaled;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(51, 242);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 48);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(289, 242);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 48);
            this.enterButton.TabIndex = 11;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(142, 160);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(246, 22);
            this.urlTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Recipe URL:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(142, 121);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(246, 22);
            this.nameTextBox.TabIndex = 8;
            // 
            // recipeNameLabel
            // 
            this.recipeNameLabel.AutoSize = true;
            this.recipeNameLabel.Location = new System.Drawing.Point(12, 124);
            this.recipeNameLabel.Name = "recipeNameLabel";
            this.recipeNameLabel.Size = new System.Drawing.Size(128, 16);
            this.recipeNameLabel.TabIndex = 7;
            this.recipeNameLabel.Text = "Enter Recipe Name:";
            // 
            // AddRecipeForm
            // 
            this.AcceptButton = this.enterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(419, 336);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.recipeNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddRecipeForm";
            this.Text = "Add Recipe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label recipeNameLabel;
    }
}
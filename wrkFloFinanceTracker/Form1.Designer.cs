namespace wrkFloFinanceTracker
{
    partial class FinanceTracker
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.financesListView = new System.Windows.Forms.ListView();
            this.titleHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amtHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tagsHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.savingsProgressBar = new System.Windows.Forms.ProgressBar();
            this.spendingProgressBar = new System.Windows.Forms.ProgressBar();
            this.savingTotalLabel = new System.Windows.Forms.Label();
            this.savedLabel = new System.Windows.Forms.Label();
            this.spentLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.netWorthLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.addButton);
            this.splitContainer2.Panel2.Controls.Add(this.financesListView);
            this.splitContainer2.Panel2.Controls.Add(this.savingsProgressBar);
            this.splitContainer2.Panel2.Controls.Add(this.spendingProgressBar);
            this.splitContainer2.Panel2.Controls.Add(this.savingTotalLabel);
            this.splitContainer2.Panel2.Controls.Add(this.savedLabel);
            this.splitContainer2.Panel2.Controls.Add(this.spentLabel);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.netWorthLabel);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(576, 450);
            this.splitContainer2.SplitterDistance = 57;
            this.splitContainer2.SplitterWidth = 10;
            this.splitContainer2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.label2.Location = new System.Drawing.Point(461, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "tracker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "finance";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addButton.Location = new System.Drawing.Point(9, 341);
            this.addButton.Margin = new System.Windows.Forms.Padding(1);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(555, 30);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // financesListView
            // 
            this.financesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleHdr,
            this.amtHdr,
            this.dateHdr,
            this.tagsHdr});
            this.financesListView.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financesListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(148)))), ((int)(((byte)(177)))));
            this.financesListView.HideSelection = false;
            this.financesListView.Location = new System.Drawing.Point(11, 109);
            this.financesListView.Name = "financesListView";
            this.financesListView.Size = new System.Drawing.Size(553, 262);
            this.financesListView.TabIndex = 12;
            this.financesListView.UseCompatibleStateImageBehavior = false;
            this.financesListView.View = System.Windows.Forms.View.Details;
            // 
            // titleHdr
            // 
            this.titleHdr.Text = "title";
            this.titleHdr.Width = 200;
            // 
            // amtHdr
            // 
            this.amtHdr.Text = "amount";
            this.amtHdr.Width = 75;
            // 
            // dateHdr
            // 
            this.dateHdr.Text = "date";
            this.dateHdr.Width = 100;
            // 
            // tagsHdr
            // 
            this.tagsHdr.Text = "tags";
            this.tagsHdr.Width = 200;
            // 
            // savingsProgressBar
            // 
            this.savingsProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(148)))), ((int)(((byte)(177)))));
            this.savingsProgressBar.Location = new System.Drawing.Point(301, 90);
            this.savingsProgressBar.Maximum = 0;
            this.savingsProgressBar.Name = "savingsProgressBar";
            this.savingsProgressBar.Size = new System.Drawing.Size(267, 13);
            this.savingsProgressBar.TabIndex = 11;
            // 
            // spendingProgressBar
            // 
            this.spendingProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(148)))), ((int)(((byte)(177)))));
            this.spendingProgressBar.Location = new System.Drawing.Point(9, 90);
            this.spendingProgressBar.Maximum = 0;
            this.spendingProgressBar.Name = "spendingProgressBar";
            this.spendingProgressBar.Size = new System.Drawing.Size(267, 13);
            this.spendingProgressBar.TabIndex = 10;
            // 
            // savingTotalLabel
            // 
            this.savingTotalLabel.AutoSize = true;
            this.savingTotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.savingTotalLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.savingTotalLabel.Location = new System.Drawing.Point(455, 65);
            this.savingTotalLabel.Name = "savingTotalLabel";
            this.savingTotalLabel.Size = new System.Drawing.Size(0, 22);
            this.savingTotalLabel.TabIndex = 8;
            // 
            // savedLabel
            // 
            this.savedLabel.AutoSize = true;
            this.savedLabel.BackColor = System.Drawing.Color.Transparent;
            this.savedLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.savedLabel.Location = new System.Drawing.Point(398, 65);
            this.savedLabel.Name = "savedLabel";
            this.savedLabel.Size = new System.Drawing.Size(56, 22);
            this.savedLabel.TabIndex = 7;
            this.savedLabel.Text = "$0 / $0";
            // 
            // spentLabel
            // 
            this.spentLabel.AutoSize = true;
            this.spentLabel.BackColor = System.Drawing.Color.Transparent;
            this.spentLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.spentLabel.Location = new System.Drawing.Point(136, 65);
            this.spentLabel.Name = "spentLabel";
            this.spentLabel.Size = new System.Drawing.Size(56, 22);
            this.spentLabel.TabIndex = 4;
            this.spentLabel.Text = "$0 / $0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label6.Location = new System.Drawing.Point(297, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "savings goal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(6, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "weekly spending:";
            // 
            // netWorthLabel
            // 
            this.netWorthLabel.AutoSize = true;
            this.netWorthLabel.BackColor = System.Drawing.Color.Transparent;
            this.netWorthLabel.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netWorthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.netWorthLabel.Location = new System.Drawing.Point(154, 1);
            this.netWorthLabel.Name = "netWorthLabel";
            this.netWorthLabel.Size = new System.Drawing.Size(52, 45);
            this.netWorthLabel.TabIndex = 1;
            this.netWorthLabel.Text = "$0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 44);
            this.label3.TabIndex = 0;
            this.label3.Text = "net worth:";
            // 
            // FinanceTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FinanceTracker";
            this.Text = "Finance Tracker";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label netWorthLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label spentLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label savingTotalLabel;
        private System.Windows.Forms.Label savedLabel;
        private System.Windows.Forms.ProgressBar savingsProgressBar;
        private System.Windows.Forms.ProgressBar spendingProgressBar;
        private System.Windows.Forms.ListView financesListView;
        private System.Windows.Forms.ColumnHeader titleHdr;
        private System.Windows.Forms.ColumnHeader amtHdr;
        private System.Windows.Forms.ColumnHeader dateHdr;
        private System.Windows.Forms.ColumnHeader tagsHdr;
        private System.Windows.Forms.Button addButton;
    }
}


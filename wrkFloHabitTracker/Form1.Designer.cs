namespace wrkFloHabitTracker
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
            this.navSplitContainer = new System.Windows.Forms.SplitContainer();
            this.habitSplitContainer = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addRowButton = new System.Windows.Forms.Button();
            this.habitListView = new System.Windows.Forms.ListView();
            this.sundayHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mondayHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tuesdayHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wednesdayHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thursdayHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fridayHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saturdayHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.habitHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.navSplitContainer)).BeginInit();
            this.navSplitContainer.Panel2.SuspendLayout();
            this.navSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.habitSplitContainer)).BeginInit();
            this.habitSplitContainer.Panel1.SuspendLayout();
            this.habitSplitContainer.Panel2.SuspendLayout();
            this.habitSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // navSplitContainer
            // 
            this.navSplitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.navSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.navSplitContainer.Name = "navSplitContainer";
            // 
            // navSplitContainer.Panel1
            // 
            this.navSplitContainer.Panel1.BackColor = System.Drawing.Color.White;
            // 
            // navSplitContainer.Panel2
            // 
            this.navSplitContainer.Panel2.Controls.Add(this.habitSplitContainer);
            this.navSplitContainer.Size = new System.Drawing.Size(800, 450);
            this.navSplitContainer.SplitterDistance = 220;
            this.navSplitContainer.SplitterWidth = 10;
            this.navSplitContainer.TabIndex = 0;
            // 
            // habitSplitContainer
            // 
            this.habitSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.habitSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.habitSplitContainer.Name = "habitSplitContainer";
            this.habitSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // habitSplitContainer.Panel1
            // 
            this.habitSplitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.habitSplitContainer.Panel1.Controls.Add(this.label2);
            this.habitSplitContainer.Panel1.Controls.Add(this.label1);
            // 
            // habitSplitContainer.Panel2
            // 
            this.habitSplitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.habitSplitContainer.Panel2.Controls.Add(this.habitListView);
            this.habitSplitContainer.Panel2.Controls.Add(this.addRowButton);
            this.habitSplitContainer.Size = new System.Drawing.Size(570, 450);
            this.habitSplitContainer.SplitterDistance = 57;
            this.habitSplitContainer.SplitterWidth = 10;
            this.habitSplitContainer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(330, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "habit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(223)))), ((int)(((byte)(248)))));
            this.label2.Location = new System.Drawing.Point(426, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "tracker";
            // 
            // addRowButton
            // 
            this.addRowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.addRowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addRowButton.Location = new System.Drawing.Point(5, 343);
            this.addRowButton.Margin = new System.Windows.Forms.Padding(1);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(555, 30);
            this.addRowButton.TabIndex = 14;
            this.addRowButton.Text = "+";
            this.addRowButton.UseVisualStyleBackColor = false;
            // 
            // habitListView
            // 
            this.habitListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.habitHdr,
            this.sundayHdr,
            this.mondayHdr,
            this.tuesdayHdr,
            this.wednesdayHdr,
            this.thursdayHdr,
            this.fridayHdr,
            this.saturdayHdr});
            this.habitListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(148)))), ((int)(((byte)(177)))));
            this.habitListView.HideSelection = false;
            this.habitListView.Location = new System.Drawing.Point(0, 0);
            this.habitListView.Name = "habitListView";
            this.habitListView.Size = new System.Drawing.Size(570, 337);
            this.habitListView.TabIndex = 15;
            this.habitListView.UseCompatibleStateImageBehavior = false;
            this.habitListView.View = System.Windows.Forms.View.Details;
            // 
            // sundayHdr
            // 
            this.sundayHdr.Text = "S";
            this.sundayHdr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sundayHdr.Width = 59;
            // 
            // mondayHdr
            // 
            this.mondayHdr.Text = "M";
            this.mondayHdr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mondayHdr.Width = 59;
            // 
            // tuesdayHdr
            // 
            this.tuesdayHdr.Text = "T";
            this.tuesdayHdr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tuesdayHdr.Width = 59;
            // 
            // wednesdayHdr
            // 
            this.wednesdayHdr.Text = "W";
            this.wednesdayHdr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wednesdayHdr.Width = 59;
            // 
            // thursdayHdr
            // 
            this.thursdayHdr.Text = "Th";
            this.thursdayHdr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.thursdayHdr.Width = 59;
            // 
            // fridayHdr
            // 
            this.fridayHdr.Text = "F";
            this.fridayHdr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fridayHdr.Width = 59;
            // 
            // saturdayHdr
            // 
            this.saturdayHdr.Text = "Sa";
            this.saturdayHdr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saturdayHdr.Width = 59;
            // 
            // habitHdr
            // 
            this.habitHdr.Text = "";
            this.habitHdr.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.navSplitContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.navSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navSplitContainer)).EndInit();
            this.navSplitContainer.ResumeLayout(false);
            this.habitSplitContainer.Panel1.ResumeLayout(false);
            this.habitSplitContainer.Panel1.PerformLayout();
            this.habitSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.habitSplitContainer)).EndInit();
            this.habitSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer navSplitContainer;
        private System.Windows.Forms.SplitContainer habitSplitContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView habitListView;
        private System.Windows.Forms.ColumnHeader habitHdr;
        private System.Windows.Forms.ColumnHeader sundayHdr;
        private System.Windows.Forms.ColumnHeader mondayHdr;
        private System.Windows.Forms.ColumnHeader tuesdayHdr;
        private System.Windows.Forms.ColumnHeader wednesdayHdr;
        private System.Windows.Forms.ColumnHeader thursdayHdr;
        private System.Windows.Forms.ColumnHeader fridayHdr;
        private System.Windows.Forms.ColumnHeader saturdayHdr;
        private System.Windows.Forms.Button addRowButton;
    }
}


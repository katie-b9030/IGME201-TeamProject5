namespace NavBar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.agendaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.financeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mealToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.habitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.settingsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deadlineLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.quoteLabel = new System.Windows.Forms.ToolStripLabel();
            this.quoteTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.agendaTabPage = new System.Windows.Forms.TabPage();
            this.FinanceTabPage = new System.Windows.Forms.TabPage();
            this.mealTabPage = new System.Windows.Forms.TabPage();
            this.habitTabPage = new System.Windows.Forms.TabPage();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripButton,
            this.financeToolStripButton,
            this.mealToolStripButton,
            this.habitToolStripButton,
            this.settingsToolStripButton,
            this.deadlineLabel,
            this.toolStripTextBox1,
            this.quoteLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(200, 450);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(212, 450);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // agendaToolStripButton
            // 
            this.agendaToolStripButton.AutoSize = false;
            this.agendaToolStripButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agendaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("agendaToolStripButton.Image")));
            this.agendaToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agendaToolStripButton.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.agendaToolStripButton.Margin = new System.Windows.Forms.Padding(10, 2, 0, 3);
            this.agendaToolStripButton.Name = "agendaToolStripButton";
            this.agendaToolStripButton.Size = new System.Drawing.Size(200, 40);
            this.agendaToolStripButton.Text = "Agenda";
            this.agendaToolStripButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // financeToolStripButton
            // 
            this.financeToolStripButton.AutoSize = false;
            this.financeToolStripButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("financeToolStripButton.Image")));
            this.financeToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.financeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.financeToolStripButton.Name = "financeToolStripButton";
            this.financeToolStripButton.Size = new System.Drawing.Size(200, 40);
            this.financeToolStripButton.Text = "Finance Tracker";
            this.financeToolStripButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mealToolStripButton
            // 
            this.mealToolStripButton.AutoSize = false;
            this.mealToolStripButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("mealToolStripButton.Image")));
            this.mealToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mealToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mealToolStripButton.Name = "mealToolStripButton";
            this.mealToolStripButton.Size = new System.Drawing.Size(200, 40);
            this.mealToolStripButton.Text = "Meal Planner";
            this.mealToolStripButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // habitToolStripButton
            // 
            this.habitToolStripButton.AutoSize = false;
            this.habitToolStripButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("habitToolStripButton.Image")));
            this.habitToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.habitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.habitToolStripButton.Name = "habitToolStripButton";
            this.habitToolStripButton.Size = new System.Drawing.Size(200, 40);
            this.habitToolStripButton.Text = "Habit Tracker";
            this.habitToolStripButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // settingsToolStripButton
            // 
            this.settingsToolStripButton.AutoSize = false;
            this.settingsToolStripButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.settingsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripButton.Image")));
            this.settingsToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsToolStripButton.Name = "settingsToolStripButton";
            this.settingsToolStripButton.Size = new System.Drawing.Size(200, 35);
            this.settingsToolStripButton.Text = "Settings";
            this.settingsToolStripButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size(207, 25);
            this.deadlineLabel.Text = "Deadlines";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(203, 31);
            // 
            // quoteLabel
            // 
            this.quoteLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.quoteLabel.Name = "quoteLabel";
            this.quoteLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.quoteLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quoteLabel.Size = new System.Drawing.Size(665, 25);
            this.quoteLabel.Text = "\"When you have a dream, you\'ve got to grab it and never let it go.\" - Carol Burne" +
    "tt";
            this.quoteLabel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // quoteTimer
            // 
            this.quoteTimer.Interval = 86400000;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.agendaTabPage);
            this.tabControl.Controls.Add(this.FinanceTabPage);
            this.tabControl.Controls.Add(this.mealTabPage);
            this.tabControl.Controls.Add(this.habitTabPage);
            this.tabControl.Controls.Add(this.settingsTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(212, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(517, 450);
            this.tabControl.TabIndex = 1;
            // 
            // agendaTabPage
            // 
            this.agendaTabPage.Location = new System.Drawing.Point(4, 29);
            this.agendaTabPage.Name = "agendaTabPage";
            this.agendaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.agendaTabPage.Size = new System.Drawing.Size(509, 417);
            this.agendaTabPage.TabIndex = 0;
            this.agendaTabPage.Text = "Agenda";
            this.agendaTabPage.UseVisualStyleBackColor = true;
            // 
            // FinanceTabPage
            // 
            this.FinanceTabPage.Location = new System.Drawing.Point(4, 29);
            this.FinanceTabPage.Name = "FinanceTabPage";
            this.FinanceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FinanceTabPage.Size = new System.Drawing.Size(509, 417);
            this.FinanceTabPage.TabIndex = 1;
            this.FinanceTabPage.Text = "Finance Tracker";
            this.FinanceTabPage.UseVisualStyleBackColor = true;
            // 
            // mealTabPage
            // 
            this.mealTabPage.Location = new System.Drawing.Point(4, 29);
            this.mealTabPage.Name = "mealTabPage";
            this.mealTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mealTabPage.Size = new System.Drawing.Size(509, 417);
            this.mealTabPage.TabIndex = 2;
            this.mealTabPage.Text = "Meal Planner";
            this.mealTabPage.UseVisualStyleBackColor = true;
            // 
            // habitTabPage
            // 
            this.habitTabPage.Location = new System.Drawing.Point(4, 29);
            this.habitTabPage.Name = "habitTabPage";
            this.habitTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.habitTabPage.Size = new System.Drawing.Size(509, 417);
            this.habitTabPage.TabIndex = 3;
            this.habitTabPage.Text = "Habit Tracker";
            this.habitTabPage.UseVisualStyleBackColor = true;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Location = new System.Drawing.Point(4, 29);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTabPage.Size = new System.Drawing.Size(509, 417);
            this.settingsTabPage.TabIndex = 4;
            this.settingsTabPage.Text = "Settings";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "NavBar";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton agendaToolStripButton;
        private System.Windows.Forms.ToolStripButton financeToolStripButton;
        private System.Windows.Forms.ToolStripButton mealToolStripButton;
        private System.Windows.Forms.ToolStripButton habitToolStripButton;
        private System.Windows.Forms.ToolStripButton settingsToolStripButton;
        private System.Windows.Forms.ToolStripLabel deadlineLabel;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel quoteLabel;
        private System.Windows.Forms.Timer quoteTimer;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage agendaTabPage;
        private System.Windows.Forms.TabPage FinanceTabPage;
        private System.Windows.Forms.TabPage mealTabPage;
        private System.Windows.Forms.TabPage habitTabPage;
        private System.Windows.Forms.TabPage settingsTabPage;
    }
}


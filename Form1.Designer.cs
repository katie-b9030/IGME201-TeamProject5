namespace Nav
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.quoteLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.agendaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.financeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mealToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.habitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.settingsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.quoteTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.quoteLabel);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // quoteLabel
            // 
            this.quoteLabel.AutoSize = true;
            this.quoteLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.quoteLabel.Location = new System.Drawing.Point(0, 350);
            this.quoteLabel.MaximumSize = new System.Drawing.Size(266, 100);
            this.quoteLabel.MinimumSize = new System.Drawing.Size(266, 100);
            this.quoteLabel.Name = "quoteLabel";
            this.quoteLabel.Size = new System.Drawing.Size(266, 100);
            this.quoteLabel.TabIndex = 2;
            this.quoteLabel.Text = "\'A dead end is just a good place to turn around.\' - Naomi Judd";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 262);
            this.textBox1.MaximumSize = new System.Drawing.Size(266, 100);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 100);
            this.textBox1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripButton,
            this.financeToolStripButton,
            this.mealToolStripButton,
            this.habitToolStripButton,
            this.settingsToolStripButton,
            this.toolStripLabel1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(266, 262);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // agendaToolStripButton
            // 
            this.agendaToolStripButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agendaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("agendaToolStripButton.Image")));
            this.agendaToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agendaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.agendaToolStripButton.Name = "agendaToolStripButton";
            this.agendaToolStripButton.Size = new System.Drawing.Size(263, 33);
            this.agendaToolStripButton.Text = "Agenda";
            this.agendaToolStripButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // financeToolStripButton
            // 
            this.financeToolStripButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("financeToolStripButton.Image")));
            this.financeToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.financeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.financeToolStripButton.Name = "financeToolStripButton";
            this.financeToolStripButton.Size = new System.Drawing.Size(263, 33);
            this.financeToolStripButton.Text = "Finance Tracker";
            this.financeToolStripButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mealToolStripButton
            // 
            this.mealToolStripButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("mealToolStripButton.Image")));
            this.mealToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mealToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mealToolStripButton.Name = "mealToolStripButton";
            this.mealToolStripButton.Size = new System.Drawing.Size(263, 33);
            this.mealToolStripButton.Text = "Meal Planner";
            this.mealToolStripButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mealToolStripButton.ToolTipText = "Meal Planner";
            // 
            // habitToolStripButton
            // 
            this.habitToolStripButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("habitToolStripButton.Image")));
            this.habitToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.habitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.habitToolStripButton.Name = "habitToolStripButton";
            this.habitToolStripButton.Size = new System.Drawing.Size(263, 33);
            this.habitToolStripButton.Text = "Habit Tracker";
            this.habitToolStripButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // settingsToolStripButton
            // 
            this.settingsToolStripButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.settingsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripButton.Image")));
            this.settingsToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsToolStripButton.Name = "settingsToolStripButton";
            this.settingsToolStripButton.Size = new System.Drawing.Size(263, 31);
            this.settingsToolStripButton.Text = "Settings";
            this.settingsToolStripButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(263, 25);
            this.toolStripLabel1.Text = "Deadlines:";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quoteTimer
            // 
            this.quoteTimer.Interval = 86400000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton agendaToolStripButton;
        private System.Windows.Forms.ToolStripButton financeToolStripButton;
        private System.Windows.Forms.ToolStripButton mealToolStripButton;
        private System.Windows.Forms.ToolStripButton habitToolStripButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripButton settingsToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label quoteLabel;
        private System.Windows.Forms.Timer quoteTimer;
    }
}


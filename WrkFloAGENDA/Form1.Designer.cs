namespace WrkFloAGENDA
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
            this.calendarTime = new System.Windows.Forms.MonthCalendar();
            this.plusButton = new System.Windows.Forms.Button();
            this.yearButton = new System.Windows.Forms.Button();
            this.monthButton = new System.Windows.Forms.Button();
            this.weekButton = new System.Windows.Forms.Button();
            this.dayButton = new System.Windows.Forms.Button();
            this.agendaText = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.eventListBox = new System.Windows.Forms.Panel();
            this.viewAllEvents = new System.Windows.Forms.Button();
            this.eventListText = new System.Windows.Forms.Label();
            this.decreaseArrow = new System.Windows.Forms.Button();
            this.increaseArrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.eventListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarTime
            // 
            this.calendarTime.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.calendarTime.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.calendarTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.calendarTime.Location = new System.Drawing.Point(64, 237);
            this.calendarTime.Name = "calendarTime";
            this.calendarTime.TabIndex = 13;
            this.calendarTime.TitleForeColor = System.Drawing.SystemColors.Desktop;
            this.calendarTime.TodayDate = new System.DateTime(2023, 11, 19, 0, 0, 0, 0);
            this.calendarTime.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(25, 151);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(56, 35);
            this.plusButton.TabIndex = 12;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // yearButton
            // 
            this.yearButton.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearButton.Location = new System.Drawing.Point(503, 86);
            this.yearButton.Name = "yearButton";
            this.yearButton.Size = new System.Drawing.Size(80, 35);
            this.yearButton.TabIndex = 11;
            this.yearButton.Text = "Year";
            this.yearButton.UseVisualStyleBackColor = true;
            this.yearButton.Click += new System.EventHandler(this.yearButton_Click);
            // 
            // monthButton
            // 
            this.monthButton.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthButton.Location = new System.Drawing.Point(364, 86);
            this.monthButton.Name = "monthButton";
            this.monthButton.Size = new System.Drawing.Size(90, 35);
            this.monthButton.TabIndex = 10;
            this.monthButton.Text = "Month";
            this.monthButton.UseVisualStyleBackColor = true;
            this.monthButton.Click += new System.EventHandler(this.monthButton_Click);
            // 
            // weekButton
            // 
            this.weekButton.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekButton.Location = new System.Drawing.Point(217, 86);
            this.weekButton.Name = "weekButton";
            this.weekButton.Size = new System.Drawing.Size(90, 35);
            this.weekButton.TabIndex = 9;
            this.weekButton.Text = "Week";
            this.weekButton.UseVisualStyleBackColor = true;
            this.weekButton.Click += new System.EventHandler(this.weekButton_Click);
            // 
            // dayButton
            // 
            this.dayButton.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayButton.Location = new System.Drawing.Point(81, 86);
            this.dayButton.Name = "dayButton";
            this.dayButton.Size = new System.Drawing.Size(86, 35);
            this.dayButton.TabIndex = 8;
            this.dayButton.Text = "Day";
            this.dayButton.UseVisualStyleBackColor = true;
            this.dayButton.Click += new System.EventHandler(this.dayButton_Click);
            // 
            // agendaText
            // 
            this.agendaText.AutoSize = true;
            this.agendaText.Font = new System.Drawing.Font("Tw Cen MT Condensed", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agendaText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.agendaText.Location = new System.Drawing.Point(290, 25);
            this.agendaText.Name = "agendaText";
            this.agendaText.Size = new System.Drawing.Size(91, 39);
            this.agendaText.TabIndex = 7;
            this.agendaText.Text = "Agenda";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, -1);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.eventListBox);
            this.splitContainer1.Panel2.Controls.Add(this.eventListText);
            this.splitContainer1.Panel2.Controls.Add(this.decreaseArrow);
            this.splitContainer1.Panel2.Controls.Add(this.increaseArrow);
            this.splitContainer1.Panel2.Controls.Add(this.yearButton);
            this.splitContainer1.Panel2.Controls.Add(this.agendaText);
            this.splitContainer1.Panel2.Controls.Add(this.calendarTime);
            this.splitContainer1.Panel2.Controls.Add(this.dayButton);
            this.splitContainer1.Panel2.Controls.Add(this.plusButton);
            this.splitContainer1.Panel2.Controls.Add(this.weekButton);
            this.splitContainer1.Panel2.Controls.Add(this.monthButton);
            this.splitContainer1.Size = new System.Drawing.Size(795, 453);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is where nav will go";
            // 
            // eventListBox
            // 
            this.eventListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventListBox.Controls.Add(this.viewAllEvents);
            this.eventListBox.Location = new System.Drawing.Point(399, 241);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.Size = new System.Drawing.Size(200, 184);
            this.eventListBox.TabIndex = 18;
            // 
            // viewAllEvents
            // 
            this.viewAllEvents.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllEvents.Location = new System.Drawing.Point(49, 149);
            this.viewAllEvents.Name = "viewAllEvents";
            this.viewAllEvents.Size = new System.Drawing.Size(90, 30);
            this.viewAllEvents.TabIndex = 19;
            this.viewAllEvents.Text = "View All";
            this.viewAllEvents.UseVisualStyleBackColor = true;
            // 
            // eventListText
            // 
            this.eventListText.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventListText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eventListText.Location = new System.Drawing.Point(424, 202);
            this.eventListText.Name = "eventListText";
            this.eventListText.Size = new System.Drawing.Size(159, 36);
            this.eventListText.TabIndex = 17;
            this.eventListText.Text = "Events added:";
            // 
            // decreaseArrow
            // 
            this.decreaseArrow.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.decreaseArrow.Location = new System.Drawing.Point(64, 200);
            this.decreaseArrow.Name = "decreaseArrow";
            this.decreaseArrow.Size = new System.Drawing.Size(75, 26);
            this.decreaseArrow.TabIndex = 16;
            this.decreaseArrow.Text = "<--";
            this.decreaseArrow.UseVisualStyleBackColor = false;
            // 
            // increaseArrow
            // 
            this.increaseArrow.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.increaseArrow.Location = new System.Drawing.Point(251, 200);
            this.increaseArrow.Name = "increaseArrow";
            this.increaseArrow.Size = new System.Drawing.Size(75, 26);
            this.increaseArrow.TabIndex = 15;
            this.increaseArrow.Text = "-->";
            this.increaseArrow.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.eventListBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarTime;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button yearButton;
        private System.Windows.Forms.Button monthButton;
        private System.Windows.Forms.Button weekButton;
        private System.Windows.Forms.Button dayButton;
        private System.Windows.Forms.Label agendaText;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button increaseArrow;
        private System.Windows.Forms.Button decreaseArrow;
        private System.Windows.Forms.Button viewAllEvents;
        private System.Windows.Forms.Label eventListText;
        private System.Windows.Forms.Panel eventListBox;
    }
}


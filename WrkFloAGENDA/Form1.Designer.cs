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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.plusButton = new System.Windows.Forms.Button();
            this.yearButton = new System.Windows.Forms.Button();
            this.monthButton = new System.Windows.Forms.Button();
            this.weekButton = new System.Windows.Forms.Button();
            this.dayButton = new System.Windows.Forms.Button();
            this.agendaText = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.decreaseArrow = new System.Windows.Forms.Button();
            this.increaseArrow = new System.Windows.Forms.Button();
            this.eventsText = new System.Windows.Forms.Label();
            this.viewAllEvents = new System.Windows.Forms.Button();
            this.eventListBox = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.eventListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar.Location = new System.Drawing.Point(26, 233);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 13;
            this.monthCalendar.TitleForeColor = System.Drawing.SystemColors.Desktop;
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(20, 144);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(56, 35);
            this.plusButton.TabIndex = 12;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            // 
            // yearButton
            // 
            this.yearButton.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearButton.Location = new System.Drawing.Point(469, 83);
            this.yearButton.Name = "yearButton";
            this.yearButton.Size = new System.Drawing.Size(80, 40);
            this.yearButton.TabIndex = 11;
            this.yearButton.Text = "Year";
            this.yearButton.UseVisualStyleBackColor = true;
            // 
            // monthButton
            // 
            this.monthButton.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthButton.Location = new System.Drawing.Point(333, 83);
            this.monthButton.Name = "monthButton";
            this.monthButton.Size = new System.Drawing.Size(90, 40);
            this.monthButton.TabIndex = 10;
            this.monthButton.Text = "Month";
            this.monthButton.UseVisualStyleBackColor = true;
            // 
            // weekButton
            // 
            this.weekButton.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekButton.Location = new System.Drawing.Point(198, 83);
            this.weekButton.Name = "weekButton";
            this.weekButton.Size = new System.Drawing.Size(90, 40);
            this.weekButton.TabIndex = 9;
            this.weekButton.Text = "Week";
            this.weekButton.UseVisualStyleBackColor = true;
            // 
            // dayButton
            // 
            this.dayButton.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayButton.Location = new System.Drawing.Point(78, 83);
            this.dayButton.Name = "dayButton";
            this.dayButton.Size = new System.Drawing.Size(86, 40);
            this.dayButton.TabIndex = 8;
            this.dayButton.Text = "Day";
            this.dayButton.UseVisualStyleBackColor = true;
            // 
            // agendaText
            // 
            this.agendaText.AutoSize = true;
            this.agendaText.Font = new System.Drawing.Font("Tw Cen MT Condensed", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agendaText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.agendaText.Location = new System.Drawing.Point(246, 22);
            this.agendaText.Name = "agendaText";
            this.agendaText.Size = new System.Drawing.Size(91, 39);
            this.agendaText.TabIndex = 7;
            this.agendaText.Text = "Agenda";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 1);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.eventListBox);
            this.splitContainer1.Panel2.Controls.Add(this.decreaseArrow);
            this.splitContainer1.Panel2.Controls.Add(this.increaseArrow);
            this.splitContainer1.Panel2.Controls.Add(this.monthCalendar);
            this.splitContainer1.Panel2.Controls.Add(this.agendaText);
            this.splitContainer1.Panel2.Controls.Add(this.yearButton);
            this.splitContainer1.Panel2.Controls.Add(this.plusButton);
            this.splitContainer1.Panel2.Controls.Add(this.monthButton);
            this.splitContainer1.Panel2.Controls.Add(this.dayButton);
            this.splitContainer1.Panel2.Controls.Add(this.weekButton);
            this.splitContainer1.Size = new System.Drawing.Size(794, 446);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nav will go here";
            // 
            // decreaseArrow
            // 
            this.decreaseArrow.Location = new System.Drawing.Point(53, 198);
            this.decreaseArrow.Name = "decreaseArrow";
            this.decreaseArrow.Size = new System.Drawing.Size(75, 23);
            this.decreaseArrow.TabIndex = 15;
            this.decreaseArrow.Text = "<--";
            this.decreaseArrow.UseVisualStyleBackColor = true;
            // 
            // increaseArrow
            // 
            this.increaseArrow.Location = new System.Drawing.Point(198, 198);
            this.increaseArrow.Name = "increaseArrow";
            this.increaseArrow.Size = new System.Drawing.Size(75, 23);
            this.increaseArrow.TabIndex = 14;
            this.increaseArrow.Text = "-->";
            this.increaseArrow.UseVisualStyleBackColor = true;
            // 
            // eventsText
            // 
            this.eventsText.AutoSize = true;
            this.eventsText.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eventsText.Location = new System.Drawing.Point(43, 13);
            this.eventsText.Name = "eventsText";
            this.eventsText.Size = new System.Drawing.Size(105, 26);
            this.eventsText.TabIndex = 16;
            this.eventsText.Text = "Events Added:";
            // 
            // viewAllEvents
            // 
            this.viewAllEvents.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllEvents.Location = new System.Drawing.Point(48, 159);
            this.viewAllEvents.Name = "viewAllEvents";
            this.viewAllEvents.Size = new System.Drawing.Size(100, 40);
            this.viewAllEvents.TabIndex = 17;
            this.viewAllEvents.Text = "View All";
            this.viewAllEvents.UseVisualStyleBackColor = true;
            this.viewAllEvents.Click += new System.EventHandler(this.viewAllEvents_Click);
            // 
            // eventListBox
            // 
            this.eventListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventListBox.Controls.Add(this.eventsText);
            this.eventListBox.Controls.Add(this.viewAllEvents);
            this.eventListBox.Location = new System.Drawing.Point(350, 233);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.Size = new System.Drawing.Size(212, 204);
            this.eventListBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.eventListBox.ResumeLayout(false);
            this.eventListBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button yearButton;
        private System.Windows.Forms.Button monthButton;
        private System.Windows.Forms.Button weekButton;
        private System.Windows.Forms.Button dayButton;
        private System.Windows.Forms.Label agendaText;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button decreaseArrow;
        private System.Windows.Forms.Button increaseArrow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewAllEvents;
        private System.Windows.Forms.Label eventsText;
        private System.Windows.Forms.Panel eventListBox;
    }
}


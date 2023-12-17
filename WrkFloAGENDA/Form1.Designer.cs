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
            this.agendaCalendar = new System.Windows.Forms.MonthCalendar();
            this.plusButton = new System.Windows.Forms.Button();
            this.agendaText = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.yearRadio = new System.Windows.Forms.RadioButton();
            this.monthRadio = new System.Windows.Forms.RadioButton();
            this.weekRadio = new System.Windows.Forms.RadioButton();
            this.dayRadio = new System.Windows.Forms.RadioButton();
            this.addEventButton = new System.Windows.Forms.Button();
            this.addEventText = new System.Windows.Forms.Label();
            this.addEventBox = new System.Windows.Forms.TextBox();
            this.eventListBox = new System.Windows.Forms.Panel();
            this.event3 = new System.Windows.Forms.CheckBox();
            this.event2 = new System.Windows.Forms.CheckBox();
            this.event1 = new System.Windows.Forms.CheckBox();
            this.eventsText = new System.Windows.Forms.Label();
            this.viewAllEvents = new System.Windows.Forms.Button();
            this.decreaseArrow = new System.Windows.Forms.Button();
            this.increaseArrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.eventListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // agendaCalendar
            // 
            this.agendaCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.agendaCalendar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.agendaCalendar.Location = new System.Drawing.Point(26, 233);
            this.agendaCalendar.Name = "agendaCalendar";
            this.agendaCalendar.TabIndex = 13;
            this.agendaCalendar.TitleForeColor = System.Drawing.SystemColors.Desktop;
            this.agendaCalendar.TodayDate = new System.DateTime(2023, 12, 18, 0, 0, 0, 0);
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
            // agendaText
            // 
            this.agendaText.AutoSize = true;
            this.agendaText.Font = new System.Drawing.Font("Tw Cen MT", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agendaText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.agendaText.Location = new System.Drawing.Point(464, 6);
            this.agendaText.Name = "agendaText";
            this.agendaText.Size = new System.Drawing.Size(116, 39);
            this.agendaText.TabIndex = 7;
            this.agendaText.Text = "Agenda";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.splitContainer1.Location = new System.Drawing.Point(3, 1);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.agendaText);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Panel2.Controls.Add(this.yearRadio);
            this.splitContainer1.Panel2.Controls.Add(this.monthRadio);
            this.splitContainer1.Panel2.Controls.Add(this.weekRadio);
            this.splitContainer1.Panel2.Controls.Add(this.dayRadio);
            this.splitContainer1.Panel2.Controls.Add(this.addEventButton);
            this.splitContainer1.Panel2.Controls.Add(this.addEventText);
            this.splitContainer1.Panel2.Controls.Add(this.addEventBox);
            this.splitContainer1.Panel2.Controls.Add(this.eventListBox);
            this.splitContainer1.Panel2.Controls.Add(this.decreaseArrow);
            this.splitContainer1.Panel2.Controls.Add(this.increaseArrow);
            this.splitContainer1.Panel2.Controls.Add(this.agendaCalendar);
            this.splitContainer1.Panel2.Controls.Add(this.plusButton);
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
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitter1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitter1.Size = new System.Drawing.Size(14, 442);
            this.splitter1.TabIndex = 24;
            this.splitter1.TabStop = false;
            // 
            // yearRadio
            // 
            this.yearRadio.AutoSize = true;
            this.yearRadio.Location = new System.Drawing.Point(459, 91);
            this.yearRadio.Name = "yearRadio";
            this.yearRadio.Size = new System.Drawing.Size(57, 20);
            this.yearRadio.TabIndex = 23;
            this.yearRadio.TabStop = true;
            this.yearRadio.Text = "Year";
            this.yearRadio.UseVisualStyleBackColor = true;
            // 
            // monthRadio
            // 
            this.monthRadio.AutoSize = true;
            this.monthRadio.Location = new System.Drawing.Point(317, 91);
            this.monthRadio.Name = "monthRadio";
            this.monthRadio.Size = new System.Drawing.Size(64, 20);
            this.monthRadio.TabIndex = 22;
            this.monthRadio.TabStop = true;
            this.monthRadio.Text = "Month";
            this.monthRadio.UseVisualStyleBackColor = true;
            // 
            // weekRadio
            // 
            this.weekRadio.AutoSize = true;
            this.weekRadio.Location = new System.Drawing.Point(184, 91);
            this.weekRadio.Name = "weekRadio";
            this.weekRadio.Size = new System.Drawing.Size(64, 20);
            this.weekRadio.TabIndex = 21;
            this.weekRadio.TabStop = true;
            this.weekRadio.Text = "Week";
            this.weekRadio.UseVisualStyleBackColor = true;
            // 
            // dayRadio
            // 
            this.dayRadio.AutoSize = true;
            this.dayRadio.Location = new System.Drawing.Point(75, 91);
            this.dayRadio.Name = "dayRadio";
            this.dayRadio.Size = new System.Drawing.Size(53, 20);
            this.dayRadio.TabIndex = 20;
            this.dayRadio.TabStop = true;
            this.dayRadio.Text = "Day";
            this.dayRadio.UseVisualStyleBackColor = true;
            // 
            // addEventButton
            // 
            this.addEventButton.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEventButton.Location = new System.Drawing.Point(416, 192);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(66, 29);
            this.addEventButton.TabIndex = 18;
            this.addEventButton.Text = "Add";
            this.addEventButton.UseVisualStyleBackColor = true;
            // 
            // addEventText
            // 
            this.addEventText.AutoSize = true;
            this.addEventText.Location = new System.Drawing.Point(224, 154);
            this.addEventText.Name = "addEventText";
            this.addEventText.Size = new System.Drawing.Size(211, 16);
            this.addEventText.TabIndex = 19;
            this.addEventText.Text = "Select Day, Then Add Event Here:";
            // 
            // addEventBox
            // 
            this.addEventBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addEventBox.Location = new System.Drawing.Point(459, 151);
            this.addEventBox.Name = "addEventBox";
            this.addEventBox.Size = new System.Drawing.Size(100, 22);
            this.addEventBox.TabIndex = 18;
            // 
            // eventListBox
            // 
            this.eventListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventListBox.Controls.Add(this.event3);
            this.eventListBox.Controls.Add(this.event2);
            this.eventListBox.Controls.Add(this.event1);
            this.eventListBox.Controls.Add(this.eventsText);
            this.eventListBox.Controls.Add(this.viewAllEvents);
            this.eventListBox.Location = new System.Drawing.Point(350, 233);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.Size = new System.Drawing.Size(212, 204);
            this.eventListBox.TabIndex = 18;
            // 
            // event3
            // 
            this.event3.AutoSize = true;
            this.event3.Location = new System.Drawing.Point(12, 98);
            this.event3.Name = "event3";
            this.event3.Size = new System.Drawing.Size(18, 17);
            this.event3.TabIndex = 20;
            this.event3.UseVisualStyleBackColor = true;
            // 
            // event2
            // 
            this.event2.AutoSize = true;
            this.event2.Location = new System.Drawing.Point(12, 75);
            this.event2.Name = "event2";
            this.event2.Size = new System.Drawing.Size(18, 17);
            this.event2.TabIndex = 19;
            this.event2.UseVisualStyleBackColor = true;
            // 
            // event1
            // 
            this.event1.AutoSize = true;
            this.event1.Location = new System.Drawing.Point(12, 52);
            this.event1.Name = "event1";
            this.event1.Size = new System.Drawing.Size(18, 17);
            this.event1.TabIndex = 18;
            this.event1.UseVisualStyleBackColor = true;
            // 
            // eventsText
            // 
            this.eventsText.AutoSize = true;
            this.eventsText.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eventsText.Location = new System.Drawing.Point(38, 14);
            this.eventsText.Name = "eventsText";
            this.eventsText.Size = new System.Drawing.Size(127, 26);
            this.eventsText.TabIndex = 16;
            this.eventsText.Text = "Events For Today:";
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
            this.increaseArrow.Location = new System.Drawing.Point(213, 198);
            this.increaseArrow.Name = "increaseArrow";
            this.increaseArrow.Size = new System.Drawing.Size(75, 23);
            this.increaseArrow.TabIndex = 14;
            this.increaseArrow.Text = "-->";
            this.increaseArrow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "WrkFlo Agenda";
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

        private System.Windows.Forms.MonthCalendar agendaCalendar;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Label agendaText;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button decreaseArrow;
        private System.Windows.Forms.Button increaseArrow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewAllEvents;
        private System.Windows.Forms.Label eventsText;
        private System.Windows.Forms.Panel eventListBox;
        private System.Windows.Forms.TextBox addEventBox;
        private System.Windows.Forms.Label addEventText;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.CheckBox event2;
        private System.Windows.Forms.CheckBox event1;
        private System.Windows.Forms.CheckBox event3;
        private System.Windows.Forms.RadioButton yearRadio;
        private System.Windows.Forms.RadioButton monthRadio;
        private System.Windows.Forms.RadioButton weekRadio;
        private System.Windows.Forms.RadioButton dayRadio;
        private System.Windows.Forms.Splitter splitter1;
    }
}


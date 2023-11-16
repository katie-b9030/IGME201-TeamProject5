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
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar.Location = new System.Drawing.Point(325, 222);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 13;
            this.monthCalendar.TitleForeColor = System.Drawing.SystemColors.Desktop;
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(82, 137);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(56, 35);
            this.plusButton.TabIndex = 12;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            // 
            // yearButton
            // 
            this.yearButton.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearButton.Location = new System.Drawing.Point(638, 76);
            this.yearButton.Name = "yearButton";
            this.yearButton.Size = new System.Drawing.Size(80, 40);
            this.yearButton.TabIndex = 11;
            this.yearButton.Text = "Year";
            this.yearButton.UseVisualStyleBackColor = true;
            // 
            // monthButton
            // 
            this.monthButton.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthButton.Location = new System.Drawing.Point(471, 76);
            this.monthButton.Name = "monthButton";
            this.monthButton.Size = new System.Drawing.Size(90, 40);
            this.monthButton.TabIndex = 10;
            this.monthButton.Text = "Month";
            this.monthButton.UseVisualStyleBackColor = true;
            // 
            // weekButton
            // 
            this.weekButton.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekButton.Location = new System.Drawing.Point(303, 76);
            this.weekButton.Name = "weekButton";
            this.weekButton.Size = new System.Drawing.Size(90, 40);
            this.weekButton.TabIndex = 9;
            this.weekButton.Text = "Week";
            this.weekButton.UseVisualStyleBackColor = true;
            // 
            // dayButton
            // 
            this.dayButton.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayButton.Location = new System.Drawing.Point(146, 76);
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
            this.agendaText.Location = new System.Drawing.Point(396, 21);
            this.agendaText.Name = "agendaText";
            this.agendaText.Size = new System.Drawing.Size(91, 39);
            this.agendaText.TabIndex = 7;
            this.agendaText.Text = "Agenda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.yearButton);
            this.Controls.Add(this.monthButton);
            this.Controls.Add(this.weekButton);
            this.Controls.Add(this.dayButton);
            this.Controls.Add(this.agendaText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button yearButton;
        private System.Windows.Forms.Button monthButton;
        private System.Windows.Forms.Button weekButton;
        private System.Windows.Forms.Button dayButton;
        private System.Windows.Forms.Label agendaText;
    }
}


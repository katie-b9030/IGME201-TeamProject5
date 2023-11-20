using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WrkFloAGENDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.dayButton.Click += new EventHandler(this.DayButton__Click);
            this.weekButton.Click += new EventHandler(this.WeekButton__Click);
            this.monthButton.Click += new EventHandler(this.MonthButton__Click);
            this.yearButton.Click += new EventHandler(this.YearButton__Click);
            this.plusButton.Click += new EventHandler(this.PlusButton__Click);
            this.increaseArrow.Click += new EventHandler(this.IncreaseArrow__Click);
            this.decreaseArrow.Click += new EventHandler(this.DecreaseArrow__Click);


            this.agendaText.ForeColor = Color.LightSkyBlue;
            this.dayButton.ForeColor = Color.LightSkyBlue;
            this.weekButton.ForeColor = Color.LightSkyBlue;
            this.monthButton.ForeColor = Color.LightSkyBlue;
            this.yearButton.ForeColor = Color.LightSkyBlue;
            this.plusButton.ForeColor = Color.Blue;

            
        }

        private void DayButton__Click(object sender, EventArgs e)
        {
            dayButton.ForeColor = Color.Blue;
            weekButton.ForeColor = Color.SkyBlue;
            monthButton.ForeColor = Color.SkyBlue;
            yearButton.ForeColor = Color.SkyBlue;

            calendarTime.MinDate = DateTime.Today.AddDays(0);
            calendarTime.MaxDate = DateTime.Today.AddDays(0);
        }

        private void WeekButton__Click(object sender, EventArgs e)
        {
            weekButton.ForeColor = Color.Blue;
            monthButton.ForeColor = Color.SkyBlue;
            yearButton.ForeColor = Color.SkyBlue;
            dayButton.ForeColor = Color.SkyBlue;

            calendarTime.MinDate = DateTime.Today.AddDays(-7);
            calendarTime.MaxDate = DateTime.Today.AddDays(7);
        }

        private void MonthButton__Click(object sender, EventArgs e)
        {
            monthButton.ForeColor = Color.Blue;
            yearButton.ForeColor = Color.SkyBlue;
            dayButton.ForeColor = Color.SkyBlue;
            weekButton.ForeColor = Color.SkyBlue;

            calendarTime.MinDate = DateTime.Today.AddMonths(-1);
            calendarTime.MaxDate = DateTime.Today.AddMonths(1);
        }

        private void YearButton__Click(object sender, EventArgs e)
        {
            yearButton.ForeColor = Color.Blue;
            monthButton.ForeColor = Color.SkyBlue;
            dayButton.ForeColor = Color.SkyBlue;
            weekButton.ForeColor = Color.SkyBlue;

            calendarTime.MinDate = DateTime.Today.AddYears(-1);
            calendarTime.MaxDate = DateTime.Today.AddYears(1);
        }

        private void PlusButton__Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dayButton_Click(object sender, EventArgs e)
        {
            
        }

        private void weekButton_Click(object sender, EventArgs e)
        {

        }

        private void monthButton_Click(object sender, EventArgs e)
        {

        }

        private void yearButton_Click(object sender, EventArgs e)
        {

        }

        private void plusButton_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void IncreaseArrow__Click(object sender, EventArgs e)
        {
            //monthCalendar.TodayDate = DateTime.Today.AddDays(1);
        }

        private void DecreaseArrow__Click(object sender, EventArgs e)
        {

        }
    }
}


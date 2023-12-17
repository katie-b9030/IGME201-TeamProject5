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
        // store the extra events (beyond 3) 
        List<string> allEvents = new List<string>();

        // shows what day each event is happening when "more events" is clicked
        DateTime eventDay1;
        DateTime eventDay2;
        DateTime eventDay3;

        int i = 2;
        public Form1()
        {
            InitializeComponent();

            // event handlers
            this.plusButton.Click += new EventHandler(this.PlusButton__Click);
            this.increaseArrow.Click += new EventHandler(this.IncreaseArrow__Click);
            this.decreaseArrow.Click += new EventHandler(this.DecreaseArrow__Click);
            this.addEventButton.Click += new EventHandler(this.AddEventButton__Click);

            this.dayRadio.CheckedChanged += new EventHandler(this.DayRadio__CheckedChanged);
            this.weekRadio.CheckedChanged += new EventHandler(this.WeekRadio__CheckedChanged);
            this.monthRadio.CheckedChanged += new EventHandler(this.MonthRadio__CheckedChanged);
            this.yearRadio.CheckedChanged += new EventHandler(this.YearRadio__CheckedChanged);

            this.event1.CheckedChanged += new EventHandler(this.Event1__CheckedChanged);
            this.event2.CheckedChanged += new EventHandler(this.Event2__CheckedChanged);
            this.event3.CheckedChanged += new EventHandler(this.Event3__CheckedChanged);

            this.agendaCalendar.DateSelected += new DateRangeEventHandler(this.AgendaCalendar__DateSelected);
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            
           


            // set starting state
            addEventBox.Visible = false;
            addEventText.Visible = false;
            addEventButton.Visible = false;
            event1.Visible = false;
            event2.Visible = false;
            event3.Visible = false;

            // set starting colors
           // this.agendaText.ForeColor = Color.LightSkyBlue;
            this.dayRadio.ForeColor = Color.Blue;
            this.dayRadio.BackColor = Color.LightGray;
            this.weekRadio.ForeColor = Color.Blue;
            this.weekRadio.BackColor = Color.LightGray;
            this.monthRadio.ForeColor = Color.Blue;
            this.monthRadio.BackColor = Color.LightGray;
            this.yearRadio.ForeColor = Color.Blue;
            this.yearRadio.BackColor = Color.LightGray;
            this.plusButton.ForeColor = Color.Blue;


        }

        // When a date is selected on the calendar
        private void AgendaCalendar__DateSelected(object sender, DateRangeEventArgs e)
        {
            // MessageBox.Show(e.Start.ToShortDateString());


            // if day selected is different day than when new event was typed in, remove event
            if (event1.Visible = true && e.Start != eventDay1)
            {
                event1.Visible = false;
            }
            else if (e.Start == eventDay1)
            {
                event1.Visible = true;
            }

           if (event2.Visible = true && e.Start != eventDay2)
            {
                event2.Visible = false;
            }
           else if (e.Start == eventDay2)
            {
                event2.Visible = true;
            }

           if (event3.Visible = true && e.Start != eventDay3)
            {
                event3.Visible = false;
            }
           else if (e.Start == eventDay3)
            {
                event3.Visible = true;
            }
        }

        private void DayRadio__CheckedChanged(object sender, EventArgs e)
        {
            dayRadio.ForeColor = Color.Blue;
            agendaCalendar.MinDate = agendaCalendar.SelectionStart.AddDays(0);
            agendaCalendar.MaxDate = agendaCalendar.SelectionStart.AddDays(0);
        }
             
        private void WeekRadio__CheckedChanged(object sender, EventArgs e)
        {
            agendaCalendar.MinDate = agendaCalendar.SelectionStart.AddDays(0);
            agendaCalendar.MaxDate = agendaCalendar.SelectionStart.AddDays(6);
        }

        private void MonthRadio__CheckedChanged(object sender, EventArgs e)
        {
            agendaCalendar.MinDate = agendaCalendar.SelectionStart.AddMonths(0);
            agendaCalendar.MaxDate = agendaCalendar.SelectionStart.AddMonths(1);
        }

        private void YearRadio__CheckedChanged(object sender, EventArgs e)
        {
            agendaCalendar.MinDate = agendaCalendar.SelectionStart.AddYears(0);
            agendaCalendar.MaxDate = agendaCalendar.SelectionStart.AddYears(1);
        }

        private void IncreaseArrow__Click(object sender, EventArgs e)
        {
          if (dayRadio.Checked == true)
            {
                agendaCalendar.MaxDate = agendaCalendar.SelectionStart.AddDays(1);
                agendaCalendar.SelectionStart = agendaCalendar.SelectionStart.AddDays(1);
                agendaCalendar.MinDate = agendaCalendar.SelectionStart.AddDays(0);
              
            }
          else if (weekRadio.Checked == true)
            {
                agendaCalendar.MaxDate = agendaCalendar.SelectionStart.AddDays(13);
                agendaCalendar.SelectionStart = agendaCalendar.SelectionStart.AddDays(7);
                agendaCalendar.MinDate = agendaCalendar.SelectionStart.AddDays(0);
            }
          else if (monthRadio.Checked == true)
            {
                agendaCalendar.MaxDate = agendaCalendar.SelectionStart.AddMonths(2);
                agendaCalendar.SelectionStart = agendaCalendar.SelectionStart.AddMonths(1);
                agendaCalendar.MinDate = agendaCalendar.SelectionStart.AddMonths(0);
            }
          else if (yearRadio.Checked == true)
            {
                agendaCalendar.MaxDate = agendaCalendar.SelectionStart.AddYears(2);
                agendaCalendar.SelectionStart = agendaCalendar.SelectionStart.AddYears(1);
                agendaCalendar.MinDate = agendaCalendar.SelectionStart.AddYears(0);
            }
           
        }

        private void DecreaseArrow__Click(object sender, EventArgs e)
        {
            if (dayRadio.Checked == true)
            {
                agendaCalendar.MinDate = agendaCalendar.SelectionStart.AddDays(-1);
                agendaCalendar.SelectionStart = agendaCalendar.SelectionStart.AddDays(0);
                agendaCalendar.MaxDate = agendaCalendar.SelectionStart.AddDays(-1);
            }
            else if (weekRadio.Checked == true)
            {
                agendaCalendar.MinDate = agendaCalendar.SelectionStart.AddDays(-7);
                agendaCalendar.SelectionStart = agendaCalendar.SelectionStart.AddDays(-7);
                agendaCalendar.MaxDate = agendaCalendar.SelectionStart.AddDays(6);
            }
            else if (monthRadio.Checked == true)
            {
                agendaCalendar.MinDate = agendaCalendar.SelectionStart.AddMonths(-1);
                agendaCalendar.SelectionStart = agendaCalendar.SelectionStart.AddMonths(-1);
                agendaCalendar.MaxDate = agendaCalendar.SelectionStart.AddMonths(1);
            }
            else if (yearRadio.Checked == true)
            {
                agendaCalendar.MinDate = agendaCalendar.SelectionStart.AddYears(-1);
                agendaCalendar.SelectionStart = agendaCalendar.SelectionStart.AddYears(-1);
                agendaCalendar.MaxDate = agendaCalendar.SelectionStart.AddYears(1);
            }
        }

        private void PlusButton__Click(object sender, EventArgs e)
        {
            addEventBox.Text = "";
            addEventText.Visible = true;
            addEventBox.Visible = true;
            addEventButton.Visible = true;
        }

        // When add event button is clicked
        private void AddEventButton__Click(object sender, EventArgs e)
        {
            //  int n = 0;
            // eventDay = agendaCalendar.SelectionStart;

            // add events 
            allEvents.Add(addEventBox.Text);

            // if no events have been added yet, make event 1 visible & change text
            if (event1.Visible != true && event1.Text == "")
            {
                event1.Text = addEventBox.Text;
                event1.Visible = true;

                addEventText.Visible = false;
                addEventBox.Visible = false;
                addEventButton.Visible = false;

                eventDay1 = agendaCalendar.SelectionStart;

            }
            // if an event has already been added on different day, make event 2 text visible
            else if (event1.Visible != true && event1.Text != "" && event2.Visible != true && event2.Text == "")
            {
                event2.Text = addEventBox.Text;
                event2.Visible = true;

                addEventText.Visible = false;
                addEventBox.Visible = false;
                addEventButton.Visible = false;

                eventDay2 = agendaCalendar.SelectionStart;
            }
            // if event added on same day, make event 2 text visible
            else if (event1.Visible == true && event2.Visible != true) 
            {
                event2.Text = addEventBox.Text;
                event2.Visible = true;

                addEventText.Visible = false;
                addEventBox.Visible = false;
                addEventButton.Visible = false;

                eventDay2 = agendaCalendar.SelectionStart;
            }
            // if 2 events already added on different days, make event 3 text visible
            else if (event2.Visible != true && event1.Visible != true && event2.Text != "" && event1.Text != "" && event3.Text == "")
            {
                event3.Text = addEventBox.Text;
                event3.Visible = true;

                addEventText.Visible = false;
                addEventBox.Visible = false;
                addEventButton.Visible = false;

                eventDay3 = agendaCalendar.SelectionStart;
            }
            // if events added on same day, make event 3 text visible
            else if (event2.Visible == true && event3.Visible != true)
            {
                event3.Text = addEventBox.Text;
                event3.Visible = true;

                addEventText.Visible = false;
                addEventBox.Visible = false;
                addEventButton.Visible = false;

                eventDay3 = agendaCalendar.SelectionStart;
            }
            // if 3 events have been already added for a day, store extra events for the more events tab
            else if (event1.Text != "" && event2.Text != "" && event3.Text != "") 
            {
              

                addEventText.Visible = false;
                addEventBox.Visible = false;
                addEventButton.Visible = false;
                i++;
            }

        }

        private void Event1__CheckedChanged(object sender, EventArgs e)
        {
                event1.Text = "";
                event1.Checked = false;
                event1.Visible = false;
                allEvents.Remove(event1.Text);
        }

        private void Event2__CheckedChanged(object sender, EventArgs e)
        {
            event2.Text = "";
            event2.Checked = false;
            event2.Visible = false;
            allEvents.Remove(event2.Text);
        }

        private void Event3__CheckedChanged(object sender, EventArgs e)
        {
            event3.Text = "";
            event3.Checked = false;
            event3.Visible = false;
            allEvents.Remove(event3.Text);
        }

        private void viewAllEvents_Click(object sender, EventArgs e)
        {
            string[] allEventsArray = allEvents.ToArray();


           if (allEventsArray.Length <= 2)
            {
                MessageBox.Show("3 or more events have not been added yet.");
       
            }
           else if (allEventsArray.Length == 3)
            {
                MessageBox.Show("Events: " + "\n" /*+ eventDay1 + ": "*/ + event1.Text + "\n" /*+ eventDay2 + ": "*/ + event2.Text + "\n" /*+ eventDay3 + ": " */ + event3.Text);
            }

            else if (allEventsArray.Length >= 4)
                {
             
                 MessageBox.Show("Events:" + "\n" /*+ eventDay1 + ": " */ + event1.Text + "\n" /*+ eventDay2 + ": " */ + event2.Text + "\n" /*+ eventDay3 + ": "*/  + event3.Text + "\n" + allEventsArray[i]);
                 //  i++;
            }
     

        }
    }
}


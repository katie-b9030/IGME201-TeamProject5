using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        DateTime moreEventDay;

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

          //  this.agendaCalendar.DateSelected += new DateRangeEventHandler(this.AgendaCalendar__DateSelected);
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

        // When day radio button checked, only show a day at a time
        private void DayRadio__CheckedChanged(object sender, EventArgs e)
        {
            dayRadio.ForeColor = Color.Blue;
            agendaCalendar.MinDate = agendaCalendar.SelectionStart.AddDays(0);
            agendaCalendar.MaxDate = agendaCalendar.SelectionStart.AddDays(0);
        }
        // When week radio button checked, only show a week at a time
        private void WeekRadio__CheckedChanged(object sender, EventArgs e)
        {
            agendaCalendar.MinDate = agendaCalendar.SelectionStart.AddDays(0);
            agendaCalendar.MaxDate = agendaCalendar.SelectionStart.AddDays(6);
        }
        // When month radio button checked, only show a month at a time
        private void MonthRadio__CheckedChanged(object sender, EventArgs e)
        {
            agendaCalendar.MinDate = agendaCalendar.SelectionStart.AddMonths(0);
            agendaCalendar.MaxDate = agendaCalendar.SelectionStart.AddMonths(1);
        }
        // When year radio button checked, only show a year at a time
        private void YearRadio__CheckedChanged(object sender, EventArgs e)
        {
            agendaCalendar.MinDate = agendaCalendar.SelectionStart.AddYears(0);
            agendaCalendar.MaxDate = agendaCalendar.SelectionStart.AddYears(1);
        }
        // When increase arrow checked, depending on current radio button selected, move forward in calendar
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
        // When decrease arrow checked, depending on current radio button selected, move backward in calendar
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
        // When "add event" button checked, make textbox/text to add event visible
        private void PlusButton__Click(object sender, EventArgs e)
        {
            addEventBox.Text = "";
            addEventText.Visible = true;
            addEventBox.Visible = true;
            addEventButton.Visible = true;
        }

        // When add event button is clicked, depending on # events added yet, make visibile & set dates
        private void AddEventButton__Click(object sender, EventArgs e)
        {
            // add events to the "all events" section (array/list)
            allEvents.Add(addEventBox.Text);

            // if no events have been added yet, make event 1 visible & change text. set date as eventDay1
            if (event1.Visible != true && event1.Text == "")
            {
                event1.Text = addEventBox.Text;
                event1.Visible = true;

                addEventText.Visible = false;
                addEventBox.Visible = false;
                addEventButton.Visible = false;

                eventDay1 = agendaCalendar.SelectionStart;

            }
           
            // if 1 event added on same day, make event 2 text visible. set date as eventDay2
            else if (event1.Visible == true && event2.Visible != true) 
            {
                event2.Text = addEventBox.Text;
                event2.Visible = true;

                addEventText.Visible = false;
                addEventBox.Visible = false;
                addEventButton.Visible = false;

                eventDay2 = agendaCalendar.SelectionStart;
            }
            
            // if 2 events added, make event 3 text visible. set date as eventDay3
            else if (event2.Visible == true && event3.Visible != true)
            {
                event3.Text = addEventBox.Text;
                event3.Visible = true;

                addEventText.Visible = false;
                addEventBox.Visible = false;
                addEventButton.Visible = false;

                eventDay3 = agendaCalendar.SelectionStart;
            }
            // if 3 events have been already added in total, store extra events for the more events tab
            else if (event1.Text != "" && event2.Text != "" && event3.Text != "") 
            {
                addEventText.Visible = false;
                addEventBox.Visible = false;
                addEventButton.Visible = false;
                i++;

                moreEventDay = agendaCalendar.SelectionStart;
            }

        }

        // When event 1 is checked off, remove it
        private void Event1__CheckedChanged(object sender, EventArgs e)
        {
                event1.Text = "";
                event1.Checked = false;
                event1.Visible = false;
                allEvents.Remove(event1.Text);
        }

        // When event 2 is checked off, remove it
        private void Event2__CheckedChanged(object sender, EventArgs e)
        {
            event2.Text = "";
            event2.Checked = false;
            event2.Visible = false;
            allEvents.Remove(event2.Text);
        }

        // When event 3 is checked off, remove it
        private void Event3__CheckedChanged(object sender, EventArgs e)
        {
            event3.Text = "";
            event3.Checked = false;
            event3.Visible = false;
            allEvents.Remove(event3.Text);
        }

        // When "view all events" clicked, push a message box showing events
        private void viewAllEvents_Click(object sender, EventArgs e)
        {
            string[] allEventsArray = allEvents.ToArray();

            // If no events, show nothing's there yet
           if (allEventsArray.Length == 0)
            {
                MessageBox.Show("No events added yet!");
       
            }
           // Else if 1 event added, print that event & day
           else if (allEventsArray.Length == 1)
            {
                MessageBox.Show(eventDay1.ToString("MM/dd/yyyy") + ": " + event1.Text);
            }
           // Else if 2 added, print that event & day
           else if (allEventsArray.Length == 2)
            {
                MessageBox.Show(eventDay1.ToString("MM/dd/yyyy") + ": " + event1.Text + "\n" + eventDay2.ToString("MM/dd/yyyy") + ": " + event2.Text);
            }
           // Else if 3 added, print that event & day
           else if (allEventsArray.Length == 3)
            {
                MessageBox.Show(eventDay1.ToString("MM/dd/yyyy") + ": " + event1.Text + "\n" + eventDay2.ToString("MM/dd/yyyy") + ": " + event2.Text + "\n" + eventDay3.ToString("MM/dd/yyyy") + ": " + event3.Text);
            }
           // else if 4+ events, show what was last added and add it to list
            else if (allEventsArray.Length >= 4)
            {
                MessageBox.Show("Event last added: '" + allEventsArray[i] + "'");

               /* for (int j = 3; j <= allEventsArray.Length; j+=3)
                {*/
                    MessageBox.Show("All Events: "  + "\n" + eventDay1.ToString("MM/dd/yyyy") + ": " + event1.Text + "\n" + eventDay2.ToString("MM/dd/yyyy") + ": " + event2.Text + "\n" + eventDay3.ToString("MM/dd/yyyy") + ": " + event3.Text + "\n" + moreEventDay.ToString("MM/dd/yyyy") + ": " + allEventsArray[i]);

               // }
            }
        }
    }
}


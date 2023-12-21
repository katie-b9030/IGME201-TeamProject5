using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavBar
{
    public partial class Form1 : Form
    {
        private List<string> quotes = new List<string>
        {
            "'Find out who you are and do it on purpose.' - Dolly Parton",
            "'Try to be a rainbow in someone else's cloud.' - Maya Angelou",
            "'Fight for the things that you care about, but do it in a way that will lead others to join you.' - Ruth Bader Ginsburg",
            "'Once you replace negative thoughts with positive ones, you'll start having positive results.' - Willie Nelson",
            "'Positive anything is better than negative nothing' - Elbert Hubbard",
            "'Each day comes baring its gifts. Untie the ribbon.' - Ann Ruth Schabaker",
            "'A dead end is just a good place to turn around.' - Naomi Judd"
        };

        private string agendaLink = "C:\\Users\\Laila Porter\\OneDrive - rit.edu\\Desktop\\IGME 201\\groupproject\\IGME201-TeamProject5\\WrkFloAGENDA\\Form1.resx";
        private string financeLink = "C:\\Users\\Laila Porter\\OneDrive - rit.edu\\Desktop\\IGME 201\\groupproject\\IGME201-TeamProject5\\wrkFloFinanceTracker\\Form1.resx";
        private string mealLink = "C:\\Users\\Laila Porter\\OneDrive - rit.edu\\Desktop\\IGME 201\\groupproject\\IGME201-TeamProject5\\wrkFloMealPlanner\\wrkFloMealPlanner\\Form1.resx";
        private string habitLink = "C:\\Users\\Laila Porter\\OneDrive - rit.edu\\Desktop\\IGME 201\\groupproject\\IGME201-TeamProject5\\wrkFloHabitTracker\\Form1.resx";


        public Form1()
        {
            InitializeComponent();

            agendaToolStripButton.Enabled = true;
            agendaToolStripButton.Click += new EventHandler(AgendaToolStripButton__Click);

            financeToolStripButton.Enabled = true;
            financeToolStripButton.Click += new EventHandler(FinanceToolStripButton__CLick);

            mealToolStripButton.Enabled = true;
            mealToolStripButton.Click += new EventHandler(MealToolStripButton__CLick);

            habitToolStripButton.Enabled = true;
            habitToolStripButton.Click += new EventHandler(HabitToolStripButton__CLick);

            settingsToolStripButton.Enabled = true;
            settingsToolStripButton.Click += new EventHandler(SettingsToolStripButton__CLick);

            quoteTimer.Enabled = true;
            quoteTimer.Interval = 86400000;
            quoteTimer.Tick += new EventHandler(QuoteTimer__Tick);
            quoteTimer.Start();

            quotes.AsReadOnly();

            
        }

        private void QuoteTimer__Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= quotes.Count; i++)
            {
                quoteLabel.Text = quotes[i];
            }
        }

        private void AgendaToolStripButton__Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                FileName = agendaLink; 
            }
            Process.Start("wrkflo agenda", FileName); 
        }

        private void FinanceToolStripButton__CLick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                FileName = financeLink;
            }
            Process.Start("wrkflo agenda", FileName);
        }

        private void MealToolStripButton__CLick(Object sender, EventArgs e)
        {
             OpenFileDialog openFileDialog = new OpenFileDialog()
             {
                FileName = mealLink;
             }
             Process.Start("wrkflo agenda", FileName);
        }

        private void HabitToolStripButton__CLick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                FileName = mealLink;
            }
            Process.Start("wrkflo agenda", FileName);
        }

        private void SettingsToolStripButton__CLick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                FileName = mealLink;
            }
            Process.Start("wrkflo agenda", FileName);
        }


    }
}

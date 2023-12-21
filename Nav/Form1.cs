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

namespace Nav
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

        

        public Form1(Form1 nav)
        {
            InitializeComponent();

            this.MdiParent = nav;

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

            this.FormClosing += new FormClosingEventHandler(this.Form1__FormClosing);

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
            // the MdiParent form keeps track of which child form is currently active
            if (this.MdiParent != this)
            {
                return;
            }
            AgendaForm1 agendaForm = new AgendaForm1();
            agendaForm.Show(); 


        }


        private void FinanceToolStripButton__CLick(object sender, EventArgs e)
        {
            // the MdiParent form keeps track of which child form is currently active
            if (this.MdiParent != this)
            {
                return;
            }
            FinanceForm1 financeForm = new FinanceForm1();
            OptionForm optionForm = new OptionForm(); 
            financeForm.Show();
            optionForm.Show();
        }


        private void MealToolStripButton__CLick(Object sender, EventArgs e)
        {
            // the MdiParent form keeps track of which child form is currently active
            if (this.MdiParent != this)
            {
                return;
            }
            MealForm1 mealForm = new MealForm1();
            MealForm2 mealForm2 = new MealForm2();
            MealForm3 mealForm3 = new MealForm3();
            MealForm4 mealForm4 = new MealForm4();
            mealForm.Show();
            mealForm2.Show();
            mealForm3.Show();
            mealForm4.Show();
        }

        private void HabitToolStripButton__CLick(object sender, EventArgs e)
        {
            // the MdiParent form keeps track of which child form is currently active
            if (this.MdiParent != this)
            {
                return;
            }
            HabitForm1 habitForm = new HabitForm1();
            HabitForm2 habitForm2 = new HabitForm2(); 

            habitForm.Show();

        }

        private void SettingsToolStripButton__CLick(object sender, EventArgs e)
        {
            // the MdiParent form keeps track of which child form is currently active
            if (this.MdiParent != this)
            {
                return;
            }

        }

        private void Form1__FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 nav = (Form1)this.MdiParent;
            nav.agendaToolStripButton.Click -= this.AgendaToolStripButton__Click;
            nav.financeToolStripButton.Click -= this.FinanceToolStripButton__CLick;
            nav.mealToolStripButton.Click -= this.MealToolStripButton__CLick;
            nav.habitToolStripButton.Click -= this.HabitToolStripButton__CLick;
            nav.settingsToolStripButton.Click -= this.SettingsToolStripButton__CLick; 
        }


    }
}
    

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wrkFloHabitTracker
{
    public partial class Form1 : Form
    {
        private Label[] habitLabels;
        private CheckBox[,] habitCheckBoxes;
        public Form1()
        {
            InitializeComponent();

            habitLabels = new Label[] {habitLabel1, habitLabel2, habitLabel3, habitLabel4, habitLabel5, habitLabel6};
            habitCheckBoxes = new CheckBox[6, 7] {{checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7},
                                                  {checkBox8, checkBox9, checkBox10, checkBox11, checkBox12, checkBox13, checkBox14},
                                                  {checkBox15, checkBox16, checkBox17, checkBox18, checkBox19, checkBox20, checkBox21},
                                                  {checkBox22, checkBox23, checkBox24, checkBox25, checkBox26, checkBox27, checkBox28},
                                                  {checkBox29, checkBox30, checkBox31, checkBox32, checkBox33, checkBox34, checkBox35},
                                                  {checkBox36, checkBox37, checkBox38, checkBox39, checkBox40, checkBox41, checkBox42}};

            this.addButton.Click += new EventHandler(AddButton__Click);
            this.removeButton.Click += new EventHandler(RemoveButton__Click);
        }

        private void RemoveButton__Click(object sender, EventArgs e)
        {
            for (int i = 5; i > -1; i--)
            {
                Label label = habitLabels[i];
                if (label.Visible == true)
                {
                    label.Visible = false;
                    for (int j = 0; j < 7; j++)
                    {
                        habitCheckBoxes[i, j].Visible = false;
                    }

                    break;
                }
            }
        }

        private void AddButton__Click(object sender, EventArgs e)
        {
            using (HabitForm habitForm = new HabitForm())
            {
                if (habitForm.ShowDialog() == DialogResult.OK)
                {
                    // user clicked "Add", retrieve habit name and update a row to become visible and change the label
                    string newHabitName = habitForm.HabitName;

                    for(int i = 0; i < 6; i++)
                    {
                        Label label = habitLabels[i];
                        if(label.Visible == false)
                        {
                            label.Text = newHabitName;
                            label.Visible = true;
                            for (int j = 0; j < 7; j++)
                            {
                                habitCheckBoxes[i, j].Visible = true;
                            }

                            break;
                        }
                    }
                }
            }
        }

    }
}

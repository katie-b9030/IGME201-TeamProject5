using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wrkFloHabitTracker
{
    public partial class HabitForm : Form
    {
        public HabitForm()
        {
            InitializeComponent();

            this.addButton.Click += new EventHandler(AddButton__Click);

            this.cancelButton.Click += new EventHandler(CancelButton__Click);
        }

        private void CancelButton__Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddButton__Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}

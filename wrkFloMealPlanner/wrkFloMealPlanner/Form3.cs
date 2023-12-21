using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wrkFloMealPlanner
{
    //Very small form to display a recipe's url in a web browser
    public partial class Form3 : Form
    {
        private string recipeName;
        private string urlString;
        //Constructor takes a recipe's name and url and displays them in a web browser inside a group box
        public Form3(string recipe, string url)
        {
            InitializeComponent();
            recipeName = recipe;
            urlString = url;

            this.Text = recipeName;

            groupBox.Text = urlString;
            webBrowser.Url = new Uri(urlString);
            
        }
    }
}

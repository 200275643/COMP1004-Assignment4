// RAD-Assignment4, Chandra Reddy Gundam #200275643, 01-12-2016. 
// This program select product table from Microsoft Azure and put products list to Data Grid,
// user can choose any product, save and read from files
// final form show all data and calculate total cost
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Assignment4
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            LoadingTimer.Enabled = false;
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Hide();
        }
    }
}

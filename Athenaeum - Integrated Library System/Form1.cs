using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Athenaeum___Integrated_Library_System
{
    public partial class WelcomingPage : Form
    {
        public WelcomingPage()
        {
            InitializeComponent();
        }

        private void WelcomingPage_Load(object sender, EventArgs e)
        {
            StartingPageTimer.Enabled = true;
        }

        private void StartingPageTimer_Tick(object sender, EventArgs e)
        {
            StartingPageTimer.Enabled = false;
            MainPage form = new MainPage();
            form.Show();
            this.Hide();

        }

       
    }
}

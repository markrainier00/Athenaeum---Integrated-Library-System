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
    public partial class BookManagerPage : Form
    {
        public BookManagerPage()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            MainPage form1 = new MainPage();
            form1.Show();
            this.Hide();
        }
    }
}

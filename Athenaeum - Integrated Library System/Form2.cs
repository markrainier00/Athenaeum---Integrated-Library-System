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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void addborrowerbutton_Click(object sender, EventArgs e)
        {
            AddBorrowerPage form1 = new AddBorrowerPage();
            form1.Show();
            this.Hide();
        }

        private void addreservationbutton_Click(object sender, EventArgs e)
        {
            AddReservationPage form2 = new AddReservationPage();
            form2.Show();
            this.Hide();
        }

        private void bookmanagerbutton_Click(object sender, EventArgs e)
        {
            BookManagerPage form3 = new BookManagerPage();
            form3.Show();
            this.Hide();
        }

        private void listofborrowerbutton_Click(object sender, EventArgs e)
        {
            ListOfBorrowerPage form4 = new ListOfBorrowerPage();
            form4.Show();
            this.Hide();
        }

        private void listofreservationbutton_Click(object sender, EventArgs e)
        {
            ListOfReservationPage form5 = new ListOfReservationPage();
            form5.Show();
            this.Hide();
        }
    }
}

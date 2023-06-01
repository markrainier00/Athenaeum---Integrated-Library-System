using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Athenaeum___Integrated_Library_System
{
    public partial class AddBorrowerPage : Form
    {
        public static string id = "";
        public static string studentName = "";
        public static string borrowerInfo = "";
        public static string date = "";

        public AddBorrowerPage()
        {
            InitializeComponent();

            using (StreamReader books = new StreamReader("Books.txt"))
            {
                string book;

                while ((book = books.ReadLine()) != null)
                {
                    comboBox1.Items.Add(book);
                }
            }

            comboBox2.Items.Add("Borrow");
            comboBox2.Items.Add("Return");
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            MainPage form1 = new MainPage();
            form1.Show();
            this.Hide();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            studentName = fnametextbox.Text + " " + mnametextbox.Text + " " + lnametextbox.Text;
            date = datetimepicker.Value.ToString("yyyy-MM-dd");
            borrowerInfo = date + " - " + comboBox1.SelectedText + " ISBN: " + printisbntextbox.Text + " - ID:" + idnumbertextbox.Text + " / " + fnametextbox.Text + " " + mnametextbox.Text + " " + lnametextbox.Text;

            if (comboBox2.Text == "Borrow")
            {
                using (StreamWriter names = new StreamWriter("HAHA_Information.txt", true))
                {
                     names.WriteLine("BORROW // " + borrowerInfo);
                }

                 borrowerInfo = "";
                MessageBox.Show(studentName + " borrowed book is recorded.");
            }
            else if (comboBox2.Text == "Return")
            {
                using (StreamWriter names = new StreamWriter("HAHA_Information.txt", true))
                {
                    names.WriteLine("RETURN // " + borrowerInfo);
                }

                borrowerInfo = "";
                MessageBox.Show(studentName + " returned book is recorded.");
                using (StreamReader borrower = new StreamReader("HAHA_Information.txt"))
            {
                string people;

                while ((people = borrower.ReadLine()) != null)
                {
                    BorrowerListBox.Items.Add(people);
                }
            }
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("Information is not completed.");
            }

            using (StreamReader borrower = new StreamReader("HAHA_Information.txt"))
            {
                string people;

                while ((people = borrower.ReadLine()) != null)
                {
                    BorrowerListBox.Items.Add(people);
                }
            }
        }

        private void AddBorrowerPage_Load(object sender, EventArgs e)
        {
            using (StreamWriter names = new StreamWriter("HAHA_Information.txt", true))
            {
            }
            using (StreamReader borrower = new StreamReader("HAHA_Information.txt"))
            {
                string people;

                while ((people = borrower.ReadLine()) != null)
                {
                    BorrowerListBox.Items.Add(people);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Athenaeum___Integrated_Library_System
{
    public partial class BookManagerPage : Form
    {
        public static string bookInfo = "";
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
       

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (authortextBox.Text != "" && datetextBox.Text != "" && titletextBox.Text != "" && publishertextBox.Text != "" && isbntextBox.Text != "")
            {
                bookInfo = authortextBox.Text + ". (" + datetextBox.Text + "). " + titletextBox.Text + ". " + publishertextBox.Text + ". " + isbntextBox.Text;
                
                using (StreamWriter text = new StreamWriter("Book_Information.txt", true))
                {
                    text.WriteLine(bookInfo);
                }

                bookInfo = "";

                using (StreamWriter text = new StreamWriter("Books.txt", true))
                {
                    text.WriteLine(titletextBox.Text + " ISBN: " + isbntextBox.Text);
                }

                MessageBox.Show("Book added.");
            }
            else
            {
                MessageBox.Show("Book information is not completed.");
            }

            using (StreamReader book = new StreamReader("Book_Information.txt"))
            {
                string line;

                while ((line = book.ReadLine()) != null)
                {
                    BooksListBox.Items.Add(line);
                }
            }

        }

        private void BookManagerPage_Load(object sender, EventArgs e)
        {
            using (StreamWriter text = new StreamWriter("Book_Information.txt", true))
            {
            }
            using (StreamReader book = new StreamReader("Book_Information.txt"))
            {
                string line;

                while ((line = book.ReadLine()) != null)
                {
                    BooksListBox.Items.Add(line);
                }
            }
        }
    }
}

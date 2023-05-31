using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Athenaeum___Integrated_Library_System
{
    public partial class AddBorrowerPage : Form
    {
        SqlConnection con;
        public AddBorrowerPage()
        {
            InitializeComponent();
            string ConString = "Data Source = LAPTOP-920H2PTG\\SQLEXPRESS; Initial Catalog=Testdb;Integrated Security = true";
            con = new SqlConnection(ConString);
            con.Open();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            MainPage form1 = new MainPage();
            form1.Show();
            this.Hide();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Borrowers values ('" + idnumbertextbox.Text + "', '" + fnametextbox.Text + "', '" + mnametextbox.Text + "', '" + lnametextbox.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            int a = cmd.ExecuteNonQuery();
            MessageBox.Show("Borrower Added");
        }
    }
}

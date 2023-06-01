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
    public partial class AddReservationPage : Form
    {
        public static string studentInfo = "";
        public static string date = "";
        public static string hour = "";
        public static string minute = "";
        public static double use = 0;
        public static string time = "";
        public static DateTime current = DateTime.Now;
        public static string currenttext = "";

        public AddReservationPage()
        {
            InitializeComponent();

            if(timequeue.Count == 0)
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            MainPage form1 = new MainPage();
            form1.Show();
            this.Hide();
        }

        Queue<string> info = new Queue<string>();
        Queue<string> timequeue = new Queue<string>();
        Queue<string> hhqueue = new Queue<string>();
        Queue<string> mmqueue = new Queue<string>();

        private void savebutton_Click(object sender, EventArgs e)
        {
            if(info.Count <= 30)
            {
                studentInfo = fnametextbox.Text + " " + mnametextbox.Text + " " + lnametextbox.Text;
                date = datetimepicker.Value.ToString("hh:mm");
                hour = datetimepicker.Value.ToString("hh");
                minute = datetimepicker.Value.ToString("mm");

                info.Enqueue(studentInfo);
                timequeue.Enqueue(date);
                hhqueue.Enqueue(hour);
                mmqueue.Enqueue(minute);

                using (StreamWriter reserve = new StreamWriter("Reservation_Information.txt", true))
                {
                    reserve.WriteLine(studentInfo + " entered at " + date);
                }
                MessageBox.Show("The reservation has been made.");
                using (StreamReader reserve = new StreamReader("Reservation_Information.txt"))
                {
                    string people;

                    while ((people = reserve.ReadLine()) != null)
                    {
                        ReservationListBox.Items.Add(people);
                    }
                }
            }
            else
            {
                MessageBox.Show("The library is currently in full capacity.");
            }
            
        }

        private void AddReservationPage_Load(object sender, EventArgs e)
        {
            using (StreamWriter reserve = new StreamWriter("Reservation_Information.txt", true))
            {
            }
            using (StreamReader reserve = new StreamReader("Reservation_Information.txt"))
            {
                string people;

                while ((people = reserve.ReadLine()) != null)
                {
                    ReservationListBox.Items.Add(people);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            use = (Convert.ToDouble(hhqueue.Peek()) + 1);
            time = use.ToString() + ":" + mmqueue.Peek();
            currenttext = current.ToString("hh:mm");
            if (time == currenttext)
            {
                info.Dequeue();
                timequeue.Dequeue();
                hhqueue.Dequeue();
                mmqueue.Dequeue();
            }
        }
    }
}

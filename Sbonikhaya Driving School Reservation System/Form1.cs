using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sbonikhaya_Driving_School_Reservation_System
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        public void FormSetup(Form myForm)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            myForm.MdiParent = this;
            myForm.Show();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginGB.Visible = true;
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCustomerForm frmNewCustomer = new NewCustomerForm();
            FormSetup(frmNewCustomer);
        }

        private void makeBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustBooking frmCustBooking = new CustBooking();
            FormSetup(frmCustBooking);
        }

        private void viewLessonScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstructorForm frmInstructorForm = new InstructorForm();
            FormSetup(frmInstructorForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text, password = PasswordBox.Text;

            if ((username == "AdmMuthenKi") && (password == "KiyolinMu0106"))
            {
                MessageBox.Show("Welcome Kiyolin Muthen");
                logOutToolStripMenuItem.Enabled = true;
                logInToolStripMenuItem.Enabled = false;
                administratorToolStripMenuItem.Enabled = true;
                LoginGB.Visible = false;
            }
            else if ((username == "InsEvansJa") && (password == "JacobEv0764"))
            {
                MessageBox.Show("Welcome Jacob Evans");
                logOutToolStripMenuItem.Enabled = true;
                logInToolStripMenuItem.Enabled = false;
                drivingInstructorToolStripMenuItem.Enabled = true;
                LoginGB.Visible = false;
            }
            else if ((username == "InsGovenderAs") && (password == "AshleyGo0617"))
            {
                MessageBox.Show("Welcome Ashley Govender");
                logOutToolStripMenuItem.Enabled = true;
                logInToolStripMenuItem.Enabled = false;
                drivingInstructorToolStripMenuItem.Enabled = true;
                LoginGB.Visible = false;
            }
            else if ((username == "InsNgcoboLo") && (password == "LondekaNg0784"))
            {
                MessageBox.Show("Welcome Londeka Ngcobo");
                logOutToolStripMenuItem.Enabled = true;
                logInToolStripMenuItem.Enabled = false;
                drivingInstructorToolStripMenuItem.Enabled = true;
                LoginGB.Visible = false;
            }
            else if ((username == "ManMakhayeSb") && (password == "SbonisoMa0103"))
            {
                MessageBox.Show("Welcome Sboniso Makhaye");
                logOutToolStripMenuItem.Enabled = true;
                logInToolStripMenuItem.Enabled = false;
                managerToolStripMenuItem.Enabled = true;
                drivingInstructorToolStripMenuItem.Enabled = true;
                administratorToolStripMenuItem.Enabled = true;
                LoginGB.Visible = false;
            }
            else
            {
                MessageBox.Show("Login Failed! Please ensure that your credentials are entered correctly");
                UsernameBox.Clear();
                PasswordBox.Clear();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logOutToolStripMenuItem.Enabled = false;
            logInToolStripMenuItem.Enabled = true;
            administratorToolStripMenuItem.Enabled = false;
            drivingInstructorToolStripMenuItem.Enabled = false;
            managerToolStripMenuItem.Enabled = false;
            UsernameBox.Clear();
            PasswordBox.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCustomerForm frmViewCustomer = new ViewCustomerForm();
            FormSetup(frmViewCustomer);
        }

        private void viewPaymentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentHistoryForm frmPaymentHistory = new PaymentHistoryForm();
            FormSetup(frmPaymentHistory);
        }

        private void viewBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBookingsForm frmViewBookings = new ViewBookingsForm();
            FormSetup(frmViewBookings);
        }

        private void cancelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelBookingForm frmCancelBooking = new CancelBookingForm();
            FormSetup(frmCancelBooking);
        }
    }
}

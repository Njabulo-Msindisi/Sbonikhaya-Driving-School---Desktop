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
    public partial class CustBooking : Form
    {
        public CustBooking()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            taCurrentBookings.FillCurrentBookings(dsDrivingSchool.CurrentBookings, dateTimePicker1.Value.Date.ToString());
        }

        private void CustBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDrivingSchool.Timeslot' table. You can move, or remove it, as needed.
            this.taTimeslot.Fill(this.dsDrivingSchool.Timeslot);
            // TODO: This line of code loads data into the 'dsDrivingSchool.ClientInner' table. You can move, or remove it, as needed.
            this.taClientInner.Fill(this.dsDrivingSchool.ClientInner);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            taClientInner.FillByCustName(dsDrivingSchool.ClientInner, txtSearch.Text);
        }

        private void cbSlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Assigns a timeslot ID to a slot for booking table
            if (cbSlots.Text == "08:00-09:00")
            {
                txtSlotID.Text = "1";
            }
            else if (cbSlots.Text == "09:00-10:00")
            {
                txtSlotID.Text = "2";
            }
            else if (cbSlots.Text == "10:00-11:00")
            {
                txtSlotID.Text = "3";
            }
            else if (cbSlots.Text == "11:00-12:00")
            {
                txtSlotID.Text = "4";
            }
            else if (cbSlots.Text == "12:00-13:00")
            {
                txtSlotID.Text = "5";
            }
            else if (cbSlots.Text == "13:00-14:00")
            {
                txtSlotID.Text = "6";
            }
            else if (cbSlots.Text == "14:00-15:00")
            {
                txtSlotID.Text = "7";
            }
            else if (cbSlots.Text == "15:00-16:00")
            {
                txtSlotID.Text = "8";
            }
        }

        private void dgvSearchCust_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Fills selected datagrid row details into textboxes
            txtClientNum.Text = dgvSearchCust.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvSearchCust.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dgvSearchCust.CurrentRow.Cells[2].Value.ToString();
            txtPackageType.Text = dgvSearchCust.CurrentRow.Cells[3].Value.ToString();
            txtPrice.Text = dgvSearchCust.CurrentRow.Cells[4].Value.ToString();
            txtLessonsLeft.Text = dgvSearchCust.CurrentRow.Cells[5].Value.ToString();
            txtInstructorNum.Text = dgvSearchCust.CurrentRow.Cells[6].Value.ToString();

            //Ensures customer NumLessonsRemaining does not go below 0
            if (txtLessonsLeft.Text == "0")
            {
                MessageBox.Show("Customer has used up all their available lessons.  Please renew the customer's package.");
                btnConfirmBooking.Enabled = false;
            }
            else
            {
                btnConfirmBooking.Enabled = true;
            }
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            try
            {
                //Inserts booking into booking table
                ViewBookingsForm frmVewBookings = new ViewBookingsForm();
                frmVewBookings.taBooking.InsertBooking(dateTimePicker1.Value.Date.ToString(), txtCancelled.Text, Convert.ToInt16(txtClientNum.Text), Convert.ToInt16(txtInstructorNum.Text), Convert.ToInt16(txtSlotID.Text));
                frmVewBookings.taBooking.Fill(dsDrivingSchool.Booking);

                //Update lessons remaining by subtracting 1
                ViewCustomerForm frmViewCustomer = new ViewCustomerForm();
                frmViewCustomer.taClient.UpdateSubtractLesson(Convert.ToInt16(txtSubtractLesson.Text), Convert.ToInt16(txtClientNum.Text));

                //MessageBox to confirm booking
                MessageBox.Show("Booking for " + txtName.Text + " " + txtSurname.Text + " on the " + dateTimePicker1.Value.Date.ToShortDateString() + " at " + cbSlots.Text + " has been confirmed");

                //Refreshes tables
                taCurrentBookings.FillCurrentBookings(dsDrivingSchool.CurrentBookings, dateTimePicker1.Value.Date.ToString());
                taClientInner.Fill(dsDrivingSchool.ClientInner);

                frmVewBookings.taBooking.Fill(this.dsDrivingSchool.Booking);
            }
            catch
            {
                MessageBox.Show("Please select a customer and time slot for the booking.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

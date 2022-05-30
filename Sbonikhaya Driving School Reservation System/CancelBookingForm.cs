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
    public partial class CancelBookingForm : Form
    {
        public CancelBookingForm()
        {
            InitializeComponent();
        }

        private void CancelBookingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDrivingSchool.CancelBooking' table. You can move, or remove it, as needed.
            this.taCancelBooking.Fill(this.dsDrivingSchool.CancelBooking);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            taCancelBooking.FillByDate(dsDrivingSchool.CancelBooking, dateTimePicker1.Value.Date.ToString());
        }

        private void dgvCancelBooking_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Updates Booking_Canceled to 'Y'
            string BookingID = dgvCancelBooking.CurrentRow.Cells[0].Value.ToString();

            ViewBookingsForm frmViewBookings = new ViewBookingsForm();
            frmViewBookings.taBooking.UpdateCancelStatus(Convert.ToInt16(BookingID));

            //Increasing NumLessons by 1
            string CustNum = dgvCancelBooking.CurrentRow.Cells[7].Value.ToString();

            ViewCustomerForm frmViewCustomer = new ViewCustomerForm();
            frmViewCustomer.taClient.UpdateAddLesson(Convert.ToInt16(CustNum));

            MessageBox.Show("The booking you have selected has been canceled.  You have been credited with one additional lesson");

            //Refreshes tables
            taCancelBooking.Fill(dsDrivingSchool.CancelBooking);
            frmViewBookings.taBooking.Fill(dsDrivingSchool.Booking);
            frmViewCustomer.taClient.Fill(dsDrivingSchool.Client);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

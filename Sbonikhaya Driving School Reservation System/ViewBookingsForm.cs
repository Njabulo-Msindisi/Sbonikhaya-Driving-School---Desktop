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
    public partial class ViewBookingsForm : Form
    {
        public ViewBookingsForm()
        {
            InitializeComponent();
        }

        private void ViewBookingsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDrivingSchool.Booking' table. You can move, or remove it, as needed.
            this.taBooking.Fill(this.dsDrivingSchool.Booking);

        }
    }
}

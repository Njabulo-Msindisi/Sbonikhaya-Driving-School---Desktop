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
    public partial class PaymentHistoryForm : Form
    {
        public PaymentHistoryForm()
        {
            InitializeComponent();
        }

        private void PaymentHistoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDrivingSchool.PaymentInner' table. You can move, or remove it, as needed.
            this.taPaymentInner.Fill(this.dsDrivingSchool.PaymentInner);
            // TODO: This line of code loads data into the 'dsDrivingSchool.PackagePayment' table. You can move, or remove it, as needed.
            this.taPackagePayment.Fill(this.dsDrivingSchool.PackagePayment);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            taPaymentInner.FillByDate(dsDrivingSchool.PaymentInner, dateTimePicker1.Value.Date.ToString());
        }
    }
}

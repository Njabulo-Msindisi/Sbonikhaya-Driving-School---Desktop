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
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
        }

        private void NewCustomerForm_Load(object sender, EventArgs e)
        {
            //Displays date and time
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void CodeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Displays corresponding InstructorID in textbox to insert to database
            //Note: Textbox is hidden when form is displayed

            string CodeSelected = CodeCB.SelectedItem.ToString();
            if (CodeSelected == "8")
            {
                InstructorNumBox.Text = "2";
            }
            else if (CodeSelected == "10")
            {
                InstructorNumBox.Text = "1";
            }
            else if (CodeSelected == "14")
            {
                InstructorNumBox.Text = "3";
            }
        }

        private void PackageCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Displays corresponding PackageID in textbox to insert to database
            //Note: Textbox is hidden when form is displayed
            try
            {
                string PackageType = PackageCB.SelectedItem.ToString();
                string CodeSelected = CodeCB.SelectedItem.ToString();
                int NumLessons;
                decimal PayAmt;

                if ((PackageType == "Mini Course") && (CodeSelected == "8"))
                {
                    NumLessons = 2;
                    NumLessonsBox.Text = NumLessons.ToString();
                    PayAmt = 300;
                    PayAmtBox.Text = PayAmt.ToString();
                    PackageIDBox.Text = "10";
                    button1.Text = "Confirm Payment";
                }
                else if ((PackageType == "Half Course") && (CodeSelected == "8"))
                {
                    NumLessons = 10;
                    NumLessonsBox.Text = NumLessons.ToString();
                    PayAmt = 1500;
                    PayAmtBox.Text = PayAmt.ToString();
                    PackageIDBox.Text = "2";
                    button1.Text = "Confirm Payment";
                }
                else if ((PackageType == "Full Course") && (CodeSelected == "8"))
                {
                    NumLessons = 20;
                    NumLessonsBox.Text = NumLessons.ToString();
                    PayAmt = 2700;
                    PayAmtBox.Text = PayAmt.ToString();
                    PackageIDBox.Text = "3";
                    button1.Text = "Confirm Payment";
                }
                else if ((PackageType == "Mini Course") && (CodeSelected == "10"))
                {
                    NumLessons = 2;
                    NumLessonsBox.Text = NumLessons.ToString();
                    PayAmt = 420;
                    PayAmtBox.Text = PayAmt.ToString();
                    PackageIDBox.Text = "11";
                    button1.Text = "Confirm Payment";
                }
                else if ((PackageType == "Half Course") && (CodeSelected == "10"))
                {
                    NumLessons = 10;
                    NumLessonsBox.Text = NumLessons.ToString();
                    PayAmt = 2100;
                    PayAmtBox.Text = PayAmt.ToString();
                    PackageIDBox.Text = "5";
                    button1.Text = "Confirm Payment";
                }
                else if ((PackageType == "Full Course") && (CodeSelected == "10"))
                {
                    NumLessons = 20;
                    NumLessonsBox.Text = NumLessons.ToString();
                    PayAmt = 3000;
                    PayAmtBox.Text = PayAmt.ToString();
                    PackageIDBox.Text = "6";
                    button1.Text = "Confirm Payment";
                }
                else if ((PackageType == "Mini Course") && (CodeSelected == "14"))
                {
                    NumLessons = 2;
                    NumLessonsBox.Text = NumLessons.ToString();
                    PayAmt = 700;
                    PayAmtBox.Text = PayAmt.ToString();
                    PackageIDBox.Text = "12";
                    button1.Text = "Confirm Payment";
                }
                else if ((PackageType == "Half Course") && (CodeSelected == "14"))
                {
                    NumLessons = 10;
                    NumLessonsBox.Text = NumLessons.ToString();
                    PayAmt = 3500;
                    PayAmtBox.Text = PayAmt.ToString();
                    PackageIDBox.Text = "8";
                    button1.Text = "Confirm Payment";
                }
                else if ((PackageType == "Full Course") && (CodeSelected == "14"))
                {
                    NumLessons = 20;
                    NumLessonsBox.Text = NumLessons.ToString();
                    PayAmt = 5000;
                    PayAmtBox.Text = PayAmt.ToString();
                    PackageIDBox.Text = "9";
                    button1.Text = "Confirm Payment";
                }
            }
            catch
            {
                MessageBox.Show("Please select a code first.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //inserts packaged customer details to client table
                ViewCustomerForm frmViewCustomer = new ViewCustomerForm();
                frmViewCustomer.taClient.InsertClient(IDNumBox.Text, NameBox.Text, SurnameBox.Text, EmailBox.Text, HomeAddressBox.Text, CellNoBox.Text, CodeCB.GetItemText(this.CodeCB.SelectedItem), Convert.ToInt16(NumLessonsBox.Text), Convert.ToInt16(PackageIDBox.Text), Convert.ToInt16(InstructorNumBox.Text));

                //Inserting payment to PackagePayment table
                PaymentHistoryForm frmPaymentHistory = new PaymentHistoryForm();
                frmPaymentHistory.taPackagePayment.InsertPackagePayment(PayMethodBox.GetItemText(this.PayMethodBox.SelectedItem), Convert.ToInt16(PayAmtBox.Text), lblDate.Text, lblTime.Text, Convert.ToInt16(ClientNumBox.Text), Convert.ToInt16(AdminNumBox.Text), Convert.ToInt16(PackageIDBox.Text));

                //Shows that payment and sign-up is completed
                MessageBox.Show("Sign-up and registration completed!" + '\n' + "Welcome to Sbhonikhaya Driving School " + NameBox.Text + " " + SurnameBox.Text + "!" + '\n' + "Payment Received: R" + PayAmtBox.Text);

                //Call up receipt
                ReceiptForm frmReceipt = new ReceiptForm();
                frmReceipt.Show();

                frmReceipt.lblCustNum.Text = ClientNumBox.Text;
                frmReceipt.lblName.Text = NameBox.Text;
                frmReceipt.lblSurname.Text = SurnameBox.Text;
                frmReceipt.lblCode.Text = CodeCB.Text;
                frmReceipt.lblPackage.Text = PackageCB.Text;
                frmReceipt.lblPayDue.Text = PayAmtBox.Text;
                frmReceipt.lblPayMethod.Text = PayMethodBox.Text;
            }
            catch
            {
                MessageBox.Show("Please ensure that all fields are filled in.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Clears all fields
            NameBox.Clear();
            SurnameBox.Clear();
            IDNumBox.Clear();
            HomeAddressBox.Clear();
            EmailBox.Clear();
            CellNoBox.Clear();
            CodeCB.Text = "";
            PackageCB.Text = "";
            NumLessonsBox.Text = "";
            PayAmtBox.Clear();
            PayMethodBox.Text = "";
            InstructorNumBox.Clear();
            PackageIDBox.Clear();
            ClientNumBox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

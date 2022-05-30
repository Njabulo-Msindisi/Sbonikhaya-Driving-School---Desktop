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
    public partial class InstructorForm : Form
    {
        public InstructorForm()
        {
            InitializeComponent();
        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDrivingSchool1.Code14Inner' table. You can move, or remove it, as needed.
            this.taCode14Inner.Fill(this.dsDrivingSchool1.Code14Inner);
            // TODO: This line of code loads data into the 'dsDrivingSchool.Code10Inner' table. You can move, or remove it, as needed.
            this.taCode10Inner.Fill(this.dsDrivingSchool.Code10Inner);
            // TODO: This line of code loads data into the 'dsDrivingSchool.Code8Inner' table. You can move, or remove it, as needed.
            this.taCode8Inner.Fill(this.dsDrivingSchool.Code8Inner);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            taCode8Inner.FillByDate(dsDrivingSchool.Code8Inner, dateTimePicker1.Value.Date.ToString());
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            taCode10Inner.FillBy(dsDrivingSchool.Code10Inner, dateTimePicker2.Value.Date.ToString());
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            taCode14Inner.FillByDate(dsDrivingSchool1.Code14Inner, dateTimePicker3.Value.Date.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

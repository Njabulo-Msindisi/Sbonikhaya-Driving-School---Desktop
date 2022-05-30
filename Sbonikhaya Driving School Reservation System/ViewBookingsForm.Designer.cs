namespace Sbonikhaya_Driving_School_Reservation_System
{
    partial class ViewBookingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBookingsForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvViewBookings = new System.Windows.Forms.DataGridView();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingCanceledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeslotIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBooking = new System.Windows.Forms.BindingSource(this.components);
            this.dsDrivingSchool = new Sbonikhaya_Driving_School_Reservation_System.dsDrivingSchool();
            this.taBooking = new Sbonikhaya_Driving_School_Reservation_System.dsDrivingSchoolTableAdapters.BookingTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDrivingSchool)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(870, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvViewBookings
            // 
            this.dgvViewBookings.AutoGenerateColumns = false;
            this.dgvViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn,
            this.bookingCanceledDataGridViewTextBoxColumn,
            this.clientNumDataGridViewTextBoxColumn,
            this.instructorNumDataGridViewTextBoxColumn,
            this.timeslotIDDataGridViewTextBoxColumn});
            this.dgvViewBookings.DataSource = this.bsBooking;
            this.dgvViewBookings.Location = new System.Drawing.Point(0, 25);
            this.dgvViewBookings.Name = "dgvViewBookings";
            this.dgvViewBookings.Size = new System.Drawing.Size(644, 237);
            this.dgvViewBookings.TabIndex = 1;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "Booking_ID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "Booking ID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "Booking_Date";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            // 
            // bookingCanceledDataGridViewTextBoxColumn
            // 
            this.bookingCanceledDataGridViewTextBoxColumn.DataPropertyName = "Booking_Canceled";
            this.bookingCanceledDataGridViewTextBoxColumn.HeaderText = "Canceled Status";
            this.bookingCanceledDataGridViewTextBoxColumn.Name = "bookingCanceledDataGridViewTextBoxColumn";
            // 
            // clientNumDataGridViewTextBoxColumn
            // 
            this.clientNumDataGridViewTextBoxColumn.DataPropertyName = "Client_Num";
            this.clientNumDataGridViewTextBoxColumn.HeaderText = "Client Num";
            this.clientNumDataGridViewTextBoxColumn.Name = "clientNumDataGridViewTextBoxColumn";
            // 
            // instructorNumDataGridViewTextBoxColumn
            // 
            this.instructorNumDataGridViewTextBoxColumn.DataPropertyName = "Instructor_Num";
            this.instructorNumDataGridViewTextBoxColumn.HeaderText = "Instructor Num";
            this.instructorNumDataGridViewTextBoxColumn.Name = "instructorNumDataGridViewTextBoxColumn";
            // 
            // timeslotIDDataGridViewTextBoxColumn
            // 
            this.timeslotIDDataGridViewTextBoxColumn.DataPropertyName = "Timeslot_ID";
            this.timeslotIDDataGridViewTextBoxColumn.HeaderText = "TimeSlotID";
            this.timeslotIDDataGridViewTextBoxColumn.Name = "timeslotIDDataGridViewTextBoxColumn";
            // 
            // bsBooking
            // 
            this.bsBooking.DataMember = "Booking";
            this.bsBooking.DataSource = this.dsDrivingSchool;
            // 
            // dsDrivingSchool
            // 
            this.dsDrivingSchool.DataSetName = "dsDrivingSchool";
            this.dsDrivingSchool.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taBooking
            // 
            this.taBooking.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvViewBookings);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(90, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 264);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Bookings";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(784, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ViewBookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ViewBookingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBookingsForm";
            this.Load += new System.EventHandler(this.ViewBookingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDrivingSchool)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private dsDrivingSchool dsDrivingSchool;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingCanceledDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeslotIDDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dgvViewBookings;
        public System.Windows.Forms.BindingSource bsBooking;
        public dsDrivingSchoolTableAdapters.BookingTableAdapter taBooking;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}
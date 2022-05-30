namespace Sbonikhaya_Driving_School_Reservation_System
{
    partial class CustBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustBooking));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numLessonsRemainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCurrentBookings = new System.Windows.Forms.BindingSource(this.components);
            this.dsDrivingSchool = new Sbonikhaya_Driving_School_Reservation_System.dsDrivingSchool();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSearchCust = new System.Windows.Forms.DataGridView();
            this.clientNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSurnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packagePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numLessonsRemainingDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsClientInner = new System.Windows.Forms.BindingSource(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSlots = new System.Windows.Forms.ComboBox();
            this.bsTimeslot = new System.Windows.Forms.BindingSource(this.components);
            this.txtPackageType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLessonsLeft = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtClientNum = new System.Windows.Forms.TextBox();
            this.txtCancelled = new System.Windows.Forms.TextBox();
            this.txtSlotID = new System.Windows.Forms.TextBox();
            this.txtInstructorNum = new System.Windows.Forms.TextBox();
            this.txtSubtractLesson = new System.Windows.Forms.TextBox();
            this.taCurrentBookings = new Sbonikhaya_Driving_School_Reservation_System.dsDrivingSchoolTableAdapters.CurrentBookingsTableAdapter();
            this.taClientInner = new Sbonikhaya_Driving_School_Reservation_System.dsDrivingSchoolTableAdapters.ClientInnerTableAdapter();
            this.taTimeslot = new Sbonikhaya_Driving_School_Reservation_System.dsDrivingSchoolTableAdapters.TimeslotTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrentBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDrivingSchool)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientInner)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTimeslot)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1112, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 220);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(647, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Current Bookings";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientSurnameDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn,
            this.slotDataGridViewTextBoxColumn,
            this.numLessonsRemainingDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsCurrentBookings;
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 174);
            this.dataGridView1.TabIndex = 1;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "Booking_ID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "Booking ID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            // 
            // clientSurnameDataGridViewTextBoxColumn
            // 
            this.clientSurnameDataGridViewTextBoxColumn.DataPropertyName = "Client_Surname";
            this.clientSurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.clientSurnameDataGridViewTextBoxColumn.Name = "clientSurnameDataGridViewTextBoxColumn";
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "Booking_Date";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            // 
            // slotDataGridViewTextBoxColumn
            // 
            this.slotDataGridViewTextBoxColumn.DataPropertyName = "Slot";
            this.slotDataGridViewTextBoxColumn.HeaderText = "Slot";
            this.slotDataGridViewTextBoxColumn.Name = "slotDataGridViewTextBoxColumn";
            // 
            // numLessonsRemainingDataGridViewTextBoxColumn
            // 
            this.numLessonsRemainingDataGridViewTextBoxColumn.DataPropertyName = "Num_Lessons_Remaining";
            this.numLessonsRemainingDataGridViewTextBoxColumn.HeaderText = "Lessons Remaining";
            this.numLessonsRemainingDataGridViewTextBoxColumn.Name = "numLessonsRemainingDataGridViewTextBoxColumn";
            // 
            // bsCurrentBookings
            // 
            this.bsCurrentBookings.DataMember = "CurrentBookings";
            this.bsCurrentBookings.DataSource = this.dsDrivingSchool;
            // 
            // dsDrivingSchool
            // 
            this.dsDrivingSchool.DataSetName = "dsDrivingSchool";
            this.dsDrivingSchool.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 30);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(315, 26);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSearchCust);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(38, 477);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(645, 233);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search and Select Customer";
            // 
            // dgvSearchCust
            // 
            this.dgvSearchCust.AutoGenerateColumns = false;
            this.dgvSearchCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchCust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientNumDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn1,
            this.clientSurnameDataGridViewTextBoxColumn1,
            this.packageTypeDataGridViewTextBoxColumn,
            this.packagePriceDataGridViewTextBoxColumn,
            this.numLessonsRemainingDataGridViewTextBoxColumn1,
            this.instructorNumDataGridViewTextBoxColumn});
            this.dgvSearchCust.DataSource = this.bsClientInner;
            this.dgvSearchCust.Location = new System.Drawing.Point(0, 65);
            this.dgvSearchCust.Name = "dgvSearchCust";
            this.dgvSearchCust.Size = new System.Drawing.Size(639, 168);
            this.dgvSearchCust.TabIndex = 2;
            this.dgvSearchCust.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSearchCust_RowHeaderMouseDoubleClick);
            // 
            // clientNumDataGridViewTextBoxColumn
            // 
            this.clientNumDataGridViewTextBoxColumn.DataPropertyName = "Client_Num";
            this.clientNumDataGridViewTextBoxColumn.HeaderText = "Client Num";
            this.clientNumDataGridViewTextBoxColumn.Name = "clientNumDataGridViewTextBoxColumn";
            this.clientNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientNameDataGridViewTextBoxColumn1
            // 
            this.clientNameDataGridViewTextBoxColumn1.DataPropertyName = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.clientNameDataGridViewTextBoxColumn1.Name = "clientNameDataGridViewTextBoxColumn1";
            // 
            // clientSurnameDataGridViewTextBoxColumn1
            // 
            this.clientSurnameDataGridViewTextBoxColumn1.DataPropertyName = "Client_Surname";
            this.clientSurnameDataGridViewTextBoxColumn1.HeaderText = "Surname";
            this.clientSurnameDataGridViewTextBoxColumn1.Name = "clientSurnameDataGridViewTextBoxColumn1";
            // 
            // packageTypeDataGridViewTextBoxColumn
            // 
            this.packageTypeDataGridViewTextBoxColumn.DataPropertyName = "Package_Type";
            this.packageTypeDataGridViewTextBoxColumn.HeaderText = "Package Type";
            this.packageTypeDataGridViewTextBoxColumn.Name = "packageTypeDataGridViewTextBoxColumn";
            // 
            // packagePriceDataGridViewTextBoxColumn
            // 
            this.packagePriceDataGridViewTextBoxColumn.DataPropertyName = "Package_Price";
            this.packagePriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.packagePriceDataGridViewTextBoxColumn.Name = "packagePriceDataGridViewTextBoxColumn";
            // 
            // numLessonsRemainingDataGridViewTextBoxColumn1
            // 
            this.numLessonsRemainingDataGridViewTextBoxColumn1.DataPropertyName = "Num_Lessons_Remaining";
            this.numLessonsRemainingDataGridViewTextBoxColumn1.HeaderText = "Lessons Remaining";
            this.numLessonsRemainingDataGridViewTextBoxColumn1.Name = "numLessonsRemainingDataGridViewTextBoxColumn1";
            // 
            // instructorNumDataGridViewTextBoxColumn
            // 
            this.instructorNumDataGridViewTextBoxColumn.DataPropertyName = "Instructor_Num";
            this.instructorNumDataGridViewTextBoxColumn.HeaderText = "Instructor Num";
            this.instructorNumDataGridViewTextBoxColumn.Name = "instructorNumDataGridViewTextBoxColumn";
            // 
            // bsClientInner
            // 
            this.bsClientInner.DataMember = "ClientInner";
            this.bsClientInner.DataSource = this.dsDrivingSchool;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(283, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(259, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Customer Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnConfirmBooking);
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cbSlots);
            this.groupBox3.Controls.Add(this.txtPackageType);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtLessonsLeft);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtSurname);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.txtClientNum);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(726, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 406);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Booking Details";
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmBooking.Location = new System.Drawing.Point(157, 354);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(187, 46);
            this.btnConfirmBooking.TabIndex = 11;
            this.btnConfirmBooking.Text = "Confirm Booking";
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(206, 222);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(67, 26);
            this.txtPrice.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Slot:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Lessons Remaining:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Package Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Price:";
            // 
            // cbSlots
            // 
            this.cbSlots.DataSource = this.bsTimeslot;
            this.cbSlots.DisplayMember = "Slot";
            this.cbSlots.FormattingEnabled = true;
            this.cbSlots.Location = new System.Drawing.Point(206, 311);
            this.cbSlots.Name = "cbSlots";
            this.cbSlots.Size = new System.Drawing.Size(138, 27);
            this.cbSlots.TabIndex = 4;
            this.cbSlots.ValueMember = "Timeslot_ID";
            this.cbSlots.SelectedIndexChanged += new System.EventHandler(this.cbSlots_SelectedIndexChanged);
            // 
            // bsTimeslot
            // 
            this.bsTimeslot.DataMember = "Timeslot";
            this.bsTimeslot.DataSource = this.dsDrivingSchool;
            // 
            // txtPackageType
            // 
            this.txtPackageType.Enabled = false;
            this.txtPackageType.Location = new System.Drawing.Point(206, 173);
            this.txtPackageType.Name = "txtPackageType";
            this.txtPackageType.Size = new System.Drawing.Size(138, 26);
            this.txtPackageType.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Surname:";
            // 
            // txtLessonsLeft
            // 
            this.txtLessonsLeft.Enabled = false;
            this.txtLessonsLeft.Location = new System.Drawing.Point(206, 267);
            this.txtLessonsLeft.Name = "txtLessonsLeft";
            this.txtLessonsLeft.Size = new System.Drawing.Size(49, 26);
            this.txtLessonsLeft.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name:";
            // 
            // txtSurname
            // 
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(206, 130);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(160, 26);
            this.txtSurname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Client Num:";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(206, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtClientNum
            // 
            this.txtClientNum.Enabled = false;
            this.txtClientNum.Location = new System.Drawing.Point(206, 42);
            this.txtClientNum.Name = "txtClientNum";
            this.txtClientNum.Size = new System.Drawing.Size(49, 26);
            this.txtClientNum.TabIndex = 0;
            // 
            // txtCancelled
            // 
            this.txtCancelled.Enabled = false;
            this.txtCancelled.Location = new System.Drawing.Point(726, 220);
            this.txtCancelled.Name = "txtCancelled";
            this.txtCancelled.Size = new System.Drawing.Size(49, 22);
            this.txtCancelled.TabIndex = 12;
            this.txtCancelled.Text = "N";
            this.txtCancelled.Visible = false;
            // 
            // txtSlotID
            // 
            this.txtSlotID.Enabled = false;
            this.txtSlotID.Location = new System.Drawing.Point(970, 220);
            this.txtSlotID.Name = "txtSlotID";
            this.txtSlotID.Size = new System.Drawing.Size(49, 22);
            this.txtSlotID.TabIndex = 13;
            this.txtSlotID.Visible = false;
            // 
            // txtInstructorNum
            // 
            this.txtInstructorNum.Enabled = false;
            this.txtInstructorNum.Location = new System.Drawing.Point(809, 220);
            this.txtInstructorNum.Name = "txtInstructorNum";
            this.txtInstructorNum.Size = new System.Drawing.Size(49, 22);
            this.txtInstructorNum.TabIndex = 14;
            this.txtInstructorNum.Visible = false;
            // 
            // txtSubtractLesson
            // 
            this.txtSubtractLesson.Enabled = false;
            this.txtSubtractLesson.Location = new System.Drawing.Point(889, 220);
            this.txtSubtractLesson.Name = "txtSubtractLesson";
            this.txtSubtractLesson.Size = new System.Drawing.Size(49, 22);
            this.txtSubtractLesson.TabIndex = 15;
            this.txtSubtractLesson.Text = "1";
            this.txtSubtractLesson.Visible = false;
            // 
            // taCurrentBookings
            // 
            this.taCurrentBookings.ClearBeforeFill = true;
            // 
            // taClientInner
            // 
            this.taClientInner.ClearBeforeFill = true;
            // 
            // taTimeslot
            // 
            this.taTimeslot.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1037, 692);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 16;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCancelled);
            this.Controls.Add(this.txtSlotID);
            this.Controls.Add(this.txtInstructorNum);
            this.Controls.Add(this.txtSubtractLesson);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking - Package Customers Only";
            this.Load += new System.EventHandler(this.CustBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrentBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDrivingSchool)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientInner)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTimeslot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsCurrentBookings;
        private dsDrivingSchool dsDrivingSchool;
        private dsDrivingSchoolTableAdapters.CurrentBookingsTableAdapter taCurrentBookings;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLessonsRemainingDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSearchCust;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbSlots;
        private System.Windows.Forms.TextBox txtPackageType;
        private System.Windows.Forms.TextBox txtLessonsLeft;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtClientNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.TextBox txtCancelled;
        private System.Windows.Forms.TextBox txtSlotID;
        private System.Windows.Forms.TextBox txtInstructorNum;
        private System.Windows.Forms.TextBox txtSubtractLesson;
        private System.Windows.Forms.BindingSource bsClientInner;
        private dsDrivingSchoolTableAdapters.ClientInnerTableAdapter taClientInner;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSurnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packagePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLessonsRemainingDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsTimeslot;
        private dsDrivingSchoolTableAdapters.TimeslotTableAdapter taTimeslot;
        private System.Windows.Forms.Button button1;
    }
}
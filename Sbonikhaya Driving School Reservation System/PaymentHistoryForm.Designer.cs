namespace Sbonikhaya_Driving_School_Reservation_System
{
    partial class PaymentHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentHistoryForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvPackagePayments = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPaymentInner = new System.Windows.Forms.DataGridView();
            this.packagePayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packagePayMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packagePayAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packagePayDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packagePayTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPackagePayment = new System.Windows.Forms.BindingSource(this.components);
            this.dsDrivingSchool = new Sbonikhaya_Driving_School_Reservation_System.dsDrivingSchool();
            this.taPackagePayment = new Sbonikhaya_Driving_School_Reservation_System.dsDrivingSchoolTableAdapters.PackagePaymentTableAdapter();
            this.bsPaymentInner = new System.Windows.Forms.BindingSource(this.components);
            this.taPaymentInner = new Sbonikhaya_Driving_School_Reservation_System.dsDrivingSchoolTableAdapters.PaymentInnerTableAdapter();
            this.packagePayIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packagePayAmtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packagePayDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packagePayTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCodeSelectedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackagePayments)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentInner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPackagePayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDrivingSchool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPaymentInner)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(879, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvPackagePayments
            // 
            this.dgvPackagePayments.AutoGenerateColumns = false;
            this.dgvPackagePayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackagePayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packagePayIDDataGridViewTextBoxColumn,
            this.packagePayMethodDataGridViewTextBoxColumn,
            this.packagePayAmtDataGridViewTextBoxColumn,
            this.packagePayDateDataGridViewTextBoxColumn,
            this.packagePayTimeDataGridViewTextBoxColumn,
            this.clientNumDataGridViewTextBoxColumn,
            this.adminNumDataGridViewTextBoxColumn,
            this.packageIDDataGridViewTextBoxColumn});
            this.dgvPackagePayments.DataSource = this.bsPackagePayment;
            this.dgvPackagePayments.Location = new System.Drawing.Point(614, 477);
            this.dgvPackagePayments.Name = "dgvPackagePayments";
            this.dgvPackagePayments.Size = new System.Drawing.Size(144, 37);
            this.dgvPackagePayments.TabIndex = 1;
            this.dgvPackagePayments.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dgvPaymentInner);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 255);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment History";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(790, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPaymentInner
            // 
            this.dgvPaymentInner.AutoGenerateColumns = false;
            this.dgvPaymentInner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentInner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packagePayIDDataGridViewTextBoxColumn1,
            this.clientIDDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientSurnameDataGridViewTextBoxColumn,
            this.packagePayAmtDataGridViewTextBoxColumn1,
            this.packagePayDateDataGridViewTextBoxColumn1,
            this.packagePayTimeDataGridViewTextBoxColumn1,
            this.clientCodeSelectedDataGridViewTextBoxColumn,
            this.packageTypeDataGridViewTextBoxColumn});
            this.dgvPaymentInner.DataSource = this.bsPaymentInner;
            this.dgvPaymentInner.Location = new System.Drawing.Point(0, 66);
            this.dgvPaymentInner.Name = "dgvPaymentInner";
            this.dgvPaymentInner.Size = new System.Drawing.Size(849, 189);
            this.dgvPaymentInner.TabIndex = 0;
            // 
            // packagePayIDDataGridViewTextBoxColumn
            // 
            this.packagePayIDDataGridViewTextBoxColumn.DataPropertyName = "PackagePayID";
            this.packagePayIDDataGridViewTextBoxColumn.HeaderText = "Package Payment ID";
            this.packagePayIDDataGridViewTextBoxColumn.Name = "packagePayIDDataGridViewTextBoxColumn";
            this.packagePayIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packagePayMethodDataGridViewTextBoxColumn
            // 
            this.packagePayMethodDataGridViewTextBoxColumn.DataPropertyName = "PackagePayMethod";
            this.packagePayMethodDataGridViewTextBoxColumn.HeaderText = "Payment Method";
            this.packagePayMethodDataGridViewTextBoxColumn.Name = "packagePayMethodDataGridViewTextBoxColumn";
            // 
            // packagePayAmtDataGridViewTextBoxColumn
            // 
            this.packagePayAmtDataGridViewTextBoxColumn.DataPropertyName = "PackagePayAmt";
            this.packagePayAmtDataGridViewTextBoxColumn.HeaderText = "Payment Amount";
            this.packagePayAmtDataGridViewTextBoxColumn.Name = "packagePayAmtDataGridViewTextBoxColumn";
            // 
            // packagePayDateDataGridViewTextBoxColumn
            // 
            this.packagePayDateDataGridViewTextBoxColumn.DataPropertyName = "PackagePayDate";
            this.packagePayDateDataGridViewTextBoxColumn.HeaderText = "Payment Date";
            this.packagePayDateDataGridViewTextBoxColumn.Name = "packagePayDateDataGridViewTextBoxColumn";
            // 
            // packagePayTimeDataGridViewTextBoxColumn
            // 
            this.packagePayTimeDataGridViewTextBoxColumn.DataPropertyName = "PackagePayTime";
            this.packagePayTimeDataGridViewTextBoxColumn.HeaderText = "Payment Time";
            this.packagePayTimeDataGridViewTextBoxColumn.Name = "packagePayTimeDataGridViewTextBoxColumn";
            // 
            // clientNumDataGridViewTextBoxColumn
            // 
            this.clientNumDataGridViewTextBoxColumn.DataPropertyName = "Client_Num";
            this.clientNumDataGridViewTextBoxColumn.HeaderText = "Client Num";
            this.clientNumDataGridViewTextBoxColumn.Name = "clientNumDataGridViewTextBoxColumn";
            // 
            // adminNumDataGridViewTextBoxColumn
            // 
            this.adminNumDataGridViewTextBoxColumn.DataPropertyName = "Admin_Num";
            this.adminNumDataGridViewTextBoxColumn.HeaderText = "Admin Num";
            this.adminNumDataGridViewTextBoxColumn.Name = "adminNumDataGridViewTextBoxColumn";
            // 
            // packageIDDataGridViewTextBoxColumn
            // 
            this.packageIDDataGridViewTextBoxColumn.DataPropertyName = "Package_ID";
            this.packageIDDataGridViewTextBoxColumn.HeaderText = "Package ID";
            this.packageIDDataGridViewTextBoxColumn.Name = "packageIDDataGridViewTextBoxColumn";
            // 
            // bsPackagePayment
            // 
            this.bsPackagePayment.DataMember = "PackagePayment";
            this.bsPackagePayment.DataSource = this.dsDrivingSchool;
            // 
            // dsDrivingSchool
            // 
            this.dsDrivingSchool.DataSetName = "dsDrivingSchool";
            this.dsDrivingSchool.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taPackagePayment
            // 
            this.taPackagePayment.ClearBeforeFill = true;
            // 
            // bsPaymentInner
            // 
            this.bsPaymentInner.DataMember = "PaymentInner";
            this.bsPaymentInner.DataSource = this.dsDrivingSchool;
            // 
            // taPaymentInner
            // 
            this.taPaymentInner.ClearBeforeFill = true;
            // 
            // packagePayIDDataGridViewTextBoxColumn1
            // 
            this.packagePayIDDataGridViewTextBoxColumn1.DataPropertyName = "PackagePayID";
            this.packagePayIDDataGridViewTextBoxColumn1.HeaderText = "Payment ID";
            this.packagePayIDDataGridViewTextBoxColumn1.Name = "packagePayIDDataGridViewTextBoxColumn1";
            this.packagePayIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ID Number";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
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
            // packagePayAmtDataGridViewTextBoxColumn1
            // 
            this.packagePayAmtDataGridViewTextBoxColumn1.DataPropertyName = "PackagePayAmt";
            this.packagePayAmtDataGridViewTextBoxColumn1.HeaderText = "Payment Amount";
            this.packagePayAmtDataGridViewTextBoxColumn1.Name = "packagePayAmtDataGridViewTextBoxColumn1";
            // 
            // packagePayDateDataGridViewTextBoxColumn1
            // 
            this.packagePayDateDataGridViewTextBoxColumn1.DataPropertyName = "PackagePayDate";
            this.packagePayDateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.packagePayDateDataGridViewTextBoxColumn1.Name = "packagePayDateDataGridViewTextBoxColumn1";
            // 
            // packagePayTimeDataGridViewTextBoxColumn1
            // 
            this.packagePayTimeDataGridViewTextBoxColumn1.DataPropertyName = "PackagePayTime";
            this.packagePayTimeDataGridViewTextBoxColumn1.HeaderText = "Time";
            this.packagePayTimeDataGridViewTextBoxColumn1.Name = "packagePayTimeDataGridViewTextBoxColumn1";
            // 
            // clientCodeSelectedDataGridViewTextBoxColumn
            // 
            this.clientCodeSelectedDataGridViewTextBoxColumn.DataPropertyName = "Client_Code_Selected";
            this.clientCodeSelectedDataGridViewTextBoxColumn.HeaderText = "Code";
            this.clientCodeSelectedDataGridViewTextBoxColumn.Name = "clientCodeSelectedDataGridViewTextBoxColumn";
            // 
            // packageTypeDataGridViewTextBoxColumn
            // 
            this.packageTypeDataGridViewTextBoxColumn.DataPropertyName = "Package_Type";
            this.packageTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.packageTypeDataGridViewTextBoxColumn.Name = "packageTypeDataGridViewTextBoxColumn";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(282, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(276, 26);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // PaymentHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 537);
            this.Controls.Add(this.dgvPackagePayments);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PaymentHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentHistoryForm";
            this.Load += new System.EventHandler(this.PaymentHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackagePayments)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentInner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPackagePayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDrivingSchool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPaymentInner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private dsDrivingSchool dsDrivingSchool;
        private System.Windows.Forms.DataGridViewTextBoxColumn packagePayIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packagePayMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packagePayAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packagePayDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packagePayTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvPackagePayments;
        public System.Windows.Forms.BindingSource bsPackagePayment;
        public dsDrivingSchoolTableAdapters.PackagePaymentTableAdapter taPackagePayment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPaymentInner;
        private System.Windows.Forms.BindingSource bsPaymentInner;
        private dsDrivingSchoolTableAdapters.PaymentInnerTableAdapter taPaymentInner;
        private System.Windows.Forms.DataGridViewTextBoxColumn packagePayIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packagePayAmtDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn packagePayDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn packagePayTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCodeSelectedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
namespace Sbonikhaya_Driving_School_Reservation_System
{
    partial class ViewCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCustomerForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvDisplayCustomers = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEmailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientHomeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCellNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCodeSelectedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numLessonsRemainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsClient = new System.Windows.Forms.BindingSource(this.components);
            this.dsDrivingSchool = new Sbonikhaya_Driving_School_Reservation_System.dsDrivingSchool();
            this.taClient = new Sbonikhaya_Driving_School_Reservation_System.dsDrivingSchoolTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayCustomers)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDrivingSchool)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(961, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvDisplayCustomers
            // 
            this.dgvDisplayCustomers.AutoGenerateColumns = false;
            this.dgvDisplayCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientNumDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientSurnameDataGridViewTextBoxColumn,
            this.clientEmailAddressDataGridViewTextBoxColumn,
            this.clientHomeAddressDataGridViewTextBoxColumn,
            this.clientCellNoDataGridViewTextBoxColumn,
            this.clientCodeSelectedDataGridViewTextBoxColumn,
            this.numLessonsRemainingDataGridViewTextBoxColumn,
            this.packageIDDataGridViewTextBoxColumn,
            this.instructorNumDataGridViewTextBoxColumn});
            this.dgvDisplayCustomers.DataSource = this.bsClient;
            this.dgvDisplayCustomers.Location = new System.Drawing.Point(0, 84);
            this.dgvDisplayCustomers.Name = "dgvDisplayCustomers";
            this.dgvDisplayCustomers.Size = new System.Drawing.Size(942, 248);
            this.dgvDisplayCustomers.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.dgvDisplayCustomers);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(942, 332);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Customers";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(871, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(411, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(247, 26);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Customer Name:";
            // 
            // clientNumDataGridViewTextBoxColumn
            // 
            this.clientNumDataGridViewTextBoxColumn.DataPropertyName = "Client_Num";
            this.clientNumDataGridViewTextBoxColumn.HeaderText = "Client Num";
            this.clientNumDataGridViewTextBoxColumn.Name = "clientNumDataGridViewTextBoxColumn";
            this.clientNumDataGridViewTextBoxColumn.ReadOnly = true;
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
            // clientEmailAddressDataGridViewTextBoxColumn
            // 
            this.clientEmailAddressDataGridViewTextBoxColumn.DataPropertyName = "Client_Email_Address";
            this.clientEmailAddressDataGridViewTextBoxColumn.HeaderText = "Email Address";
            this.clientEmailAddressDataGridViewTextBoxColumn.Name = "clientEmailAddressDataGridViewTextBoxColumn";
            // 
            // clientHomeAddressDataGridViewTextBoxColumn
            // 
            this.clientHomeAddressDataGridViewTextBoxColumn.DataPropertyName = "Client_Home_Address";
            this.clientHomeAddressDataGridViewTextBoxColumn.HeaderText = "Home Address";
            this.clientHomeAddressDataGridViewTextBoxColumn.Name = "clientHomeAddressDataGridViewTextBoxColumn";
            // 
            // clientCellNoDataGridViewTextBoxColumn
            // 
            this.clientCellNoDataGridViewTextBoxColumn.DataPropertyName = "Client_Cell_No";
            this.clientCellNoDataGridViewTextBoxColumn.HeaderText = "Cell Number";
            this.clientCellNoDataGridViewTextBoxColumn.Name = "clientCellNoDataGridViewTextBoxColumn";
            // 
            // clientCodeSelectedDataGridViewTextBoxColumn
            // 
            this.clientCodeSelectedDataGridViewTextBoxColumn.DataPropertyName = "Client_Code_Selected";
            this.clientCodeSelectedDataGridViewTextBoxColumn.HeaderText = "Code";
            this.clientCodeSelectedDataGridViewTextBoxColumn.Name = "clientCodeSelectedDataGridViewTextBoxColumn";
            // 
            // numLessonsRemainingDataGridViewTextBoxColumn
            // 
            this.numLessonsRemainingDataGridViewTextBoxColumn.DataPropertyName = "Num_Lessons_Remaining";
            this.numLessonsRemainingDataGridViewTextBoxColumn.HeaderText = "Lessons Remaining";
            this.numLessonsRemainingDataGridViewTextBoxColumn.Name = "numLessonsRemainingDataGridViewTextBoxColumn";
            // 
            // packageIDDataGridViewTextBoxColumn
            // 
            this.packageIDDataGridViewTextBoxColumn.DataPropertyName = "Package_ID";
            this.packageIDDataGridViewTextBoxColumn.HeaderText = "Package ID";
            this.packageIDDataGridViewTextBoxColumn.Name = "packageIDDataGridViewTextBoxColumn";
            // 
            // instructorNumDataGridViewTextBoxColumn
            // 
            this.instructorNumDataGridViewTextBoxColumn.DataPropertyName = "Instructor_Num";
            this.instructorNumDataGridViewTextBoxColumn.HeaderText = "Instructor Num";
            this.instructorNumDataGridViewTextBoxColumn.Name = "instructorNumDataGridViewTextBoxColumn";
            // 
            // bsClient
            // 
            this.bsClient.DataMember = "Client";
            this.bsClient.DataSource = this.dsDrivingSchool;
            // 
            // dsDrivingSchool
            // 
            this.dsDrivingSchool.DataSetName = "dsDrivingSchool";
            this.dsDrivingSchool.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taClient
            // 
            this.taClient.ClearBeforeFill = true;
            // 
            // ViewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 647);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ViewCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View List of Customers";
            this.Load += new System.EventHandler(this.ViewCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayCustomers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDrivingSchool)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private dsDrivingSchool dsDrivingSchool;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEmailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientHomeAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCellNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCodeSelectedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLessonsRemainingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorNumDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dgvDisplayCustomers;
        public System.Windows.Forms.BindingSource bsClient;
        public dsDrivingSchoolTableAdapters.ClientTableAdapter taClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
namespace TAPAAPI
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboGet = new System.Windows.Forms.ComboBox();
            this.btnUpdatePatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.btnGetAppointment = new System.Windows.Forms.Button();
            this.dgvAppoiment = new System.Windows.Forms.DataGridView();
            this.colPatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExternalPatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScheduleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScheduleTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDistrict = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveMedicine = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoiment)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveMedicine);
            this.groupBox1.Controls.Add(this.cboGet);
            this.groupBox1.Controls.Add(this.btnUpdatePatient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpAppointment);
            this.groupBox1.Controls.Add(this.btnGetAppointment);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 124);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cboGet
            // 
            this.cboGet.FormattingEnabled = true;
            this.cboGet.Location = new System.Drawing.Point(263, 20);
            this.cboGet.Name = "cboGet";
            this.cboGet.Size = new System.Drawing.Size(98, 24);
            this.cboGet.TabIndex = 9;
            // 
            // btnUpdatePatient
            // 
            this.btnUpdatePatient.Location = new System.Drawing.Point(513, 20);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(128, 23);
            this.btnUpdatePatient.TabIndex = 8;
            this.btnUpdatePatient.Text = "Update thông tin";
            this.btnUpdatePatient.UseVisualStyleBackColor = true;
            this.btnUpdatePatient.Click += new System.EventHandler(this.btnUpdatePatient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ngày lấy lịch hẹn:";
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.CustomFormat = "dd/MM/yyyy";
            this.dtpAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointment.Location = new System.Drawing.Point(142, 21);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.Size = new System.Drawing.Size(115, 22);
            this.dtpAppointment.TabIndex = 6;
            // 
            // btnGetAppointment
            // 
            this.btnGetAppointment.Location = new System.Drawing.Point(382, 19);
            this.btnGetAppointment.Name = "btnGetAppointment";
            this.btnGetAppointment.Size = new System.Drawing.Size(114, 23);
            this.btnGetAppointment.TabIndex = 5;
            this.btnGetAppointment.Text = "Lấy lịch hẹn";
            this.btnGetAppointment.UseVisualStyleBackColor = true;
            this.btnGetAppointment.Click += new System.EventHandler(this.btnGetAppointment_Click);
            // 
            // dgvAppoiment
            // 
            this.dgvAppoiment.AllowUserToAddRows = false;
            this.dgvAppoiment.AllowUserToDeleteRows = false;
            this.dgvAppoiment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppoiment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPatientID,
            this.colExternalPatientID,
            this.colPatientName,
            this.colGender,
            this.colScheduleID,
            this.colScheduleTime,
            this.colStatus,
            this.colType,
            this.colNumberOrder,
            this.colAddress,
            this.colDistrict,
            this.colWard,
            this.colCity,
            this.colDoctorID,
            this.colDoctorName});
            this.dgvAppoiment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppoiment.Location = new System.Drawing.Point(0, 124);
            this.dgvAppoiment.Name = "dgvAppoiment";
            this.dgvAppoiment.RowHeadersWidth = 51;
            this.dgvAppoiment.RowTemplate.Height = 24;
            this.dgvAppoiment.Size = new System.Drawing.Size(800, 326);
            this.dgvAppoiment.TabIndex = 5;
            // 
            // colPatientID
            // 
            this.colPatientID.DataPropertyName = "PatientID";
            this.colPatientID.HeaderText = "PatientID";
            this.colPatientID.MinimumWidth = 6;
            this.colPatientID.Name = "colPatientID";
            this.colPatientID.Width = 125;
            // 
            // colExternalPatientID
            // 
            this.colExternalPatientID.DataPropertyName = "ExternalPatientID";
            this.colExternalPatientID.HeaderText = "ExternalPatientID";
            this.colExternalPatientID.MinimumWidth = 6;
            this.colExternalPatientID.Name = "colExternalPatientID";
            this.colExternalPatientID.Width = 125;
            // 
            // colPatientName
            // 
            this.colPatientName.DataPropertyName = "PatientName";
            this.colPatientName.HeaderText = "PatientName";
            this.colPatientName.MinimumWidth = 6;
            this.colPatientName.Name = "colPatientName";
            this.colPatientName.Width = 125;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.HeaderText = "Gender";
            this.colGender.MinimumWidth = 6;
            this.colGender.Name = "colGender";
            this.colGender.Width = 125;
            // 
            // colScheduleID
            // 
            this.colScheduleID.DataPropertyName = "ScheduleID";
            this.colScheduleID.HeaderText = "ScheduleID";
            this.colScheduleID.MinimumWidth = 6;
            this.colScheduleID.Name = "colScheduleID";
            this.colScheduleID.Width = 125;
            // 
            // colScheduleTime
            // 
            this.colScheduleTime.DataPropertyName = "ScheduleTime";
            this.colScheduleTime.HeaderText = "ScheduleTime";
            this.colScheduleTime.MinimumWidth = 6;
            this.colScheduleTime.Name = "colScheduleTime";
            this.colScheduleTime.Width = 125;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 125;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "Type";
            this.colType.HeaderText = "Type";
            this.colType.MinimumWidth = 6;
            this.colType.Name = "colType";
            this.colType.Width = 125;
            // 
            // colNumberOrder
            // 
            this.colNumberOrder.DataPropertyName = "NumberOrder";
            this.colNumberOrder.HeaderText = "NumberOrder";
            this.colNumberOrder.MinimumWidth = 6;
            this.colNumberOrder.Name = "colNumberOrder";
            this.colNumberOrder.Width = 125;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Address";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            this.colAddress.Width = 125;
            // 
            // colDistrict
            // 
            this.colDistrict.DataPropertyName = "District";
            this.colDistrict.HeaderText = "District";
            this.colDistrict.MinimumWidth = 6;
            this.colDistrict.Name = "colDistrict";
            this.colDistrict.Width = 125;
            // 
            // colWard
            // 
            this.colWard.DataPropertyName = "Ward";
            this.colWard.HeaderText = "Ward";
            this.colWard.MinimumWidth = 6;
            this.colWard.Name = "colWard";
            this.colWard.Width = 125;
            // 
            // colCity
            // 
            this.colCity.DataPropertyName = "City";
            this.colCity.HeaderText = "City";
            this.colCity.MinimumWidth = 6;
            this.colCity.Name = "colCity";
            this.colCity.Width = 125;
            // 
            // colDoctorID
            // 
            this.colDoctorID.DataPropertyName = "DoctorID";
            this.colDoctorID.HeaderText = "DoctorID";
            this.colDoctorID.MinimumWidth = 6;
            this.colDoctorID.Name = "colDoctorID";
            this.colDoctorID.Width = 125;
            // 
            // colDoctorName
            // 
            this.colDoctorName.DataPropertyName = "DoctorName";
            this.colDoctorName.HeaderText = "DoctorName";
            this.colDoctorName.MinimumWidth = 6;
            this.colDoctorName.Name = "colDoctorName";
            this.colDoctorName.Width = 125;
            // 
            // btnSaveMedicine
            // 
            this.btnSaveMedicine.Location = new System.Drawing.Point(382, 60);
            this.btnSaveMedicine.Name = "btnSaveMedicine";
            this.btnSaveMedicine.Size = new System.Drawing.Size(173, 23);
            this.btnSaveMedicine.TabIndex = 10;
            this.btnSaveMedicine.Text = "Update thông tin thuốc";
            this.btnSaveMedicine.UseVisualStyleBackColor = true;
            this.btnSaveMedicine.Click += new System.EventHandler(this.btnSaveMedicine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAppoiment);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoiment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.Button btnGetAppointment;
        private System.Windows.Forms.DataGridView dgvAppoiment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExternalPatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScheduleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScheduleTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDistrict;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWard;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctorName;
        private System.Windows.Forms.Button btnUpdatePatient;
        private System.Windows.Forms.ComboBox cboGet;
        private System.Windows.Forms.Button btnSaveMedicine;
    }
}


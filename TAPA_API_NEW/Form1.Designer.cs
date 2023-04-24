namespace TAPA_API_NEW
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnUpdateInfo = new Button();
            label2 = new Label();
            txtToken = new TextBox();
            btnGetToken = new Button();
            btnGetAppointment = new Button();
            dtpDateAppointment = new DateTimePicker();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            dgvAppointment = new DataGridView();
            PatientID = new DataGridViewTextBoxColumn();
            ExternalPatientID = new DataGridViewTextBoxColumn();
            PatientName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            ScheduleID = new DataGridViewTextBoxColumn();
            DoctorID = new DataGridViewTextBoxColumn();
            DoctorName = new DataGridViewTextBoxColumn();
            ScheduleTime = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            NumberOrder = new DataGridViewTextBoxColumn();
            PrefixOrderNum = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            District = new DataGridViewTextBoxColumn();
            Ward = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            btnUploadMedicine = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointment).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUploadMedicine);
            groupBox1.Controls.Add(btnUpdateInfo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtToken);
            groupBox1.Controls.Add(btnGetToken);
            groupBox1.Controls.Add(btnGetAppointment);
            groupBox1.Controls.Add(dtpDateAppointment);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin dữ dữ liệu";
            // 
            // btnUpdateInfo
            // 
            btnUpdateInfo.Location = new Point(242, 74);
            btnUpdateInfo.Name = "btnUpdateInfo";
            btnUpdateInfo.Size = new Size(171, 29);
            btnUpdateInfo.TabIndex = 6;
            btnUpdateInfo.Text = "Cập nhật thông tin";
            btnUpdateInfo.UseVisualStyleBackColor = true;
            btnUpdateInfo.Click += btnUpdateInfo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 23);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 5;
            label2.Text = "Token:";
            // 
            // txtToken
            // 
            txtToken.Location = new Point(394, 18);
            txtToken.Name = "txtToken";
            txtToken.ReadOnly = true;
            txtToken.Size = new Size(293, 27);
            txtToken.TabIndex = 4;
            // 
            // btnGetToken
            // 
            btnGetToken.Location = new Point(10, 74);
            btnGetToken.Name = "btnGetToken";
            btnGetToken.Size = new Size(110, 29);
            btnGetToken.TabIndex = 3;
            btnGetToken.Text = "Lấy token";
            btnGetToken.UseVisualStyleBackColor = true;
            btnGetToken.Click += btnGetToken_Click;
            // 
            // btnGetAppointment
            // 
            btnGetAppointment.Location = new Point(126, 74);
            btnGetAppointment.Name = "btnGetAppointment";
            btnGetAppointment.Size = new Size(110, 29);
            btnGetAppointment.TabIndex = 2;
            btnGetAppointment.Text = "Lấy Lịch Hẹn";
            btnGetAppointment.UseVisualStyleBackColor = true;
            btnGetAppointment.Click += btnGetAppointment_Click;
            // 
            // dtpDateAppointment
            // 
            dtpDateAppointment.CustomFormat = "dd/MM/yyyy";
            dtpDateAppointment.Format = DateTimePickerFormat.Custom;
            dtpDateAppointment.Location = new Point(144, 18);
            dtpDateAppointment.Name = "dtpDateAppointment";
            dtpDateAppointment.Size = new Size(123, 27);
            dtpDateAppointment.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 23);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Ngày đặt lịch hẹn:";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvAppointment);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 325);
            panel2.TabIndex = 2;
            // 
            // dgvAppointment
            // 
            dgvAppointment.AllowUserToAddRows = false;
            dgvAppointment.AllowUserToDeleteRows = false;
            dgvAppointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointment.Columns.AddRange(new DataGridViewColumn[] { PatientID, ExternalPatientID, PatientName, Gender, ScheduleID, DoctorID, DoctorName, ScheduleTime, Status, Type, NumberOrder, PrefixOrderNum, Address, District, Ward, City });
            dgvAppointment.Dock = DockStyle.Fill;
            dgvAppointment.Location = new Point(0, 0);
            dgvAppointment.Name = "dgvAppointment";
            dgvAppointment.RowHeadersWidth = 51;
            dgvAppointment.RowTemplate.Height = 29;
            dgvAppointment.Size = new Size(800, 325);
            dgvAppointment.TabIndex = 0;
            // 
            // PatientID
            // 
            PatientID.DataPropertyName = "PatientID";
            PatientID.HeaderText = "PatientID";
            PatientID.MinimumWidth = 6;
            PatientID.Name = "PatientID";
            PatientID.Width = 125;
            // 
            // ExternalPatientID
            // 
            ExternalPatientID.DataPropertyName = "ExternalPatientID";
            ExternalPatientID.HeaderText = "ExternalPatientID";
            ExternalPatientID.MinimumWidth = 6;
            ExternalPatientID.Name = "ExternalPatientID";
            ExternalPatientID.Width = 125;
            // 
            // PatientName
            // 
            PatientName.DataPropertyName = "PatientName";
            PatientName.HeaderText = "PatientName";
            PatientName.MinimumWidth = 6;
            PatientName.Name = "PatientName";
            PatientName.Width = 125;
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.Width = 125;
            // 
            // ScheduleID
            // 
            ScheduleID.DataPropertyName = "ScheduleID";
            ScheduleID.HeaderText = "ScheduleID";
            ScheduleID.MinimumWidth = 6;
            ScheduleID.Name = "ScheduleID";
            ScheduleID.Width = 125;
            // 
            // DoctorID
            // 
            DoctorID.DataPropertyName = "DoctorID";
            DoctorID.HeaderText = "DoctorID";
            DoctorID.MinimumWidth = 6;
            DoctorID.Name = "DoctorID";
            DoctorID.Width = 125;
            // 
            // DoctorName
            // 
            DoctorName.DataPropertyName = "DoctorName";
            DoctorName.HeaderText = "DoctorName";
            DoctorName.MinimumWidth = 6;
            DoctorName.Name = "DoctorName";
            DoctorName.Width = 125;
            // 
            // ScheduleTime
            // 
            ScheduleTime.DataPropertyName = "ScheduleTime";
            ScheduleTime.HeaderText = "ScheduleTime";
            ScheduleTime.MinimumWidth = 6;
            ScheduleTime.Name = "ScheduleTime";
            ScheduleTime.Width = 125;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // Type
            // 
            Type.DataPropertyName = "Type";
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.Width = 125;
            // 
            // NumberOrder
            // 
            NumberOrder.DataPropertyName = "NumberOrder";
            NumberOrder.HeaderText = "NumberOrder";
            NumberOrder.MinimumWidth = 6;
            NumberOrder.Name = "NumberOrder";
            NumberOrder.Width = 125;
            // 
            // PrefixOrderNum
            // 
            PrefixOrderNum.DataPropertyName = "PrefixOrderNum";
            PrefixOrderNum.HeaderText = "PrefixOrderNum";
            PrefixOrderNum.MinimumWidth = 6;
            PrefixOrderNum.Name = "PrefixOrderNum";
            PrefixOrderNum.Width = 125;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 125;
            // 
            // District
            // 
            District.DataPropertyName = "District";
            District.HeaderText = "District";
            District.MinimumWidth = 6;
            District.Name = "District";
            District.Width = 125;
            // 
            // Ward
            // 
            Ward.DataPropertyName = "Ward";
            Ward.HeaderText = "Ward";
            Ward.MinimumWidth = 6;
            Ward.Name = "Ward";
            Ward.Width = 125;
            // 
            // City
            // 
            City.DataPropertyName = "City";
            City.HeaderText = "City";
            City.MinimumWidth = 6;
            City.Name = "City";
            City.Width = 125;
            // 
            // btnUploadMedicine
            // 
            btnUploadMedicine.Location = new Point(419, 74);
            btnUploadMedicine.Name = "btnUploadMedicine";
            btnUploadMedicine.Size = new Size(171, 29);
            btnUploadMedicine.TabIndex = 7;
            btnUploadMedicine.Text = "Upload Thông tin đơn thuốc";
            btnUploadMedicine.UseVisualStyleBackColor = true;
            btnUploadMedicine.Click += btnUploadMedicine_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAppointment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private DateTimePicker dtpDateAppointment;
        private Button btnGetAppointment;
        private Button btnGetToken;
        private TextBox txtToken;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvAppointment;
        private DataGridViewTextBoxColumn PatientID;
        private DataGridViewTextBoxColumn ExternalPatientID;
        private DataGridViewTextBoxColumn PatientName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn ScheduleID;
        private DataGridViewTextBoxColumn DoctorID;
        private DataGridViewTextBoxColumn DoctorName;
        private DataGridViewTextBoxColumn ScheduleTime;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn NumberOrder;
        private DataGridViewTextBoxColumn PrefixOrderNum;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn District;
        private DataGridViewTextBoxColumn Ward;
        private DataGridViewTextBoxColumn City;
        private Button btnUpdateInfo;
        private Button btnUploadMedicine;
    }
}
namespace ClientManagementSystem
{
    partial class frmClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClients));
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblNationalId = new System.Windows.Forms.Label();
            this.txtNationalId = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.gbClientInfo = new System.Windows.Forms.GroupBox();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.rbMarried = new System.Windows.Forms.RadioButton();
            this.gbOperations = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgDatas = new System.Windows.Forms.DataGridView();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pbCalender = new System.Windows.Forms.PictureBox();
            this.gbClientInfo.SuspendLayout();
            this.gbOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalender)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(137, 45);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(269, 27);
            this.txtId.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.Location = new System.Drawing.Point(100, 49);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 20);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(73, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 27);
            this.txtName.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.Location = new System.Drawing.Point(50, 115);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(81, 20);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Surname:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(137, 111);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(269, 27);
            this.txtSurname.TabIndex = 4;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAge.Location = new System.Drawing.Point(88, 148);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(43, 20);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Age:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(137, 144);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(269, 27);
            this.txtAge.TabIndex = 6;
            // 
            // lblNationalId
            // 
            this.lblNationalId.AutoSize = true;
            this.lblNationalId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNationalId.Location = new System.Drawing.Point(34, 181);
            this.lblNationalId.Name = "lblNationalId";
            this.lblNationalId.Size = new System.Drawing.Size(97, 20);
            this.lblNationalId.TabIndex = 9;
            this.lblNationalId.Text = "National ID:";
            // 
            // txtNationalId
            // 
            this.txtNationalId.Location = new System.Drawing.Point(137, 177);
            this.txtNationalId.Name = "txtNationalId";
            this.txtNationalId.Size = new System.Drawing.Size(269, 27);
            this.txtNationalId.TabIndex = 8;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.Location = new System.Drawing.Point(70, 214);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 20);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone:";
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaritalStatus.Location = new System.Drawing.Point(13, 247);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(118, 20);
            this.lblMaritalStatus.TabIndex = 13;
            this.lblMaritalStatus.Text = "Marital Status:";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblJob.Location = new System.Drawing.Point(90, 280);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(41, 20);
            this.lblJob.TabIndex = 15;
            this.lblJob.Text = "Job:";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(137, 276);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(269, 27);
            this.txtJob.TabIndex = 14;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCity.Location = new System.Drawing.Point(88, 313);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 20);
            this.lblCity.TabIndex = 17;
            this.lblCity.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(137, 309);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(269, 27);
            this.txtCity.TabIndex = 16;
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Location = new System.Drawing.Point(137, 210);
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(269, 27);
            this.mtxtPhone.TabIndex = 18;
            // 
            // gbClientInfo
            // 
            this.gbClientInfo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbClientInfo.Controls.Add(this.rbSingle);
            this.gbClientInfo.Controls.Add(this.rbMarried);
            this.gbClientInfo.Controls.Add(this.mtxtPhone);
            this.gbClientInfo.Controls.Add(this.txtId);
            this.gbClientInfo.Controls.Add(this.lblCity);
            this.gbClientInfo.Controls.Add(this.lblId);
            this.gbClientInfo.Controls.Add(this.txtCity);
            this.gbClientInfo.Controls.Add(this.txtName);
            this.gbClientInfo.Controls.Add(this.lblJob);
            this.gbClientInfo.Controls.Add(this.lblName);
            this.gbClientInfo.Controls.Add(this.txtJob);
            this.gbClientInfo.Controls.Add(this.txtSurname);
            this.gbClientInfo.Controls.Add(this.lblMaritalStatus);
            this.gbClientInfo.Controls.Add(this.lblSurname);
            this.gbClientInfo.Controls.Add(this.txtAge);
            this.gbClientInfo.Controls.Add(this.lblPhone);
            this.gbClientInfo.Controls.Add(this.lblAge);
            this.gbClientInfo.Controls.Add(this.lblNationalId);
            this.gbClientInfo.Controls.Add(this.txtNationalId);
            this.gbClientInfo.Location = new System.Drawing.Point(12, 12);
            this.gbClientInfo.Name = "gbClientInfo";
            this.gbClientInfo.Size = new System.Drawing.Size(446, 361);
            this.gbClientInfo.TabIndex = 19;
            this.gbClientInfo.TabStop = false;
            this.gbClientInfo.Text = "Client Information";
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Location = new System.Drawing.Point(293, 245);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(76, 24);
            this.rbSingle.TabIndex = 20;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "Single";
            this.rbSingle.UseVisualStyleBackColor = true;
            // 
            // rbMarried
            // 
            this.rbMarried.AutoSize = true;
            this.rbMarried.Location = new System.Drawing.Point(165, 245);
            this.rbMarried.Name = "rbMarried";
            this.rbMarried.Size = new System.Drawing.Size(87, 24);
            this.rbMarried.TabIndex = 19;
            this.rbMarried.TabStop = true;
            this.rbMarried.Text = "Married";
            this.rbMarried.UseVisualStyleBackColor = true;
            // 
            // gbOperations
            // 
            this.gbOperations.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.gbOperations.Controls.Add(this.btnReset);
            this.gbOperations.Controls.Add(this.btnList);
            this.gbOperations.Controls.Add(this.btnUpdate);
            this.gbOperations.Controls.Add(this.btnDelete);
            this.gbOperations.Controls.Add(this.btnAdd);
            this.gbOperations.Location = new System.Drawing.Point(479, 12);
            this.gbOperations.Name = "gbOperations";
            this.gbOperations.Size = new System.Drawing.Size(239, 361);
            this.gbOperations.TabIndex = 20;
            this.gbOperations.TabStop = false;
            this.gbOperations.Text = "Operations";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Silver;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReset.Location = new System.Drawing.Point(6, 297);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(227, 40);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Silver;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.Location = new System.Drawing.Point(6, 235);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(227, 40);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "LIST";
            this.btnList.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(6, 173);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(227, 40);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(6, 111);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(227, 40);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(6, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(227, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // dgDatas
            // 
            this.dgDatas.AllowUserToAddRows = false;
            this.dgDatas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgDatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatas.Location = new System.Drawing.Point(12, 379);
            this.dgDatas.Name = "dgDatas";
            this.dgDatas.ReadOnly = true;
            this.dgDatas.RowHeadersWidth = 51;
            this.dgDatas.RowTemplate.Height = 24;
            this.dgDatas.Size = new System.Drawing.Size(954, 259);
            this.dgDatas.TabIndex = 21;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(813, 74);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(104, 27);
            this.lblTime.TabIndex = 23;
            this.lblTime.Text = "00:00:00";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.ForeColor = System.Drawing.Color.Red;
            this.lblDate.Location = new System.Drawing.Point(801, 43);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(128, 27);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "00.00.0000";
            // 
            // pbCalender
            // 
            this.pbCalender.BackColor = System.Drawing.Color.Transparent;
            this.pbCalender.Image = ((System.Drawing.Image)(resources.GetObject("pbCalender.Image")));
            this.pbCalender.Location = new System.Drawing.Point(764, 136);
            this.pbCalender.Name = "pbCalender";
            this.pbCalender.Size = new System.Drawing.Size(202, 213);
            this.pbCalender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCalender.TabIndex = 24;
            this.pbCalender.TabStop = false;
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(976, 650);
            this.Controls.Add(this.pbCalender);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dgDatas);
            this.Controls.Add(this.gbOperations);
            this.Controls.Add(this.gbClientInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Management System";
            this.Load += new System.EventHandler(this.frmClients_Load);
            this.gbClientInfo.ResumeLayout(false);
            this.gbClientInfo.PerformLayout();
            this.gbOperations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblNationalId;
        private System.Windows.Forms.TextBox txtNationalId;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.GroupBox gbClientInfo;
        private System.Windows.Forms.GroupBox gbOperations;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgDatas;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.RadioButton rbMarried;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pbCalender;
    }
}


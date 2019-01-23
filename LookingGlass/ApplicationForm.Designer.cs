namespace LookingGlass
{
    partial class ApplicationForm
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblEmployerName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblCandidateFullName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtEmployerName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtCandidateFullName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvApplication = new System.Windows.Forms.DataGridView();
            this.pnlAddApplication = new System.Windows.Forms.Panel();
            this.cboCandidateName = new System.Windows.Forms.ComboBox();
            this.cboCandidateID = new System.Windows.Forms.ComboBox();
            this.cboVacancyDescription = new System.Windows.Forms.ComboBox();
            this.cboVacancyID = new System.Windows.Forms.ComboBox();
            this.lblCandidate = new System.Windows.Forms.Label();
            this.lblVacancy = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddApplication = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplication)).BeginInit();
            this.pnlAddApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(299, 44);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description:";
            // 
            // lblEmployerName
            // 
            this.lblEmployerName.AutoSize = true;
            this.lblEmployerName.Location = new System.Drawing.Point(287, 82);
            this.lblEmployerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployerName.Name = "lblEmployerName";
            this.lblEmployerName.Size = new System.Drawing.Size(84, 13);
            this.lblEmployerName.TabIndex = 2;
            this.lblEmployerName.Text = "Employer Name:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(329, 120);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(39, 13);
            this.lblSalary.TabIndex = 3;
            this.lblSalary.Text = "Salary:";
            // 
            // lblCandidateFullName
            // 
            this.lblCandidateFullName.AutoSize = true;
            this.lblCandidateFullName.Location = new System.Drawing.Point(251, 159);
            this.lblCandidateFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCandidateFullName.Name = "lblCandidateFullName";
            this.lblCandidateFullName.Size = new System.Drawing.Size(108, 13);
            this.lblCandidateFullName.TabIndex = 4;
            this.lblCandidateFullName.Text = "Candidate Full Name:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(393, 42);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(98, 20);
            this.txtDescription.TabIndex = 5;
            // 
            // txtEmployerName
            // 
            this.txtEmployerName.Location = new System.Drawing.Point(393, 80);
            this.txtEmployerName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmployerName.Name = "txtEmployerName";
            this.txtEmployerName.Size = new System.Drawing.Size(188, 20);
            this.txtEmployerName.TabIndex = 6;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(393, 118);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(76, 20);
            this.txtSalary.TabIndex = 7;
            // 
            // txtCandidateFullName
            // 
            this.txtCandidateFullName.Location = new System.Drawing.Point(393, 156);
            this.txtCandidateFullName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCandidateFullName.Name = "txtCandidateFullName";
            this.txtCandidateFullName.Size = new System.Drawing.Size(188, 20);
            this.txtCandidateFullName.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(315, 273);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 33);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Application";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddA_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(457, 273);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 33);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete Application";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(457, 335);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(124, 33);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvApplication
            // 
            this.dgvApplication.AllowUserToAddRows = false;
            this.dgvApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplication.Location = new System.Drawing.Point(47, 29);
            this.dgvApplication.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvApplication.Name = "dgvApplication";
            this.dgvApplication.RowTemplate.Height = 27;
            this.dgvApplication.Size = new System.Drawing.Size(180, 311);
            this.dgvApplication.TabIndex = 12;
            this.dgvApplication.SelectionChanged += new System.EventHandler(this.dgvApplication_SelectionChanged);
            // 
            // pnlAddApplication
            // 
            this.pnlAddApplication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddApplication.Controls.Add(this.cboCandidateName);
            this.pnlAddApplication.Controls.Add(this.cboCandidateID);
            this.pnlAddApplication.Controls.Add(this.cboVacancyDescription);
            this.pnlAddApplication.Controls.Add(this.cboVacancyID);
            this.pnlAddApplication.Controls.Add(this.lblCandidate);
            this.pnlAddApplication.Controls.Add(this.lblVacancy);
            this.pnlAddApplication.Controls.Add(this.btnCancel);
            this.pnlAddApplication.Controls.Add(this.btnAddApplication);
            this.pnlAddApplication.Location = new System.Drawing.Point(246, 29);
            this.pnlAddApplication.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlAddApplication.Name = "pnlAddApplication";
            this.pnlAddApplication.Size = new System.Drawing.Size(346, 207);
            this.pnlAddApplication.TabIndex = 13;
            this.pnlAddApplication.Visible = false;
            // 
            // cboCandidateName
            // 
            this.cboCandidateName.FormattingEnabled = true;
            this.cboCandidateName.Location = new System.Drawing.Point(173, 115);
            this.cboCandidateName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboCandidateName.Name = "cboCandidateName";
            this.cboCandidateName.Size = new System.Drawing.Size(118, 21);
            this.cboCandidateName.TabIndex = 7;
            // 
            // cboCandidateID
            // 
            this.cboCandidateID.FormattingEnabled = true;
            this.cboCandidateID.Location = new System.Drawing.Point(96, 115);
            this.cboCandidateID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboCandidateID.Name = "cboCandidateID";
            this.cboCandidateID.Size = new System.Drawing.Size(50, 21);
            this.cboCandidateID.TabIndex = 6;
            // 
            // cboVacancyDescription
            // 
            this.cboVacancyDescription.FormattingEnabled = true;
            this.cboVacancyDescription.Location = new System.Drawing.Point(173, 50);
            this.cboVacancyDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboVacancyDescription.Name = "cboVacancyDescription";
            this.cboVacancyDescription.Size = new System.Drawing.Size(118, 21);
            this.cboVacancyDescription.TabIndex = 5;
            // 
            // cboVacancyID
            // 
            this.cboVacancyID.FormattingEnabled = true;
            this.cboVacancyID.Location = new System.Drawing.Point(96, 50);
            this.cboVacancyID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboVacancyID.Name = "cboVacancyID";
            this.cboVacancyID.Size = new System.Drawing.Size(50, 21);
            this.cboVacancyID.TabIndex = 4;
            // 
            // lblCandidate
            // 
            this.lblCandidate.AutoSize = true;
            this.lblCandidate.Location = new System.Drawing.Point(26, 118);
            this.lblCandidate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCandidate.Name = "lblCandidate";
            this.lblCandidate.Size = new System.Drawing.Size(58, 13);
            this.lblCandidate.TabIndex = 3;
            this.lblCandidate.Text = "Candidate:";
            // 
            // lblVacancy
            // 
            this.lblVacancy.AutoSize = true;
            this.lblVacancy.Location = new System.Drawing.Point(36, 50);
            this.lblVacancy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVacancy.Name = "lblVacancy";
            this.lblVacancy.Size = new System.Drawing.Size(52, 13);
            this.lblVacancy.TabIndex = 2;
            this.lblVacancy.Text = "Vacancy:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(190, 153);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 29);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.Location = new System.Drawing.Point(38, 153);
            this.btnAddApplication.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(109, 29);
            this.btnAddApplication.TabIndex = 0;
            this.btnAddApplication.Text = "Save Application";
            this.btnAddApplication.UseVisualStyleBackColor = true;
            this.btnAddApplication.Click += new System.EventHandler(this.btnAddApplication_Click);
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 390);
            this.Controls.Add(this.pnlAddApplication);
            this.Controls.Add(this.dgvApplication);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCandidateFullName);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEmployerName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCandidateFullName);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblEmployerName);
            this.Controls.Add(this.lblDescription);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ApplicationForm";
            this.Text = "Application Maintanence";
            this.Load += new System.EventHandler(this.ApplicationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplication)).EndInit();
            this.pnlAddApplication.ResumeLayout(false);
            this.pnlAddApplication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblEmployerName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblCandidateFullName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtEmployerName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtCandidateFullName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvApplication;
        private System.Windows.Forms.Panel pnlAddApplication;
        private System.Windows.Forms.ComboBox cboCandidateName;
        private System.Windows.Forms.ComboBox cboCandidateID;
        private System.Windows.Forms.ComboBox cboVacancyDescription;
        private System.Windows.Forms.ComboBox cboVacancyID;
        private System.Windows.Forms.Label lblCandidate;
        private System.Windows.Forms.Label lblVacancy;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddApplication;
    }
}
namespace LookingGlass
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnApplication = new System.Windows.Forms.Button();
            this.btnSTCandidate = new System.Windows.Forms.Button();
            this.btnSTVancancy = new System.Windows.Forms.Button();
            this.btnVacancy = new System.Windows.Forms.Button();
            this.btnCandidate = new System.Windows.Forms.Button();
            this.btnEmployer = new System.Windows.Forms.Button();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCandidates = new System.Windows.Forms.Button();
            this.btnVacancies = new System.Windows.Forms.Button();
            this.grpMaintenance.SuspendLayout();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnApplication);
            this.grpMaintenance.Controls.Add(this.btnSTCandidate);
            this.grpMaintenance.Controls.Add(this.btnSTVancancy);
            this.grpMaintenance.Controls.Add(this.btnVacancy);
            this.grpMaintenance.Controls.Add(this.btnCandidate);
            this.grpMaintenance.Controls.Add(this.btnEmployer);
            this.grpMaintenance.Location = new System.Drawing.Point(29, 42);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(347, 464);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // btnApplication
            // 
            this.btnApplication.Location = new System.Drawing.Point(33, 401);
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.Size = new System.Drawing.Size(273, 41);
            this.btnApplication.TabIndex = 5;
            this.btnApplication.Text = "Application Maintenance";
            this.btnApplication.UseVisualStyleBackColor = true;
            this.btnApplication.Click += new System.EventHandler(this.btnApplication_Click);
            // 
            // btnSTCandidate
            // 
            this.btnSTCandidate.Location = new System.Drawing.Point(33, 328);
            this.btnSTCandidate.Name = "btnSTCandidate";
            this.btnSTCandidate.Size = new System.Drawing.Size(273, 41);
            this.btnSTCandidate.TabIndex = 4;
            this.btnSTCandidate.Text = "Assign Skill to a Candidate";
            this.btnSTCandidate.UseVisualStyleBackColor = true;
            this.btnSTCandidate.Click += new System.EventHandler(this.btnSTCandidate_Click);
            // 
            // btnSTVancancy
            // 
            this.btnSTVancancy.Location = new System.Drawing.Point(33, 255);
            this.btnSTVancancy.Name = "btnSTVancancy";
            this.btnSTVancancy.Size = new System.Drawing.Size(273, 41);
            this.btnSTVancancy.TabIndex = 3;
            this.btnSTVancancy.Text = "Assign Skill to a Vancancy";
            this.btnSTVancancy.UseVisualStyleBackColor = true;
            this.btnSTVancancy.Click += new System.EventHandler(this.btnSTVancancy_Click);
            // 
            // btnVacancy
            // 
            this.btnVacancy.Location = new System.Drawing.Point(33, 182);
            this.btnVacancy.Name = "btnVacancy";
            this.btnVacancy.Size = new System.Drawing.Size(273, 41);
            this.btnVacancy.TabIndex = 2;
            this.btnVacancy.Text = "Vacancy Maintanence";
            this.btnVacancy.UseVisualStyleBackColor = true;
            this.btnVacancy.Click += new System.EventHandler(this.btnVacancy_Click);
            // 
            // btnCandidate
            // 
            this.btnCandidate.Location = new System.Drawing.Point(33, 109);
            this.btnCandidate.Name = "btnCandidate";
            this.btnCandidate.Size = new System.Drawing.Size(273, 41);
            this.btnCandidate.TabIndex = 1;
            this.btnCandidate.Text = "Candidate Maintenance ";
            this.btnCandidate.UseVisualStyleBackColor = true;
            this.btnCandidate.Click += new System.EventHandler(this.btnCandidate_Click);
            // 
            // btnEmployer
            // 
            this.btnEmployer.Location = new System.Drawing.Point(33, 36);
            this.btnEmployer.Name = "btnEmployer";
            this.btnEmployer.Size = new System.Drawing.Size(273, 41);
            this.btnEmployer.TabIndex = 0;
            this.btnEmployer.Text = "Employer Maintenance ";
            this.btnEmployer.UseVisualStyleBackColor = true;
            this.btnEmployer.Click += new System.EventHandler(this.btnEmployer_Click);
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.btnExit);
            this.grpReport.Controls.Add(this.btnCandidates);
            this.grpReport.Controls.Add(this.btnVacancies);
            this.grpReport.Location = new System.Drawing.Point(499, 42);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(368, 464);
            this.grpReport.TabIndex = 1;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Reporting";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(51, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(272, 41);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCandidates
            // 
            this.btnCandidates.Location = new System.Drawing.Point(43, 109);
            this.btnCandidates.Name = "btnCandidates";
            this.btnCandidates.Size = new System.Drawing.Size(272, 41);
            this.btnCandidates.TabIndex = 2;
            this.btnCandidates.Text = "Candidates";
            this.btnCandidates.UseVisualStyleBackColor = true;
            this.btnCandidates.Click += new System.EventHandler(this.btnCandidates_Click);
            // 
            // btnVacancies
            // 
            this.btnVacancies.Location = new System.Drawing.Point(43, 36);
            this.btnVacancies.Name = "btnVacancies";
            this.btnVacancies.Size = new System.Drawing.Size(272, 41);
            this.btnVacancies.TabIndex = 1;
            this.btnVacancies.Text = "Vacancies";
            this.btnVacancies.UseVisualStyleBackColor = true;
            this.btnVacancies.Click += new System.EventHandler(this.btnVacancies_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 556);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.grpMaintenance);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.Button btnApplication;
        private System.Windows.Forms.Button btnSTCandidate;
        private System.Windows.Forms.Button btnSTVancancy;
        private System.Windows.Forms.Button btnVacancy;
        private System.Windows.Forms.Button btnCandidate;
        private System.Windows.Forms.Button btnEmployer;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCandidates;
        private System.Windows.Forms.Button btnVacancies;
    }
}


namespace LookingGlass
{
    partial class STCandidateForm
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.lblYears = new System.Windows.Forms.Label();
            this.btnRemoveSkill = new System.Windows.Forms.Button();
            this.btnAssignSkill = new System.Windows.Forms.Button();
            this.dgvCandidateSkill = new System.Windows.Forms.DataGridView();
            this.dgvSkill = new System.Windows.Forms.DataGridView();
            this.dgvCandidate = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new LookingGlass.DataSet1();
            this.cANDIDATEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANDIDATEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(456, 393);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(124, 36);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(340, 298);
            this.txtYears.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(55, 20);
            this.txtYears.TabIndex = 14;
            this.txtYears.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYears_KeyPress);
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(300, 301);
            this.lblYears.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(34, 13);
            this.lblYears.TabIndex = 13;
            this.lblYears.Text = "Years";
            // 
            // btnRemoveSkill
            // 
            this.btnRemoveSkill.Location = new System.Drawing.Point(302, 343);
            this.btnRemoveSkill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRemoveSkill.Name = "btnRemoveSkill";
            this.btnRemoveSkill.Size = new System.Drawing.Size(92, 36);
            this.btnRemoveSkill.TabIndex = 12;
            this.btnRemoveSkill.Text = "Remove Skill";
            this.btnRemoveSkill.UseVisualStyleBackColor = true;
            this.btnRemoveSkill.Click += new System.EventHandler(this.btnRemoveSkill_Click);
            // 
            // btnAssignSkill
            // 
            this.btnAssignSkill.Location = new System.Drawing.Point(302, 235);
            this.btnAssignSkill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAssignSkill.Name = "btnAssignSkill";
            this.btnAssignSkill.Size = new System.Drawing.Size(92, 36);
            this.btnAssignSkill.TabIndex = 11;
            this.btnAssignSkill.Text = "Assign Skill";
            this.btnAssignSkill.UseVisualStyleBackColor = true;
            this.btnAssignSkill.Click += new System.EventHandler(this.btnAssignSkill_Click);
            // 
            // dgvCandidateSkill
            // 
            this.dgvCandidateSkill.AllowUserToAddRows = false;
            this.dgvCandidateSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidateSkill.Location = new System.Drawing.Point(26, 235);
            this.dgvCandidateSkill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvCandidateSkill.Name = "dgvCandidateSkill";
            this.dgvCandidateSkill.RowTemplate.Height = 27;
            this.dgvCandidateSkill.Size = new System.Drawing.Size(256, 145);
            this.dgvCandidateSkill.TabIndex = 10;
            // 
            // dgvSkill
            // 
            this.dgvSkill.AllowUserToAddRows = false;
            this.dgvSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkill.Location = new System.Drawing.Point(411, 235);
            this.dgvSkill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvSkill.Name = "dgvSkill";
            this.dgvSkill.RowTemplate.Height = 27;
            this.dgvSkill.Size = new System.Drawing.Size(182, 145);
            this.dgvSkill.TabIndex = 9;
            // 
            // dgvCandidate
            // 
            this.dgvCandidate.AllowUserToAddRows = false;
            this.dgvCandidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidate.Location = new System.Drawing.Point(85, 27);
            this.dgvCandidate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvCandidate.Name = "dgvCandidate";
            this.dgvCandidate.RowTemplate.Height = 27;
            this.dgvCandidate.Size = new System.Drawing.Size(410, 172);
            this.dgvCandidate.TabIndex = 8;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cANDIDATEBindingSource
            // 
            this.cANDIDATEBindingSource.DataMember = "CANDIDATE";
            this.cANDIDATEBindingSource.DataSource = this.dataSet1;
            // 
            // STCandidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 465);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.btnRemoveSkill);
            this.Controls.Add(this.btnAssignSkill);
            this.Controls.Add(this.dgvCandidateSkill);
            this.Controls.Add(this.dgvSkill);
            this.Controls.Add(this.dgvCandidate);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "STCandidateForm";
            this.Text = "Assign Skill to a Candidate";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANDIDATEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Button btnRemoveSkill;
        private System.Windows.Forms.Button btnAssignSkill;
        private System.Windows.Forms.DataGridView dgvCandidateSkill;
        private System.Windows.Forms.DataGridView dgvSkill;
        private System.Windows.Forms.DataGridView dgvCandidate;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cANDIDATEBindingSource;
    }
}
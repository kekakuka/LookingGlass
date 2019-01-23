namespace LookingGlass
{
    partial class STVacancyForm
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
            this.dgvVacancy = new System.Windows.Forms.DataGridView();
            this.dgvSkill = new System.Windows.Forms.DataGridView();
            this.dgvVacancySkill = new System.Windows.Forms.DataGridView();
            this.btnAssignSkill = new System.Windows.Forms.Button();
            this.btnRemoveSkill = new System.Windows.Forms.Button();
            this.lblYears = new System.Windows.Forms.Label();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancySkill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVacancy
            // 
            this.dgvVacancy.AllowUserToAddRows = false;
            this.dgvVacancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancy.Location = new System.Drawing.Point(75, 10);
            this.dgvVacancy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvVacancy.Name = "dgvVacancy";
            this.dgvVacancy.RowTemplate.Height = 27;
            this.dgvVacancy.Size = new System.Drawing.Size(410, 172);
            this.dgvVacancy.TabIndex = 0;
            // 
            // dgvSkill
            // 
            this.dgvSkill.AllowUserToAddRows = false;
            this.dgvSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkill.Location = new System.Drawing.Point(401, 218);
            this.dgvSkill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvSkill.Name = "dgvSkill";
            this.dgvSkill.RowTemplate.Height = 27;
            this.dgvSkill.Size = new System.Drawing.Size(182, 145);
            this.dgvSkill.TabIndex = 1;
            // 
            // dgvVacancySkill
            // 
            this.dgvVacancySkill.AllowUserToAddRows = false;
            this.dgvVacancySkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancySkill.Location = new System.Drawing.Point(16, 218);
            this.dgvVacancySkill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvVacancySkill.Name = "dgvVacancySkill";
            this.dgvVacancySkill.RowTemplate.Height = 27;
            this.dgvVacancySkill.Size = new System.Drawing.Size(256, 145);
            this.dgvVacancySkill.TabIndex = 2;
            // 
            // btnAssignSkill
            // 
            this.btnAssignSkill.Location = new System.Drawing.Point(292, 218);
            this.btnAssignSkill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAssignSkill.Name = "btnAssignSkill";
            this.btnAssignSkill.Size = new System.Drawing.Size(92, 36);
            this.btnAssignSkill.TabIndex = 3;
            this.btnAssignSkill.Text = "Assign Skill";
            this.btnAssignSkill.UseVisualStyleBackColor = true;
            this.btnAssignSkill.Click += new System.EventHandler(this.btnAssignSkill_Click);
            // 
            // btnRemoveSkill
            // 
            this.btnRemoveSkill.Location = new System.Drawing.Point(292, 327);
            this.btnRemoveSkill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRemoveSkill.Name = "btnRemoveSkill";
            this.btnRemoveSkill.Size = new System.Drawing.Size(92, 36);
            this.btnRemoveSkill.TabIndex = 4;
            this.btnRemoveSkill.Text = "Remove Skill";
            this.btnRemoveSkill.UseVisualStyleBackColor = true;
            this.btnRemoveSkill.Click += new System.EventHandler(this.btnRemoveSkill_Click);
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(290, 284);
            this.lblYears.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(34, 13);
            this.lblYears.TabIndex = 5;
            this.lblYears.Text = "Years";
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(330, 282);
            this.txtYears.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(55, 20);
            this.txtYears.TabIndex = 6;
            this.txtYears.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYears_KeyPress);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(446, 376);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(124, 36);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // STVacancyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 422);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.btnRemoveSkill);
            this.Controls.Add(this.btnAssignSkill);
            this.Controls.Add(this.dgvVacancySkill);
            this.Controls.Add(this.dgvSkill);
            this.Controls.Add(this.dgvVacancy);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "STVacancyForm";
            this.Text = "Assign Skill to a Vacancy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancySkill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVacancy;
        private System.Windows.Forms.DataGridView dgvSkill;
        private System.Windows.Forms.DataGridView dgvVacancySkill;
        private System.Windows.Forms.Button btnAssignSkill;
        private System.Windows.Forms.Button btnRemoveSkill;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Button btnReturn;
    }
}
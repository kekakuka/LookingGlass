namespace LookingGlass
{
    partial class CandidatesReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidatesReportForm));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPrintCandidates = new System.Windows.Forms.Button();
            this.printCandidates = new System.Drawing.Printing.PrintDocument();
            this.prvCandidates = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(342, 101);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(215, 68);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPrintCandidates
            // 
            this.btnPrintCandidates.Location = new System.Drawing.Point(59, 101);
            this.btnPrintCandidates.Name = "btnPrintCandidates";
            this.btnPrintCandidates.Size = new System.Drawing.Size(215, 68);
            this.btnPrintCandidates.TabIndex = 2;
            this.btnPrintCandidates.Text = "Print Candidates";
            this.btnPrintCandidates.UseVisualStyleBackColor = true;
            this.btnPrintCandidates.Click += new System.EventHandler(this.btnPrintCandidates_Click);
            // 
            // printCandidates
            // 
            this.printCandidates.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCandidates_PrintPage);
            // 
            // prvCandidates
            // 
            this.prvCandidates.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvCandidates.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvCandidates.ClientSize = new System.Drawing.Size(400, 300);
            this.prvCandidates.Document = this.printCandidates;
            this.prvCandidates.Enabled = true;
            this.prvCandidates.Icon = ((System.Drawing.Icon)(resources.GetObject("prvCandidates.Icon")));
            this.prvCandidates.Name = "printPreviewDialog1";
            this.prvCandidates.Visible = false;
            // 
            // CandidatesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 279);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrintCandidates);
            this.Name = "CandidatesReportForm";
            this.Text = "Candidates";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPrintCandidates;
        private System.Drawing.Printing.PrintDocument printCandidates;
        private System.Windows.Forms.PrintPreviewDialog prvCandidates;
    }
}
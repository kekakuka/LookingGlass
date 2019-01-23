using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookingGlass
{
    public partial class CandidatesReportForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfCandidatesPrinted, pagesAmountExpected;
        private DataRow[] candidatesForPrint;

        public CandidatesReportForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        //print button for printview
        private void btnPrintCandidates_Click(object sender, EventArgs e)
        {
            amountOfCandidatesPrinted = 0;
            candidatesForPrint = DM.lookingGlassDS.Tables["CANDIDATE"].Select();
            pagesAmountExpected = candidatesForPrint.Length;
            prvCandidates.ShowDialog();
        }


        private void printCandidates_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);
            //set the row in the candidate table
            DataRow drCandidate = candidatesForPrint[amountOfCandidatesPrinted];
            Brush brush = new SolidBrush(Color.Black);
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;
            //print the candidate details
            g.DrawString("Candidate ID:   " + drCandidate["CandidateID"].ToString() + "\n" + "\n"
                       + drCandidate["FirstName"] + " " + drCandidate["LastName"] + "\n"
                     + drCandidate["StreetAddress"] + "\n"
                     + drCandidate["Suburb"], headingFont, brush, leftMargin + headingLeftMargin, topMargin);
            //add lines
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            DataRow[] drCandidateSkills = drCandidate.GetChildRows(DM.dtCandidate.ChildRelations["CANDIDATE_CANDIDATESKILL"]);
            //check if the candidate has skills
            if (drCandidateSkills.Length == 0)
            {
                g.DrawString("No skills have been assigned to the Candidate yet", headingFont, brush,
leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
            }
            else
            {
                g.DrawString("Skills", headingFont, brush,
leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;
                foreach (DataRow drCandidateSkill in drCandidateSkills)
                {
                    //find the candidate skills in the candidate row by the skillID
                    int sID = Convert.ToInt32(drCandidateSkill["SkillID"]);
                    DataRow drSkill = DM.dtSkill.Rows[DM.skillView.Find(sID)];
                    //check if the years is one year
                    string year;
                    if (drCandidateSkill["Years"].ToString() == "1") { year = " Year"; }
                    else { year = " Years"; }
                    g.DrawString(drSkill["Description"].ToString() + " : ", headingFont, brush,
                   leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString( "                                                                  " + drCandidateSkill["Years"].ToString() + year, headingFont, brush,
                   leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;
                }
            }
            linesSoFarHeading++;
            DataRow[] drApplications = drCandidate.GetChildRows(DM.dtCandidate.ChildRelations["CANDIDATE_APPLICATION"]);
            //check if the candidate has applications
            if (drApplications.Length == 0)
            {
                g.DrawString("No vacancy have been assigned to the Candidate yet", headingFont, brush,
leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;
            }
            else
            {
                g.DrawString("Current Vacancy Application:", headingFont, brush,
leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;
                foreach (DataRow drApplication in drApplications)
                {
                    //find the vacancy row in vacancy table by  vacancyID which is from the application table
                    int aVacancyID = Convert.ToInt32(drApplication["VacancyID"].ToString());
                    DataRow drVacancy = DM.dtVacancy.Rows[DM.vacancyView.Find(aVacancyID)];
                    g.DrawString("Vacancy ID: " + drApplication["VacancyID"].ToString() + "     " + drVacancy["Description"].ToString(), headingFont, brush,
                   leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;
                }
                linesSoFarHeading++;
            }
            //print the next row in the candidate table by ++
            amountOfCandidatesPrinted++;
            //if the actual pages is different the expected .allow to add pages 
            if (!(amountOfCandidatesPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }
        }

        //close the form
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

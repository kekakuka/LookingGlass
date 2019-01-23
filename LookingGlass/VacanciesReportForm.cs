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
    public partial class VacanciesReportForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfVacanciesPrinted, pagesAmountExpected;
        private DataRow[] vacanciesForPrint;

        public VacanciesReportForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        //print button for printview
        private void btnPrintVacancies_Click(object sender, EventArgs e)
        {
            amountOfVacanciesPrinted = 0;
            vacanciesForPrint = DM.lookingGlassDS.Tables["VACANCY"].Select();
            pagesAmountExpected = vacanciesForPrint.Length;      //set the amount of the pages  
            prvVacancies.ShowDialog();
        }

        //close the form
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void printVacancies_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);
            //set the row in the vacancy table
            DataRow drVacancy = vacanciesForPrint[amountOfVacanciesPrinted];
            Brush brush = new SolidBrush(Color.Black);
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;
            //find the employ row by the employID
            int aEmployerID = Convert.ToInt32(drVacancy["EmployerID"].ToString());
            DataRow drEmployer = DM.dtEmployer.Rows[DM.employerView.Find(aEmployerID)];
            //print the vacancy details
            g.DrawString("Vacancy ID:              " + drVacancy["VacancyID"].ToString() + "\n"
                + "Description:              " + drVacancy["Description"] + "\n"
                + "Employer Name:      " + drEmployer["EmployerName"] + "\n"
                + "Status:                       " + drVacancy["Status"] + "\n"
                + "Salary:                       " + "NZ$" + string.Format("{0:N}", drVacancy["Salary"])
                , headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            //add the lines
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            DataRow[] drVacancySkills = drVacancy.GetChildRows(DM.dtVacancy.ChildRelations["VACANCY_VACANCYSKILL"]);
            //check if the vacancy has skill requirement
            if (drVacancySkills.Length == 0)
            {
                g.DrawString("No skills have been assigned to the Vacancy yet", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            }
            else
            {
                g.DrawString("Skills", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                //add the lines
                linesSoFarHeading++;
                linesSoFarHeading++;
                foreach (DataRow drVacancySkill in drVacancySkills)
                {
                    //find the vacancy skills in the skill row by the skillID
                    int sID = Convert.ToInt32(drVacancySkill["SkillID"]);
                    DataRow drSkill = DM.dtSkill.Rows[DM.skillView.Find(sID)];
                    //check if the years is one year
                    string year;
                    if (drVacancySkill["Years"].ToString() == "1") { year = " Year"; }
                    else { year = " Years"; }
                    //print the skill details
                    g.DrawString(drSkill["Description"].ToString() + ":" , headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString( "                                                            " + drVacancySkill["Years"].ToString() + year, headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;
                }
                linesSoFarHeading++;
            }
            //print the next row in the vacancy table by ++
            amountOfVacanciesPrinted++;
            //if the actual pages is different the expected .allow to add pages 
            if (!(amountOfVacanciesPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }
        }







    }
}

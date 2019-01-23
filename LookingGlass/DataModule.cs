using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LookingGlass
{
    public partial class DataModule : Form
    {
        //the reference for the tables
        public DataTable dtCandidate;
        public DataTable dtVacancy;
        public DataTable dtEmployer;
        public DataTable dtApplication;
        public DataTable dtSkill;
        public DataTable dtVacancySkill;
        public DataTable dtCandidateSkill;

        //the reference to the tables' view
        public DataView candidateView;
        public DataView vacancyView;
        public DataView employerView;
        public DataView applicationView;
        public DataView skillView;
        public DataView vacancySkillView;
        public DataView candidateSkillView;

        public DataModule()
        {
            InitializeComponent();
            lookingGlassDS.EnforceConstraints = false;
            //use dataAdapter to add or updata 
            daApplication.Fill(lookingGlassDS);
            daCandidate.Fill(lookingGlassDS);
            daCandidateSkill.Fill(lookingGlassDS);
            daEmployer.Fill(lookingGlassDS);
            daSkill.Fill(lookingGlassDS);
            daVacancy.Fill(lookingGlassDS);
            daVacancySkill.Fill(lookingGlassDS);
            //assign the tables to the var
            dtApplication = lookingGlassDS.Tables["Application"];
            dtCandidate = lookingGlassDS.Tables["Candidate"];
            dtCandidateSkill = lookingGlassDS.Tables["CandidateSkill"];
            dtEmployer = lookingGlassDS.Tables["Employer"];
            dtSkill = lookingGlassDS.Tables["Skill"];
            dtVacancy = lookingGlassDS.Tables["Vacancy"];
            dtVacancySkill = lookingGlassDS.Tables["VacancySkill"];
            //create the dataviews and the sorts.
            vacancyView = new DataView(dtVacancy);
            vacancyView.Sort = "VacancyID";
            vacancySkillView = new DataView(dtVacancySkill);
            vacancySkillView.Sort = "VacancyID";
            employerView = new DataView(dtEmployer);
            employerView.Sort = "EmployerID";
            skillView = new DataView(dtSkill);
            skillView.Sort = "SKILLID";
            candidateView = new DataView(dtCandidate);
            candidateView.Sort = "CandidateID";
            candidateSkillView = new DataView(dtCandidateSkill);
            candidateSkillView.Sort = "CandidateID";
            applicationView = new DataView(dtApplication);
            applicationView.Sort = "VacancyID";
            lookingGlassDS.EnforceConstraints = true;
        }

        //for updating the seven tables
        public void UpdateEmployer()
        {
            daEmployer.Update(dtEmployer);
        }

        public void UpdateCandidate()
        {
            daCandidate.Update(dtCandidate);
        }

        public void UpdateVacancy()
        {
            daVacancy.Update(dtVacancy);
        }

        public void UpdateVacancySkill()
        {
            daVacancySkill.Update(dtVacancySkill);
        }

        public void UpdateCandidateSkill()

        {
            daCandidateSkill.Update(dtCandidateSkill);
        }

        public void UpdateApplication()
        {
            daApplication.Update(dtApplication);
        }

        //automaticly create ID to stop the ID errors
        private void daEmployer_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnLookingGlass);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["EmployerID"] = newID;
            }
        }

        //automaticly create ID to stop the ID errors
        private void daVacancy_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnLookingGlass);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["VacancyID"] = newID;
            }
        }

        //automaticly create ID to stop the ID errors
        private void daCandidate_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnLookingGlass);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["CandidateID"] = newID;
            }
        }
    }

}

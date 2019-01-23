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
    public partial class ApplicationForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private DataRow[] candidatesSkills;
        private DataRow[] vacancySkills;
        private DataRow drApplication;

        public ApplicationForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }
        //bind controls
        public void BindControls()
        {
            //bind text from relation  to show description and salary
            txtDescription.DataBindings.Add("Text", DM.lookingGlassDS, "Application.APPLICATION_VACANCY.Description");
            txtSalary.DataBindings.Add("Text", DM.lookingGlassDS, "Application.APPLICATION_VACANCY.Salary");
            dgvApplication.DataSource = DM.lookingGlassDS;
            dgvApplication.DataMember = "Application";
            txtDescription.Enabled = false;
            txtSalary.Enabled = false;
            txtEmployerName.Enabled = false;
            txtCandidateFullName.Enabled = false;
            currencyManager = (CurrencyManager)this.BindingContext[DM.lookingGlassDS, "APPLICATION"];
        }

        //show the candidate full name and employername
        private void ShowInformation()
        {
            
                //use candidate ID find the name of the candidate and show the full name of the candidate
                int canID = Convert.ToInt32(dgvApplication["CandidateID", currencyManager.Position].Value);
                DataRow drCandidate = DM.dtCandidate.Rows[DM.candidateView.Find(canID)];
                txtCandidateFullName.Text = drCandidate["FirstName"].ToString() + " " + drCandidate["LastName"].ToString();
                //use the vacancyID find the employID in the vacancy table and then find the employe rname in the employ table by employID
                int vID = Convert.ToInt32(dgvApplication["VacancyID", currencyManager.Position].Value);
                DataRow drVacancy = DM.dtVacancy.Rows[DM.vacancyView.Find(vID)];
                int emID = Convert.ToInt32(drVacancy["EmployerID"].ToString());
                DataRow drEmployer = DM.dtEmployer.Rows[DM.employerView.Find(emID)];
                txtEmployerName.Text = drEmployer["EmployerName"].ToString();
          
        }

        //bind the candidate information to the combox
        private void LoadCandidateName()
        {
            cboCandidateName.DataSource = DM.lookingGlassDS;
            cboCandidateName.DisplayMember = "Candidate.FirstName";
            cboCandidateName.ValueMember = "Candidate.FirstName";
            cboCandidateID.DataSource = DM.lookingGlassDS;
            cboCandidateID.DisplayMember = "Candidate.CandidateID";
            cboCandidateID.ValueMember = "Candidate.CandidateID";
        }

        //bind the vacancy information to the combox
        private void LoadVacancyDescription()
        {
            cboVacancyDescription.DataSource = DM.lookingGlassDS;
            cboVacancyDescription.DisplayMember = "Vacancy.Description";
            cboVacancyDescription.ValueMember = "Vacancy.Description";
            cboVacancyID.DataSource = DM.lookingGlassDS;
            cboVacancyID.DisplayMember = "Vacancy.VacancyID";
            cboVacancyID.ValueMember = "Vacancy.VacancyID";
        }

        //close this form
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //add button to show add panel and load combox
        private void btnAddA_Click(object sender, EventArgs e)
        {
            dgvApplication.Enabled = false;
            btnAdd.Enabled = false;
            dgvApplication.Visible = false;
            btnDelete.Enabled = false;
            btnReturn.Enabled = false;
            pnlAddApplication.Show();
            LoadCandidateName();
            LoadVacancyDescription();
        }

        //cancel the add panel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvApplication.Visible = true;
            dgvApplication.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnReturn.Enabled = true;
            pnlAddApplication.Hide();
        }

        //add an application
        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            DataRow newApplicationRow = DM.dtApplication.NewRow();

            int vID = Convert.ToInt32(cboVacancyID.Text);
            DataRow drVacancy = DM.dtVacancy.Rows[DM.vacancyView.Find(vID)];
            string status = drVacancy["Status"].ToString();
            //if the vacancy is filled stop the application
            if (status == "filled")
            {
                MessageBox.Show("Candidates can only apply to current vacancies");
                return;
            }
            else
            {
                //select the vacancyskill and candidateskill table
                candidatesSkills = DM.lookingGlassDS.Tables["CANDIDATESKILL"].Select();
                vacancySkills = DM.lookingGlassDS.Tables["VACANCYSKILL"].Select();
                //set a bool var to check the compare result
                Boolean ok;
                for (int i = 0; i < vacancySkills.Length; i++)
                {
                    //if the input vacancyID can find in the vacancyskill table check other information.
                    //if cannot find then directly add the application
                    if (vacancySkills[i]["VacancyID"].ToString() == cboVacancyID.Text)
                    {
                        //set the ok to false to stop the application
                        ok = false;
                        for (int j = 0; j < candidatesSkills.Length; j++)
                        {
                            //if the input candidateID can find in the candidateskill table check other information.
                            //if cannot find and ok=false so stop the application
                            if (candidatesSkills[j]["CandidateID"].ToString() == cboCandidateID.Text)
                            {
                                //if the candidate has skills for the vacancy then compare the years
                                //if dosen't have and ok=false so stop the application
                                if (vacancySkills[i]["SkillID"].ToString() == candidatesSkills[j]["SkillID"].ToString())
                                {
                                    //if the candidateskill years overweigh the vacancy's ok=true ,and go on the for loop
                                    //if less than the vacancy.ok=false and break the loop .stop the application
                                    if (Convert.ToInt32(vacancySkills[i]["Years"].ToString()) <= Convert.ToInt32(candidatesSkills[j]["Years"].ToString()))
                                    {
                                        ok = true;
                                    }
                                    else
                                    {
                                        ok = false;
                                        break;
                                    }
                                }
                            }
                        }
                        if (ok == false)
                        {
                            MessageBox.Show("The candidates does not have the experience to apply for the vacancy");
                            return;
                        }
                    }
                }
                //if ok = ture ,add the new application
                //use "try catch" to stop the same assign
                try
                {
                    newApplicationRow["VacancyID"] = Convert.ToInt32(cboVacancyID.Text);
                    newApplicationRow["CandidateID"] = Convert.ToInt32(cboCandidateID.Text);
                    DM.dtApplication.Rows.Add(newApplicationRow);
                    DM.UpdateApplication();
                    MessageBox.Show("Application added successfully");
                    return;
                }
                catch (ConstraintException)
                {
                    MessageBox.Show("This vacancy has already been allocated to this candidate.", "Error");
                }
            }
        }

        //delete current application
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) ==
                                DialogResult.OK)
            {
                drApplication = DM.dtApplication.Rows[currencyManager.Position];
                drApplication.Delete();
                DM.UpdateApplication();
                return;
            }
            else
            {
                return;
            }
        }

        //show the information when the selection of the dgv changed.
        private void dgvApplication_SelectionChanged(object sender, EventArgs e)
        {
            ShowInformation();
        }
        //stop the currencyManager.Position=-1;
        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            currencyManager.Position = 0;
        }
    }
}


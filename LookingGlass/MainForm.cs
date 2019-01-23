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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private DataModule DM;                                //the reference to the form that holds the data components
        private ApplicationForm frmApplication;               //the reference to the Application form                 
        private CandidateForm frmCandidate;                   //the reference to the Candidate Form
        private CandidatesReportForm frmCandidates;           //the reference to the Candidates Form
        private EmployerForm frmEmployer;                     //the reference to the Employer Form
        private STCandidateForm frmSTCandidate;               //the reference to the STCandidate Form 
        private STVacancyForm frmSTVacancy;                   //the reference to the STVacancy Form 
        private VacanciesReportForm frmVacancies;             //the reference to the Vacancies Form 
        private VacancyForm frmVacancy;                       //the reference to the Vacancy Form 

        //create the data module and load the dataset
        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
        }

        //close the mainform
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //create the application form
        private void btnApplication_Click(object sender, EventArgs e)
        {
            if (frmApplication == null)
            {
                frmApplication = new ApplicationForm(DM, this);
            }
            frmApplication.ShowDialog();
        }

        //create the employer form
        private void btnEmployer_Click(object sender, EventArgs e)
        {
            if (frmEmployer == null)
            {
                frmEmployer = new EmployerForm(DM, this);
            }
            frmEmployer.ShowDialog();
        }

        //create the candidate form
        private void btnCandidate_Click(object sender, EventArgs e)
        {
            if (frmCandidate == null)
            {
                frmCandidate = new CandidateForm(DM, this);
            }
            frmCandidate.ShowDialog();
        }

        //create the vacancy form
        private void btnVacancy_Click(object sender, EventArgs e)
        {

            if (frmVacancy == null)
            {
                frmVacancy = new VacancyForm(DM, this);
            }
            frmVacancy.ShowDialog();
        }

        //create the vacancies report form
        private void btnVacancies_Click(object sender, EventArgs e)
        {
            if (frmVacancies == null)
            {
                frmVacancies = new VacanciesReportForm(DM, this);
            }
            frmVacancies.ShowDialog();
        }

        //the form for assigning skill to vacancy
        private void btnSTVancancy_Click(object sender, EventArgs e)
        {
            if (frmSTVacancy == null)
            {
                frmSTVacancy = new STVacancyForm(DM, this);
            }
            frmSTVacancy.ShowDialog();
        }

        //create the candidates report form
        private void btnCandidates_Click(object sender, EventArgs e)
        {
            if (frmCandidates == null)
            {
                frmCandidates = new CandidatesReportForm(DM, this);
            }
            frmCandidates.ShowDialog();
        }

        //the form for assigning skill to candidate
        private void btnSTCandidate_Click(object sender, EventArgs e)
        {
            if (frmSTCandidate == null)
            {
                frmSTCandidate = new STCandidateForm(DM, this);
            }
            frmSTCandidate.ShowDialog();
        }
    }

}

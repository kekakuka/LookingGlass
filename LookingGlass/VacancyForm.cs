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
    public partial class VacancyForm : Form
    {
        private DataRow[] vacancies;
        private DataRow[] vacancyskills;
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public VacancyForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        //bind controls
        public void BindControls()
        {
            txtVacancyID.DataBindings.Add("Text", DM.lookingGlassDS, "Vacancy.VacancyID");
            txtDescription.DataBindings.Add("Text", DM.lookingGlassDS, "Vacancy.Description");
            txtStatus.DataBindings.Add("Text", DM.lookingGlassDS, "Vacancy.Status");
            txtSalary.DataBindings.Add("Text", DM.lookingGlassDS, "Vacancy.Salary");
            txtEmployerID.DataBindings.Add("Text", DM.lookingGlassDS, "Vacancy.EmployerID");
            //bind the employ name from the relations
            txtEmployerName.DataBindings.Add("Text", DM.lookingGlassDS, "Vacancy.Vacancy_Employer.EmployerName");
            txtVacancyID.Enabled = false;
            txtDescription.Enabled = false;
            txtStatus.Enabled = false;
            txtSalary.Enabled = false;
            txtEmployerName.Enabled = false;
            txtEmployerID.Enabled = false;
            lstBoxVacancy.DataSource = DM.lookingGlassDS;
            lstBoxVacancy.DisplayMember = "Vacancy.Description";
            lstBoxVacancy.ValueMember = "Vacancy.Description";
            currencyManager = (CurrencyManager)this.BindingContext[DM.lookingGlassDS, "VACANCY"];
        }

        //load employ ID name in the combox
        private void LoadEmployerName()
        {
            cboAddName.DataSource = DM.lookingGlassDS;
            cboAddName.DisplayMember = "Employer.EmployerName";
            cboAddName.ValueMember = "Employer.EmployerName";
            cboAddID.DataSource = DM.lookingGlassDS;
            cboAddID.DisplayMember = "Employer.EmployerID";
            cboAddID.ValueMember = "Employer.EmployerID";
        }

        //previous and next button
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        //close this form
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //delete the current row
        private void btnDeleteVacancy_Click(object sender, EventArgs e)
        {
            DataRow deleteVacancyRow = DM.dtVacancy.Rows[currencyManager.Position];
            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) ==
                                DialogResult.OK)
            {
                //assign the application table to an array(vacancies)
                vacancies = DM.lookingGlassDS.Tables["APPLICATION"].Select();
                //use for loop to compare input ID with the vacancyID in the application table
                for (int i = 0; i < vacancies.Length; i++)
                {
                    DataRow drVacancy = vacancies[i];
                    int vacID = Convert.ToInt32(txtVacancyID.Text);
                    int vacID2 = Convert.ToInt32(drVacancy["VacancyID"]);
                    //if find the same id ,return
                    if (vacID == vacID2)
                    {
                        MessageBox.Show("You may only delete a vacancy that has no applications");
                        return;
                    }
                }
                //assign the vacancyskills table to an array(vacancyskill)         
                vacancyskills = DM.lookingGlassDS.Tables["VACANCYSKILL"].Select();
                //use for loop to compare input ID with the vacancyID in the vacancyskill table 
                for (int i = 0; i < vacancyskills.Length; i++)
                {
                    DataRow drVacancySkill = vacancyskills[i];
                    int vacID = Convert.ToInt32(txtVacancyID.Text);
                    int vacID2 = Convert.ToInt32(drVacancySkill["VacancyID"]);
                    //if find the same id delete the vacancy information from the vacancyskill table
                    if (vacID == vacID2)
                    {
                        drVacancySkill.Delete();
                        DM.UpdateVacancySkill();
                    }
                }
                deleteVacancyRow.Delete();
                MessageBox.Show("Vacancy deleted successfully");
                DM.UpdateVacancy();
                return;
            }
            else
            {
                return;
            }
        }

        //add button to show the add panel
        private void btnAddVacancy_Click(object sender, EventArgs e)
        {
            lstBoxVacancy.Visible = false;
            btnDeleteVacancy.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateVacancy.Enabled = false;
            btnAddVacancy.Enabled = false;
            btnReturn.Enabled = false;
            lblDescription.Visible = false;
            txtDescription.Visible = false;
            btnMark.Enabled = false;
            LoadEmployerName();
            pnlAddVacancy.Show();
            txtpnlAddVacancyID.Enabled = false;
        }

        //save the new row
        private void btnSaveVacancy_Click(object sender, EventArgs e)
        {
            DataRow newVacancyRow = DM.dtVacancy.NewRow();
            //stop the empty text to stop error
            if ((txtpnlAddDescription.Text == "") || (txtpnlAddSalary.Text == "") ||
                (cboAddID.Text == "") || (cboAddName.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields");
                return;
            }
            else
            {
                //the salary should between 30000-200000
                if ((Convert.ToInt32(txtpnlAddSalary.Text) < 30000) || (Convert.ToInt32(txtpnlAddSalary.Text)) > 200000)
                {
                    MessageBox.Show("Salary should between 30000 and 200000");
                    return;
                }
                //add a new row in the table
                else
                {
                    newVacancyRow["Description"] = txtpnlAddDescription.Text;
                    newVacancyRow["Salary"] = Convert.ToInt32(txtpnlAddSalary.Text);
                    newVacancyRow["EmployerID"] = Convert.ToInt32(cboAddID.Text);
                    newVacancyRow["Status"] = "current";
                    DM.dtVacancy.Rows.Add(newVacancyRow);
                    DM.UpdateVacancy();
                    MessageBox.Show("Vacancy added successfully");
                    return;
                }
            }
        }

        //cancel the add panel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            lstBoxVacancy.Visible = true;
            btnDeleteVacancy.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateVacancy.Enabled = true;
            btnAddVacancy.Enabled = true;
            btnReturn.Enabled = true;
            lblDescription.Visible = true;
            txtDescription.Visible = true;
            pnlAddVacancy.Hide();
            btnMark.Enabled = true;
        }

        //update button to show the update panel
        private void btnUpdateVacancy_Click(object sender, EventArgs e)
        {
            lstBoxVacancy.Visible = false;
            btnDeleteVacancy.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateVacancy.Enabled = false;
            btnAddVacancy.Enabled = false;
            btnReturn.Enabled = false;
            lblDescription.Visible = false;
            txtDescription.Visible = false;
            pnlUpVacancy.Show();
            btnMark.Enabled = false;
            txtpnlUpVacancyID.Enabled = false;
            txtpnlUpStatus.Enabled = false;
            txtpnlUpEmployerName.Enabled = false;
            txtpnlUpVacancyID.Text = txtVacancyID.Text;
            txtpnlUpDescription.Text = txtDescription.Text;
            txtpnlUpStatus.Text = txtStatus.Text;
            txtpnlUpSalary.Text = txtSalary.Text;
            txtpnlUpEmployerName.Text = txtEmployerName.Text;
        }

        //cancel the update panel
        private void btnCancel1_Click(object sender, EventArgs e)
        {
            lstBoxVacancy.Visible = true;
            btnDeleteVacancy.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateVacancy.Enabled = true;
            btnAddVacancy.Enabled = true;
            btnReturn.Enabled = true;
            lblDescription.Visible = true;
            txtDescription.Visible = true;
            pnlUpVacancy.Hide();
            btnMark.Enabled = true;
        }

        //save the update
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateVacancyRow = DM.dtVacancy.Rows[currencyManager.Position];
            //stop the empty text to stop error
            if ((txtpnlUpDescription.Text == "") || (txtpnlUpSalary.Text == ""))
            {
                MessageBox.Show("You must enter a value for each text fields ");
                return;
            }
            else
            {
                //the salary should between 30000-200000
                if ((Convert.ToInt32(txtpnlUpSalary.Text) < 30000) || (Convert.ToInt32(txtpnlUpSalary.Text)) > 200000)

                {
                    MessageBox.Show("Salary should between 30000 and 200000");
                    return;
                }
                //update current row
                else
                {
                    updateVacancyRow["Description"] = txtpnlUpDescription.Text;
                    updateVacancyRow["Salary"] = Convert.ToInt32(txtpnlUpSalary.Text);
                    currencyManager.EndCurrentEdit();
                    DM.UpdateVacancy();
                    MessageBox.Show("Vacancy updated successfully", "Success");
                }
            }
        }

        //mark the vacancy as filled
        private void btnMark_Click(object sender, EventArgs e)
        {
            DataRow updateVacancyRow = DM.dtVacancy.Rows[currencyManager.Position];
            string oldStatus = updateVacancyRow["Status"].ToString();
            //cannot fill filled vacancy
            if (oldStatus == "filled")
            {
                MessageBox.Show("Vacancy is already filled");
            }
            else
            {
                updateVacancyRow["Status"] = "filled";
                currencyManager.EndCurrentEdit();
                DM.UpdateVacancy();
                MessageBox.Show("Vacancy marked as filled");
                //assign the application table to an array(vacancies)                          
                vacancies = DM.lookingGlassDS.Tables["APPLICATION"].Select();
                //use for loop to compare input ID with the vacancyID in the application table
                for (int i = 0; i < vacancies.Length; i++)
                {
                    DataRow drVacancy = vacancies[i];
                    int vacID = Convert.ToInt32(txtVacancyID.Text);
                    int vacID2 = Convert.ToInt32(drVacancy["VacancyID"]);
                    //if fine the  same ID,delete the application row
                    if (vacID == vacID2)
                    {
                        drVacancy.Delete();
                        DM.UpdateApplication();
                    }
                }
            }
        }

        //only allow input number and backspace in the salary text
        private void txtpnlUpSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //only allow input number and backspace in the salary text
        private void txtpnlAddSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}




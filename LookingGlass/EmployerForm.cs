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
    public partial class EmployerForm : Form
    {
        private DataModule DM;                  
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private DataRow[] vacancies;

        public EmployerForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        //bind controls 
        public void BindControls()
        {
            txtEmployerID.DataBindings.Add("Text", DM.lookingGlassDS, "Employer.EmployerID");
            txtEmployerName.DataBindings.Add("Text", DM.lookingGlassDS, "Employer.EmployerName");
            txtStreetAddress.DataBindings.Add("Text", DM.lookingGlassDS, "Employer.Street Address");
            txtSuburb.DataBindings.Add("Text", DM.lookingGlassDS, "Employer.Suburb");
            txtPhoneNumber.DataBindings.Add("Text", DM.lookingGlassDS, "Employer.PhoneNumber");
            txtEmployerID.Enabled = false;
            txtEmployerName.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtSuburb.Enabled = false;
            lstBoxEmployer.DataSource = DM.lookingGlassDS;
            lstBoxEmployer.DisplayMember = "Employer.EmployerName";
            lstBoxEmployer.ValueMember = "Employer.EmployerName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.lookingGlassDS, "EMPLOYER"];
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

        //close the form
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //add button for showing the add panel
        private void btnAddEmployer_Click(object sender, EventArgs e)
        {
            lstBoxEmployer.Visible = false;
            btnDeleteEmployer.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateEmployer.Enabled = false;
            btnAddEmployer.Enabled = false;
            pnlAddEmployer.Show();
            btnReturn.Enabled = false;
        }

        //cancel the add panel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddEmployer.Hide();
            lstBoxEmployer.Enabled = true;
            lstBoxEmployer.Visible = true;
            btnDeleteEmployer.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateEmployer.Enabled = true;
            btnAddEmployer.Enabled = true;
            btnReturn.Enabled = true;
        }

        //save the new add
        private void btnSaveEmployer_Click(object sender, EventArgs e)
        {
            DataRow newEmployerRow = DM.dtEmployer.NewRow();
            //If any of the text areas are empty then do not write data and return
            if ((txtpnlAddPhoneNumber.Text == "") || (txtpnlAddEmployerName.Text == "") ||
                (txtpnlAddStreetAddress.Text == "") || (txtpnlAddSuburb.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields");
                return;
            }
            //Add the new row to the Table
            else
            {
                newEmployerRow["PhoneNumber"] = txtpnlAddPhoneNumber.Text;
                newEmployerRow["EmployerName"] = txtpnlAddEmployerName.Text;
                newEmployerRow["Street Address"] = txtpnlAddStreetAddress.Text;
                newEmployerRow["Suburb"] = txtpnlAddSuburb.Text;
                DM.dtEmployer.Rows.Add(newEmployerRow);
                DM.UpdateEmployer();
                MessageBox.Show("Employer added successfully", "Success");
                return;
            }
        }

        //update button for showing the update panel
        private void btnUpdateEmployer_Click(object sender, EventArgs e)
        {
            lstBoxEmployer.Visible = false;
            btnDeleteEmployer.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateEmployer.Enabled = false;
            btnAddEmployer.Enabled = false;
            btnReturn.Enabled = false;
            pnlUpEmployer.Show();
            txtpnlUpEmployerID.Enabled = false;
            //show the previous text
            txtpnlUpEmployerID.Text = txtEmployerID.Text;
            txtpnlUpPhoneNumber.Text = txtPhoneNumber.Text;
            txtpnlUpEmployerName.Text = txtEmployerName.Text;
            txtpnlUpStreetAddress.Text = txtStreetAddress.Text;
            txtpnlUpSuburb.Text = txtSuburb.Text;
        }

        //save the update
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateEmployerRow = DM.dtEmployer.Rows[currencyManager.Position];
            //If any of the text areas are empty then do not write data and return
            if ((txtpnlUpPhoneNumber.Text == "") || (txtpnlUpEmployerName.Text == "") ||
                 (txtpnlUpStreetAddress.Text == "") || (txtpnlUpSuburb.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields");
                return;
            }
            //update the current row to the Table
            else
            {
                updateEmployerRow["PhoneNumber"] = txtpnlUpPhoneNumber.Text;
                updateEmployerRow["EmployerName"] = txtpnlUpEmployerName.Text;
                updateEmployerRow["Street Address"] = txtpnlUpStreetAddress.Text;
                updateEmployerRow["Suburb"] = txtpnlUpSuburb.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateEmployer();
                MessageBox.Show("Employer updated successfully", "Success");
            }
        }

        //cancel the update panel
        private void btnCancel1_Click(object sender, EventArgs e)
        {
            pnlUpEmployer.Hide();
            lstBoxEmployer.Enabled = true;
            lstBoxEmployer.Visible = true;
            btnDeleteEmployer.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateEmployer.Enabled = true;
            btnAddEmployer.Enabled = true;
            btnReturn.Enabled = true;
        }

        //delete the current row
        private void btnDeleteEmployer_Click(object sender, EventArgs e)
        {
            DataRow deleteEmployerRow = DM.dtEmployer.Rows[currencyManager.Position];
            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) ==
                                DialogResult.OK)
            {
                //assign the vacancy table to an array(vacancies)
                vacancies = DM.lookingGlassDS.Tables["VACANCY"].Select();
                //use for loop to compare input ID with the employID in the vacancy table
                for (int i = 0; i < vacancies.Length; i++)
                {
                    DataRow drVacancy = vacancies[i];
                    int emID = Convert.ToInt32(txtEmployerID.Text);
                    int emID2 = Convert.ToInt32(drVacancy["EmployerID"]);
                    if (emID == emID2)
                    {
                        MessageBox.Show("You may only delete employers who have no vacancies");
                        return;
                    }
                }
                //cannot find the same ID  then delete the current row
                deleteEmployerRow.Delete();
                MessageBox.Show("Employer deleted successfully");
                DM.UpdateEmployer();
                return;
            }
            else
            {
                return;
            }
        }
    }
}






















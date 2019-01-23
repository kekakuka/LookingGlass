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
    public partial class CandidateForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private DataRow[] candidates;
        private DataRow[] candidateskills;

        public CandidateForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        //bind controls 
        public void BindControls()
        {
            txtCandidateID.DataBindings.Add("Text", DM.lookingGlassDS, "Candidate.CandidateID");
            txtFirstName.DataBindings.Add("Text", DM.lookingGlassDS, "Candidate.FirstName");
            txtLastName.DataBindings.Add("Text", DM.lookingGlassDS, "Candidate.LastName");
            txtPhoneNumber.DataBindings.Add("Text", DM.lookingGlassDS, "Candidate.PhoneNumber");
            txtStreetAddress.DataBindings.Add("Text", DM.lookingGlassDS, "Candidate.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DM.lookingGlassDS, "Candidate.Suburb");
            txtCandidateID.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtSuburb.Enabled = false;
            lstBoxCandidate.DataSource = DM.lookingGlassDS;
            lstBoxCandidate.DisplayMember = "Candidate.LastName";
            lstBoxCandidate.ValueMember = "Candidate.LastName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.lookingGlassDS, "CANDIDATE"];
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
        private void btnDeleteCandidate_Click(object sender, EventArgs e)
        {
            DataRow deleteCandidateRow = DM.dtCandidate.Rows[currencyManager.Position];
            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //assign the application table to an array(candidates)
                candidates = DM.lookingGlassDS.Tables["APPLICATION"].Select();
                //use for loop to compare input ID with the candidateID in the application table
                for (int i = 0; i < candidates.Length; i++)
                {
                    DataRow drCandidate = candidates[i];
                    int canID = Convert.ToInt32(txtCandidateID.Text);
                    int canID2 = Convert.ToInt32(drCandidate["CandidateID"]);
                    //if find the same id ,return
                    if (canID == canID2)
                    {
                        MessageBox.Show("You may only delete candidates who have no applications");
                        return;
                    }
                }
                //assign the candidateskill table to an array(candidateskills)
                candidateskills = DM.lookingGlassDS.Tables["CANDIDATESKILL"].Select();
                //use for loop to compare input ID with the candidateID in the candidateskill table 
                for (int i = 0; i < candidateskills.Length; i++)
                {
                    DataRow drCandidateSkill = candidateskills[i];
                    int canID = Convert.ToInt32(txtCandidateID.Text);
                    int canID2 = Convert.ToInt32(drCandidateSkill["CandidateID"]);
                    //if find the same id delete the candidate information from the candidateskill table
                    if (canID == canID2)
                    {
                        drCandidateSkill.Delete();
                        DM.UpdateCandidateSkill();
                    }
                }
                deleteCandidateRow.Delete();
                MessageBox.Show("Candidate deleted successfully.");
                DM.UpdateCandidate();
                return;
            }
            else
            {
                return;
            }
        }

        //add button to show the add panel
        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            lstBoxCandidate.Visible = false;
            btnDeleteCandidate.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateCandidate.Enabled = false;
            btnAddCandidate.Enabled = false;
            btnReturn.Enabled = false;
            lblFirstName.Visible = false;
            txtFirstName.Visible = false;
            pnlAddCandidate.Show();
        }

        //save the new row
        private void btnSaveCandidate_Click(object sender, EventArgs e)
        {
            DataRow newCandidateRow = DM.dtCandidate.NewRow();
            //stop the empty text to stop error
            if ((txtpnlAddFirstName.Text == "") || (txtpnlAddPhoneNumber.Text == "") || (txtpnlAddLastName.Text == "") ||
                (txtpnlAddStreetAddress.Text == "") || (txtpnlAddSuburb.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields");
                return;
            }
            //add a new row in the table
            else
            {
                newCandidateRow["FirstName"] = txtpnlAddFirstName.Text;
                newCandidateRow["PhoneNumber"] = txtpnlAddPhoneNumber.Text;
                newCandidateRow["LastName"] = txtpnlAddLastName.Text;
                newCandidateRow["StreetAddress"] = txtpnlAddStreetAddress.Text;
                newCandidateRow["Suburb"] = txtpnlAddSuburb.Text;
                DM.dtCandidate.Rows.Add(newCandidateRow);
                DM.UpdateCandidate();
                MessageBox.Show("Candidate added successfully");
                return;
            }
        }

        //cancel the add panel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddCandidate.Hide();
            lstBoxCandidate.Visible = true;
            lstBoxCandidate.Enabled = true;
            btnDeleteCandidate.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateCandidate.Enabled = true;
            btnAddCandidate.Enabled = true;
            lblFirstName.Visible = true;
            txtFirstName.Visible = true;
            btnReturn.Enabled = true;
        }

        //update button to show the update panel
        private void btnUpdateCandidate_Click(object sender, EventArgs e)
        {
            lstBoxCandidate.Visible = false;
            btnDeleteCandidate.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateCandidate.Enabled = false;
            btnReturn.Enabled = false;
            btnAddCandidate.Enabled = false;
            lblFirstName.Visible = false;
            txtFirstName.Visible = false;
            pnlUpCandidate.Show();
            txtpnlUpCandidateID.Enabled = false;
            txtpnlUpCandidateID.Text = txtCandidateID.Text;
            txtpnlUpFirstName.Text = txtFirstName.Text;
            txtpnlUpLastName.Text = txtLastName.Text;
            txtpnlUpPhoneNumber.Text = txtPhoneNumber.Text;
            txtpnlUpStreetAddress.Text = txtStreetAddress.Text;
            txtpnlUpSuburb.Text = txtSuburb.Text;
        }

        //save the update
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateCandidateRow = DM.dtCandidate.Rows[currencyManager.Position];
            //stop the empty text to stop error
            if ((txtpnlUpFirstName.Text == "") || (txtpnlUpPhoneNumber.Text == "") || (txtpnlUpLastName.Text == "") ||
                (txtpnlUpStreetAddress.Text == "") || (txtpnlUpSuburb.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields");
                return;
            }
            //update current row
            else
            {
                updateCandidateRow["FirstName"] = txtpnlUpFirstName.Text;
                updateCandidateRow["PhoneNumber"] = txtpnlUpPhoneNumber.Text;
                updateCandidateRow["LastName"] = txtpnlUpLastName.Text;
                updateCandidateRow["StreetAddress"] = txtpnlUpStreetAddress.Text;
                updateCandidateRow["Suburb"] = txtpnlUpSuburb.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateCandidate();
                MessageBox.Show("Candidate updated successfully");
            }
        }

        //cancel the update panel
        private void btnCancel1_Click(object sender, EventArgs e)
        {
            pnlUpCandidate.Hide();
            lstBoxCandidate.Visible = true;
            lstBoxCandidate.Enabled = true;
            btnDeleteCandidate.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateCandidate.Enabled = true;
            btnAddCandidate.Enabled = true;
            lblFirstName.Visible = true;
            txtFirstName.Visible = true;
            btnReturn.Enabled = true;
        }

       
    }
}

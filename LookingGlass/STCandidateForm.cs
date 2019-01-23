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
    public partial class STCandidateForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmSkill;
        private CurrencyManager cmCandidate;
        private CurrencyManager cmCCS;


        public STCandidateForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmSkill = (CurrencyManager)this.BindingContext[DM.lookingGlassDS, "Skill"];
            cmCandidate = (CurrencyManager)this.BindingContext[DM.lookingGlassDS, "Candidate"];
            cmCCS = (CurrencyManager)this.BindingContext[DM.lookingGlassDS, "Candidate.Candidate_CandidateSkill"];
            BindControls();
        }

        //bind the three dgvs
        public void BindControls()
        {
            dgvSkill.DataSource = DM.lookingGlassDS;
            dgvSkill.DataMember = "Skill";
            dgvCandidate.DataSource = DM.lookingGlassDS;
            dgvCandidate.DataMember = "Candidate";
            dgvCandidateSkill.DataSource = DM.lookingGlassDS;
            dgvCandidateSkill.DataMember = "Candidate.Candidate_CandidateSkill";
        }

        //close this form
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //assign skill to candidate
        private void btnAssignSkill_Click(object sender, EventArgs e)
        {
            //use "try catch" to stop the same assign
            try
            {
                //stop the empty text or more than 30 in the year text area
                if ((txtYears.Text == "") || (Convert.ToInt32(txtYears.Text) > 30))
                {
                    MessageBox.Show("Please set the right value of years(1-30)");
                }
                //assign skill to vacancy
                else
                {
                    DataRow newCandidateSkill = DM.dtCandidateSkill.NewRow();
                    newCandidateSkill["Years"] = txtYears.Text;
                    newCandidateSkill["CandidateID"] = dgvCandidate["CandidateID", cmCandidate.Position].Value;
                    newCandidateSkill["SkillID"] = dgvSkill["SkillID", cmSkill.Position].Value;


                    DM.lookingGlassDS.Tables["CandidateSkill"].Rows.Add(newCandidateSkill);
                    DM.UpdateCandidateSkill();
                    MessageBox.Show("Skill assigned successfully");
                }
            }
            catch (ConstraintException) { MessageBox.Show("Skill has already been assigned to this Candidate."); }
        }

        //remove skill from candidate
        private void btnRemoveSkill_Click(object sender, EventArgs e)
        {
            //the current ID in candidate and skill
            string CandidateID = DM.dtCandidate.Rows[cmCandidate.Position]["CandidateID"].ToString();
            string SkillID = dgvCandidateSkill.Rows[cmCCS.Position].Cells[1].Value.ToString();
            int row = 0;
            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) ==
                             DialogResult.OK)
            {
                //use for loop find the current candidateID and skillID in the candidateskill table
                for (int i = 0; i < DM.dtCandidateSkill.Rows.Count; i++)
                {
                    //the ID in candidateskill table
                    string cID = DM.dtCandidateSkill.Rows[i]["CandidateID"].ToString();
                    string sID = DM.dtCandidateSkill.Rows[i]["SkillID"].ToString();
                    //if find both the same  ID, record the row
                    if (CandidateID == cID && SkillID == sID)
                    {
                        row = i;
                    }
                }
                DataRow dr = DM.lookingGlassDS.Tables["CandidateSkill"].Rows[row];
                //delete the row have both same ID.
                dr.Delete();
                DM.UpdateCandidateSkill();
                MessageBox.Show("Skill removed successfully.");
            }
            else
            {
                return;
            }
        }

        //only allow to input number and backspace in the year text
        private void txtYears_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

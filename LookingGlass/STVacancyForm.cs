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
    public partial class STVacancyForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmSkill;
        private CurrencyManager cmVacancy;
        private CurrencyManager cmVVS;

        public STVacancyForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmSkill = (CurrencyManager)this.BindingContext[DM.lookingGlassDS, "Skill"];
            cmVacancy = (CurrencyManager)this.BindingContext[DM.lookingGlassDS, "Vacancy"];
            cmVVS = (CurrencyManager)this.BindingContext[DM.lookingGlassDS, "Vacancy.Vacancy_VacancySkill"];
            BindControls();
        }

        //bind the three dgvs
        public void BindControls()
        {
            dgvSkill.DataSource = DM.lookingGlassDS;
            dgvSkill.DataMember = "Skill";
            dgvVacancy.DataSource = DM.lookingGlassDS;
            dgvVacancy.DataMember = "Vacancy";
            dgvVacancySkill.DataSource = DM.lookingGlassDS;
            dgvVacancySkill.DataMember = "Vacancy.Vacancy_VacancySkill"; //bind from the relation
        }
      
        //close this form
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        //assign skill to vacancy
        private void btnAssignSkill_Click(object sender, EventArgs e)
        {
            //use "try catch" to stop the same assign
            try
            {
                //stop the empty text or more than 10 in the year text area
                if ((txtYears.Text == "") || (Convert.ToInt32(txtYears.Text) > 10))
                {
                    MessageBox.Show("Please set the right value of years(1-10)");
                }
                //assign skill to vacancy
                else
                {
                    DataRow newVacancySkill = DM.dtVacancySkill.NewRow();
                    newVacancySkill["Years"] = txtYears.Text;
                    newVacancySkill["VacancyID"] = dgvVacancy["VacancyID", cmVacancy.Position].Value;
                    newVacancySkill["SkillID"] = dgvSkill["SkillID", cmSkill.Position].Value;
                    DM.lookingGlassDS.Tables["VacancySkill"].Rows.Add(newVacancySkill);
                    DM.UpdateVacancySkill();
                    MessageBox.Show("Skill assigned successfully");
                }
            }
            catch (ConstraintException)
            {
                MessageBox.Show("This skill has already been assigned to this vacancy.");
            }
        }

        //remove skill from vacancy
        private void btnRemoveSkill_Click(object sender, EventArgs e)
        {
            //the current ID in vacancy and skill
            string VacancyID = DM.dtVacancy.Rows[cmVacancy.Position]["VacancyID"].ToString();
            string SkillID = dgvVacancySkill.Rows[cmVVS.Position].Cells[1].Value.ToString();
            int row = 0;
            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) ==
                              DialogResult.OK)
            {
                //use for loop find the current vacancyID and skillID in the vacancyskill table
                for (int i = 0; i < DM.dtVacancySkill.Rows.Count; i++)

                {
                    //the ID in vacancyskill table
                    string vID = DM.dtVacancySkill.Rows[i]["VacancyID"].ToString();
                    string sID = DM.dtVacancySkill.Rows[i]["SkillID"].ToString();
                    //if find both the same  ID ,record the row
                    if (VacancyID == vID && SkillID == sID)
                    {
                        row = i;

                    }
                }
                DataRow dr = DM.lookingGlassDS.Tables["VacancySkill"].Rows[row];
                //delete the row have both same ID.
                dr.Delete();
                MessageBox.Show("Skill removed successfully");
                DM.UpdateVacancySkill();
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



using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProjectManagement.Utils;
using ProjectManagement.ViewModels;
using System.Data.Entity;

namespace ProjectManagement
{
    public partial class ExpertDetailsForm : Form
    {
        private readonly PmContext dbContext;
        private readonly decimal currentExpertId;

        public ExpertDetailsForm(ExpertVM expert)
        {
            if (expert == null)
            {
                throw new ArgumentNullException(nameof(expert));
            }

            this.dbContext = new PmContext();
            InitializeComponent();
            this.BindExpertTypesDropDown(expert);

            this.currentExpertId = expert.Id;
            this.FirstNameTextBox.Text = expert.FirstName;
            this.MiddleNameTextBox.Text = expert.MiddleName;
            this.LastNameTextBox.Text = expert.LastName;
        }

        private void BindExpertTypesDropDown(ExpertVM expert)
        {
            var expertTypes = new Dictionary<string, string>
            {
                { "E", "Външен" },
                { "I", "Вътрешен" }
            };

            this.ExpertTypeDropDown.DataSource = new BindingSource(expertTypes, null);
            this.ExpertTypeDropDown.DisplayMember = "Value";
            this.ExpertTypeDropDown.ValueMember = "Key";

            if (expert.ExpertType == "Вътрешен")
            {
                this.ExpertTypeDropDown.SelectedItem = this.ExpertTypeDropDown.Items[1];
            }
            else
            {
                this.ExpertTypeDropDown.SelectedItem = this.ExpertTypeDropDown.Items[0];
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            this.ToggleEditingOnInputs();
            this.EditBtn.Visible = false;
            this.ApplyChangesBtn.Visible = true;
        }

        private void ToggleEditingOnInputs()
        {
            this.FirstNameTextBox.Enabled = !this.FirstNameTextBox.Enabled;
            this.MiddleNameTextBox.Enabled = !this.MiddleNameTextBox.Enabled;
            this.LastNameTextBox.Enabled = !this.LastNameTextBox.Enabled;
            this.ExpertTypeDropDown.Enabled = !this.ExpertTypeDropDown.Enabled;
            //this.ExpertTypeTextBox.ReadOnly = !this.ExpertTypeTextBox.ReadOnly;
        }

        private void ApplyChangesBtn_Click(object sender, EventArgs e)
        {
            if (!IsValidInput(FirstNameTextBox) 
                || !IsValidInput(MiddleNameTextBox)
                || !IsValidInput(LastNameTextBox))
            {
                return;
            }
            this.UpdateCurrentExpert();

            this.ToggleEditingOnInputs();
            this.EditBtn.Visible = true;
            this.ApplyChangesBtn.Visible = false;
        }

        private void UpdateCurrentExpert()
        {
            var expertToBeUpdated = this.dbContext.EXPERTS
                            .FirstOrDefault(x => x.EXPRET_ID == this.currentExpertId);

            if (expertToBeUpdated != null)
            {
                expertToBeUpdated.EXPERT_NAME = this.FirstNameTextBox.Text;
                expertToBeUpdated.EXPERT_SURNAME = this.MiddleNameTextBox.Text;
                expertToBeUpdated.EXPERT_LASTNAME = this.LastNameTextBox.Text;

                var selectedExpertTypeDropDown = this.ExpertTypeDropDown.SelectedValue.ToString();
                string expertType = string.Empty;

                if (selectedExpertTypeDropDown == ExpertType.ExternalExpert)
                {
                    expertType = ExpertType.ExternalExpert;
                }
                else
                {
                    expertType = ExpertType.InternalExpert;
                }

                expertToBeUpdated.EXPERT_TYPE = expertType;

                this.dbContext.SaveChanges();
            }
        }

        private bool IsValidInput(TextBox tb)
        {
            string tbName = "";
            switch (tb.Name)
            {
                case "FirstNameTextBox": tbName = "име"; break;
                case "MiddleNameTextBox": tbName = "презиме"; break;
                case "LastNameTextBox": tbName = "фамилия"; break;
                default:
                    break;
            }

            if (tb.Text == "")
            {
                MessageBox.Show($"Моля, попълнете полето {tbName}!");
                return false;
            }
            return true;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("SearchExpertForm"))
                {
                    Button searchButton = (Button)(f.Controls
                                            .Find("button1", true)
                                            .FirstOrDefault());
                    searchButton.PerformClick();
                    this.Close();
                }
            }
        }

        private void ExpertDetailsForm_Load(object sender, EventArgs e)
        {
            var gridData = dbContext.PROJECTS
                               .Where(x=>x.CLIENT_ID==currentExpertId)
                               .Include(x => x.PROJECT_STATUS1)
                               .Include(x => x.CLIENT)
                               .Select(x => new ProjectVM()
                               {
                                   Id = x.PROJECT_ID,
                                   Name = x.PROJECT_NAME,
                                   Client = x.CLIENT.CLIENT_NAME,
                                   StartDate = x.PROJECT_BEGIN,
                                   EndDate = x.PROJECT_END,
                                   Status = x.PROJECT_STATUS1.PSTATUS_NAME,
                                   PayPerH = x.PROJECT_PAY_PER_HOUR,
                               })
                               .ToList();

            this.ProjectsGV.Visible = true;
            this.projectVMBindingSource.DataSource = gridData;
        }
    }
}

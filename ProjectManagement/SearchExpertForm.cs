using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using ProjectManagement.ViewModels;

namespace ProjectManagement
{
    public partial class SearchExpertForm : Form
    {
        private readonly PmContext dbContext;

        public SearchExpertForm()
        {
            InitializeComponent();
            this.dbContext = new PmContext();

            //Set default values to controls
            this.SearchFilterDropDown.SelectedIndex = 0;
            this.ExpertSearchResultGrid.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Expression<Func<EXPERT, bool>> expertTypeSearchCriteria = this.GetExpertTypeSearchCriteria();
            Expression<Func<EXPERT, bool>> expertNameSearchCriteria = this.GetSearchByNameCriteria();

            var experts = this.dbContext.EXPERTS
               .Where(expertTypeSearchCriteria)
               .Where(expertNameSearchCriteria)
               .Select(x => new ExpertVM()
               {
                   FirstName = x.EXPERT_NAME,
                   MiddleName = x.EXPERT_SURNAME,
                   LastName = x.EXPERT_LASTNAME,
                   ExpertType = x.EXPERT_TYPE,
                   Id = x.EXPRET_ID
               })
               .ToList();

            this.ExpertSearchResultGrid.Visible = true;
            this.expertsBindingSource.DataSource = experts;
        }

        private Expression<Func<EXPERT, bool>> GetSearchByNameCriteria()
        {
            Expression<Func<EXPERT, bool>> expertNameSearchCriteria
             = (EXPERT expert) => true;

            var enteredExperedName = this.SearchExpertTextBox.Text;

            if (string.IsNullOrEmpty(enteredExperedName))
            {
                // if no name is entered list all users
                return expertNameSearchCriteria;
            }

            var selectedNameCriteriaIndex = this.SearchFilterDropDown.SelectedIndex;

            switch (selectedNameCriteriaIndex)
            {
                case 0:
                    expertNameSearchCriteria = (EXPERT expert) => expert.EXPERT_NAME.Contains(enteredExperedName);
                    break;
                case 1:
                    expertNameSearchCriteria = (EXPERT expert) => expert.EXPERT_SURNAME.Contains(enteredExperedName);
                    break;
                case 2:
                    expertNameSearchCriteria = (EXPERT expert) => expert.EXPERT_LASTNAME.Contains(enteredExperedName);
                    break;
            }

            return expertNameSearchCriteria;
        }

        private Expression<Func<EXPERT, bool>> GetExpertTypeSearchCriteria()
        {
            // Any expert type is selected
            Expression<Func<EXPERT, bool>> expertTypeSearchCriteria =
                 (EXPERT ex) => true;

            if (this.InternalExpertRadioBtn.Checked)
            {
                expertTypeSearchCriteria =
                    (EXPERT expert) => expert.EXPERT_TYPE == "I";
            }
            else if (this.ExternalExpertRaidoBtn.Checked)
            {
                expertTypeSearchCriteria =
                    (EXPERT expert) => expert.EXPERT_TYPE == "E";
            }

            return expertTypeSearchCriteria;
        }

        private void ExpertSearchResultGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 4)
                {
                    DataGridViewRow row = this.ExpertSearchResultGrid.Rows[e.RowIndex];
                    var selectedExpert = new ExpertVM()
                    {
                        FirstName = row.Cells[0].Value.ToString(),
                        LastName = row.Cells[1].Value.ToString(),
                        MiddleName = row.Cells[2].Value.ToString(),
                        ExpertType = "Външен"
                    };

                    var detailsForm = new ExpertDetailsForm(selectedExpert);
                    detailsForm.ShowDialog();
                }
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

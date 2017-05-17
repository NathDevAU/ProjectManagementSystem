using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using ProjectManagement.ViewModels;
using ProjectManagement.Utils;

namespace ProjectManagement
{
    public partial class SearchProjectForm : Form
    {
        private readonly PmContext context;

        public SearchProjectForm()
        {
            this.context = new PmContext();

            InitializeComponent();

            //Set default values to controls
            this.SearchFilterDropDown.SelectedIndex = 0;
            this.ProjectsGV.Visible = false;
            this.dateTimePicker.Visible = false;
            this.ProjectStatusCb.Visible = false;
        }

        private void SearchProjectForm_Load(object sender, EventArgs e)
        {
        }

        public void SearchBtn_Click(object sender, EventArgs e)
        {

            Expression<Func<PROJECT, bool>> searchCriteria = this.GetSearchCriteria();

            var gridData = context.PROJECTS
                                  .Where(searchCriteria)
                                  .Include(x => x.PROJECT_STATUS1)
                                  .Include(x=>x.CLIENT)
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
            this.projectsBindingSource.DataSource = gridData;
        }

        private Expression<Func<PROJECT, bool>> GetSearchCriteria()
        {
            Expression<Func<PROJECT, bool>> searchCriteria = (PROJECT project) => true;

            var enteredCriteria = this.SearchFilterTextBox.Text;

            var selectedCriteriaIndex = this.SearchFilterDropDown.SelectedIndex;
            switch (selectedCriteriaIndex)
            {
                case 0:
                    searchCriteria = (PROJECT project) => project.PROJECT_ID.ToString().Contains(enteredCriteria);
                    break;
                case 1:
                    searchCriteria = (PROJECT project) => project.PROJECT_NAME.Contains(enteredCriteria);
                    break;
                case 2:
                   searchCriteria = (PROJECT project) => project.CLIENT.CLIENT_NAME.Contains(enteredCriteria);
                    break;
                case 3:
                    searchCriteria = (PROJECT project) => project.PROJECT_BEGIN == dateTimePicker.Value.Date;
                    break;
                case 4:
                    searchCriteria = (PROJECT project) => project.PROJECT_END == dateTimePicker.Value.Date;
                    break;
                case 5:
                    searchCriteria = (PROJECT project) => project.PROJECT_STATUS ==
                                                     (ProjectStatusCb.SelectedIndex == 4 ?
                                                     Constants.ProjectStatusFinishedId : ProjectStatusCb.SelectedIndex + 1);
                    break;
            }

            return searchCriteria;
        }

        private void ProjectGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 7)
                {
                    DataGridViewRow row = this.ProjectsGV.Rows[e.RowIndex];
                    var selectedProjectId = row.Cells[0].Value.ToString();
                    var detailsForm = new ProjectDetailsForm(selectedProjectId);
                    detailsForm.ShowDialog();
                }
            }



        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchFilterDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchFilterTextBox.Clear();
            dateTimePicker.Value = DateTime.Today;
            ProjectStatusCb.SelectedIndex = -1;

            switch (SearchFilterDropDown.SelectedIndex)
            {
                case 0:
                    SearchFilterTextBox.Visible = true;
                    dateTimePicker.Visible = false;
                    ProjectStatusCb.Visible = false;
                    break;
                case 1:
                    SearchFilterTextBox.Visible = true;
                    dateTimePicker.Visible = false;
                    ProjectStatusCb.Visible = false;
                    break;

                case 2:
                    SearchFilterTextBox.Visible = true;
                    dateTimePicker.Visible = false;
                    ProjectStatusCb.Visible = false;
                    break;
                case 3:
                    SearchFilterTextBox.Visible = false;
                    dateTimePicker.Visible = true;
                    ProjectStatusCb.Visible = false;
                    break;
                case 4:
                    SearchFilterTextBox.Visible = false;
                    dateTimePicker.Visible = true;
                    ProjectStatusCb.Visible = false;
                    break;
                case 5:
                    SearchFilterTextBox.Visible = true;
                    dateTimePicker.Visible = false;
                    ProjectStatusCb.Visible = true;
                    break;

                default:
                    SearchFilterTextBox.Visible = true;
                    dateTimePicker.Visible = false;
                    ProjectStatusCb.Visible = false;
                    break;
            }
        }
    }
}

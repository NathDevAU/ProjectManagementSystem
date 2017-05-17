using ProjectManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class ProjectDetailsForm : Form
    {
        private readonly PmContext context;
        private readonly decimal currentProjectId;
        private PROJECT currentProject;
        public ProjectDetailsForm(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            this.context = new PmContext();
            InitializeComponent();
            currentProjectId = decimal.Parse(id);
            currentProject = context.PROJECTS.Find(currentProjectId);
            StatusDdl.Enabled = false;
            ProjectClientComboBox.SelectedValue = currentProject.CLIENT.CLIENT_ID;

        }

        public ProjectDetailsForm()
        {
        }

        private void ProjectDetailsForm_Load(object sender, EventArgs e)
        {
            PopulateControls();

            PopulateTasksGV();
            PopulateClientsCb();
        }

        private void PopulateClientsCb()
        {
            var clients = new Dictionary<decimal, string>();

            foreach (var cl in context.CLIENT)
            {
                clients.Add(cl.CLIENT_ID, cl.CLIENT_NAME);
            }
            this.ProjectClientComboBox.DataSource = new BindingSource(clients, null);
            this.ProjectClientComboBox.DisplayMember = "Value";
            this.ProjectClientComboBox.ValueMember = "Key";
        }

        private void PopulateControls()
        {
            ProjectIdTextBox.Text = currentProject.PROJECT_ID.ToString();
            ProjectNameTextBox.Text = currentProject.PROJECT_NAME;
            ProjectDescriptionTextBox.Text = currentProject.PROJECT_DESCRIPTION;
            ProjectClientComboBox.SelectedValue = currentProject.CLIENT.CLIENT_ID;
            StatusDdl.SelectedItem = currentProject.PROJECT_STATUS1.PSTATUS_NAME;
            ProjectStartDateDatePicker.Value = currentProject.PROJECT_BEGIN.Date;
            ProjectEndDatePicker.Value = currentProject.PROJECT_END.Date;
            PayPerHourTextBox.Text = currentProject.PROJECT_PAY_PER_HOUR.ToString();
            TaskCountTb.Text = currentProject.PROJECT_TASKS.Count.ToString();
            HoursCountTb.Text = "99:99"; //TODO: sum of each task hours
            CostSoFarTb.Text = "NotImplemented"; //TODO : project cost formula?
        }

        public void PopulateTasksGV()
        {

            var gridData = context.PROJECT_TASKS
                                  .Where(x => x.PROJECT_ID == currentProjectId)
                                  .Select(x => new TaskVM()
                                  {
                                      TaskName = x.TASK_NAME,
                                      EndDate = x.TASK_END,
                                      TaskId = x.TASK_ID
                                  })
                                  .ToList();

            this.taskVMBindingSource.DataSource = gridData;
            TasksGV.DataSource = this.taskVMBindingSource;

        }



        private void EditDetailsBtn_Click(object sender, EventArgs e)
        {
            RegisterNewClientBtn.Visible = true;
            ProjectIdTextBox.Enabled = true;
            ProjectNameTextBox.Enabled = true;
            ProjectDescriptionTextBox.Enabled = true;
            ProjectClientComboBox.Enabled = true;
            RegisterNewClientBtn.Enabled = true;
            ProjectEndDatePicker.Enabled = true;
            ProjectStartDateDatePicker.Enabled = true;
            PayPerHourTextBox.Enabled = true;
            TaskCountTb.Enabled = true;
            HoursCountTb.Enabled = true;
            CostSoFarTb.Enabled = true;

            SaveBtn.Visible = true;
            EditDetailsBtn.Visible = false;



        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //TODO: SAVE CHANGES


            RegisterNewClientBtn.Visible = false;
            ProjectIdTextBox.Enabled = false;
            ProjectNameTextBox.Enabled = false;
            ProjectDescriptionTextBox.Enabled = false;
            ProjectClientComboBox.Enabled = false;
            RegisterNewClientBtn.Enabled = false;
            ProjectEndDatePicker.Enabled = false;
            ProjectStartDateDatePicker.Enabled = false;
            PayPerHourTextBox.Enabled = false;
            TaskCountTb.Enabled = false;
            HoursCountTb.Enabled = false;
            CostSoFarTb.Enabled = false;

            SaveBtn.Visible = false;
            EditDetailsBtn.Visible = true;
        }


        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            var form = new CreatingTaskForm(currentProject.PROJECT_ID);

            form.ShowDialog();
        }

        private void ChangeStatusBtn_Click(object sender, EventArgs e)
        {
            //IMPLEMENT LOGIC
        }

        private void TasksGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 4)
                {
                    DataGridViewRow row = this.TasksGV.Rows[e.RowIndex];
                    var selectedTaskId = row.Cells[0].Value.ToString();
                    var detailsForm = new TaskDetailsForm(selectedTaskId);
                    detailsForm.ShowDialog();
                }
            }
        }
    }
}
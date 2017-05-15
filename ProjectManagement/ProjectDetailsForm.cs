using System;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class ProjectDetailsForm : Form
    {
        private readonly PmContext context;
        private readonly decimal currentId;
        private PROJECT currentProject;
        public ProjectDetailsForm(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            this.context = new PmContext();
            InitializeComponent();
            currentId = decimal.Parse(id);
            currentProject = context.PROJECTS.Find(currentId);
            StatusDdl.Enabled = false;
        }

        public ProjectDetailsForm()
        {
        }

        private void ProjectDetailsForm_Load(object sender, EventArgs e)
        {
            ProjectIdTextBox.Text = currentProject.PROJECT_ID.ToString();
            ProjectNameTextBox.Text = currentProject.PROJECT_NAME;
            ProjectDescriptionTextBox.Text = currentProject.PROJECT_DESCRIPTION;
            StatusDdl.SelectedItem = currentProject.PROJECT_STATUS1.PSTATUS_NAME;
            ProjectClientComboBox.SelectedValue = currentProject.PROJECT_CLIENT;
            ProjectStartDateDatePicker.Value = currentProject.PROJECT_BEGIN.Date;
            ProjectEndDatePicker.Value = currentProject.PROJECT_END.Date;
            PayPerHourTextBox.Text = currentProject.PROJECT_PAY_PER_HOUR.ToString();
            TaskCountTb.Text = currentProject.PROJECT_TASKS.Count.ToString();
            HoursCountTb.Text = "99:99"; //TODO: sum of each task hours
            CostSoFarTb.Text = "NotImplemented"; //TODO : project cost formula?





            
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var form = new TaskDetailsForm();
                form.ShowDialog();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTaskBtn_Click_1(object sender, EventArgs e)
        {
            var form = new CreatingTaskForm();
            form.ShowDialog();
        }

        private void ChangeStatusBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
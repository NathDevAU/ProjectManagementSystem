using ProjectManagement.Models;
using ProjectManagement.Utils;
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
            ClientTb.Enabled = false;
            ClientTb.Text = currentProject.CLIENT.CLIENT_NAME;
            ProjectClientComboBox.Visible = false;
            RegisterNewClientBtn.Visible = false;
            CancelNewClientBtn.Visible = false;


        }

        public ProjectDetailsForm()
        {
        }

        private void ProjectDetailsForm_Load(object sender, EventArgs e)
        {
            PopulateControls();
            PopulateStatusDdl();
            PopulateTasksGV();
            PopulateClientsCb();
            StatusDdl.SelectedValue = currentProject.PROJECT_STATUS;

        }

        private void PopulateStatusDdl()
        {

            var statuses = new Dictionary<decimal, string>();

            foreach (var st in context.PROJECT_STATUS)
            {
                statuses.Add(st.PSTATUS_ID, st.PSTATUS_NAME);
            }
            this.ProjectClientComboBox.DataSource = new BindingSource(statuses, null);
            this.ProjectClientComboBox.DisplayMember = "Value";
            this.ProjectClientComboBox.ValueMember = "Key";

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
            ProjectClientComboBox.SelectedValue = currentProject.CLIENT_ID;
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
            if (currentProject.PROJECT_STATUS == Constants.ProjectStatusCanceledId ||
                currentProject.PROJECT_STATUS == Constants.ProjectStatusFinishedId ||
                currentProject.PROJECT_STATUS == Constants.ProjectStatusFrozenId)
            {
                MessageBox.Show("Проект с такъв статус не може да бъде редактиран!");
                return;
            }


            RegisterNewClientBtn.Visible = true;
            ProjectNameTextBox.Enabled = true;
            ProjectDescriptionTextBox.Enabled = true;
            ProjectClientComboBox.Enabled = true;
            RegisterNewClientBtn.Enabled = true;
            ProjectEndDatePicker.Enabled = true;
            ProjectStartDateDatePicker.Enabled = true;
            PayPerHourTextBox.Enabled = true;

            SaveBtn.Visible = true;
            EditDetailsBtn.Visible = false;

            ClientTb.Visible = false;
            ProjectClientComboBox.Visible = true;
            RegisterNewClientBtn.Visible = true;

            ProjectClientComboBox.SelectedValue = currentProject.CLIENT_ID;

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //TODO: SAVE CHANGES


            currentProject.PROJECT_NAME = ProjectNameTextBox.Text;
            currentProject.PROJECT_DESCRIPTION = ProjectDescriptionTextBox.Text;
            currentProject.CLIENT_ID = decimal.Parse(ProjectClientComboBox.SelectedValue.ToString());
            currentProject.PROJECT_BEGIN = ProjectStartDateDatePicker.Value;
            currentProject.PROJECT_END = ProjectEndDatePicker.Value;
            currentProject.PROJECT_PAY_PER_HOUR = decimal.Parse(PayPerHourTextBox.Text);
            context.SaveChanges();


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


            //if form is open from Create Tast Form:
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("SearchProjectForm"))
                {
                    SearchProjectForm form = Application.OpenForms.OfType<SearchProjectForm>().FirstOrDefault();
                    if (form != null)
                    {
                        form.SearchBtn_Click(sender, e);
                    }
                }
            }





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
            if (ChangeStatusBtn.Text == "Промени")
            {
                StatusDdl.Enabled = true;
                ChangeStatusBtn.Text = "Запази";
            }
            else if (ChangeStatusBtn.Text == "Запази")
            {
                switch (StatusDdl.SelectedIndex)
                {
                    case 0:
                        if (currentProject.PROJECT_STATUS != Constants.ProjectStatusNewId)
                        {
                            MessageBox.Show("Проектът не може да премине в статус Нов");
                            StatusDdl.SelectedIndex = -1;
                            return;
                        }
                        break;
                    case 1:
                        if (currentProject.PROJECT_STATUS != Constants.ProjectStatusNewId &&
                            currentProject.PROJECT_STATUS != Constants.ProjectStatusCanceledId &&
                            currentProject.PROJECT_STATUS != Constants.ProjectStatusFrozenId)
                        {
                            MessageBox.Show("Проектът не може да премине статус В изпълнение");
                            StatusDdl.SelectedIndex = -1;
                            return;
                        }
                        break;
                    case 2:
                        if (currentProject.PROJECT_STATUS != Constants.ProjectStatusNewId &&
                            currentProject.PROJECT_STATUS != Constants.ProjectStatusOngoingId)
                        {
                            MessageBox.Show("Проектът не може да премине в статус Замръзен");
                            StatusDdl.SelectedIndex = -1;
                            return;
                        }
                        break;
                    case 3:
                        if (currentProject.PROJECT_STATUS != Constants.ProjectStatusNewId &&
                          currentProject.PROJECT_STATUS != Constants.ProjectStatusOngoingId)
                        {
                            MessageBox.Show("Проектът не може да премине в статус Прекратен");
                            StatusDdl.SelectedIndex = -1;
                            return;
                        }
                        break;
                    case 4:
                        if (currentProject.PROJECT_STATUS != Constants.ProjectStatusOngoingId)
                        {
                            MessageBox.Show("Проектът не може да премине в статус Приключил");
                            StatusDdl.SelectedIndex = -1;
                            return;
                        }
                        break;
                }
                currentProject.PROJECT_STATUS = context.PROJECT_STATUS.Where(x => x.PSTATUS_NAME == StatusDdl.Text).FirstOrDefault().PSTATUS_ID;
                context.SaveChanges();
                ChangeStatusBtn.Text = "Промени";
                StatusDdl.Enabled = false;
            }
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

        private void RegisterNewClientBtn_Click(object sender, EventArgs e)
        {
            if (RegisterNewClientBtn.Text == "Нов")
            {
                ProjectClientComboBox.Visible = false;
                ClientTb.Visible = true;
                ClientTb.Enabled = true;
                ClientTb.Clear();
                CancelNewClientBtn.Visible = true;
                RegisterNewClientBtn.Text = "Запази";
            }
            else if (RegisterNewClientBtn.Text == "Запази")
            {
                if (ClientTb.Text == "")
                {
                    MessageBox.Show("Въведете име на клиент!");
                    return;
                }
                if (context.CLIENT.Any(x => x.CLIENT_NAME == ClientTb.Text))
                {
                    MessageBox.Show("Вече съществува клиент с това име!");
                    return;
                }
                ProjectClientComboBox.Visible = true;
                ClientTb.Visible = false;
                ClientTb.Enabled = false;
                CancelNewClientBtn.Visible = false;
                var newClient = new CLIENT();
                newClient.CLIENT_NAME = ClientTb.Text;
                context.CLIENT.Add(newClient);
                context.SaveChanges();

                PopulateClientsCb();

                ProjectClientComboBox.SelectedValue = newClient.CLIENT_ID;
                RegisterNewClientBtn.Text = "Нов";
                MessageBox.Show("Клиентът е добавен успешно!");
            }
        }

        private void CancelNewClientBtn_Click(object sender, EventArgs e)
        {
            RegisterNewClientBtn.Text = "Нов";
            ClientTb.Visible = false;
            ProjectClientComboBox.Visible = true;
            CancelNewClientBtn.Visible = false;
        }
    }
}
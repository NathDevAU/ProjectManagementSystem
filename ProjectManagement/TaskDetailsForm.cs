using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class TaskDetailsForm : Form
    {
        private readonly PmContext context;
        private decimal currentTaskId;
        private PROJECT_TASKS currentTask;


        public TaskDetailsForm(string Id)
        {
            this.context = new PmContext();
            InitializeComponent();
            currentTaskId = decimal.Parse(Id);
            currentTask = context.PROJECT_TASKS.Find(currentTaskId);
            ProjectNameTb.Enabled = false;

        }

        private void TaskDetailsForm_Load(object sender, EventArgs e)
        {
            PopulateExpertCb();
            PopulatePriorityCb();
            PopulateStatusCb();

            TaskNameTb.Text = currentTask.TASK_NAME;
            ProjectNameTb.Text = currentTask.PROJECT.PROJECT_NAME;
            DescriptionRtb.Text = currentTask.TASK_DESCRIPTION;
            ResultRtb.Text = currentTask.TAS_DELIVERABLES;
            ExpertsCb.SelectedValue = currentTask.EXPRET_ID;
            PriorityCb.SelectedValue = currentTask.TASK_PRIORITY;
            StatusCb.SelectedValue = currentTask.TASK_STATUS;

            // NOT FINISH
            //  ComentRtb.Text = "";
            //  TaskExpertCb.SelectedValue = currentTask.EXPRET_ID;
            //  StatusDdl.SelectedItem = currentProject.PROJECT_STATUS1.PSTATUS_NAME;

            TaskHoursTb.Text = currentTask.TASK_HOURS.ToString();
            StatusCb.Text = currentTask.TASK_STATUS1.STATUS_NAME;
            TaskStartDatePicker.Value = currentTask.TASK_BEGIN.Date;
            TaskEndDatePicker.Value = currentTask.TASK_END.Date;

            for (int i = 1; i <= currentTask.TASK_READY; i++)
            {
                TaskProgressBar.PerformStep();
            }
        }

        private void PopulateStatusCb()
        {
            Dictionary<string, decimal> cbData = new Dictionary<string, decimal>();

            var taskStatuses = context.TASK_STATUS.ToList();
            foreach (var stat in taskStatuses)
            {
                cbData.Add(stat.STATUS_NAME, stat.STATUS_ID);
            }
            this.StatusCb.DataSource = new BindingSource(cbData, null);
            this.StatusCb.DisplayMember = "Key";
            this.StatusCb.ValueMember = "Value";
            StatusCb.Refresh();
            cbData.Clear();
        }

        private void PopulatePriorityCb()
        {
            Dictionary<string, string> cbData = new Dictionary<string, string>();

            var experts = context.EXPERTS.ToList();

            cbData.Add("Висок", "H");
            cbData.Add("Среден", "M");
            cbData.Add("Нисък", "L");

            this.PriorityCb.DataSource = new BindingSource(cbData, null);
            this.PriorityCb.DisplayMember = "Key";
            this.PriorityCb.ValueMember = "Value";
            PriorityCb.Refresh();
            cbData.Clear();
        }

        public void PopulateExpertCb()
        {
            Dictionary<string, decimal> cbData = new Dictionary<string, decimal>();

            var experts = context.EXPERTS.ToList();
            foreach (var expert in experts)
            {
                cbData.Add(
                 string.Concat(
                     expert.EXPERT_NAME, " ",
                     expert.EXPERT_SURNAME, " ",
                     expert.EXPERT_LASTNAME),
                 expert.EXPRET_ID);
            }


            this.ExpertsCb.DataSource = new BindingSource(cbData, null);
            this.ExpertsCb.DisplayMember = "Key";
            this.ExpertsCb.ValueMember = "Value";
            ExpertsCb.Refresh();
            cbData.Clear();
        }

        private void EditTasks_Click(object sender, EventArgs e)
        {
            TaskNameTb.Enabled = true;
            DescriptionRtb.Enabled = true;
            TaskResultRtb.Enabled = true;
            ExpertsCb.Enabled = true;
            NewExpertBnt.Enabled = true;
            ResultRtb.Enabled = true;
            StatusCb.Enabled = true;

            if (currentTask.TASK_STATUS==Utils.TaskStatus.TaskStatusCompleatedId)
            {
            TaskHoursTb.Enabled = true;
            }

            TaskStartDatePicker.Enabled = true;
            TaskEndDatePicker.Enabled = true;
            PriorityCb.Enabled = true;

            NewExpertBnt.Visible = true;

            EditTasks.Visible = false;
            SaveBtn.Visible = true;
            StepBtn.Visible = true;


        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (TaskNameTb.Text=="")
            {
                MessageBox.Show("Въведете име на задачата!");
                return;
            }
            if (DescriptionRtb.Text == "")
            {
                MessageBox.Show("Въведете описание на задачата!");
                return;
            }
            if (ResultRtb.Text == "")
            {
                MessageBox.Show("Въведете oчакван резултат!");
                return;
            }
            if (true)
            {

            }



            if (decimal.Parse(TaskHoursTb.Text.ToString()) < currentTask.TASK_HOURS)
            {
                MessageBox.Show($"Въведете число по-голямо от {currentTask.TASK_HOURS}");
                return;
            }
            currentTask.TASK_NAME = TaskNameTb.Text;
            currentTask.TASK_DESCRIPTION = DescriptionRtb.Text;
            currentTask.TAS_DELIVERABLES = ResultRtb.Text;
            currentTask.TASK_PRIORITY = PriorityCb.SelectedValue.ToString();//?
            currentTask.EXPRET_ID = decimal.Parse(ExpertsCb.SelectedValue.ToString());
            currentTask.TASK_HOURS = decimal.Parse(TaskHoursTb.Text);
            currentTask.TASK_STATUS = decimal.Parse(StatusCb.SelectedValue.ToString());
            currentTask.TASK_BEGIN = TaskStartDatePicker.Value;
            currentTask.TASK_END = TaskEndDatePicker.Value;

            context.SaveChanges();

            TaskNameTb.Enabled = false;
            DescriptionRtb.Enabled = false;
            TaskResultRtb.Enabled = false;
            ExpertsCb.Enabled = false;
            NewExpertBnt.Enabled = false;
            ResultRtb.Enabled = false;
            StatusCb.Enabled = false;
            TaskHoursTb.Enabled = false;
            TaskStartDatePicker.Enabled = false;
            TaskEndDatePicker.Enabled = false;
            PriorityCb.Enabled = false;
            NewExpertBnt.Visible = false;
            StepBtn.Visible = false;


            EditTasks.Visible = true;
            SaveBtn.Visible = false;

            //if form is open from Create Tast Form:
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("ProjectDetailsForm"))
                {
                    ProjectDetailsForm form = Application.OpenForms.OfType<ProjectDetailsForm>().FirstOrDefault();
                    if (form != null)
                    {
                        form.PopulateTasksGV();
                        form.PopulateControls();
                    }
                }
            }

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewExpertBnt_Click(object sender, EventArgs e)
        {
            var registerForm = new ExprertsRegisterForm();
            registerForm.ShowDialog();
        }

        private void StepBtn_Click(object sender, EventArgs e)
        {
            if (currentTask.TASK_READY < 10)
            {
                TaskProgressBar.PerformStep();
                currentTask.TASK_READY++;
                context.SaveChanges();
            }
        }
    }
}

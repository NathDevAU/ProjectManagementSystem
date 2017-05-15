using ProjectManagement.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class CreatingTaskForm : Form
    {
        private readonly PmContext context;
        private decimal currentId;
        private PROJECT currentProject;

        public CreatingTaskForm(decimal id)
        {
            this.context = new PmContext();
            InitializeComponent();
            currentId = id;
            currentProject = context.PROJECTS.Find(currentId);
        }






        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreatingTaskForm_Load(object sender, EventArgs e)
        {
            task_Project_TB.Text = currentProject.PROJECT_NAME;
            task_comment_RTB.Text = "такова нещо в базата няма!";

            Populate_Click(sender, e);
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (!IsValidInput(task_Name_TB) ||
                !IsValidSelection(task_Priority_CB)
                )
            {
                return;
            }

            if (taskStartDate.Value.Date < DateTime.Now.Date ||
             taskEndDate.Value.Date < DateTime.Now.Date ||
             taskEndDate.Value < taskStartDate.Value)
            {
                MessageBox.Show("Невалидна дата!");
                return;
            }
            if (context.PROJECT_TASKS.Any(o => o.TASK_NAME == task_Name_TB.Text))
            {
                MessageBox.Show("Вече съществува задача с това име!");
                return;
            }

            var task = new PROJECT_TASKS();

            task.TASK_NAME = task_Name_TB.Text;
            if (task_Priority_CB.SelectedIndex == Priority.HighPriorityIndex)
            {
                task.TASK_PRIORITY = "H";
            }
            else if (task_Priority_CB.SelectedIndex == Priority.MediumPriorityIndex)
            {
                task.TASK_PRIORITY = "M";
            }
            else if (task_Priority_CB.SelectedIndex == Priority.LowPriorityIndex)
            {
                task.TASK_PRIORITY = "L";
            }
            task.TASK_DESCRIPTION = task_Description_RTB.Text;
            task.TAS_DELIVERABLES = task_Result_RTB.Text;
            task.TASK_BEGIN = taskStartDate.Value;
            task.TASK_END = taskEndDate.Value;
            task.TASK_STATUS = Utils.TaskStatus.TaskStatusPlannedId;
            task.TASK_STATUS1 = context.TASK_STATUS.Find(Utils.TaskStatus.TaskStatusPlannedId);
            task.TASK_READY = 0;
            task.PROJECT_ID = currentProject.PROJECT_ID; 
            var expertId=decimal.Parse(ExpertsCb.SelectedValue.ToString());
            task.EXPRET_ID = expertId;
            task.PROJECT = currentProject;
            task.EXPERT = context.EXPERTS.Find(expertId);
            task.TASK_READY = 0;
            task.TASK_HOURS = 0;

            ////FIX!! ne bachka i s nego i bez nego
            decimal count = context.PROJECT_TASKS.Count() + 1 ;
            task.TASK_ID = count;

            context.PROJECT_TASKS.Add(task);
            context.SaveChanges();
        }

        private bool IsValidSelection(ComboBox task_CB)
        {
            if (task_CB.Text == "")
            {
                MessageBox.Show($"Моля, изберете Приоритет на задача!");
                return false;
            }
            return true;
        }

        private bool IsValidInput(TextBox task_TB)
        {
            if (task_TB.Text == "")
            {
                MessageBox.Show(string.Format("Моля, попълнете полето {0}!", task_name.Text));
                return false;
            }

            return true;
        }

        private void RegisterExpertBtn_Click(object sender, EventArgs e)
        {
            var registerForm = new ExprertsRegisterForm();
            registerForm.ShowDialog();

        }

        public void Populate_Click(object sender, EventArgs e)
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
    }
}

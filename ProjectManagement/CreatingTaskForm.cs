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



        private void ExpertTypeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreatingTaskForm_Load(object sender, EventArgs e)
        {
            task_Project_TB.Text = currentProject.PROJECT_NAME;
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
    }
}

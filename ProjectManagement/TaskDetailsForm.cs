using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagement.Models;
using ProjectManagement.Utils;
using ProjectManagement.ViewModels;

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
            textBox1.Enabled = false;

        }

        private void TaskDetailsForm_Load(object sender, EventArgs e)
        {
            TaskNameTb.Text = currentTask.TASK_NAME;
            textBox1.Text = currentTask.PROJECT.PROJECT_NAME;
            DescriptionRtb.Text = currentTask.TASK_DESCRIPTION;
            ResultRtb.Text = currentTask.TAS_DELIVERABLES;

            // NOT FINISH
            //  ComentRtb.Text = "";
            //  TaskExpertCb.SelectedValue = currentTask.EXPRET_ID;
            //  StatusDdl.SelectedItem = currentProject.PROJECT_STATUS1.PSTATUS_NAME;

            PriorityCb.Text = currentTask.TASK_PRIORITY;
            TaskHoursTb.Text = currentTask.TASK_HOURS.ToString();
            StatusCb.Text = currentTask.TASK_STATUS1.STATUS_NAME;
            TaskStartDatePicker.Value = currentTask.TASK_BEGIN.Date;
            TaskEndDatePicker.Value = currentTask.TASK_END.Date;

        }

        private void EditTasks_Click(object sender, EventArgs e)
        {
            TaskNameTb.Enabled = true;
            DescriptionRtb.Enabled = true;
            TaskResultRtb.Enabled = true;
            ComentRtb.Enabled = true;
            TaskExpertCb.Enabled = true;
            NewExpertBnt.Enabled = true;
            ResultRtb.Enabled = true;
            StatusCb.Enabled = true;
            TaskHoursTb.Enabled = true;
            TaskStartDatePicker.Enabled = true;
            TaskEndDatePicker.Enabled = true;
            PriorityCb.Enabled = true;

            NewExpertBnt.Visible = true;

            EditTasks.Visible = false;
            SaveBtn.Visible = true;


        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            currentTask.TASK_NAME = TaskNameTb.Text;
            currentTask.TASK_DESCRIPTION = DescriptionRtb.Text;
            currentTask.TAS_DELIVERABLES = ResultRtb.Text;
            currentTask.TASK_PRIORITY = PriorityCb.Text;
            currentTask.TASK_HOURS = decimal.Parse(TaskHoursTb.Text);
            currentTask.TASK_STATUS1.STATUS_NAME = StatusCb.Text;
            currentTask.TASK_BEGIN = TaskStartDatePicker.Value;
            currentTask.TASK_END = TaskEndDatePicker.Value;

            context.SaveChanges();

            TaskNameTb.Enabled = false;
            DescriptionRtb.Enabled = false;
            TaskResultRtb.Enabled = false;
            ComentRtb.Enabled = false;
            TaskExpertCb.Enabled = false;
            NewExpertBnt.Enabled = false;
            ResultRtb.Enabled = false;
            StatusCb.Enabled = false;
            TaskHoursTb.Enabled = false;
            TaskStartDatePicker.Enabled = false;
            TaskEndDatePicker.Enabled = false;
            PriorityCb.Enabled = false;
            NewExpertBnt.Visible = false;


            EditTasks.Visible = true;
            SaveBtn.Visible = false;



        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

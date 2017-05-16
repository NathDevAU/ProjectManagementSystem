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
    public partial class TaskDetailsForm : Form
    {
        private string selectedTaskId;

        public TaskDetailsForm(string selectedTaskId)
        {
            this.selectedTaskId = selectedTaskId;
            InitializeComponent();

        }

        private void TaskDetailsForm_Load(object sender, EventArgs e)
        {

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

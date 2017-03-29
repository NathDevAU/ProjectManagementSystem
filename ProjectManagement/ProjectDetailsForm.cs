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
    public partial class ProjectDetailsForm : Form
    {
        public ProjectDetailsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
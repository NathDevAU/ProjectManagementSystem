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
            if (EditDetailsBtn.Text == "Редактиране на проекта")
            {
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

                EditDetailsBtn.Text = "Запази";
            }
            else if (EditDetailsBtn.Text == "Запази")
            {
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

                EditDetailsBtn.Text = "Редактиране на проекта";
            }



        }

        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            var form = new CreatingTaskForm();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var form = new TaskDetailsForm();
                form.ShowDialog();
            }
        }
    }
}

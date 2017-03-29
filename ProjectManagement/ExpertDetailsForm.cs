using ProjectManagement.ViewModels;
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
    public partial class ExpertDetailsForm : Form
    {
        public ExpertDetailsForm(Expert expert)
        {
            InitializeComponent();
            this.FirstNameTextBox.Text = expert.FirstName;
            this.MiddleNameTextBox.Text = expert.MiddleName;
            this.LastNameTextBox.Text = expert.LastName;
            this.ExpertTypeDropDown.SelectedIndex = 1;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            this.ToggleEditingOnInputs();
            this.EditBtn.Visible = false;
            this.ApplyChangesBtn.Visible = true;
        }

        private void ToggleEditingOnInputs()
        {
            this.FirstNameTextBox.Enabled = !this.FirstNameTextBox.Enabled;
            this.MiddleNameTextBox.Enabled = !this.MiddleNameTextBox.Enabled;
            this.LastNameTextBox.Enabled = !this.LastNameTextBox.Enabled;
            this.ExpertTypeDropDown.Enabled = !this.ExpertTypeDropDown.Enabled;
            //this.ExpertTypeTextBox.ReadOnly = !this.ExpertTypeTextBox.ReadOnly;

        }

        private void ApplyChangesBtn_Click(object sender, EventArgs e)
        {
            this.ToggleEditingOnInputs();
            this.EditBtn.Visible = true;
            this.ApplyChangesBtn.Visible = false;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

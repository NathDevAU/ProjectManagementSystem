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
            this.IsExternalTextBox.Text = expert.IsExternal.ToString();
        }

        private void EditExpertInfoBtn_Click(object sender, EventArgs e)
        {
            this.ToggleEditingOnInputs();
            this.EditExpertInfoBtn.Visible = false;
            this.SaveChangesBtn.Visible = true;
        }
      
        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            this.ToggleEditingOnInputs();
            this.EditExpertInfoBtn.Visible = true;
            this.SaveChangesBtn.Visible = false;
        }

        private void ToggleEditingOnInputs()
        {
            this.FirstNameTextBox.ReadOnly = !this.FirstNameTextBox.ReadOnly;
            this.MiddleNameTextBox.ReadOnly = !this.MiddleNameTextBox.ReadOnly;
            this.LastNameTextBox.ReadOnly = !this.LastNameTextBox.ReadOnly;
            this.IsExternalTextBox.ReadOnly = !this.IsExternalTextBox.ReadOnly;
        }
    }
}

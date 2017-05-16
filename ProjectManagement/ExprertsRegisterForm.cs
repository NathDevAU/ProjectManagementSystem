using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class ExprertsRegisterForm : Form
    {
        PmContext context = new PmContext();
        EXPERT expert;
        public ExprertsRegisterForm()
        {
            InitializeComponent();
        }

        private void CreateExpertBtn_Click(object sender, EventArgs e)
        {

            if (!IsValidInput(ExpertNameTextBox) || !IsValidInput(ExpertMiddleNameTextBox) || !IsValidInput(ExpertLastNameTextBox))
            {
                return;
            }

            expert = new EXPERT();
            expert.EXPERT_NAME = ExpertNameTextBox.Text;
            expert.EXPERT_SURNAME = ExpertMiddleNameTextBox.Text;
            expert.EXPERT_LASTNAME = ExpertLastNameTextBox.Text;
            if (OutsideExpert.Checked == true)
            {
                expert.EXPERT_TYPE = "E";
            }
            else if (InsideExpert.Checked == true)
            {
                expert.EXPERT_TYPE = "I";
            }
            else if (OutsideExpert.Checked == false && InsideExpert.Checked == false)
            {
                MessageBox.Show("Изберете тип на експерта!");
                return;
            }

            context.EXPERTS.Add(expert);
            context.SaveChanges();
            MessageBox.Show("Експертът е регистриран успешно.");

            ExpertNameTextBox.Clear();
            ExpertMiddleNameTextBox.Clear();
            ExpertLastNameTextBox.Clear();
            InsideExpert.Checked = false;
            OutsideExpert.Checked = false;


            //if form is open from Create Tast Form:
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals("CreatingTaskForm"))
                {
                    CreatingTaskForm form = Application.OpenForms.OfType<CreatingTaskForm>().FirstOrDefault();
                    if (form != null)
                    {
                        form.PopulateExpertCb();
                        var cb = (ComboBox)form.Controls.Find("ExpertsCb", true).FirstOrDefault();
                        cb.SelectedValue = expert.EXPRET_ID;
                        this.Close();
                    }
                }
            }




        }
        private bool IsValidInput(TextBox tb)
        {
            string tbName = "";
            switch (tb.Name)
            {
                case "ExpertNameTextBox": tbName = "име"; break;
                case "ExpertMiddleNameTextBox": tbName = "презиме"; break;
                case "ExpertLastNameTextBox": tbName = "фамилия"; break;
                default:
                    break;
            }

            if (tb.Text == "")
            {
                MessageBox.Show($"Моля, попълнете полето {tbName}!");
                return false;
            }
            return true;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

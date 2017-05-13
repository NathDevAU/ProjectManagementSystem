using System;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class ExprertsRegisterForm : Form
    {
        PmContext context = new PmContext();
        public ExprertsRegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateExpertBtn_Click(object sender, EventArgs e)
        {
         
            if (!IsValidInput(ExpertNameTextBox) || !IsValidInput(ExpertMiddleNameTextBox) || !IsValidInput(ExpertLastNameTextBox))
            {
                return;
            }

            var expert = new EXPERT();
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
    }
}

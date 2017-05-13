using System;
using System.Linq;
using System.Windows.Forms;
using ProjectManagement.Utils;

namespace ProjectManagement
{
    public partial class CreatingProjectForm : Form
    {
        private readonly PmContext context;

        public CreatingProjectForm()
        {
            InitializeComponent();

            this.context = new PmContext();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (!IsValidInput(ProjectIdTextBox) ||
                !IsValidInput(PayPerHourTextBox) ||
                !IsNotNull(ProjectNameTextBox) ||
                !IsNotNull(ProjectDescriptionTextBox) ||
                !IsValidSelection(ProjectClientComboBox)
                )
            {
                // MessageBox.Show("Грешка");
                return;
            }
            if (ProjectStartDateDatePicker.Value.Date < DateTime.Now.Date ||
                ProjectEndDatePicker.Value.Date < DateTime.Now.Date ||
                ProjectEndDatePicker.Value < ProjectStartDateDatePicker.Value)
            {
                MessageBox.Show("Невалидна дата!");
                return;
            }


            var projectId = decimal.Parse(ProjectIdTextBox.Text);
            if (context.PROJECTS.Any(o => o.PROJECT_ID == projectId))
            {
                MessageBox.Show("Вече съществува проект с този код!");
                return;
            }
            if (context.PROJECTS.Any(o => o.PROJECT_NAME == ProjectNameTextBox.Text))
            {
                MessageBox.Show("Вече съществува проект с този име!");
                return;
            }
            var project = new PROJECT();
            project.PROJECT_ID = projectId;
            project.PROJECT_NAME = ProjectNameTextBox.Text;
            project.PROJECT_DESCRIPTION = ProjectDescriptionTextBox.Text;
            project.PROJECT_CLIENT = ProjectClientComboBox.SelectedItem.ToString(); //TODO: FIX
            project.PROJECT_BEGIN = ProjectStartDateDatePicker.Value;
            project.PROJECT_END = ProjectEndDatePicker.Value;
            project.PROJECT_STATUS = Constants.ProjectStatusNewId;
            project.PROJECT_PAY_PER_HOUR = decimal.Parse(PayPerHourTextBox.Text);

            context.PROJECTS.Add(project);
            context.SaveChanges();

            MessageBox.Show("Проектът е създаден.");
        }

        private bool IsNotNull(TextBox tb)
        {
            string tbName = tb.Name == "ProjectNameTextBox" ? "име на проекта" : "описание на проекта";

            if (tb.Text == "")
            {
                MessageBox.Show($"Моля, попълнете {tbName}!");
                return false;
            }

            return true;
        }
        private bool IsValidInput(TextBox tb)
        {
               string tbName = tb.Name == "ProjectIdTextBox" ? "код на проекта" : "часова ставка";

            //if (tb.Text == "")
            //{
            //    MessageBox.Show($"Моля, попълнете стойност в поле {tbName}!");
            //    return false;
            //}
            // else

            if (IsNumber(tb.Text) == false)
            {
                MessageBox.Show($"Моля, въведете валидно число в поле {tbName}!");
                return false;
            }

            else if (IsNumber(tb.Text) == true && Convert.ToInt32(tb.Text) < 0)
            {
                MessageBox.Show($"Моля, попълнете Положителна стойност в поле {tbName}!");
                return false;
            }

            return true;
        }

        private bool IsValidSelection(ComboBox cb)
        {
            // string cbName = cb.Name == "itemCb" ? "артикул" : "валута";
            if (cb.Text == "")
            {
                MessageBox.Show($"Моля, изберете клиент!");
                return false;
            }
            return true;
        }

        public static bool IsNumber(string aNumber)
        {
            double temp_big_int;
            var is_number = double.TryParse(aNumber, out temp_big_int);
            return is_number;
        }

        private void RegisterNewClientBtn_Click(object sender, EventArgs e)
        {
            ProjectClientComboBox.Items.Insert(0, ProjectClientComboBox.Text);
            ProjectClientComboBox.SelectedIndex = 0;
        }
    }
}

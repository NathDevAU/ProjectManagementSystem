using System;
using System.Linq;
using System.Windows.Forms;
using ProjectManagement.Utils;
using System.Collections.Generic;
using ProjectManagement.Models;

namespace ProjectManagement
{
    public partial class CreatingProjectForm : Form
    {
        private readonly PmContext context;

        public CreatingProjectForm()
        {
            InitializeComponent();

            this.context = new PmContext();
            NewClientTb.Visible = false;
            CancelRegisterClient.Visible = false;
            ProjectClientComboBox.SelectedIndex = -1;
        }
        private void CreatingProjectForm_Load(object sender, EventArgs e)
        {
            PopulateClientsCb();


        }

        private void PopulateClientsCb()
        {
            var clients = new Dictionary<decimal, string>();

            foreach (var cl in context.CLIENT)
            {
                clients.Add(cl.CLIENT_ID, cl.CLIENT_NAME);
            }
            this.ProjectClientComboBox.DataSource = new BindingSource(clients, null);
            this.ProjectClientComboBox.DisplayMember = "Value";
            this.ProjectClientComboBox.ValueMember = "Key";
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
            if (RegisterNewClientBtn.Text== "Запази клиент")
            {
                MessageBox.Show("Моля запазете регистрирането на клиент!");
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
                MessageBox.Show("Вече съществува проект с това име!");
                return;
            }
            var project = new PROJECT();
            project.PROJECT_ID = projectId;
            project.PROJECT_NAME = ProjectNameTextBox.Text;
            project.PROJECT_DESCRIPTION = ProjectDescriptionTextBox.Text;
            project.CLIENT_ID = decimal.Parse(ProjectClientComboBox.SelectedValue.ToString()); //TODO: FIX
            project.PROJECT_BEGIN = ProjectStartDateDatePicker.Value;
            project.PROJECT_END = ProjectEndDatePicker.Value;
            project.PROJECT_STATUS = Constants.ProjectStatusNewId;
            project.PROJECT_PAY_PER_HOUR = decimal.Parse(PayPerHourTextBox.Text);

            context.PROJECTS.Add(project);
            context.SaveChanges();

            MessageBox.Show("Проектът е създаден.");

            ProjectIdTextBox.Clear();
            ProjectNameTextBox.Clear();
            ProjectDescriptionTextBox.Clear();
            ProjectClientComboBox.SelectedIndex = -1;
            ProjectStartDateDatePicker.Value = DateTime.Now.Date;
            ProjectEndDatePicker.Value = DateTime.Now.Date;
            PayPerHourTextBox.Clear();
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
            if (RegisterNewClientBtn.Text == "Регистрация на нов клиент")
            {
                ProjectClientComboBox.Visible = false;
                NewClientTb.Clear();
                NewClientTb.Visible = true;
                CancelRegisterClient.Visible = true;

                RegisterNewClientBtn.Text = "Запази клиент";

            }
            else
            {
                if (NewClientTb.Text=="")
                {
                    MessageBox.Show("Моля, въведете име на клиент!");
                    return;
                }
                if (!context.CLIENT.Any(x => x.CLIENT_NAME == NewClientTb.Text))
                {
                    var newClient = new CLIENT();
                    newClient.CLIENT_NAME = NewClientTb.Text;
                    context.CLIENT.Add(newClient);
                    context.SaveChanges();


                    PopulateClientsCb();

                    ProjectClientComboBox.SelectedValue = newClient.CLIENT_ID;
                    MessageBox.Show("Регистрацията е успешна!");
                    ProjectClientComboBox.Visible = true;
                    NewClientTb.Visible = false;
                    CancelRegisterClient.Visible = false;
                    RegisterNewClientBtn.Text = "Регистрация на нов клиент";
                }
                else
                {
                    MessageBox.Show("Вече съществува клиент с това име!");
                }
            }
        }

        private void CancelRegisterClient_Click(object sender, EventArgs e)
        {
            NewClientTb.Clear();
            NewClientTb.Visible = false;
            ProjectClientComboBox.SelectedIndex = 0;
            ProjectClientComboBox.Visible = true;
            RegisterNewClientBtn.Text = "Регистрация на нов клиент";
            CancelRegisterClient.Visible = false;

        }
    }
}

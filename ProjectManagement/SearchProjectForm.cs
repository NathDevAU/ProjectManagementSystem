using ProjectManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class SearchProjectForm : Form
    {
        public SearchProjectForm()
        {
            InitializeComponent();
        }

        PmContext context = new PmContext();

        private void SearchProjectForm_Load(object sender, EventArgs e)
        {


        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var gridData = new List<ProjectVM>();
            switch (SearchFilterDropDown.SelectedIndex)
            {
                case 0:
                    gridData = context.PROJECTS
                               .Where(x => x.PROJECT_ID.ToString().Contains(SearchFilterTextBox.Text))
                               .Include(x => x.PROJECT_STATUS1)
                               .Select(x => new ProjectVM()
                               {
                                   Id = x.PROJECT_ID,
                                   Name = x.PROJECT_NAME,
                                   Client = x.PROJECT_CLIENT,
                                   StartDate = x.PROJECT_BEGIN,
                                   EndDate = x.PROJECT_END,
                                   Status = x.PROJECT_STATUS1.PSTATUS_NAME,
                                   PayPerH = x.PROJECT_PAY_PER_HOUR,
                               })
                               .ToList();

                    


                    break;
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: break;

                default:
                    MessageBox.Show("Изберете критерии!");

                    break;
            }

            ProjectsGV.DataSource = gridData;
           // ProjectsGV.DataBind(); TODO: DataBind does not exist in winforms.





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var form = new ProjectDetailsForm();
                form.ShowDialog();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

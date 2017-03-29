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
    public partial class SearchExpertForm : Form
    {
        public SearchExpertForm()
        {
            InitializeComponent();
            var experts = new Experts()
            {
                FirstName = "Stoyan",
                MiddleName = "Dimitrov",
                LastName = "Ruzmanov",
                IsExternal = false
            };

            var data = experts;
            this.expertsBindingSource.DataSource = data;
            //this.ExpertSearchResultGrid.DataBindings.Add("FirstName", experts, "FirstName");
            //this.ExpertSearchResultGrid.DataBindings.Add(nameof(Experts.MiddleName), experts, nameof(Experts.MiddleName));
            //this.ExpertSearchResultGrid.DataBindings.Add(nameof(Experts.LastName), experts, nameof(Experts.LastName));
            //this.ExpertSearchResultGrid.DataBindings.Add(nameof(Experts.IsExternal), experts, nameof(Experts.IsExternal));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

    public class Experts
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public bool IsExternal { get; set; }
    }
}

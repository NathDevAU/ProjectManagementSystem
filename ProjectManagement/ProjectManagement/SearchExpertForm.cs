﻿using ProjectManagement.ViewModels;
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
            var experts = new Expert()
            {
                FirstName = "Stoyan",
                MiddleName = "Dimitrov",
                LastName = "Ruzmanov",
                IsExternal = false
            };

            var data = experts;
            this.expertsBindingSource.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ExpertSearchResultGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 4)
                {
                    DataGridViewRow row = this.ExpertSearchResultGrid.Rows[e.RowIndex];
                    var selectedExpert = new Expert()
                    {
                        FirstName = row.Cells[0].Value.ToString(),
                        LastName = row.Cells[1].Value.ToString(),
                        MiddleName = row.Cells[2].Value.ToString(),
                        IsExternal = false
                    };

                    var detailsForm = new ExpertDetailsForm(selectedExpert);
                    detailsForm.ShowDialog();
                }
            }
        }
    }
}

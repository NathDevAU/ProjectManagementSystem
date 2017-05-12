﻿using System;
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
            //var ids = new List<decimal>();
            //decimal currentId = 0M;
            //foreach (var exp in context.EXPERTS)
            //{
            //    ids.Add(exp.EXPRET_ID);
            //}
            //if (!ids.Any())
            //{
            //    currentId = 1;
            //}
            //else
            //{
            //    currentId = (ids.Max()) + 1M;
            //}

            if (!IsValidInput(ExpertNameTextBox) || !IsValidInput(ExpertMiddleNameTextBox) || !IsValidInput(ExpertLastNameTextBox))
            {
                return;
            }

            var expert = new EXPERT();
          //  expert.EXPRET_ID = currentId;
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
            string tbName = tb.Name == "quantityTb" ? "количество" : "ед.цена";
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
                MessageBox.Show($"Моля, попълнете стойност в поле {tbName}!");
                return false;
            }
            return true;
        }
    }
}

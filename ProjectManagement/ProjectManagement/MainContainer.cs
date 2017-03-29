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
    public partial class MainContainer : Form
    {
        public MainContainer()
        {
            InitializeComponent();
        }

        private void testFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SearchForm();
            form.MdiParent = this;

            form.Show();
        }

        private void експертToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ExprertsRegisterForm();
            form.Show();
        }
    }
}

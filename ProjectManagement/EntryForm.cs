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
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void Entrybutton_Click(object sender, EventArgs e)
        {
            if (EntrytextBox.Text == "user1" && PasstextBox.Text == "123")
            {
                this.Hide();
                MainContainer main = new MainContainer();
                main.ShowDialog();
                this.Close();
            }
            else if (EntrytextBox.Text == "user2" && PasstextBox.Text == "123")
            {
                this.Hide();
                MainContainer main = new MainContainer();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Грешно име или парола!");
            }

        }
    }
}

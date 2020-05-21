using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMessageWall
{
    public partial class Dashboard : Form
    {
        BindingList<string> msgs = new BindingList<string>();

        public Dashboard()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            messageListBox.DataSource = msgs;
        }

        private void addMessageBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(messageTextBox.Text))
            {
                MessageBox.Show("No Entry", "Blank Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                msgs.Add(messageTextBox.Text);
                messageTextBox.Text = "";
            }

            messageTextBox.Focus();
        }
    }
}

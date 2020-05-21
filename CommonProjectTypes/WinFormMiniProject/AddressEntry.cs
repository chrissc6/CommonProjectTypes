using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormMiniProjectLibrary;

namespace WinFormMiniProject
{
    public partial class AddressEntry : Form
    {
        ISaveAddress _parent;
        public AddressEntry(ISaveAddress parent)
        {
            InitializeComponent();

            _parent = parent;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool valid = InfoCheck();

            if (!valid)
            {
                AddressModel address = new AddressModel
                {
                    StreetAddress = streetAddressTextBox.Text,
                    City = cityTextBox.Text,
                    State = stateTextBox.Text,
                    ZipCode = zipCodeTextBox.Text
                };

                _parent.SaveAddress(address);

                //PersonEntry entry = new PersonEntry();
                //entry.Show();
                this.Close();
            }
        }

        private bool InfoCheck()
        {
            bool x = true;

            if (string.IsNullOrWhiteSpace(streetAddressTextBox.Text))
            {
                MessageBox.Show("No Entry", "Blank Message StreetAddress", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return x;
            }
            else if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                MessageBox.Show("No Entry", "Blank Message City", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return x;
            }
            else if (string.IsNullOrWhiteSpace(stateTextBox.Text))
            {
                MessageBox.Show("No Entry", "Blank Message State", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return x;
            }
            else if (string.IsNullOrWhiteSpace(zipCodeTextBox.Text))
            {
                MessageBox.Show("No Entry", "Blank Message ZipCode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return x;
            }
            else
            {
                x = false;
                return x;
            }
        }
    }
}

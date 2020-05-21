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
            AddressModel address = new AddressModel
            {
                StreetAddress = streetAddressTextBox.Text,
                City = cityTextBox.Text,
                State = stateTextBox.Text,
                ZipCode = zipCodeTextBox.Text
            };

            _parent.SaveAddress(address);
            
            PersonEntry entry = new PersonEntry();
            entry.Show();
            this.Close();
        }
    }
}

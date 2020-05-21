﻿using System;
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
    public partial class PersonEntry : Form, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();
        public PersonEntry()
        {
            InitializeComponent();

            //test address
            //addresses.Add(new AddressModel { StreetAddress = "123 Test st.", City = "Cincinnati", State = "Ohio", ZipCode = "12345" });

            addressesListBox.DataSource = addresses;
            addressesListBox.DisplayMember = nameof(AddressModel.AddressDisplayValue);
        }

        private void addAddressBtn_Click(object sender, EventArgs e)
        {
            AddressEntry entry = new AddressEntry(this);

            entry.Show();
        }

        public void AddNewAddressComplete(AddressModel am)
        {

        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WinFormMiniProjectLibrary;

namespace WPFCoreMiniProject
{
    /// <summary>
    /// Interaction logic for AddressEntry.xaml
    /// </summary>
    public partial class AddressEntry : Window
    {
        ISaveAddress _parent;

        public AddressEntry(ISaveAddress parent)
        {
            InitializeComponent();

            _parent = parent;
        }

        private void saveAddress_Click(object sender, RoutedEventArgs e)
        {
            AddressModel address = new AddressModel
            {
                StreetAddress = streetAddressTextBox.Text,
                City = cityTextBox.Text,
                State = stateTextBox.Text,
                ZipCode = zipCodeTextBox.Text
            };

            _parent.SaveAddress(address);

            this.Close();
        }
    }
}

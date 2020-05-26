using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WinFormMiniProjectLibrary;

namespace WPFCoreMiniProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();

        public MainWindow()
        {
            InitializeComponent();

            addressesListBox.ItemsSource = addresses;

            ////test address
            //addresses.Add(new AddressModel
            //{
            //    StreetAddress = "123 Test St.",
            //    City = "Cincinnati",
            //    State = "OH",
            //    ZipCode = "12345"
            //});
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }

        private void addAddressButton_Click(object sender, RoutedEventArgs e)
        {
            AddressEntry entry = new AddressEntry(this);

            entry.Show();
        }

        private void savePerson_Click(object sender, RoutedEventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,

                //IsChecked can return a null, so we use a null coalescing operator (??)
                //says if the first thing is null then do the next thing instead (false)
                IsActive = (activeCheckBox.IsChecked ?? false),

                Addresses = addresses.ToList()
            };
        }
    }
}

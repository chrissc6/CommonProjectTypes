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

namespace WPFCoreMessageWall
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindingList<string> msgs = new BindingList<string>();

        public MainWindow()
        {
            InitializeComponent();

            messageList.ItemsSource = msgs;
        }

        private void addMessageText_Click(object sender, RoutedEventArgs e)
        {
            msgs.Add(messageText.Text);
            messageText.Text = "";
        }
    }
}

using System;
using System.Collections.ObjectModel;
using AppContactREAL.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AppContactREAL.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel = new MainViewModel();
        public MainPage()
        {
            InitializeComponent();
        }


        private void ClearButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            nameBox.Text = "";
            phoneNumberBox.Text = "";
        }

        private void SubmitButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            string name = nameBox.Text;
            string phoneNumber = phoneNumberBox.Text;

            Contact myContact = new Contact();
            myContact.Name = name;
            myContact.PhoneNumber = phoneNumber;

            OutputBox.Items.Add(myContact);
        }

        private void OutputBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Contact myContact = OutputBox.SelectedItem as Contact;

            if (myContact != null)
            {
                nameBox.Text = myContact.Name;
                phoneNumberBox.Text = myContact.PhoneNumber;
            }

        }
    }
}

using System;
using System.Collections.Generic;
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

namespace form
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ok(object sender, RoutedEventArgs e)
        {
            var fname = firstName.Text;
            var sname = secondName.Text;
            var gender = Gender.Text;
            var address = Address.Text;
            var phone = Phone.Text;
            var mobile = Mobile.Text;
            var email = Email.Text;
            var job = Job.Text;


            if (MessageBox.Show($"you've entered name = {fname+" "+sname}\ngender = {gender}\naddress = {address}\nphone = {phone}\nmobile = {mobile}\nemail = {email}\njob = {job}\n",
                    "PersonalInf0",
                    MessageBoxButton.OKCancel,
                    MessageBoxImage.Information) == MessageBoxResult.OK)
            {
                MessageBox.Show("data saved successfully\n",
                    "saving",
                    MessageBoxButton.OK);
            }
            else
            {
                clear();
            }

            
        }

        private void cancel(object sender, RoutedEventArgs e)
        {
            clear();
        }
        private void clear ()
        {
            secondName.Text = "";
            Gender.Text = "";
            firstName.Text = "";
             Address.Text = "";
            Phone.Text = "";
            Mobile.Text = "";
            Email.Text = "";
            Job.Text = "";
        }
    }
}

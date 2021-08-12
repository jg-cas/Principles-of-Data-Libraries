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
using BookLibrary;

namespace LibraryAssignmentFrontEnd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Login login;
        public MainWindow()
        {
            InitializeComponent();
            login = new Login();
        }

        private void Logintry_Click(object sender, RoutedEventArgs e)
        {
            if (login.login(Logintxt.Text, Passwordtxt.Password))
            {
                Window1 window = new Window1();
                window.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Password or Login");
                Logintxt.Clear();
                Passwordtxt.Clear();
            }
            
        }
    }
}

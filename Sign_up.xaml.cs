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

namespace TanksMenu
{
    /// <summary>
    /// Interaction logic for Sign_Up.xaml
    /// </summary>
    public partial class Sign_Up : UserControl
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void Sign_up_Click(object sender, RoutedEventArgs e)
        {
            if(this.email_TextBox.Text != "" && this.password_PasswordBox.Password != "" && this.password_again_PasswordBox.Password != "")
            {
                MessageBox.Show(new Server().Register(this.email_TextBox.Text, this.password_PasswordBox.Password, this.password_again_PasswordBox.Password));
            }
            Navigator.GoToPage(new Sign_in());
        }
    }
}

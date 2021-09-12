using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для Sign_in.xaml
    /// </summary>
    public partial class Sign_in : UserControl
    {
        public Sign_in()
        {
            InitializeComponent();
        }

        private void Sign_up_Click(object sender, RoutedEventArgs e)
        {
            Navigator.GoToPage(new Sign_Up());
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            string result = "";
            if (this.email_TextBox.Text != "" && this.password_PasswordBox.Password != "")
            {
                result = new Server().Login(this.email_TextBox.Text, this.password_PasswordBox.Password);
                MessageBox.Show(result);
            }
            if(result == "Login success!")
            {
            
                Process.Start($"{Environment.CurrentDirectory.Replace("\\TanksMenu", "")}\\Tanks.exe", "authorized");
            }
        }
    }
}

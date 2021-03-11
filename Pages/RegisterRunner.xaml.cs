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

namespace Marafon_I_71.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegisterRunner.xaml
    /// </summary>
    public partial class RegisterRunner : Page
    {
        public RegisterRunner()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegisterNewRunner());
        }
    }
}

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
using Microsoft.Win32;
using System.IO;
namespace Marafon_I_71.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegisterNewRunner.xaml
    /// </summary>
    public partial class RegisterNewRunner : Page
    {
        public RegisterNewRunner()
        {
            InitializeComponent();
        }
        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = ".png";
            openFileDialog.Filter = "PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (openFileDialog.ShowDialog() == true)
            {
                //byte[] имяПеременной = File.ReadAllBytes(переменная.FileName); //считывание файла в точечный рисунок
                //ИмяТаблиы obj = this.DataContext as ИмяТаблиы;
                //obj.ИмяПоля = имяПеременной;
                byte[] image = File.ReadAllBytes(openFileDialog.FileName);
                txtEditor.Text = image.ToString(); 
            }
        }
    }
}



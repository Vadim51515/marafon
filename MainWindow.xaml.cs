using Marafon_I_71.Pages;
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
using System.Timers;
using System.ComponentModel;

namespace Marafon_I_71
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DateTime startTime;
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(new Home());
            //задаем дату начала мероприятия
            startTime = DateTime.Parse("2021-11-21 12:00");

        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void TimerDate()
        {

            Timer tmr = new Timer
            {
                Interval = 1000
            };
            tmr.Elapsed += Tmr_Elapsed;

            tmr.Start();

            

        }
        private void Tmr_Elapsed(object sender, ElapsedEventArgs e)
        {

            PropertyChange("Time");
            Dispatcher.Invoke(() =>  TimerTextBlock.Text = Time);
        }
        private void PropertyChange(string name)
        {

            if (PropertyChanged != null)
        
                PropertyChanged(this, new PropertyChangedEventArgs(name));

        }
        public string Time
        {

            get

            {
                TimeSpan timeSpan = startTime - DateTime.Now;
                return string.Format("{0} дней {1} часов и {2} минут до старта марафона!", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes);
            }

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            TimerDate();

        }
        private void mainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (!mainFrame.CanGoBack)
            {
                back.Visibility = Visibility.Collapsed;
                title.HorizontalAlignment = HorizontalAlignment.Center;
            }
            else back.Visibility = Visibility.Visible;
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            if (mainFrame.CanGoBack)
            {
                mainFrame.GoBack();
            }

        }
    }
}

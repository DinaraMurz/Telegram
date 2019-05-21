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

namespace Telegram
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isLightTheme = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            if (isLightTheme)
            {
                themeStyle.Source = new Uri("DarkTheme.xaml", UriKind.Relative);
                isLightTheme = false;
            }
            else
            {
                themeStyle.Source = new Uri("LightTheme.xaml", UriKind.Relative);
                isLightTheme = true;
            }
        }
    }
}

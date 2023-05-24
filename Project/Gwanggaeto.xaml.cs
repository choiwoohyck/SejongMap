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
using System.Windows.Shapes;

namespace Project
{
    /// <summary>
    /// Gwanggaeto.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Gwanggaeto : Window
    {
        public Gwanggaeto()
        {
            InitializeComponent();
        }

        private void GwanggaetoButton1_Click(object sender, RoutedEventArgs e)
        {

            int usingCnt = 10;
            int maxCnt = 20;

            G_UsingCnt1.Content = usingCnt + " / ";
            G_MaxCnt1.Content = maxCnt;

            if (usingCnt >= maxCnt)
                G_UsingCnt1.Foreground = new SolidColorBrush(Colors.Red);
            else
                G_UsingCnt1.Foreground = new SolidColorBrush(Colors.Green);
        }

        private void GwanggaetoButton2_Click(object sender, RoutedEventArgs e)
        {

            int usingCnt = 10;
            int maxCnt = 20;

            G_UsingCnt2.Content = usingCnt + " / ";
            G_MaxCnt2.Content = maxCnt;

            if (usingCnt >= maxCnt)
                G_UsingCnt2.Foreground = new SolidColorBrush(Colors.Red);
            else
                G_UsingCnt2.Foreground = new SolidColorBrush(Colors.Green);
        }

        private void GwanggaetoButton3_Click(object sender, RoutedEventArgs e)
        {

            int usingCnt = 10;
            int maxCnt = 20;

            G_UsingCnt3.Content = usingCnt + " / ";
            G_MaxCnt3.Content = maxCnt;

            if (usingCnt >= maxCnt)
                G_UsingCnt3.Foreground = new SolidColorBrush(Colors.Red);
            else
                G_UsingCnt3.Foreground = new SolidColorBrush(Colors.Green);
        }

        private void GwanggaetoButton4_Click(object sender, RoutedEventArgs e)
        {

            int usingCnt = 10;
            int maxCnt = 20;

            G_UsingCnt4.Content = usingCnt + " / ";
            G_MaxCnt4.Content = maxCnt;

            if (usingCnt >= maxCnt)
                G_UsingCnt4.Foreground = new SolidColorBrush(Colors.Red);
            else
                G_UsingCnt4.Foreground = new SolidColorBrush(Colors.Green);
        }

        private void GwanggaetoButton5_Click(object sender, RoutedEventArgs e)
        {

            int usingCnt = 10;
            int maxCnt = 20;

            G_UsingCnt5.Content = usingCnt + " / ";
            G_MaxCnt5.Content = maxCnt;

            if (usingCnt >= maxCnt)
                G_UsingCnt5.Foreground = new SolidColorBrush(Colors.Red);
            else
                G_UsingCnt5.Foreground = new SolidColorBrush(Colors.Green);
        }

        private void GwanggaetoButton6_Click(object sender, RoutedEventArgs e)
        {

            int usingCnt = 10;
            int maxCnt = 20;

            G_UsingCnt6.Content = usingCnt + " / ";
            G_MaxCnt6.Content = maxCnt;

            if (usingCnt >= maxCnt)
                G_UsingCnt6.Foreground = new SolidColorBrush(Colors.Red);
            else
                G_UsingCnt6.Foreground = new SolidColorBrush(Colors.Green);
        }
    }
}

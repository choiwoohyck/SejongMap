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
    /// Goonja.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Goonja : Window
    {
        public Goonja()
        {
            InitializeComponent();
        }

        private void GoonjaButton1_Click(object sender, RoutedEventArgs e)
        {

            int usingCnt = 10;
            int maxCnt = 20;

            UsingCnt1.Content = usingCnt + " / ";
            MaxCnt1.Content = maxCnt;

            if (usingCnt >= maxCnt)
                UsingCnt1.Foreground = new SolidColorBrush(Colors.Red);
            else
                UsingCnt1.Foreground = new SolidColorBrush(Colors.Green);

        }

        private void GoonjaButton2_Click(object sender, RoutedEventArgs e)
        {
            int usingCnt = 20;
            int maxCnt = 20;

            UsingCnt2.Content = usingCnt + " / ";
            MaxCnt2.Content = maxCnt;

            if (usingCnt >= maxCnt)
                UsingCnt2.Foreground = new SolidColorBrush(Colors.Red);
            else
                UsingCnt2.Foreground = new SolidColorBrush(Colors.Green);

        }
    }
}

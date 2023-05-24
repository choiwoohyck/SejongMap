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
    /// Leedang.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Leedang : Window
    {
        public Leedang()
        {
            InitializeComponent();
        }

        private void LeedangButton1_Click(object sender, RoutedEventArgs e)
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

        private void LeedangButton2_Click(object sender, RoutedEventArgs e)
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

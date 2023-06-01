using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Markup;

namespace Project
{
    /// <summary>
    /// Page3.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 
    
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();

        }

        private void SaenalClick(object sender, RoutedEventArgs e)
        {

            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/Saenal.xaml", UriKind.RelativeOrAbsolute));
        }

        private void JiphyeonClick(object sender, RoutedEventArgs e)
        {

            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/Jiphyeon.xaml", UriKind.RelativeOrAbsolute));
        }

        private void GoonjaClick(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/Goonja.xaml", UriKind.RelativeOrAbsolute));
        }

        private void GwanggaetoClick(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/Gwanggaeto.xaml", UriKind.RelativeOrAbsolute));
        }

        private void LeedangClick(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/Leedang.xaml", UriKind.RelativeOrAbsolute));
        }

        private void AicenterClick(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/AIcenter.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}

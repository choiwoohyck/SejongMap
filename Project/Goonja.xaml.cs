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
using MySqlConnector;

namespace Project
{
    /// <summary>
    /// Goonja.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Goonja : Page
    {
        public Goonja()
        {
            InitializeComponent();

            MySqlConnection MyConnection = new MySqlConnection("Server = 172.19.29.101; Port = 3306; Database = sejongmap; " +
                                                                 "Uid = root; Pwd = vangogh1!");

            string selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '군자관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber LIKE '1%';";

            MyConnection.Open();

            MySqlCommand cmd = new MySqlCommand(selectQuery, MyConnection);

            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                UsingCnt1.Content = result + " /";
            }

            selectQuery = "SELECT COUNT(DISTINCT(RoomNumber)) FROM project WHERE BuildingName = '군자관' " +
                        "AND RoomNumber LIKE '1%';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            if (result != null)
            {
                MaxCnt1.Content = result;
            }
            //군자관 1층에서 사용가능한 강의실 개수
            selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '군자관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
               "AND RoomNumber LIKE '3%';";

            //MyConnection.Open();

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            if (result != null)
            {
                UsingCnt2.Content = result + " /";
            }

            selectQuery = "SELECT COUNT(DISTINCT(RoomNumber)) FROM project WHERE BuildingName = '군자관' " +
                        "AND RoomNumber LIKE '3%';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            if (result != null)
            {
                MaxCnt2.Content = result;
            }
            //군자관 3층에서 사용가능한 강의실 개수
        }

        private void GoonjaButton1_Click(object sender, RoutedEventArgs e)
        {

            /*int usingCnt = 10;
            int maxCnt = 20;

            UsingCnt1.Content = usingCnt + " / ";
            MaxCnt1.Content = maxCnt;

            if (usingCnt >= maxCnt)
                UsingCnt1.Foreground = new SolidColorBrush(Colors.Red);
            else
                UsingCnt1.Foreground = new SolidColorBrush(Colors.Green);
            */
            //MySQL연동하여 상호작용
            MySqlConnection MyConnection = new MySqlConnection("Server = 172.19.29.101; Port = 3306; Database = sejongmap; " +
                                                                 "Uid = root; Pwd = vangogh1!");

            string selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '군자관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber LIKE '1%';";

            MyConnection.Open();

            MySqlCommand cmd = new MySqlCommand(selectQuery, MyConnection);

            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                UsingCnt1.Content = result;
            }

            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/Goonja1F.xaml", UriKind.RelativeOrAbsolute));
        }

        private void GoonjaButton2_Click(object sender, RoutedEventArgs e)
        {
            /*
            int usingCnt = 20;
            int maxCnt = 20;

            UsingCnt2.Content = usingCnt + " / ";
            MaxCnt2.Content = maxCnt;

            if (usingCnt >= maxCnt)
                UsingCnt2.Foreground = new SolidColorBrush(Colors.Red);
            else
                UsingCnt2.Foreground = new SolidColorBrush(Colors.Green);
            */
            //MySQL연동하여 상호작용
            MySqlConnection MyConnection = new MySqlConnection("Server = 172.19.29.101; Port = 3306; Database = sejongmap; " +
                                                                 "Uid = root; Pwd = vangogh1!");

            string selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '군자관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber LIKE '3%';";

            MyConnection.Open();

            MySqlCommand cmd = new MySqlCommand(selectQuery, MyConnection);

            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                UsingCnt2.Content = result;
            }

            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/Goonja3F.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}

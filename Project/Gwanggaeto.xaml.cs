﻿using System;
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
    /// Gwanggaeto.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Gwanggaeto : Window
    {
        public Gwanggaeto()
        {
            InitializeComponent();
            int a = 0;
            MySqlConnection MyConnection = new MySqlConnection("Server = 192.168.35.231; Port = 3306; Database = sejongmap; " +
                                                                 "Uid = root; Pwd = vangogh1!");

            string selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '광개토관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber LIKE '1%';";

            MyConnection.Open();

            MySqlCommand cmd = new MySqlCommand(selectQuery, MyConnection);

            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                G_UsingCnt1.Content = result + " /";
            }

            selectQuery = "SELECT COUNT(DISTINCT(RoomNumber)) FROM project WHERE BuildingName = '광개토관' " +
                        "AND RoomNumber LIKE '1%';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            if (result != null)
            {
                G_MaxCnt1.Content = result;
            }
            //1F 버튼 content 작성

            selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '광개토관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber LIKE '2%';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            if (result != null)
            {
                G_UsingCnt2.Content = result + " /";
            }

            selectQuery = "SELECT COUNT(DISTINCT(RoomNumber)) FROM project WHERE BuildingName = '광개토관' " +
                       "AND RoomNumber LIKE '2%';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            if (result != null)
            {
                G_MaxCnt2.Content = result;
            }
            //2F 입력

            selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '광개토관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber LIKE '4%';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            if (result != null)
            {
                G_UsingCnt3.Content = result + " /";
            }

            selectQuery = "SELECT COUNT(DISTINCT(RoomNumber)) FROM project WHERE BuildingName = '광개토관' " +
                       "AND RoomNumber LIKE '4%';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            if (result != null)
            {
                G_MaxCnt3.Content = result;
            }
            //4F 입력

            selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '광개토관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber LIKE '6%';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            if (result != null)
            {
                G_UsingCnt4.Content = result + " /";
            }

            selectQuery = "SELECT COUNT(DISTINCT(RoomNumber)) FROM project WHERE BuildingName = '광개토관' " +
                       "AND RoomNumber LIKE '6%';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            if (result != null)
            {
                G_MaxCnt4.Content = result;
            }
            //6F 입력

            selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '광개토관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber LIKE '7%';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            if (result != null)
            {
                G_UsingCnt5.Content = result + " /";
            }

            selectQuery = "SELECT COUNT(DISTINCT(RoomNumber)) FROM project WHERE BuildingName = '광개토관' " +
                       "AND RoomNumber LIKE '7%';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            if (result != null)
            {
                G_MaxCnt5.Content = result;
            }
            //7F 입력

            selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '광개토관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber LIKE '8%';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            if (result != null)
            {
                G_UsingCnt6.Content = result + " /";
            }

            selectQuery = "SELECT COUNT(DISTINCT(RoomNumber)) FROM project WHERE BuildingName = '광개토관' " +
                       "AND RoomNumber LIKE '8%';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            if (result != null)
            {
                G_MaxCnt6.Content = result;
            }
            //8F 입력
            
        }

        private void GwanggaetoButton1_Click(object sender, RoutedEventArgs e)
        {
            /*
            int usingCnt = 10;
            int maxCnt = 20;

            G_UsingCnt1.Content = usingCnt + " / ";
            G_MaxCnt1.Content = maxCnt;

            if (usingCnt >= maxCnt)
                G_UsingCnt1.Foreground = new SolidColorBrush(Colors.Red);
            else
                G_UsingCnt1.Foreground = new SolidColorBrush(Colors.Green);
            */
            //MySQL연동하여 상호작용
            

            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/Gwanggaeto1F.xaml", UriKind.RelativeOrAbsolute));
        }

        private void GwanggaetoButton2_Click(object sender, RoutedEventArgs e)
        {

            /*int usingCnt = 10;
            int maxCnt = 20;

            G_UsingCnt2.Content = usingCnt + " / ";
            G_MaxCnt2.Content = maxCnt;

            if (usingCnt >= maxCnt)
                G_UsingCnt2.Foreground = new SolidColorBrush(Colors.Red);
            else
                G_UsingCnt2.Foreground = new SolidColorBrush(Colors.Green);
            */
            //MySQL연동하여 상호작용
           

            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/Gwanggaeto2F.xaml", UriKind.RelativeOrAbsolute));
        }

        private void GwanggaetoButton3_Click(object sender, RoutedEventArgs e)
        {
            /*
            int usingCnt = 10;
            int maxCnt = 20;

            G_UsingCnt3.Content = usingCnt + " / ";
            G_MaxCnt3.Content = maxCnt;

            if (usingCnt >= maxCnt)
                G_UsingCnt3.Foreground = new SolidColorBrush(Colors.Red);
            else
                G_UsingCnt3.Foreground = new SolidColorBrush(Colors.Green);
            */
            //MySQL연동하여 상호작용
            

            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/Gwanggaeto4F.xaml", UriKind.RelativeOrAbsolute));
        }

        private void GwanggaetoButton4_Click(object sender, RoutedEventArgs e)
        {
            /*
            int usingCnt = 10;
            int maxCnt = 20;

            G_UsingCnt4.Content = usingCnt + " / ";
            G_MaxCnt4.Content = maxCnt;

            if (usingCnt >= maxCnt)
                G_UsingCnt4.Foreground = new SolidColorBrush(Colors.Red);
            else
                G_UsingCnt4.Foreground = new SolidColorBrush(Colors.Green);
            */
            //MySQL연동하여 상호작용
            
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/Gwanggaeto6F.xaml", UriKind.RelativeOrAbsolute));
        }

        private void GwanggaetoButton5_Click(object sender, RoutedEventArgs e)
        {
            /*
            int usingCnt = 10;
            int maxCnt = 20;

            G_UsingCnt5.Content = usingCnt + " / ";
            G_MaxCnt5.Content = maxCnt;

            if (usingCnt >= maxCnt)
                G_UsingCnt5.Foreground = new SolidColorBrush(Colors.Red);
            else
                G_UsingCnt5.Foreground = new SolidColorBrush(Colors.Green);
            */
            //MySQL연동하여 상호작용
            
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/Gwanggaeto7F.xaml", UriKind.RelativeOrAbsolute));
        }

        private void GwanggaetoButton6_Click(object sender, RoutedEventArgs e)
        {
            /*
            int usingCnt = 10;
            int maxCnt = 20;

            G_UsingCnt6.Content = usingCnt + " / ";
            G_MaxCnt6.Content = maxCnt;

            if (usingCnt >= maxCnt)
                G_UsingCnt6.Foreground = new SolidColorBrush(Colors.Red);
            else
                G_UsingCnt6.Foreground = new SolidColorBrush(Colors.Green);
            */
            //MySQL연동하여 상호작용
            

            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/Gwanggaeto8F.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}

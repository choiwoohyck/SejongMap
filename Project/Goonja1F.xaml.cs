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
using System.Windows.Shapes;
using MySqlConnector;
namespace Project
{
    /// <summary>
    /// Goonja1F.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Goonja1F : Page
    {
        public Goonja1F()
        {
            InitializeComponent();

            MySqlConnection MyConnection = new MySqlConnection("Server = 192.168.35.231; Port = 3306; Database = sejongmap; " +
                                                                             "Uid = root; Pwd = vangogh1!");

            string selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '군자관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber = '109B';";

            MyConnection.Open();

            MySqlCommand cmd = new MySqlCommand(selectQuery, MyConnection);

            object result = cmd.ExecuteScalar();
            
            long useInt = (long)result;
            if (useInt != 0)
            {
                usingCnt1.Content = "Avail";
            }
            else
            {
                usingCnt1.Content = "Unavail";
            }
            //109B호에 대한 사용가능 여부

            selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '군자관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber = '107';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();
            useInt = (long)result;

            if (useInt != 0)
            {
                usingCnt2.Content = "Avail";
            }
            else
            {
                usingCnt2.Content = "Unavail";
            }
            //107호에 대한 사용가능 여부
        }
    }
}

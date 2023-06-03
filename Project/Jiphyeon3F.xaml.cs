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
using MySqlConnector;

namespace Project
{
    /// <summary>
    /// Jiphyeon3F.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Jiphyeon3F : Page
    {
        public Jiphyeon3F()
        {
            InitializeComponent();

            MySqlConnection MyConnection = new MySqlConnection("Server = 172.19.29.101; Port = 3306; Database = sejongmap; " +
                                                               "Uid = root; Pwd = vangogh1!");

            string selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '집현관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber = '301';";

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
            //301호에 대한 사용가능 여부

            selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '집현관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber = '302';";

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
            //302호에 대한 사용여부

            selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '집현관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber = '303';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            useInt = (long)result;
            if (useInt != 0)
            {
                usingCnt3.Content = "Avail";
            }
            else
            {
                usingCnt3.Content = "Unavail";
            }
            //303

            selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '집현관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber = '307';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            useInt = (long)result;
            if (useInt != 0)
            {
                usingCnt4.Content = "Avail";
            }
            else
            {
                usingCnt4.Content = "Unavail";
            }
            //307

            selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '집현관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber = '309';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            useInt = (long)result;
            if (useInt != 0)
            {
                usingCnt5.Content = "Avail";
            }
            else
            {
                usingCnt5.Content = "Unavail";
            }
            //309

            selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '집현관' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber = '311';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            useInt = (long)result;
            if (useInt != 0)
            {
                usingCnt6.Content = "Avail";
            }
            else
            {
                usingCnt6.Content = "Unavail";
            }
            //311
        }
    }
}

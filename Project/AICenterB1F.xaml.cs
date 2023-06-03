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
    /// AICenterB1F.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AICenterB1F : Window
    {
        public AICenterB1F()
        {
            InitializeComponent();

            MySqlConnection MyConnection = new MySqlConnection("Server = 172.19.29.101; Port = 3306; Database = sejongmap; " +
                                                                "Uid = root; Pwd = vangogh1!");

            string selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '대양AI센터' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber = 'B103';";

            MyConnection.Open();

            MySqlCommand cmd = new MySqlCommand(selectQuery, MyConnection);

            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                Available.Content = "Avail";
            }
            else
            {
                Available.Content = "Unavail";
            }
            //B103호에 대한 사용가능 여부

            selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '대양AI센터' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber = 'B107';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            if (result != null)
            {
                usingCnt2.Content = "Avail";
            }
            else
            {
                usingCnt2.Content = "Unavail";
            }
            //B107호에 대한 사용가능 여부

            selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '대양AI센터' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber = 'B109';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            if (result != null)
            {
                usingCnt2.Content = "Avail";
            }
            else
            {
                usingCnt2.Content = "Unavail";
            }
            //B109호에 대한 사용가능 여부

            selectQuery = "SELECT COUNT(RoomNumber) FROM project WHERE BuildingName = '대양AI센터' AND DayOfWeek = dayofweek(CURDATE()) AND timediff(CURTIME(), StartTime) > 0 AND timediff(EndTime, CURTIME()) > 0 " +
                "AND RoomNumber = 'B116';";

            cmd = new MySqlCommand(selectQuery, MyConnection);

            result = cmd.ExecuteScalar();

            if (result != null)
            {
                usingCnt2.Content = "Avail";
            }
            else
            {
                usingCnt2.Content = "Unavail";
            }
            //B116호에 대한 사용가능 여부
        }
    }
}

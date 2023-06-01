using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class ManagingDB : MainWindow
    {
        MySqlConnection MyConnection = new MySqlConnection("Server = localhost; Port = 3307; Database = sejongmap; " +
                                                            "Uid = root; Pwd = vangogh1!");
        public ManagingDB()
        {
            InitializeComponent();
        }
    }
}
//MySQL에 접속할 객체 생성

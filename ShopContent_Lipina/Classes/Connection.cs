using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ShopContent_Lipina.Classes
{
    public class Connection
    {
        private static readonly string config = "server=student.permaviat.ru;" +
            "Trusted_Connection=No;" +
            "DataBase=base2_ISP_21_2_17;" +
            "User=ISP_21_2_17;" +
            "PWD=Tz4ZP5o6W#";
        public static SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(config);
            connection.Open();
            return connection;
        }
        public static SqlDataReader Query(string SQL, out SqlConnection connection)
        {
            connection = OpenConnection();
            return new SqlCommand(SQL, connection).ExecuteReader();
        }
        public static void CloseConnection(SqlConnection connection)
        {
            connection.Close();
            SqlConnection.ClearPool(connection);
        }
    }
}

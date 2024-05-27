using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace pr42savichev.Classes
{
    public class Connection
    {
        private static readonly string config = "server=student.permaviat.ru;Trusted_Connection=No;DataBase=***;User=***;pwd=***";

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

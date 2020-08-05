using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ConsoleApp1
{
    public class DBConnection
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        public SqlConnection CreateConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString.ToString();
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            return connection;
        }

        public void OpenConnection(SqlConnection connection)
        {
            connection.Open();
        }

        public int InsertData(string sqlQuery, SqlConnection connection)
        {
            int rowAffeced = 0;
            command = new SqlCommand(sqlQuery, connection);
            rowAffeced = command.ExecuteNonQuery();
            return rowAffeced;
        }

        public DataSet FetchData(string sqlQuery, SqlConnection connection)
        {
            DataSet dataSet = new DataSet();
            adapter = new SqlDataAdapter(sqlQuery, connection);
            adapter.Fill(dataSet);
            return dataSet;
        }

        public void CloseConnection(SqlConnection connection)
        {
            connection.Close();
        }
    }
}

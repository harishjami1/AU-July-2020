/*
First create a table Employee with 'ID'and 'Name' as columns
Then create a row with ID=240;
Then run the program to get the results
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace ConsoleApp
{
   public class dBConnection
   {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        public  void CreateConnection()
        {string connectionString=ConfigurationManager.CnnectionStrings["DBConnection"].ConnectionString.ToString();
         connection =new SqlConnection();
        connection.ConnectionString=connectionString;
        return connection;
        }
        public void OpenConnection()
        {
            connection.Open();
        }
        public int InsertData(string sqlQuery,SqlConnection connection)
        {   int rowsaffected =0;
            command =new SqlCommand(sqlQuery,connection);
            connection.Open();
            rowsaffected=command.ExecuteNonQuery();
            return rowsaffected;
        }
        public void CloseConnection()
        {
            connection.Close();
        }
        public DataSet FetchData(string sqlQuery,SqlConnection connection)
        {
            Dataset dataSet =new DataSet();
            adapter =new SqlAdapter(sqlQuery,connection);
            adapter.Fill(dataSet);
            return dataSet;
        }
        static void Main(String [] args)
        {
           SqlConnection conn= CreateConnection();
           OpenConnection(conn);
           String sqlQuery = "insert into Employee(ID,Name)values('230','Anish')";
           
           int rows =InsertData(sqlQuery,conn);
           CloseConnection(conn);
           if(rows!=0)
           {
               Console.WriteLine("Data insertion successful");
           }
           else{
               Console.WriteLine("Data insertion Failed");
           }
           //For Deleting
           conn= CreateConnection();
           OpenConnection(conn);
           String sqlQuery = "delete from Employee where ID=240";
           
           int rows =InsertData(sqlQuery,conn);
           CloseConnection(conn);
           if(rows!=0)
           {
               Console.WriteLine("Data Deletion successful");
           }
           else{
               Console.WriteLine("Data Deletioon Failed");
           }
           //For viewing
          conn= CreateConnection();
           OpenConnection(conn);
           String sqlQuery = "select * from Employee";
           DataSet dataSet =FetchData(sqlQuery,conn);
           
           CloseConnection(conn);
           if(dataSet!=null)
           {   for(int i=0;i<dataSet.Tables[0].Rows.Count;i++)
               Console.WriteLine("Employee ID :"+dataSet.Tables[0].Rows[i]["ID"]+"Employee Name :"+dataSet.Tables[0].Rows[i]["Name"]);
           }
           else{
               Console.WriteLine("Data Extraction  Failed");
           Console.ReadKey();
                }
        }
}   }
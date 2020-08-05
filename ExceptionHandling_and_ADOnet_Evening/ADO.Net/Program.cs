using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConnection DBConnection = new DBConnection();
            SqlConnection connection;
            string sqlQuery;
            Console.WriteLine("Enter 1 for Inserting Data into the table");
            Console.WriteLine("Enter 2 for deleting data from the table");
            Console.WriteLine("Enter 3 for viewing data from the table");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Employee Name");
                    string employeeName = Console.ReadLine();
                    Console.WriteLine("Enter Employee Salary");
                    int employeeSalary = int.Parse(Console.ReadLine());
                    connection = DBConnection.CreateConnection();
                    DBConnection.OpenConnection(connection);
                    sqlQuery = "insert into Employee(EmployeeName,EmployeeSalary) values('" + employeeName + "'," + employeeSalary + ");";
                    int rowAffected = DBConnection.InsertData(sqlQuery, connection);
                    DBConnection.CloseConnection(connection);
                    if (rowAffected != 0)
                    {
                        Console.WriteLine("Data Successfully Inserted");
                    }
                    else
                    {
                        Console.WriteLine("Insertion Failed");
                    }
                    break;
                case 2:
                    connection = DBConnection.CreateConnection();
                    DBConnection.OpenConnection(connection);
                    sqlQuery = "delete from Employee where EmployeeSalary>10000";
                    int rowAffected = DBConnection.InsertData(sqlQuery, connection);
                    DBConnection.CloseConnection(connection);
                    if (rowAffected != 0)
                    {
                        Console.WriteLine("Data deletion successful");
                    }
                    else
                    {
                        Console.WriteLine("Deletion Failed");
                    }
                    break;

                case 3:
                    connection = DBConnection.CreateConnection();
                    DBConnection.OpenConnection(connection);
                    sqlQuery = "select * from Employee";
                    DataSet dataSet = DBConnection.FetchData(sqlQuery, connection);
                    DBConnection.CloseConnection(connection);
                    if (dataSet != null)
                    {
                        for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                        {
                            Console.WriteLine("EmployeeName Name =>" + dataSet.Tables[0].Rows[i]["EmployeeName"] + " EmployeeName Salary =>" + dataSet.Tables[0].Rows[i]["EmployeeSalary"]);
                        }            
                    }
                    else
                    {
                        Console.WriteLine("Retrieval Failed");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Value");
                    break;
            }
            
           
            Console.ReadKey();
        }
    }
}

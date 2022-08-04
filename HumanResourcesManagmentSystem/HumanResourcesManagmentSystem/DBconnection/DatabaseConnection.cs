using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HumanResourcesManagmentSystem.Models;
namespace HumanResourcesManagmentSystem.DBconnection
{
    public static class DatabaseConnection
    {
        public static string ConnectionStrings = "Data Source=DESKTOP-LU90HPM;Initial Catalog=HumanResurceDB;Integrated Security=True";

        public static void ConnectToDatabase()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionStrings);
            sqlConnection.Open();
            System.Console.WriteLine("Ugurla qosuldu !");
            sqlConnection.Close();
        }
        public static List<Personal> ReadyPersonalList()
        {
            List<Personal> personals = new List<Personal>();
            SqlDataReader sqlDataReader;
            SqlConnection sqlConnection = new SqlConnection(ConnectionStrings);
            sqlConnection.Open();
            string readyQuery = "select * from tblPersonal";
            SqlCommand sqlCommand = new SqlCommand(readyQuery,sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Personal personal = new Personal();
                personal.Id = (int)sqlDataReader.GetValue(0);
                personal.EmployeeNumber = (int)sqlDataReader.GetValue(1);
                personal.FirstName = sqlDataReader.GetValue(2).ToString();
                personal.LastName = sqlDataReader.GetValue(3).ToString();
                personal.DateOfEmployment = Convert.ToDateTime(sqlDataReader.GetValue(4));
                personal.Adress = sqlDataReader.GetValue(5).ToString();
                personal.Position = sqlDataReader.GetValue(6).ToString();
                personal.SalaryRate = (decimal)sqlDataReader.GetValue(7);
                personal.WorkingMinutesInMonth = (int)sqlDataReader.GetValue(8);
                personals.Add(personal);
            }
            sqlConnection.Close();
            return personals;
        }
    }
   
}

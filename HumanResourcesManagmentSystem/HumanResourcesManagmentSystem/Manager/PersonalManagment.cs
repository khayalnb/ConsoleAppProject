using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResourcesManagmentSystem.DBconnection;
using HumanResourcesManagmentSystem.Models;

namespace HumanResourcesManagmentSystem.Manager
{
    public class PersonalManagment
    {
        public static void Ready()
        {
            List<Personal> personals = DatabaseConnection.ReadyPersonalList();
            foreach (var item in personals)
            {
                Console.Write(item.Id + " " + item.EmployeeNumber + " " + item.FirstName
                    + " " + item.LastName + " " + item.DateOfEmployment + " " + item.Adress
                    + " " + item.Position + " " + item.SalaryRate + " " + item.WorkingMinutesInMonth + "");
            }
        }
    }
}


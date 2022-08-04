using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesManagmentSystem.Models
{
    public class Worktime
    {
        public int Id { get; set; }
        public int EmployeeNumber { get; set; }
        public int DayOfMonth { get; set; }
        public DateTime TimeOfEntry { get; set; }
        public DateTime TimeOfExit { get; set; }
    }
}

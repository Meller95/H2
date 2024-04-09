using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesV10
{
    public class Employee
    {
        public string Name { get; set; }
        public int HoursPerWeek { get; set; }

        public Employee(string name, int hoursPerWeek)
        {
            Name = name;
            HoursPerWeek = hoursPerWeek;
        }

    }
}

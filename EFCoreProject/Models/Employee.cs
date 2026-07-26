using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int EmployeeSsn { get; set; }

        public string EmployeeFname { get; set; }
        public string EmployeeMinit { get; set; }
        public string EmployeeLname { get; set; }

        public int EmployeeAge { get; set; }
        public double EmployeeSalary { get; set; }
        public string EmployeeAddress { get; set; }
        public DateTime EmployeeBirthDate { get; set; }
        public string EmployeeSex { get; set; }

    }
}

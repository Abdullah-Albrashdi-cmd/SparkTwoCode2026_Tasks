using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{
    public class Employee
    {
        [Key]
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

        //WORKS_FOR
        [ForeignKey("D")]
        public int DepartmentId { get; set; }

        public Department D {  get; set; }

        //DEPENDENTS_OF
        public List<Dependent> Dependents { get; set; }

        //MANAGES
        [InverseProperty("Employee")]
        public Department ManDepartment { get; set; }

        //WORKS_ON
        public List<WorksOnEmpProj> wo { get; set; }


        //SUPERVISION
        [InverseProperty("supervisor")]
        public List<Employee> supervise { set; get; }


        [ForeignKey("supervisor")]
        public int SupervisorId { get; set; }

        public Employee supervisor { get; set; }

    }
}
